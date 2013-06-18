using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace VolumeControl.WCFService
{
    [ServiceContract]
    public interface IVolumeControlWCFService
    {
        [OperationContract]
        void MuteOrUnmute();
    }

}
