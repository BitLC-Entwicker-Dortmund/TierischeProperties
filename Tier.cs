using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TierischeProperties {
    class Tier {
        // java-like

        private string zweiterNachname;
 
        public void SetZweiterNachname (string s ) {
            zweiterNachname = s;
        }

        public string GetZweiterNachname ( ) {
            return zweiterNachname;
        }

        // c#
        public string Name { get; set; }

        private string kampfName;

        public string KampfName {
            get { 
                return kampfName; }
            set { kampfName = value; }
        }

    }
}
