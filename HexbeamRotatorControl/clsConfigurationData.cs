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
        public String    rotatorName;

        public void LoadConfigurationData()
        {
            udpInboundPort = Convert.ToInt16(Application.UserAppDataRegistry.GetValue("UdpInboundPort", "12040"));
            udpESP8266Port = Convert.ToInt16(Application.UserAppDataRegistry.GetValue("ESP8266UdpPort", "4210"));
            String ipAddr = Convert.ToString(
                    Application.UserAppDataRegistry.GetValue("ESP8266IpAddr", "192.168.1.255"));
            if ( ipAddr.Length > 0)
                esp8266IpAddr = IPAddress.Parse(ipAddr);
            rotatorName = Convert.ToString(Application.UserAppDataRegistry.GetValue("RotatorName", "ESP-XXYYZZ"));
        }

        public void SaveConfigurationData()
        {
            Application.UserAppDataRegistry.SetValue("UdpInboundPort", udpInboundPort.ToString());
            Application.UserAppDataRegistry.SetValue("ESP8266UdpPort", udpESP8266Port.ToString());
            if (esp8266IpAddr != null)
                Application.UserAppDataRegistry.SetValue("ESP8266IpAddr", esp8266IpAddr.ToString());
            else
                Application.UserAppDataRegistry.SetValue("ESP8266IpAddr", "");
            Application.UserAppDataRegistry.SetValue("RotatorName", rotatorName.ToString());
        }
    }
}
