using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace HdrSetLib
{
    public class HdrSetter
    {

        [DllImport( "dxgi.dll", EntryPoint = "CreateDXGIFactory1", SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true, CallingConvention = CallingConvention.StdCall )]
        private static extern int CreateDXGIFactory1( [MarshalAs( UnmanagedType.LPStruct )] Guid riid, out IntPtr ppFactory );

        private static Guid IDXGIFactory5_GUID = new Guid( "8b4f173b-2fea-46d2-bf3c-9e91dbbcadad" );

        public static void SetHDR( bool enable )
        {
            IntPtr pFactory = IntPtr.Zero;
            int result = CreateDXGIFactory1( IDXGIFactory5_GUID, out pFactory );

            if( result < 0 )
            {
                Marshal.ThrowExceptionForHR( result );
            }

            object factory5 = null;
            if( pFactory != IntPtr.Zero )
            {
                factory5 = Marshal.GetObjectForIUnknown( pFactory );
                Marshal.Release( pFactory );
            }

            if( factory5 != null )
            {
                var dxgiFactory5 = (IDXGIFactory5)factory5;
                dxgiFactory5.SetHDRMetaData( enable ? DXGI_HDR_METADATA_HDR10.SCENE_REFERRED : DXGI_HDR_METADATA_HDR10.NONE, 0, IntPtr.Zero );
            }
        }

        [ComImport, Guid( "8b4f173b-2fea-46d2-bf3c-9e91dbbcadad" ), InterfaceType( ComInterfaceType.InterfaceIsIUnknown )]
        private interface IDXGIFactory5
        {
            // IDXGIFactory methods
            // ...

            // IDXGIFactory1 methods
            // ...

            // IDXGIFactory2 methods
            // ...

            // IDXGIFactory3 methods
            // ...

            // IDXGIFactory4 methods
            // ...

            // IDXGIFactory5 methods
            void SetHDRMetaData( DXGI_HDR_METADATA_HDR10 Type, uint Size, IntPtr pMetaData );
        }

        public enum DXGI_HDR_METADATA_HDR10
        {
            NONE = 0,
            SCENE_REFERRED = 1,
            DISPLAY_REFERRED = 2
        }
    }

}
