using System;
using System.IO;
using MobilityScm.Modelo.Tipos;
using MobilityScm.Vertical.Entidades;
using System.Runtime.InteropServices;
using System.Text;

namespace MobilityScm.Vertical.Servicios
{
    public class UtileriasServicio
    {
        public Operacion ConvertirEnArregloBytes(string nombreArchivo)
        {
            {
                try
                {
                    {
                        var stream = new FileStream(nombreArchivo, FileMode.Open, FileAccess.Read);
                        var array = new byte[(Convert.ToInt32(stream.Length) + 1)];
                        Array.Resize<byte>(ref array, Convert.ToInt32(stream.Length));
                        stream.Read(array, 0, Convert.ToInt32(stream.Length));
                        stream.Close();
                        return new Operacion
                        {
                            Codigo = 0,
                            Dato = array,
                            Mensaje = "Proceso Exitoso",
                            Resultado = ResultadoOperacionTipo.Exito
                        };
                    }
                }
                catch (Exception e)
                {
                    return new Operacion
                    {
                        Codigo = -1,
                        Mensaje = e.Message,
                        Resultado = ResultadoOperacionTipo.Error

                    };
                }
            }
        }

        private const int SPI_GETOEMINFO = 260;
        private const int SPI_GETPLATFORMMANUFACTURER = 262;
        private const int SPI_GETOSINFO = 224;

        [DllImport("coredll.dll", EntryPoint = "SystemParametersInfo", SetLastError = true)]
        private static extern int SystemParametersInfoString(int uiAction, int uiParam, StringBuilder pvParam, int fWinIni);

        public static string UsuarioDeseaObtenerInformacionModelo()
        {
            try
            {
                StringBuilder sb = new StringBuilder(256);

                if (SystemParametersInfoString(SPI_GETOEMINFO, sb.Capacity, sb, 0) != 0)
                {
                    return sb.ToString();
                }
            }
            catch
            {
            }

            return "<Unknown platform>";
        }

        public static string UsuarioDeseaObtenerInformacionFabricante()
        {
            try
            {
                StringBuilder sb = new StringBuilder(256);

                if (SystemParametersInfoString(SPI_GETPLATFORMMANUFACTURER, sb.Capacity, sb, 0) != 0)
                {
                    return sb.ToString();
                }
            }
            catch
            {
            }

            return "<Unknown Manufacturer>";
        }
        public static string UsuarioDeseaObtenerOsVersion(){
            try
            {
                return System.Environment.OSVersion.Version.ToString();
            }
            catch
            {
            }

            return "<Unknown Manufacturer>";
          
        }
    }
}
