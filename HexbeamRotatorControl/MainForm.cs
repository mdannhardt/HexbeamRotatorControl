using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace HexbeamRotatorControl
{
    public partial class MainDisplayForm : Form
    {
        UdpClient m_udpInboundServer;
        UdpClient m_udpESP8266;
        IPEndPoint m_ESP8266IpEndPoint;

        Int32 m_TimeOut = 0; // Incrementing bearing request counter. Reset when a bearing received.

        clsConfigurationData cfgData = new clsConfigurationData();

        public MainDisplayForm()
        {
            InitializeComponent();
            initialize();
        }

        private void initialize()
        {
            cfgData.LoadConfigurationData();

            tbCurrentBearing.Text = " ??? ";

            // Create a UDP port to listen for incoming commands on.
            try
            {
                m_udpInboundServer = new UdpClient(cfgData.udpInboundPort);
                m_udpInboundServer.BeginReceive(new AsyncCallback(recvExternalCommand), null);
            }
            catch
            {
                MessageBox.Show("Can't create UDP inbound end point.");
            }

            // Create a UDP port for the ESP8266 rotator controller.
            try
            {
                m_ESP8266IpEndPoint = new IPEndPoint(cfgData.esp8266IpAddr, cfgData.udpESP8266Port);
                m_udpESP8266 = new UdpClient(cfgData.udpESP8266Port+1);
                // Allow broadcasting
                m_udpESP8266.EnableBroadcast = true;
                m_udpESP8266.BeginReceive(new AsyncCallback(recvESP8266Response), null);
            }
            catch (Exception e)
            {
                String what = "Exception caught!! Can't create UDP port for ESP8266 rotator controller. Source : " + e.Source + " Message : " + e.Message;
                MessageBox.Show(what);
            }

            setEnables(false);
        }

        // CallBack - Packet has been received from the ESP8266 rotator controller.
        private void recvESP8266Response(IAsyncResult res)
        {
            IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 8000);
            byte[] received;
            try
            {
                received = m_udpESP8266.EndReceive(res, ref RemoteIpEndPoint);
            }
            catch //(System.ObjectDisposedException ex)
            {
                return;
            }

            // Process received message paying attention only to the ones of interest
            // and ignoring all the rest.
            String rsp = Encoding.UTF8.GetString(received);

            String[] rspData = rsp.Split(':');
            if (rspData[0] == "GET_BEARING")
            {
                m_TimeOut = 0;
                SetBearingText(rspData[1]);
                SetRotationText(rspData.Length > 2 ? rspData[2] : "");
            }
            else
                Console.Write(rsp);

            // Setup for next message
            try
            {
                m_udpESP8266.BeginReceive(new AsyncCallback(recvESP8266Response), null);
            }
            catch //(System.ObjectDisposedException ex)
            {
                return;
            }
        }

        // CallBack - Data has been received from an external program.
        private void recvExternalCommand(IAsyncResult res)
        {
            IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 8000);
            byte[] received;
            try
            {
                received = m_udpInboundServer.EndReceive(res, ref RemoteIpEndPoint);
            }
            catch //(System.ObjectDisposedException ex)
            {
                return;
            }

            // Process received message paying attention only to the ones of interest
            // and ignoring all the rest.
            String recvCmd = Encoding.UTF8.GetString(received);
            if (recvCmd.Contains("STOP"))
            {
                sendCommand(Encoding.ASCII.GetBytes("<PST><STOP>1</STOP></PST>"));
               // sendCommand(Encoding.ASCII.GetBytes("STOP\n"));
            }

            else if (recvCmd.Contains("AZIMUTH"))
            {
                // Move the data over to the bearing input where the change 
                // will cause the command to be issued.
                try
                {
                    String bearingStr = recvCmd.Replace("<PST><AZIMUTH>", "");
                    bearingStr = bearingStr.Replace("</AZIMUTH></PST>", "");
                    SetBearingNum(Int16.Parse(bearingStr));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error processing client command.");
                }
            }
            else if (recvCmd.Contains("goazi")) // From N1MM
            {
                int Start, End;
                Start = recvCmd.IndexOf("<goazi>", 0) + "<goazi>".Length;
                End = recvCmd.IndexOf("</goazi>", Start);
                String bearingStr = recvCmd.Substring(Start, End - Start);
                // Move the data over to the bearing input where the change 
                // will cause the command to be issued.
                try
                {
                   // String bearingStr = recvCmd.Replace("<PST><AZIMUTH>", "");
                  //  bearingStr = bearingStr.Replace("</AZIMUTH></PST>", "");
                    SetBearingNum((Int16)Convert.ToDouble(bearingStr));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error processing client command.");
                }
            }

            // Setup for next message
            try
            {
                m_udpInboundServer.BeginReceive(new AsyncCallback(recvExternalCommand), null);
            }
            catch //(System.ObjectDisposedException ex)
            {
                return;
            }
        }

        public delegate void SetBearingNumCallback(Int16 bearing);
        private void SetBearingNum(Int16 bearing)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.tbCurrentBearing.InvokeRequired)
            {
                SetBearingNumCallback d = new SetBearingNumCallback(SetBearingNum);
                this.Invoke(d, new object[] { bearing });
            }
            else
            {
                // force the change event even if the same bearing commanded.
                if (this.numTargetBearing.Value == bearing)
                    this.numTargetBearing.Value = bearing+1;
                this.numTargetBearing.Value = bearing;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            sendCommand(Encoding.ASCII.GetBytes("<PST><STOP>1</STOP></PST>"));
        }

        private void setEnables(bool dataRcved)
        {
            Boolean portOpen = (m_udpInboundServer != null && m_udpESP8266 != null) ? true : false;

            timerGetCurrentBearing.Enabled = portOpen;
            btnStop.Enabled = portOpen;

            if (!portOpen)
                dataRcved = false;

            numTargetBearing.Enabled = dataRcved;
            btnN.Enabled = dataRcved;
            btnNE.Enabled = dataRcved;
            btnE.Enabled = dataRcved;
            btnSE.Enabled = dataRcved;
            btnS.Enabled = dataRcved;
            btnSW.Enabled = dataRcved;
            btnW.Enabled = dataRcved;
            btnNW.Enabled = dataRcved;
        }

        public delegate void SetBearingTextCallback(string text);
        private void SetBearingText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.tbCurrentBearing.InvokeRequired)
            {
                SetBearingTextCallback d = new SetBearingTextCallback(SetBearingText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.tbCurrentBearing.Text = text;
                setEnables(true);
            }
        }


        public delegate void SetRotationTextCallback(string text);
        private void SetRotationText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.tbCurrentBearing.InvokeRequired)
            {
                SetRotationTextCallback d = new SetRotationTextCallback(SetRotationText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.tbRotation.Text = text;
            }
        }

        private void numTargetBearing_ValueChanged(object sender, EventArgs e)
        {
            if (numTargetBearing.Value == 0)
            {
                numTargetBearing.Value = 360;
                return;
            }

            if (numTargetBearing.Value == 361)
            {
                numTargetBearing.Value = 1;
                return;
            }
            
            sendCommand(Encoding.ASCII.GetBytes("<PST><AZIMUTH>" + numTargetBearing.Value + "</AZIMUTH></PST>"));
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            numTargetBearing.Value = numTargetBearing.Value == 360 ? 359 : 360;
        }

        private void btnNE_Click(object sender, EventArgs e)
        {
            numTargetBearing.Value = numTargetBearing.Value == 45 ? 46 : 45;
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            numTargetBearing.Value = numTargetBearing.Value == 90? 91 : 90;
        }

        private void btnSE_Click(object sender, EventArgs e)
        {
            numTargetBearing.Value = numTargetBearing.Value == 135 ? 136 : 135;
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(tbCurrentBearing.Text) > 180)
                numTargetBearing.Value = numTargetBearing.Value == 181 ? 182 : 181;
            else
                numTargetBearing.Value = numTargetBearing.Value == 179 ? 178 : 179;
        }

        private void btnSW_Click(object sender, EventArgs e)
        {
            numTargetBearing.Value = numTargetBearing.Value == 225 ? 226 : 225;
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            numTargetBearing.Value = numTargetBearing.Value == 270 ? 271 : 270;
        }

        private void btnNW_Click(object sender, EventArgs e)
        {
            numTargetBearing.Value = numTargetBearing.Value == 315 ? 316 : 315;
        }

        private void timerGetCurrentBearing_Tick(object sender, EventArgs e)
        {
            sendCommand(Encoding.ASCII.GetBytes("GET_BEARING\n"));
            if (++m_TimeOut > 5)
                SetBearingText("???");
        }

        private void btnCfg_Click(object sender, EventArgs e)
        {
            if (m_udpInboundServer != null)
                m_udpInboundServer.Close();
            if (m_udpESP8266 != null)
                m_udpESP8266.Close();

            m_udpInboundServer = null;
            m_udpESP8266 = null;

            timerGetCurrentBearing.Enabled = false;
            CfgForm cfg = new CfgForm();
            cfg.ShowDialog();
            // reload configuration incase it has changed.
            initialize();
        }

        private void btnToggleMin_Click(object sender, EventArgs e)
        {
            bool full = this.Height > 77;
            full = !full; // new mode

            numTargetBearing.Visible = full;
            btnN.Visible = full;
            btnNE.Visible = full;
            btnE.Visible = full;
            btnSE.Visible = full;
            btnS.Visible = full;
            btnSW.Visible = full;
            btnW.Visible = full;
            btnNW.Visible = full;
            btnStop.Visible = full;

            this.Size = new Size(this.Width, full ? 165 : 77);
        }


        private void tbCurrentBearing_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // move the current bearing into the bearing set numeric for easy bumping.
            numTargetBearing.Value = Decimal.Parse(tbCurrentBearing.Text);
        }


        // Error sending to the ESP8266
        private void commPortError()
        {
            timerGetCurrentBearing.Enabled = false;
            try
            {
                m_udpESP8266.Close();
                m_udpESP8266 = null;
            }
            catch
            {
                MessageBox.Show("Error sending to ESP8255.");
            }
            finally
            {
                MessageBox.Show("Check settings.");
                setEnables(false);
            }
        }

        private void btnCalib_Click(object sender, EventArgs e)
        {
            sendCommand(Encoding.ASCII.GetBytes("CAL_DECL\n"));
        }

        private void sendCommand(Byte[] sendBytes)
        {
            try
            {
                m_udpESP8266.Send(sendBytes, sendBytes.Length, m_ESP8266IpEndPoint);
            }
            catch
            {
                commPortError();
            }
        }
    }
}
