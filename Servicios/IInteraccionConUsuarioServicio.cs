using System;
using System.Collections.Generic;

namespace MobilityScm.Vertical.Servicios
{
    public interface IInteraccionConUsuarioServicio
    {

        void Confirmar(string mensaje, Action accionAceptar, string titulo, string botonAceptar, string botonCancelar);
        void Confirmar(string mensaje, Action<bool> respuesta, string titulo, string botonAceptar, string botonCancelar);
        void Confirmar(string mensaje, Action<bool> respuesta);

        void Alerta(string mensaje, Action accionFinalizar, string titulo);
        void Mensaje(string mensaje, Action accionFinalizar, string titulo);

        void CerrarActividadActual();

        void AgregarActividadActual();

        void CerrarDosActividadesPrevias();
        void Alerta(string mensaje);
        void Confirmar(string mensaje, Action accionAceptar);
        void Alerta(string mensaje, Action accionFinalizar);
        void Mensaje(string mensaje);

        void MensajeExito(string mensaje);
        void MensajeErrorDialogo(string mensaje);

        void MensajeListaDeErrorDialogo(List<string> listaErrores);

        string ObtenerUsuario();

        string ObtenerNombreUsuario();

        string ObtenerLogo();

        string ObtenerNombreEmpresa();

        string ObtenerCentroDistribucion();

        string ObtenerLogoDeImagenPredeterminada();

        string ObtenerDireccionBaseDeApi();

        void MensajeExito(string mensaje, bool mostrarAlerta);

        string ObtenerDominioDeUsuario();

        string ObtenerClaveDeUsuario();

        string ObtenerUsuarioYDominio();
        string ObtenerUsuarioDeBaseDeDatos();
        string ObtenerContraseniaDeBaseDeDatos();

        string ObtenerServerIp();

        void MostrarDialogoDeCargando();

        void CerrarDialogoDeCargando();
    }
}