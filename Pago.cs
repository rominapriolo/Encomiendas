using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Encomiendas
{
    class Pago
    {
        public int nroPago { get; set; }
        public string razonSocial { get; set; }
        public string cuit { get; set; }
        public string nroComprobante { get; set; }
        public DateTime fecha { get; set; }        
        public decimal importeCancelado { get; set; }
        public List<Pago> listaPagos { get; set; }

        //registrarPago()
        //listarPagos()
        string ruta_archivo_pagos = @"../../datos/Pago.txt";
        public void listarPagos() 
        {
            var stream = File.OpenRead(ruta_archivo_pagos);
            var reader = new StreamReader(stream);


            if (new FileInfo(ruta_archivo_pagos).Length != 0)
            {
                while (!reader.EndOfStream)
                {
                    var linea = reader.ReadLine();

                    string[] valores = linea.Split(';');

                    if (valores[2].Equals(cuit))
                    {
                        Pago pago = new Pago();
                        pago.nroPago = int.Parse(valores[0].ToString());
                        pago.razonSocial = valores[1];
                        pago.cuit = valores[2];
                        pago.nroComprobante = valores[3];
                        pago.fecha = DateTime.Parse(valores[4].ToString());
                        pago.importeCancelado = Decimal.Parse(valores[5]);

                        listaPagos.Add(pago);
                    }

                }
            }

            stream.Close();
        }

    }
}
