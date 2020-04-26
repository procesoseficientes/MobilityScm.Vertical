using MobilityScm.Modelo.Tipos;

namespace MobilityScm.Vertical.Servicios
{
    public static class Ts
    {

        public static LenguajesTipo LenguajeTipoActual
        {
            get;
            set;
        }

        #region "Etiquetas"

        public static string EtiquetaInventario
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Inventory";
                    case LenguajesTipo.Español:
                        return "Inventario";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaNuevoCliente
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "New Client";
                    case LenguajesTipo.Español:
                        return "Cliente Nuevo";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaObjetivo
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Goal";
                    case LenguajesTipo.Español:
                        return "Objetivo";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaUnidadDeTiempo
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Time Unit";
                    case LenguajesTipo.Español:
                        return "Unidad de Tiempo";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaAl
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "To";
                    case LenguajesTipo.Español:
                        return "Al";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaFamilia
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Family";
                    case LenguajesTipo.Español:
                        return "Familia";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaMarca
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Brand";
                    case LenguajesTipo.Español:
                        return "Marca";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaDetallePromo
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Promotion Detail";
                    case LenguajesTipo.Español:
                        return "Detalle Promocion";
                    default:
                        return "";
                }
            }
        }


        public static string EtiquetaBonificado
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Discounted";
                    case LenguajesTipo.Español:
                        return "Bonificado";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaBonificaciones
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Discounts";
                    case LenguajesTipo.Español:
                        return "Bonificaciones";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaRemanente
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Excess";
                    case LenguajesTipo.Español:
                        return "Remanente";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaGeneral
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "General";
                    case LenguajesTipo.Español:
                        return "General";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaValidez
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Valid";
                    case LenguajesTipo.Español:
                        return "Valido";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaAtras
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Back";
                    case LenguajesTipo.Español:
                        return "Atras";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaAnulacionDeDocumentos
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Cancellation of Documents";
                    case LenguajesTipo.Español:
                        return "Anulación Documentos";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaDocumento
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Doc";
                    case LenguajesTipo.Español:
                        return "Doc";
                    default:
                        return "";
                }
            }

        }
        public static string EtiquetaCantidad
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Quantity";
                    case LenguajesTipo.Español:
                        return "Cantidad";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaCodigoDeBarras
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Barcode";
                    case LenguajesTipo.Español:
                        return "Código de Barras";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaTodas
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "All";
                    case LenguajesTipo.Español:
                        return "Todas";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaIngresoSeries
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Series";
                    case LenguajesTipo.Español:
                        return "Series";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaObjetivoTotal
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Goal Total";
                    case LenguajesTipo.Español:
                        return "Objetivo Total";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaDias
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Days";
                    case LenguajesTipo.Español:
                        return "Dias";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaObjetivoParcial
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Partial Goal of {0} days {1}";
                    case LenguajesTipo.Español:
                        return "Objetivo Parcial de {0} dias {1}";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaDocumentoVentaDirecta
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Invoice";
                    case LenguajesTipo.Español:
                        return "Factura";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaUnidades
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Units";
                    case LenguajesTipo.Español:
                        return "Unid";
                    default:
                        return "";
                }
            }
        }
        public static string EtiquetaProducto
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Item";
                    case LenguajesTipo.Español:
                        return "Producto";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaTotal
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Total";
                    case LenguajesTipo.Español:
                        return "Total";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaDireccion
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Address";
                    case LenguajesTipo.Español:
                        return "Direccion";
                    default:
                        return "";
                }
            }
        }
        public static string EtiquetaNit
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "NIT";
                    case LenguajesTipo.Español:
                        return "NIT";
                    default:
                        return "";
                }
            }
        }
        public static string EtiquetaNombreCliente
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Name";
                    case LenguajesTipo.Español:
                        return "Cliente";
                    default:
                        return "";
                }
            }
        }
        public static string EtiquetaClienteId
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Business Partner Id";
                    case LenguajesTipo.Español:
                        return "Id Cliente";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaComprometido
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Comm";
                    case LenguajesTipo.Español:
                        return "Comp";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaDisponible
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return @"/A";
                    case LenguajesTipo.Español:
                        return "Disp";
                    default:
                        return "";
                }
            }
        }
        public static string EtiquetaPrecio
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Price";
                    case LenguajesTipo.Español:
                        return "Precio";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaPromedioVenta
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "AVG";
                    case LenguajesTipo.Español:
                        return "Pro";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaMenuPrincipal
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Main Menu";
                    case LenguajesTipo.Español:
                        return "Menu Principal";
                    default:
                        return "";
                }
            }
        }
        public static string EtiquetaMarcaDeSalida
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Start Point";
                    case LenguajesTipo.Español:
                        return "Marca de Salida";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaKilometraje
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Kilometer";
                    case LenguajesTipo.Español:
                        return "Kilometraje";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaNoDocumento
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Document Number";
                    case LenguajesTipo.Español:
                        return "No Documento";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaNoDeGalones
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "number of gallons";
                    case LenguajesTipo.Español:
                        return "No. De Galones";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaFechaAbastecimiento
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Date supply";
                    case LenguajesTipo.Español:
                        return "Fecha De Abastecimiento";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaTipoDeDocumento
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Document Type";
                    case LenguajesTipo.Español:
                        return "Tipo De Documento";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaInicioDeViaje
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Trip Start";
                    case LenguajesTipo.Español:
                        return "Inicio De Viaje";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaAceptar
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "OK";
                    case LenguajesTipo.Español:
                        return "Aceptar";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaUsuario
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "User";
                    case LenguajesTipo.Español:
                        return "Usuario";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaClave
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Password";
                    case LenguajesTipo.Español:
                        return "Clave";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaCargandoRuta
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Loading Data";
                    case LenguajesTipo.Español:
                        return "Cargando Ruta";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaClientes
        {

            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Customers";
                    case LenguajesTipo.Español:
                        return "Clientes";
                    default:
                        return "";
                }
            }

        }

        public static string EtiquetaOpcionesAdicionales
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Additional Options";
                    case LenguajesTipo.Español:
                        return "Opciones Adicionales";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaOpcionDeRecepcion
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Get Packages";
                    case LenguajesTipo.Español:
                        return "Opciones de Recepción";
                    default:
                        return "";
                }
            }


        }

        public static string EtiquetaOpcionDeEnvio
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Send Packages";
                    case LenguajesTipo.Español:
                        return "Opciones de Envio";
                    default:
                        return "";
                }
            }

        }

        public static string EtiquetaDebe
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Debit";
                    case LenguajesTipo.Español:
                        return "Debe";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaPagado
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Paid";
                    case LenguajesTipo.Español:
                        return "Pagado";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaDescuento
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Discount";
                    case LenguajesTipo.Español:
                        return "Descuento";
                    default:
                        return "";
                }
            }
        }


        public static string EtiquetaEmpresa
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Company";
                    case LenguajesTipo.Español:
                        return "Empresa";
                    default:
                        return "";
                }
            }

        }

        public static string EtiquetaTelefono
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Phone";
                    case LenguajesTipo.Español:
                        return "Telefono";
                    default:
                        return "";
                }
            }

        }

        public static string EtiquetaLimiteDeCredito
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Credit Limit";
                    case LenguajesTipo.Español:
                        return "Limite de Credito";
                    default:
                        return "";
                }
            }

        }

        public static string EtiquetaCreditoDisponible
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Available Credit";
                    case LenguajesTipo.Español:
                        return "Credito Disponible";
                    default:
                        return "";
                }
            }

        }

        public static string EtiquetaUltimaVisita
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Last Visit";
                    case LenguajesTipo.Español:
                        return "Ultima Visita";
                    default:
                        return "";
                }
            }

        }

        public static string EtiquetaInformacionCliente
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Customer Information";
                    case LenguajesTipo.Español:
                        return "Informacion Cliente";
                    default:
                        return "";
                }
            }

        }

        public static string EtiquetaAgregar
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Add";
                    case LenguajesTipo.Español:
                        return "Agregar";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaFormasDePago
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Way to pay";
                    case LenguajesTipo.Español:
                        return "Formas de Pago";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaTipo
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Type";
                    case LenguajesTipo.Español:
                        return "Tipo";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaFecha
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Date";
                    case LenguajesTipo.Español:
                        return "Fecha";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaFechaDeEntrega
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Delivery date";
                    case LenguajesTipo.Español:
                        return "Fecha de Entrega";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaModuloSeleccionProductos
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Items";
                    case LenguajesTipo.Español:
                        return "Artículos";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaModuloAtenderVisita
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Partners";
                    case LenguajesTipo.Español:
                        return "Clientes";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaSaldo
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Balance";
                    case LenguajesTipo.Español:
                        return "Saldo";
                    default:
                        return "";
                }
            }
        }
        public static string EtiquetaVuelto
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Change";
                    case LenguajesTipo.Español:
                        return "Vuelto";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaMonto
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Amount";
                    case LenguajesTipo.Español:
                        return "Monto";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaNumeroDocumento
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Document";
                    case LenguajesTipo.Español:
                        return "Documento";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaResumenDeCobros
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Charges Summary";
                    case LenguajesTipo.Español:
                        return "Resumen de Cobros";
                    default:
                        return "";
                }
            }
        }


        public static string EtiquetaEstadoDeCuenta
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Account";
                    case LenguajesTipo.Español:
                        return "Estado de Cuenta";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaCheques
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Checks";
                    case LenguajesTipo.Español:
                        return "Cheques";
                    default:
                        return "";
                }
            }
        }


        public static string EtiquetaCheque
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Check";
                    case LenguajesTipo.Español:
                        return "Cheque";
                    default:
                        return "";
                }
            }
        }


        public static string EtiquetaAnulacionDeFacturas
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Cancellation Invoices";
                    case LenguajesTipo.Español:
                        return "Anulacion de Facturas";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaEfectivo
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Cash";
                    case LenguajesTipo.Español:
                        return "Efectivo";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaDeposito
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Deposit";
                    case LenguajesTipo.Español:
                        return "Deposito";
                    default:
                        return "";
                }
            }
        }


        public static string EtiquetaBoleta
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Receipt";
                    case LenguajesTipo.Español:
                        return "Boleta";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaBanco
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Bank";
                    case LenguajesTipo.Español:
                        return "Banco";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaNoCuenta
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Account Number";
                    case LenguajesTipo.Español:
                        return "No. Cuenta";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaExcluirUltimoPago
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Exclude Last Payment";
                    case LenguajesTipo.Español:
                        return "Excluir ultimo pago";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaTotalCheques
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Checks Total";
                    case LenguajesTipo.Español:
                        return "Total Cheques";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaTotalEfectivo
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Cash Total";
                    case LenguajesTipo.Español:
                        return "Total Efectivo";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaLinea
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Line";
                    case LenguajesTipo.Español:
                        return "Linea";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaRazonDeAnulacion
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Cancellation Reason";
                    case LenguajesTipo.Español:
                        return "Razon de Anulacion";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaCuenta
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Account Number";
                    case LenguajesTipo.Español:
                        return "Numero de Cuenta";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaExcluirPago
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Exclude Last Payment";
                    case LenguajesTipo.Español:
                        return "Excluir Ultimo Pago";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaFactura
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Invoice";
                    case LenguajesTipo.Español:
                        return "Factura";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaNombre
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Name";
                    case LenguajesTipo.Español:
                        return "Nombre";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaContacto
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Contact";
                    case LenguajesTipo.Español:
                        return "Contacto";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaTipoProducto
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Product Type";
                    case LenguajesTipo.Español:
                        return "Tipo Producto";
                    default:
                        return "";
                }
            }

        }

        public static string EtiquetaOpcionesPrincipales
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Main Options";
                    case LenguajesTipo.Español:
                        return "Opciones Principales";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaNumero
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "No";
                    case LenguajesTipo.Español:
                        return "No";
                    default:
                        return "";
                }
            }

        }

        public static string EtiquetaValidacionClave
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Password Validation";
                    case LenguajesTipo.Español:
                        return "Validacion de Clave";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaTransaccionesElectronicas
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Electronic Transactions";
                    case LenguajesTipo.Español:
                        return "Transacciones Electronicas";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaBuscar
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Search";
                    case LenguajesTipo.Español:
                        return "Busqueda";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaReferencia
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Ref.";
                    case LenguajesTipo.Español:
                        return "Ref.";
                    default:
                        return "";
                }
            }

        }

        public static string EtiquetaRegistroTransacciones
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Record Transactions";
                    case LenguajesTipo.Español:
                        return "Registro Transacciones";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaEnviar
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Send";
                    case LenguajesTipo.Español:
                        return "Enviar";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaSiguiente
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Next";
                    case LenguajesTipo.Español:
                        return "Siguiente";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaDetalleCliente
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Customer Details";
                    case LenguajesTipo.Español:
                        return "Detalle Cliente";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaTelefonoEpin
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Epin Phone";
                    case LenguajesTipo.Español:
                        return "Telefono Epin";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaTelefonoMmt
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "MMT Phone";
                    case LenguajesTipo.Español:
                        return "Telefono MMT";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaFinDeDia
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "End of Day";
                    case LenguajesTipo.Español:
                        return "Fin de Dia";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaCancelar
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Cancel";
                    case LenguajesTipo.Español:
                        return "Cancelar";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaExpandir
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Expand All";
                    case LenguajesTipo.Español:
                        return "Expandir Todos";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaOrdenDeVenta
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Sale Order";
                    case LenguajesTipo.Español:
                        return "Orden de Venta";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaConsultaInventario
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Stock Enquiry";
                    case LenguajesTipo.Español:
                        return "Consulta de Inventario";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaMalEstado
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Disrepair";
                    case LenguajesTipo.Español:
                        return "Mal Estado";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaDetalleRuta
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Route Details";
                    case LenguajesTipo.Español:
                        return "Detalle de Ruta";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaDescripcion
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Description";
                    case LenguajesTipo.Español:
                        return "Descripcion";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaEstado
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "State";
                    case LenguajesTipo.Español:
                        return "Estado";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaRuta
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Route";
                    case LenguajesTipo.Español:
                        return "Ruta";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaLocacion
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Location";
                    case LenguajesTipo.Español:
                        return "Locacion";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaDocumentoDeInventario
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Inventory Document";
                    case LenguajesTipo.Español:
                        return "Documento de Inventario";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaRegistroDeNoVenta
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Non Sale Record";
                    case LenguajesTipo.Español:
                        return "Registro De No Venta";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaRazonDeNoVenta
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Non Sale Reason";
                    case LenguajesTipo.Español:
                        return "Razon De No Venta";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaDarDeBaja
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Unsuscribe";
                    case LenguajesTipo.Español:
                        return "Dar De Baja";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaTasaDeCambio
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Exchange Rate";
                    case LenguajesTipo.Español:
                        return "Tasa De Cambio";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaMoneda
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Currency";
                    case LenguajesTipo.Español:
                        return "Moneda";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaVentaAnticipada
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Sale";
                    case LenguajesTipo.Español:
                        return "Venta Anticipada";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaResumenVentaAnticipada
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Summary";
                    case LenguajesTipo.Español:
                        return "Resumen Venta Anticipada";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaOpcionesConsultas
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Consultations Options";
                    case LenguajesTipo.Español:
                        return "Opciones Consultas";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaAnulacionDeDepositos
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Cancellation Deposits";
                    case LenguajesTipo.Español:
                        return "Anulacion de Depositos";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaCobertura
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Coverage";
                    case LenguajesTipo.Español:
                        return "Cobertura";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaEfectividad
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Effectiveness";
                    case LenguajesTipo.Español:
                        return "Efectividad";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaDropSizeDiario
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Drop Size Daily";
                    case LenguajesTipo.Español:
                        return "Drop Size Diario";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaDropSizeMensual
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Drop Size Monthly";
                    case LenguajesTipo.Español:
                        return "Drop Size Mensual";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaExistencia
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Stock";
                    case LenguajesTipo.Español:
                        return "Existencia";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaVendido
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Sold";
                    case LenguajesTipo.Español:
                        return "Vendido";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaConsultaFacturas
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Transaction History";
                    case LenguajesTipo.Español:
                        return "Historial de Transacciones";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaSerie
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Series";
                    case LenguajesTipo.Español:
                        return "Serie";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaAnulada
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Canceled";
                    case LenguajesTipo.Español:
                        return "Anulada";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaEmitida
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Issued";
                    case LenguajesTipo.Español:
                        return "Emitida";
                    default:
                        return "";
                }
            }
        }




        #endregion

        #region "Mensajes"

        public static string DeseIntentarloDeNuevo
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Do you want to try again";
                    case LenguajesTipo.Español:
                        return "Desea intentarlo de nuevo";
                    default:
                        return "";
                }
            }
        }

        public static string ErrorAlEliminar
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Error on delete";
                    case LenguajesTipo.Español:
                        return "Error al eliminar";
                    default:
                        return "";
                }
            }
        }
        public static string NoExisteRutaParaEseRecorrido
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "There is no generated route for that travel";
                    case LenguajesTipo.Español:
                        return "No existe ruta generada para ese recorrido";
                    default:
                        return "";
                }
            }
        }

        public static string NoHayGeoposicionesQueGuardar
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "There are no geopositions to save";
                    case LenguajesTipo.Español:
                        return "No existen geoposiicones para guardar";
                    default:
                        return "";
                }
            }
        }

        public static string IngreseTodosLosCampos
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "You must fill all the fields";
                    case LenguajesTipo.Español:
                        return "Debe ingresar todos los campos";
                    default:
                        return "";
                }
            }
        }

        public static string RutaGeneradaConExito
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "The route was succesfully generated";
                    case LenguajesTipo.Español:
                        return "La ruta fue generada con exito";
                    default:
                        return "";
                }
            }
        }

        public static string ErrorAlGenerarDatos
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Error generating data";
                    case LenguajesTipo.Español:
                        return "Error al generar datos";
                    default:
                        return "";
                }
            }
        }

        public static string DeseaContinuar
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Would you like to continue?";
                    case LenguajesTipo.Español:
                        return "Desea continuar?";
                    default:
                        return "";
                }
            }
        }

        public static string ClienteYaExistente
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Similar client already exists";
                    case LenguajesTipo.Español:
                        return "Ya existe un cliente similar";
                    default:
                        return "";
                }
            }
        }

        public static string NitInvalido
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Invalid NIT";
                    case LenguajesTipo.Español:
                        return "NIT Invalido";
                    default:
                        return "";
                }
            }
        }

        public static string PrimeraPromocion
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "This is the first discount";
                    case LenguajesTipo.Español:
                        return "Esta es la primera promocion";
                    default:
                        return "";
                }
            }
        }

        public static string UltimaPromocion
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "This is the last discount";
                    case LenguajesTipo.Español:
                        return "Esta es la ultima promocion";
                    default:
                        return "";
                }
            }
        }

        public static string DeseaSalirSinSaldarLaFactura
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Would you like to exit without paying this invoice?";
                    case LenguajesTipo.Español:
                        return "Desea salir sin saldar la factura?";
                    default:
                        return "";
                }
            }
        }

        public static string ErrorAlGuardar
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Error on Saving";
                    case LenguajesTipo.Español:
                        return "Error al Guardar";
                    default:
                        return "";
                }
            }
        }

        public static string Ciudad
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "City";
                    case LenguajesTipo.Español:
                        return "Ciudad";
                    default:
                        return "";
                }
            }
        }

        public static string DeseImprimirElDocumento
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Do you want to print the document?";
                    case LenguajesTipo.Español:
                        return "Desea imprimir el documento?";
                    default:
                        return "";
                }
            }
        }
        public static string IngreseNombreDeCliente
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "You must insert a name for the Client";
                    case LenguajesTipo.Español:
                        return "Ingrese un nombre para el Cliente";
                    default:
                        return "";
                }
            }
        }


        public static string LaSerieYaFueUtilizada
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "The series {0} was already used";
                    case LenguajesTipo.Español:
                        return "La Serie {0} Ya Fue Utilizada";
                    default:
                        return "";
                }
            }
        }

        public static string NoSeEncontroLaSerie
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Series  {0} not found";
                    case LenguajesTipo.Español:
                        return "No Se Encontro La Serie: {0}";
                    default:
                        return "";
                }
            }
        }


        public static string NoHayDatosQueGuardar
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "There are no data to save";
                    case LenguajesTipo.Español:
                        return "No Hay Datos Que Guardar";
                    default:
                        return "";
                }
            }
        }

        public static string ArticuloYaIngresado
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Item already entered";
                    case LenguajesTipo.Español:
                        return "Articulo Ya Ingresado";
                    default:
                        return "";
                }
            }
        }
        public static string NohaySuficienteStock
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "there is not enough product in stock";
                    case LenguajesTipo.Español:
                        return "No hay Suficiente Stock";
                    default:
                        return "";
                }
            }
        }


        public static string YaSeHaUtilizadoEl75PorCiento
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "We have already used 75% of the resolution: {0} is required to manage a new resolution for printing invoices";
                    case LenguajesTipo.Español:
                        return "Ya se ha utilizado el 75% de la resolución: {0} Es necesario gestionar una nueva resolución para la impresión de facturas";
                    default:
                        return "";
                }
            }
        }
        public static string NohayValoresDisponiblesParaLaSerieDeEsteTipoDeDocumento
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "No Available For This Series Document Type";
                    case LenguajesTipo.Español:
                        return "No hay Valores Disponibles Para La Serie De Este Tipo DeDocumento";
                    default:
                        return "";
                }
            }
        }

        public static string SocioDeNegociosNoEcontrado
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Business Partner Not Found";
                    case LenguajesTipo.Español:
                        return "Socio De Negocios No Encontrado";
                    default:
                        return "";
                }
            }
        }



        public static string DatoNoEcontrado
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Data Not Found";
                    case LenguajesTipo.Español:
                        return "Dato No Encontrado";
                    default:
                        return "";
                }
            }
        }


        public static string DeseaGuardarElDocumento
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Do you want to save it?";
                    case LenguajesTipo.Español:
                        return "Desea Guardar El Documento?";
                    default:
                        return "";
                }
            }
        }

        public static string LugarDeSalidaInexistente
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Location nonexistent output";
                    case LenguajesTipo.Español:
                        return "Lugar de salida inexistente";
                    default:
                        return "";
                }
            }
        }
        public static string ElKilometrajeDebeSerMayorA
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "The mileage should be greater than ";
                    case LenguajesTipo.Español:
                        return "El kilometraje debe ser mayor a  ";
                    default:
                        return "";
                }
            }
        }

        public static string SeIniciaráDiaConUnaMarcaIncorrecta
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Day will begin with an incorrect mark";
                    case LenguajesTipo.Español:
                        return "SeIniciará día con una marca incorrecta";
                    default:
                        return "";
                }
            }
        }

        public static string SeRegistraráGasolinaAlVehiculo
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Gasoline vehicle will be registered?";
                    case LenguajesTipo.Español:
                        return "Se registrará gasolina al vehículo?";
                    default:
                        return "";
                }
            }
        }


        public static string IngreseMarcaDeSalida
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Enter starting point";
                    case LenguajesTipo.Español:
                        return "Ingrese Marca De Salida";
                    default:
                        return "";
                }
            }
        }


        public static string IngreseKilometraje
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Enter Mileagee";
                    case LenguajesTipo.Español:
                        return "Ingrese Kilometraje";
                    default:
                        return "";
                }
            }
        }

        public static string IngreseFechaDelVale
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Enter voucher date";
                    case LenguajesTipo.Español:
                        return " Ingrese Fecha Del Vale";
                    default:
                        return "";
                }
            }
        }
        public static string IngreseCantidadDeCombustible
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Enter Quantity Fuel";
                    case LenguajesTipo.Español:
                        return "Ingrese Cantidad De Combustible";
                    default:
                        return "";
                }
            }
        }
        public static string IngreseNúmerodedocumento
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Enter document number";
                    case LenguajesTipo.Español:
                        return "Ingrese Número de documento";
                    default:
                        return "";
                }
            }
        }

        public static string DebeIngresarUnaCantidad
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Must enter a value";
                    case LenguajesTipo.Español:
                        return "Debe Ingresar Una Cantidad";
                    default:
                        return "";
                }
            }
        }

        public static string DebeIngresarUsuarioYClave
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "User and Password are Required";
                    case LenguajesTipo.Español:
                        return "Debe ingresar usuario y clave";
                    default:
                        return "";
                }
            }
        }

        public static string EsNecesarioInicializarElSistema
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Required to initialize the system";
                    case LenguajesTipo.Español:
                        return "Es Necesario Inicializar el Sistema";
                    default:
                        return "";
                }
            }
        }

        public static string ProcesoExitoso
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Success";
                    case LenguajesTipo.Español:
                        return "Proceso exitoso";
                    default:
                        return "";
                }
            }
        }

        public static string ErrorEnModulo
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.Español:
                        return "Error En Modulo ";
                    case LenguajesTipo.English:
                        return "Error in Module ";
                    default:
                        return "";
                }
            }

        }

        public static string NoHaFinalizadoElDia
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Has not Finished The Day";
                    case LenguajesTipo.Español:
                        return "No Ha Finalizado El Día";
                    default:
                        return "";
                }
            }
        }

        public static string InicioDeDiaRealizado
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Performed beginning day";
                    case LenguajesTipo.Español:
                        return "Inicio de día realizado";
                    default:
                        return "";
                }
            }
        }

        public static string BancosPorEmpresaNoEncontrados
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Banks by company not found";
                    case LenguajesTipo.Español:
                        return "Bancos por empresa no encontrados";
                    default:
                        return "";
                }
            }
        }

        public static string MonedasPorEmpresaNoEncontrados
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Currencies by company not found";
                    case LenguajesTipo.Español:
                        return "Monedas por empresa no encontradas";
                    default:
                        return "";
                }
            }
        }

        public static string MetodosDePagoNoEncontrados
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Payment methods not found";
                    case LenguajesTipo.Español:
                        return "Metodos de pago no encontrados";
                    default:
                        return "";
                }
            }
        }

        public static string BancoNoEncontrado
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Bank not found";
                    case LenguajesTipo.Español:
                        return "Banco no encontrado";
                    default:
                        return "";
                }
            }
        }

        public static string MetodoDePagoNoElegido
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Choose payment method";
                    case LenguajesTipo.Español:
                        return "Elija metodo de pago";
                    default:
                        return "";
                }
            }
        }

        public static string MonedaNoElegida
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Choose Currency";
                    case LenguajesTipo.Español:
                        return "Elija moneda de pago";
                    default:
                        return "";
                }
            }
        }


        public static string BancoNoElegido
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "choose bank";
                    case LenguajesTipo.Español:
                        return "Elija banco";
                    default:
                        return "";
                }
            }
        }

        public static string NumeroDocumentoNoIngresado
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Enter document number";
                    case LenguajesTipo.Español:
                        return "Ingrese numero de documento";
                    default:
                        return "";
                }
            }
        }

        public static string MontoNoIngresado
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Enter Amount";
                    case LenguajesTipo.Español:
                        return "Ingrese el monto del pago";
                    default:
                        return "";
                }
            }
        }

        public static string NoExisteSaldoPendienteDeCobro
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Not exist balance";
                    case LenguajesTipo.Español:
                        return "No existe saldo pendiente de cobro";
                    default:
                        return "";
                }
            }
        }

        public static string MontoDebeSerNumerico
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Amount is a number";
                    case LenguajesTipo.Español:
                        return "Monto debe ser un numero";
                    default:
                        return "";
                }
            }
        }


        public static string RazonesNoEncontrados
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Reasons not found";
                    case LenguajesTipo.Español:
                        return "Razones no encontradas";
                    default:
                        return "";
                }
            }
        }

        public static string NoEsPosibleSincronizarEnEsteMomento
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Can not sync at this time";
                    case LenguajesTipo.Español:
                        return "No es posible sincronizar en este momento";
                    default:
                        return "";
                }
            }
        }

        public static string Anulado
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Canceled";
                    case LenguajesTipo.Español:
                        return "Anulado";
                    default:
                        return "";
                }
            }
        }

        public static string DeseaEliminarLaFactura
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Do you want to delete the invoice?";
                    case LenguajesTipo.Español:
                        return "Desea eliminar la factura?";
                    default:
                        return "";
                }
            }
        }


        public static string DeseaEliminarElRegistro
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Do you want to delete the record?";
                    case LenguajesTipo.Español:
                        return "Desea eliminar el registro?";
                    default:
                        return "";
                }
            }
        }

        public static string PagosNoSeleccionados
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Choose payment(s) to deposit";
                    case LenguajesTipo.Español:
                        return "Seleccione pago(s) a depositar";
                    default:
                        return "";
                }
            }
        }


        public static string IngreseBoleta
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Enter receipt num";
                    case LenguajesTipo.Español:
                        return "Ingrese numero de boleta";
                    default:
                        return "";
                }
            }
        }

        public static string IngreseUnMontoMayorACero
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Enter an amount greater than zero";
                    case LenguajesTipo.Español:
                        return "Ingrese un monto mayor a Cero";
                    default:
                        return "";
                }
            }
        }

        public static string ClaveIncorrecta
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Incorrect Password";
                    case LenguajesTipo.Español:
                        return "Clave Incorrecta";
                    default:
                        return "";
                }
            }
        }

        public static string DeseaLiberarLasTransaccionesSeleccionadas
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Do you want to release the selected transactions?";
                    case LenguajesTipo.Español:
                        return "Desea liberar las transacciones seleccionadas?";
                    default:
                        return "";
                }
            }
        }

        public static string NoExisteElemento
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "The Element {0} Does Not Exist";
                    case LenguajesTipo.Español:
                        return "No Existe el Elemento {0}";
                    default:
                        return "";
                }
            }
        }

        public static string SeleccioneTransaccionesAEnviar
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Select transactions to be sent";
                    case LenguajesTipo.Español:
                        return "Seleccione las transacciones a enviar";
                    default:
                        return "";
                }
            }
        }

        public static string AccesoDenegado
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Acces denied";
                    case LenguajesTipo.Español:
                        return "Acceso denegado";
                    default:
                        return "";
                }
            }
        }

        public static string DeseaRealizarFinDeDia
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Do you want end day?";
                    case LenguajesTipo.Español:
                        return "Desea realizar fin de dia?";
                    default:
                        return "";
                }
            }
        }

        public static string DeseaRealizarFinDeDiaConfirmar
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Are you sure?";
                    case LenguajesTipo.Español:
                        return "Seguro que desea realizar fin de dia?";
                    default:
                        return "";
                }
            }

        }



        public static string DebeSincronizarDocsDeVenta
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Syncronize sale documents";
                    case LenguajesTipo.Español:
                        return "Debe sincronizar los documentos de venta";
                    default:
                        return "";
                }
            }

        }

        public static string DebeImprimirDocsDeVenta
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "You should print sale documents";
                    case LenguajesTipo.Español:
                        return "Debe imprimir los documentos de venta";
                    default:
                        return "";
                }
            }

        }

        public static string DebeImprimirDocsDePago
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "You should print payment documents";
                    case LenguajesTipo.Español:
                        return "Debe imprimir los documentos de venta";
                    default:
                        return "";
                }
            }

        }

        public static string DebeDepositarLosCobros
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "You should deposit payments";
                    case LenguajesTipo.Español:
                        return "Debe depositar todos los cobros";
                    default:
                        return "";
                }
            }

        }

        public static string DebeSincronizarCobros
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "You should syncronize payment";
                    case LenguajesTipo.Español:
                        return "Debe sincronizar todos los cobros";
                    default:
                        return "";
                }
            }

        }

        public static string DebeSincronizarDepositos
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "You should syncronize deposits";
                    case LenguajesTipo.Español:
                        return "Debe sincronizar todos los depositos";
                    default:
                        return "";
                }
            }

        }

        public static string DebeDevolverElInventario
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "You should return inventory";
                    case LenguajesTipo.Español:
                        return "Debe hacer devolucion de inventario";
                    default:
                        return "";
                }
            }

        }

        public static string DebeEnviarTransElectronicas
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "You should send electronic transactions";
                    case LenguajesTipo.Español:
                        return "Debe enviar transacciones electronicas";
                    default:
                        return "";
                }
            }

        }

        public static string DebeRealizarTareasDeInventario
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "You should resolve inventory task";
                    case LenguajesTipo.Español:
                        return "Debe hacer las tareas de inventario";
                    default:
                        return "";
                }
            }

        }

        public static string ElServidorRemotoDevolvióUnError
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "The remote server returned an error";
                    case LenguajesTipo.Español:
                        return "El servidor remoto devolvió un error";
                    default:
                        return "";
                }
            }
        }

        public static string NoTienePrivilegioParaReporte
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "You do not have privilege for this report";
                    case LenguajesTipo.Español:
                        return "No tiene privilegio para este reporte";
                    default:
                        return "";
                }
            }
        }

        public static string TipoDePagoNoPuedeExcederSaldo
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "This payment type can't exceed the balance";
                    case LenguajesTipo.Español:
                        return "Este tipo de pago no puede exceder el saldo";
                    default:
                        return "";
                }
            }
        }

        public static string NoSePuedePagarMasDeUnaFactura
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "You can't pay more than one invoice with this payment type";
                    case LenguajesTipo.Español:
                        return "No se puede pagar mas de una factura con este tipo de pago";
                    default:
                        return "";
                }
            }
        }

        public static string DebeDeEliminarElUltimoPago
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "You only can delete the last payment";
                    case LenguajesTipo.Español:
                        return "Solo puede eliminar el ultimo pago";
                    default:
                        return "";
                }
            }
        }
        public static string EtiquetaSemana
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Week";
                    case LenguajesTipo.Español:
                        return "Semana";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaVisitado
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Visited";
                    case LenguajesTipo.Español:
                        return "Visitado";
                    default:
                        return "";
                }
            }
        }
        public static string Bueno
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Good";
                    case LenguajesTipo.Español:
                        return "Bueno";
                    default:
                        return "";
                }
            }
        }

        public static string EtiquetaSinVistar
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Unvisited";
                    case LenguajesTipo.Español:
                        return "No Visitado";
                    default:
                        return "";
                }
            }
        }
        public static string Malo
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Bad";
                    case LenguajesTipo.Español:
                        return "Malo";
                    default:
                        return "";
                }
            }
        }

        public static string DebeSeleccionarUnCliente
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "You should choose a customer";
                    case LenguajesTipo.Español:
                        return "Debe de seleccionar un cliente";
                    default:
                        return "";
                }
            }
        }

        public static string DebeIngresarTodosLosDatos
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "You should set all data";
                    case LenguajesTipo.Español:
                        return "Debe de ingresar todos los datos";
                    default:
                        return "";
                }
            }
        }

        public static string DebeIngresarCantidadMayor
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "The Quantity should be greater than 5";
                    case LenguajesTipo.Español:
                        return "La cantidad debe ser mayor a 5";
                    default:
                        return "";
                }
            }
        }

        public static string ClienteNoTieneTelefono
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "This Customer does not have phone.";
                    case LenguajesTipo.Español:
                        return "Este cliente no posee teléfono.";
                    default:
                        return "";
                }
            }
        }

        public static string ClienteSeleccionado
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Customer Selected";
                    case LenguajesTipo.Español:
                        return "Cliente Seleccionado";
                    default:
                        return "";
                }
            }
        }

        public static string DocumentosNoImpresos
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "There are documents pending to print.";
                    case LenguajesTipo.Español:
                        return "Existen Documentos Pendientes de imprimir";
                    default:
                        return "";
                }
            }
        }

        public static string ElMontoADepositarExcedeLoCobrado
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "The deposit amount exceeds payments";
                    case LenguajesTipo.Español:
                        return "El monto a depositar excede los pagos";
                    default:
                        return "";
                }
            }
        }

        // "El texto no puede estar en blanco."

        public static string ElTextoNoPuedeEstarEnBlanco
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "Text can not be blank.";
                    case LenguajesTipo.Español:
                        return "El texto no puede estar en blanco.";
                    default:
                        return "";
                }
            }
        }

        public static string LicenciaNoValida
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "No Valid License";
                    case LenguajesTipo.Español:
                        return "Licencia No Valida";
                    default:
                        return "";
                }
            }
        }

        public static string FaltaCentroDeDistribucion
        {
            get
            {
                switch (LenguajeTipoActual)
                {
                    case LenguajesTipo.English:
                        return "You must select distribution center";
                    case LenguajesTipo.Español:
                        return "Falta Centro de distribución";
                    default:
                        return "";
                }
            }
        }

        #endregion


    }
}