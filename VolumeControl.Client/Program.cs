using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.InteropServices;

namespace VolumeControl.Client {
    class VolumeControlClient {

        static void Main(string[] args) {
            try {
                var serviceUri = new Uri("net.tcp://192.168.1.101:6666/volumecontrol");
                var test = new VolumeControlService.VolumeControlWCFServiceClient(new NetTcpBinding(SecurityMode.Transport), new EndpointAddress(serviceUri));
                test.MuteOrUnmute();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message + Environment.NewLine + ex.StackTrace);
                Console.ReadKey();
            }
        }
    }
}
