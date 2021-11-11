using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace Encomiendas
{
    class ServicioSolicitadoDetalle
    {
        public int idServicio { get; set; }        
        //public string tipo { get; set; }
        public decimal peso { get; set; }
        public decimal iva21 { get; set; }
        public decimal exento { get; set; }
        public decimal gravado { get; set; }
        public decimal total { get; set; }
        public string unidad { get; set; }
        public List<ServicioSolicitadoDetalle> detalle { get; set; }


        string ruta_archivo_servicio_solicitado_detalle = @"../../datos/ServicioSolicitadoDetalle.txt";

        public void traerDetalleServicio()
        {
            var stream = File.OpenRead(ruta_archivo_servicio_solicitado_detalle);
            var reader = new StreamReader(stream);

            if (new FileInfo(ruta_archivo_servicio_solicitado_detalle).Length != 0)
            {
                while (!reader.EndOfStream)
                {
                    var linea = reader.ReadLine();
                    string[] valores = linea.Split(';');

                    //detalle = new List<ServicioSolicitadoDetalle>();

                    if (int.Parse(valores[0]) == idServicio)
                    {

                        ServicioSolicitadoDetalle item = new ServicioSolicitadoDetalle();
                        item.idServicio = idServicio;
                        item.peso = Decimal.Parse(valores[1]);
                        item.iva21 = Decimal.Parse(valores[2]);
                        item.exento = Decimal.Parse(valores[3]);
                        item.gravado = Decimal.Parse(valores[4]);
                        item.total = Decimal.Parse(valores[5]);
                        item.unidad = valores[6];

                        //MessageBox.Show(item.peso.ToString());

                        detalle.Add(item);
                        //   MessageBox.Show(linea);
                    }
                }
            }

            //    MessageBox.Show(detalle.Count.ToString());

            stream.Close();
        }

        private string obtenerLineaDatos()
        {
            string linea = "";

            linea = idServicio + ";"
                    + peso + ";"
                    + iva21 + ";"
                    + exento + ";"
                    + gravado + ";"
                    + total + ";"
                    + unidad;                    
            return linea;
        }

        public void guardarDatos()
        {       
            if (!File.Exists(ruta_archivo_servicio_solicitado_detalle))
            {
                MessageBox.Show("Falta el Archivo de ServicioSolicitadoDetalle, por favor genere el archivo y lanze la aplicación nuevamnete");
                Application.Exit();
            }

            var stream = File.OpenRead(ruta_archivo_servicio_solicitado_detalle);
            var reader = new StreamReader(stream);

            List<string> lineas = new List<string>();


            if (new FileInfo(ruta_archivo_servicio_solicitado_detalle).Length != 0)
            {
                while (!reader.EndOfStream)
                {
                    var linea = reader.ReadLine();
                    lineas.Add(linea);
                }
            }

            stream.Close();


            using (StreamWriter writer = new StreamWriter(ruta_archivo_servicio_solicitado_detalle))
            {
                foreach (string linea in lineas)
                {
                    writer.WriteLine(linea);
                }
                writer.WriteLine(obtenerLineaDatos());
                writer.Close();
            }

        }


    }
}
