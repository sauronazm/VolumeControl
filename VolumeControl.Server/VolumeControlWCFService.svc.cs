using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using NAudio.CoreAudioApi;

namespace VolumeControl.WCFService {
    public class VolumeControlWCFService : IVolumeControlWCFService {

        public void MuteOrUnmute() {

            // Used http://stackoverflow.com/a/12534628/1454669
            MMDeviceEnumerator MMDE = new MMDeviceEnumerator();
            MMDeviceCollection devs = MMDE.EnumerateAudioEndPoints(NAudio.CoreAudioApi.DataFlow.All, NAudio.CoreAudioApi.DeviceState.All);
            foreach (MMDevice dev in devs) {
                if (dev.FriendlyName.ToLower().IndexOf("speakers") > -1) {
                    try {
                        dev.AudioEndpointVolume.Mute = !dev.AudioEndpointVolume.Mute;
                    }
                    catch (Exception) {
                    }
                }
            }
        }
    }
}
