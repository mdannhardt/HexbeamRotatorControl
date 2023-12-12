using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace HexbeamRotatorControl
{
    public class clsConfigurationData
    {
        public Int16 udpInboundPort;
        public Int16 udpESP8266Port;
        public IPAddress esp8266IpAddr;

        public void LoadConfigurationData()
        {
            udpInboundPort = Convert.ToInt16(Application.UserAppDataRegistry.GetValue("UdpInboundPort", "12040"));
            udpESP8266Port = Convert.ToInt16(Application.UserAppDataRegistry.GetValue("ESP8266UdpPort", "4210"));
            esp8266IpAddr = IPAddress.Parse(
                Convert.ToString(
                    Application.UserAppDataRegistry.GetValue("ESP8266IpAddr", "192.168.137.255")));
        }

        public void SaveConfigurationData()
        {
            Application.UserAppDataRegistry.SetValue("UdpInboundPort", udpInboundPort.ToString());
            Application.UserAppDataRegistry.SetValue("ESP8266UdpPort", udpESP8266Port.ToString());
            Application.UserAppDataRegistry.SetValue("ESP8266IpAddr", esp8266IpAddr.ToString());
        }
    }
}
