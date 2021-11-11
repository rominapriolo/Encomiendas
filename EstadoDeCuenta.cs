using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace Encomiendas
{
    class EstadoDeCuenta
    {
        public string cuit { get; set; }
        private int id_cliente { get; set; }
        public List<Factura> FacturacionPaga { get; set; }
        public List<Factura> FacturacionImpaga { get; set; }
        public List<ServicioSolicitado> serviciosCumplidos { get; set; }
        public List<ServicioSolicitado> serviciosPendientes { get; set; }
        public decimal saldo { get; set; }
        //public List<Factura> facturas { get; set; }
        public List<Pago> pagos { get; set; }
        public List<ServicioSolicitado> servicios_del_cliente { get; set; }
               

        public void traerEstadoDeCuenta() 
        {
            listarPagos();
            listarFacturasPagasEImpagas();
            calcularSaldo();
            listarServiciosCumplidos();
            listarServiciosPdtesDeFacturar();
        }

        private void calcularSaldo() 
        {
            foreach (Factura factura_impaga in FacturacionImpaga)
            {               
               saldo += factura_impaga.totalFactura;                
            }
        }

        private void listarPagos()
        {
            Pago pago = new Pago();
            pago.cuit = cuit;
            pago.listaPagos = new List<Pago>();
            pago.listarPagos();
            pagos = pago.listaPagos;

        }


        private void listarServiciosCumplidos()
        {

            ClienteCorporativo clienteCorporativo = new ClienteCorporativo();
            clienteCorporativo.cuit = cuit;
            clienteCorporativo.traerIdCliente();
            id_cliente = clienteCorporativo.idCliente;

            ServicioSolicitado servicioSolicitado = new ServicioSolicitado();
            servicioSolicitado.idCliente = id_cliente;
            servicioSolicitado.serviciosCumplidos = new List<ServicioSolicitado>();
            servicioSolicitado.listarServiciosCumplidos();

            serviciosCumplidos = servicioSolicitado.serviciosCumplidos;
           
        }


        private void listarServiciosPdtesDeFacturar()
        {
           
            ServicioSolicitado servicioSolicitado = new ServicioSolicitado();
            servicioSolicitado.idCliente = id_cliente;
            servicioSolicitado.serviciosPendientes = new List<ServicioSolicitado>();
            servicioSolicitado.listarServiciosPdtesDeFacturar();

            serviciosPendientes = servicioSolicitado.serviciosPendientes;
        }

        private void listarFacturasPagasEImpagas()
        {

            Factura factura = new Factura();
            factura.cuit = cuit;
            factura.listaPagos = new List<Pago>();
            factura.facturacionImpaga = new List<Factura>();
            factura.facturacionPaga = new List<Factura>();

            factura.listaPagos = pagos;
            
            factura.listarFacturasPagasEImpagas();

            FacturacionImpaga = factura.facturacionImpaga;
            FacturacionPaga = factura.facturacionPaga;

        }


    }
}
