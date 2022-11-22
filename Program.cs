using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TierischeProperties {
    class Program {
        static void Main ( string [ ] args ) {
            Tier einTier = new Tier ( );
            einTier.Name = "Sven";
            einTier.KampfName = "Tiger";

            einTier.SetZweiterNachname ( "the Debile");            

            Console.ReadLine ( );
        }
    }
}
