//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.34014
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GadgeteerApp2 {
    using Gadgeteer;
    using GTM = Gadgeteer.Modules;
    
    
    public partial class Program : Gadgeteer.Program {
        
        /// <summary>The Distance US3 module using socket 4 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.Distance_US3 distance_US3;
        
        /// <summary>The Button module using socket 3 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.Button button;
        
        /// <summary>The UsbClientSP module using socket 8 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.UsbClientSP usbClientSP2;
        
        /// <summary>The Bluetooth module using socket 2 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.Bluetooth bluetooth;
        
        /// <summary>This property provides access to the Mainboard API. This is normally not necessary for an end user program.</summary>
        protected new static GHIElectronics.Gadgeteer.FEZCerberus Mainboard {
            get {
                return ((GHIElectronics.Gadgeteer.FEZCerberus)(Gadgeteer.Program.Mainboard));
            }
            set {
                Gadgeteer.Program.Mainboard = value;
            }
        }
        
        /// <summary>This method runs automatically when the device is powered, and calls ProgramStarted.</summary>
        public static void Main() {
            // Important to initialize the Mainboard first
            Program.Mainboard = new GHIElectronics.Gadgeteer.FEZCerberus();
            Program p = new Program();
            p.InitializeModules();
            p.ProgramStarted();
            // Starts Dispatcher
            p.Run();
        }
        
        private void InitializeModules() {
            this.distance_US3 = new GTM.GHIElectronics.Distance_US3(4);
            this.button = new GTM.GHIElectronics.Button(3);
            this.usbClientSP2 = new GTM.GHIElectronics.UsbClientSP(8);
            this.bluetooth = new GTM.GHIElectronics.Bluetooth(2);
        }
    }
}
