using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.ServiceProcess;
using System.ServiceModel;

namespace VolumeControlWindowsService.WindowsService
{
    public class VolumeControlWindowsService : System.ServiceProcess.ServiceBase {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        /// 

        private System.ComponentModel.Container components = null;

        internal static ServiceHost workingServiceHost = null; 

        public VolumeControlWindowsService()
        {
            // This call is required by the Windows.Forms Component Designer.
            InitializeComponent();
        }

        // The main entry point for the process
        static void Main()
        {
            System.ServiceProcess.ServiceBase[] ServicesToRun;

            // More than one user Service may run within the same process. To add
            // another service to this process, change the following line to
            // create a second service object. For example,
            //
            //   ServicesToRun = New System.ServiceProcess.ServiceBase[] {new Service1(), new MySecondUserService()};
            //
            ServicesToRun = new System.ServiceProcess.ServiceBase[] { new VolumeControlWindowsService() };

            System.ServiceProcess.ServiceBase.Run(ServicesToRun);
        }

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            // 
            // VolumeControlWindowsService
            // 
            this.ServiceName = Constants.WINDOWS_SERVICE_NAME;

        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Set things in motion so your service can do its work.
        /// </summary>
        protected override void OnStart(string[] args)
        {
            // TODO: Add code here to start your service.
            if (workingServiceHost != null) {
                workingServiceHost.Close();
            }

            workingServiceHost = new ServiceHost(typeof(VolumeControl.WCFService.VolumeControlWCFService));
            workingServiceHost.Open();
        }

        /// <summary>
        /// Stop this service.
        /// </summary>
        protected override void OnStop()
        {
            // TODO: Add code here to perform any tear-down necessary to stop your service.
            if (workingServiceHost != null)
            {
                workingServiceHost.Close();
                workingServiceHost = null;
            }
        }
        protected override void OnContinue()
        {
        }
    }
}
