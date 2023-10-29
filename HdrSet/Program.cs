using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HdrSetLib;

namespace HdrSet
{
    class Program
    {

        private static void Instruct()
        {
            Console.WriteLine( "Usage: hdrset {on|off}" );
        }

        static void Main( string[] args )
        {
            if (args.Length < 2)
            {
                Instruct();
                return;
            }
            if (args[1].ToLower() == "on")
            {
                HdrSetter.SetHDR( true );
            }
            else if (args[1].ToLower() == "off")
            {
                HdrSetter.SetHDR( false );
            }
            else
            {
                Instruct();
            }
        }
    }
}
