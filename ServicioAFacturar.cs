using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Encomiendas
{
    class ServicioAFacturar
    {
        string ruta_archivo_servicio_a_facturar = @"../../datos/ServicioAFacturar.txt";

        public int idServicioAFacturar { get; set; }

        public void guardarDatos()
        {
        
            if (!File.Exists(ruta_archivo_servicio_a_facturar))
            {
                MessageBox.Show("Falta el Archivo de ServicioSolicitado, por favor genere el archivo y lanze la aplicación nuevamnete");
                Application.Exit();
            }

            var stream = File.OpenRead(ruta_archivo_servicio_a_facturar);
            var reader = new StreamReader(stream);

            List<string> lineas = new List<string>();


            if (new FileInfo(ruta_archivo_servicio_a_facturar).Length != 0)
            {
                while (!reader.EndOfStream)
                {
                    var linea = reader.ReadLine();
                    lineas.Add(linea);
                }
            }

            stream.Close();


            using (StreamWriter writer = new StreamWriter(ruta_archivo_servicio_a_facturar))
            {
                foreach (string linea in lineas)
                {
                    writer.WriteLine(linea);
                }
                writer.WriteLine(idServicioAFacturar);
                writer.Close();
            }

        }

    }
}
