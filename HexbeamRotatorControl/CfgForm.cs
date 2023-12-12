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

namespace HexbeamRotatorControl
{
    public partial class CfgForm : Form
    {
        clsConfigurationData cfgData = new clsConfigurationData();
        IPAddress esp8266Address;

        public CfgForm()
        {
            InitializeComponent();
            cfgData.LoadConfigurationData();
        }

        private void CfgForm_Load(object sender, EventArgs e)
        {
            numUdpInboundPort.Value = cfgData.udpInboundPort;
            numUdpOutboundPort.Value = cfgData.udpESP8266Port;
            tbIpAddress.Text = cfgData.esp8266IpAddr.ToString();
        }

        private void CfgForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs eArg)
        {

            try
            {
                // Create an instance of IPAddress for the specified address string (in
                // dotted-quad, or colon-hexadecimal notation).
                esp8266Address = IPAddress.Parse(tbIpAddress.Text);
                cfgData.udpInboundPort = (Int16)numUdpInboundPort.Value;
                cfgData.udpESP8266Port = (Int16)numUdpOutboundPort.Value;
                cfgData.esp8266IpAddr = esp8266Address;
                cfgData.SaveConfigurationData();
            }

            catch (ArgumentNullException e)
            {
                String what = "ArgumentNullException caught!!! Source : " + e.Source + " Message : " + e.Message;
                MessageBox.Show(what);
            }

            catch (FormatException e)
            {
                String what = e.Message + " Address is not Saved";
                MessageBox.Show(what);

            }

            catch (Exception e)
            {
                String what = "Exception caught!!! Source : " + e.Source + " Message : " + e.Message;
                MessageBox.Show(what);
            }
        }

        private void tbIpAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbIpAddress_TextChanged(object sender, EventArgs eArg)
        {
        }
    }
}
