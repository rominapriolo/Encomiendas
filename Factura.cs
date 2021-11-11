using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Encomiendas
{
    class Factura
    {
        public int idFactura { get; set; }
        public string nroFactura { get; set; }
        public int idCliente { get; set; }
        public string razonSocial { get; set; }
        public string cuit { get; set; }
        public string letraComprobante { get; set; }       
        public DateTime fechaFactura { get; set; }
        public decimal exento { get; set; }
        public decimal gravado { get; set; }
        public decimal iva21 { get; set; }
        public decimal totalFactura { get; set; }
        public List<ServicioSolicitado> listaServicios { get; set; }
        public List<Factura> facturacionPaga { get; set; }
        public List<Factura> facturacionImpaga { get; set; }
        public List<Pago> listaPagos { get; set; }


        string ruta_archivo_pagos = @"../../datos/Pago.txt";
        string ruta_archivo_facturas = @"../../datos/Factura.txt";

        //listarServiciosAFacturar()
        //calcularTotal()
        //emitirFactura()
        //listarFacturas()
        public void listarFacturasPagasEImpagas()
        {
            var stream = File.OpenRead(ruta_archivo_facturas);
            var reader = new StreamReader(stream);


            if (new FileInfo(ruta_archivo_pagos).Length != 0)
            {
                while (!reader.EndOfStream)
                {
                    var linea = reader.ReadLine();

                    string[] valores = linea.Split(';');

                    if (valores[4].Equals(cuit))
                    {
                        Factura factura = new Factura();
                        factura.letraComprobante = valores[5];
                        factura.nroFactura = valores[1];
                        factura.idFactura = int.Parse(valores[1]);
                        factura.idCliente = int.Parse(valores[2]);
                        factura.razonSocial = valores[3];
                        factura.cuit = valores[4];
                        factura.fechaFactura = DateTime.Parse(valores[6]);
                        factura.exento = Decimal.Parse(valores[7]);
                        factura.gravado = Decimal.Parse(valores[8]);
                        factura.iva21 = Decimal.Parse(valores[9]);
                        factura.totalFactura = Decimal.Parse(valores[10]);

                        int encuentra = 0;

                        foreach (Pago item in listaPagos)
                        {
                            //                            MessageBox.Show(item.nroComprobante);

                            if (item.nroComprobante.Equals(factura.letraComprobante + factura.nroFactura))
                            {
                                encuentra = 1;
                            }

                            //   FacturacionPaga.Add(factura);

                        }

                        if (encuentra == 0)
                        {
                            facturacionImpaga.Add(factura);
                        }
                        else
                        {
                            facturacionPaga.Add(factura);
                        }
                    }
                }
            }



            stream.Close();
        }


    }
}
