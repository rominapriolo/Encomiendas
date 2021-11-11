using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Encomiendas
{
    class Usuario
    {
        public string usuario { get; set; }
        public string contrasena { get; set; }
        public string razonSocial { get; set; }
        public string cuit { get; set; }
        public int empleado_si_no { get; set; }

        private string ruta_archivo_usuarios = "../../datos/usuarios.txt";

        public bool verificarUsuario()
        {
            bool existe = false;
            var stream = File.OpenRead(ruta_archivo_usuarios);
            var reader = new StreamReader(stream);

            while (!reader.EndOfStream)
            {


                var linea = reader.ReadLine();

                string[] valores = linea.Split(';');

                if (valores[0].Equals(usuario) && valores[1].Equals(contrasena))
                {

                    string cliente = valores[4];

                    if (cliente.Equals("1"))
                    {
                        VariablesGlobales.var_cuit_cliente_corporativo = valores[3];
                    }

                    existe = true;
                    break;
                }

            }

            stream.Close();

            return existe;
        }

    }
}
