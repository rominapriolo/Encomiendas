using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Encomiendas
{
    class ClienteCorporativo
    {
        public int idCliente { get; set; }
        public string cuit { get; set; }
        public string razonSocial { get; set; }
        public string direccion { get; set; }
        public string provincia { get; set; }
        public string localidad { get; set; }
        public string codigoPostal { get; set; }
        public string nroCelular { get; set; }
        public string correoElectronico { get; set; }
        //public string cuentaCorriente { get; set; } // a que corresponde esto?
        public string condicionFrenteIVA  { get; set; }
        public DateTime fechaRegistro { get; set; }
        string ruta_archivo_clientes = @"../../datos/ClienteCorporativo.txt";

        public void traerIdCliente()
        {
            var stream_clientes = File.OpenRead(ruta_archivo_clientes);
            var reader_clientes = new StreamReader(stream_clientes);


            if (new FileInfo(ruta_archivo_clientes).Length != 0)
            {
                while (!reader_clientes.EndOfStream)
                {
                    var linea = reader_clientes.ReadLine();
                    string[] valores = linea.Split(';');

                    if (valores[1].Equals(cuit))
                    {
                        idCliente = int.Parse(valores[0]);
                    }
                }
            }

            stream_clientes.Close();
        }


    }
}
