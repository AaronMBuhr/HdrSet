using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace HdrSet
{
    public partial class frmMain : Form
    {

        //[DllImport( "WinHdrLib.dll", EntryPoint = "fnIsHdrSet", CallingConvention = CallingConvention.StdCall )]
        //public static extern bool fnIsHdrSet();


        private static bool IsHdrSet()
        {
            var color = AdvancedColorInfo.CurrentAdvancedColorKind()
        }
        public frmMain()
        {

            InitializeComponent();
            if( fnIsHdrSet() )
            {
                lblIsHdrSetValue.Text = "yes";
            }

        }
    }
}
