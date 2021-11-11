using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Encomiendas
{
    class ServicioSolicitado
    {
        public int idServicio { get; set; }
        public int idCliente { get; set; }
        public string razonSocialReceptor { get; set; }
        public string celularReceptor { get; set; }
        public string correoElectronicoReceptor { get; set; }
        public string direccionDestino { get; set; }
        public string retiroPorSucursal { get; set; }
        public int idSucursalDeDestino { get; set; }
        public string provincia { get; set; }
        public string localidad { get; set; }
        public string codigoPostal { get; set; }
        public string region { get; set; }
        public DateTime fechaDeLaSolicitud { get; set; }
        public string tipoEnvio { get; set; }
        public string urgencia { get; set; }
        public string estadoServicio { get; set; }
        public decimal gravado { get; set; }
        public decimal exento { get; set; }
        public decimal iva21 { get; set; }
        public decimal total { get; set; }
        public string retiroEnPuerta { get; set; }
        public string internacional { get; set; }
        public string direccionInternacional { get; set; }
        public string regionInternacional { get; set; }
        public List<ServicioSolicitadoDetalle> detalle { get; set; }
        public List<ServicioSolicitado> serviciosCumplidos { get; set; }
        public List<ServicioSolicitado> serviciosPendientes { get; set; }



        string ruta_archivo_servicio_solicitado = @"../../datos/ServicioSolicitado.txt";
        string ruta_archivo_servicio_solicitado_detalle = @"../../datos/ServicioSolicitadoDetalle.txt";
        string ruta_archivo_servicios_a_facturar = @"../../datos/ServicioAFacturar.txt";
        //realizarSolicitudServicio()
        //actualizarEstadoServicio()
        //verEstadoServicio()
        //validacionDatos()
        //guardarDatos()       
        //buscarServicio()       
        //listarServicios()       

        public void buscarDatosSolicitud()
        {


            var stream = File.OpenRead(ruta_archivo_servicio_solicitado);
            var reader = new StreamReader(stream);

            if (new FileInfo(ruta_archivo_servicio_solicitado).Length != 0)
            {
                while (!reader.EndOfStream)
                {
                    var linea = reader.ReadLine();
                    string[] valores = linea.Split(';');

                    if (int.Parse(valores[0]) == idServicio)
                    {

                        if (idCliente != 0)
                        {
                            if (idCliente != int.Parse(valores[1]))
                            {
                                stream.Close();
                                return;
                            }
                        }


                        idCliente = int.Parse(valores[1]);
                        razonSocialReceptor = valores[2];
                        celularReceptor = valores[3];
                        correoElectronicoReceptor = valores[4];
                        direccionDestino = valores[5];
                        retiroPorSucursal = valores[6];
                        idSucursalDeDestino = int.Parse(valores[7]);
                        provincia = valores[8];
                        localidad = valores[9];
                        codigoPostal = valores[10];
                        region = valores[11];
                        fechaDeLaSolicitud = DateTime.Parse(valores[12]);
                        tipoEnvio = valores[13];
                        urgencia = valores[14];
                        estadoServicio = valores[15];
                        gravado = Decimal.Parse(valores[16]);
                        exento = Decimal.Parse(valores[17]);
                        iva21 = Decimal.Parse(valores[18]);
                        total = Decimal.Parse(valores[19]);
                        retiroEnPuerta = valores[20];
                        internacional = valores[21];
                        direccionInternacional = valores[22];
                        regionInternacional = valores[23];
                    }
                }

                traerDetalleSolicitud();

            }

            stream.Close();

            //return resultado;
        }

        private void traerDetalleSolicitud()
        {
            ServicioSolicitadoDetalle servicioSolicitadoDetalle = new ServicioSolicitadoDetalle();
            servicioSolicitadoDetalle.idServicio = idServicio;
            servicioSolicitadoDetalle.detalle = new List<ServicioSolicitadoDetalle>();
            servicioSolicitadoDetalle.traerDetalleServicio();
            detalle = servicioSolicitadoDetalle.detalle;

            //    var stream = File.OpenRead(ruta_archivo_servicio_solicitado_detalle);
            //    var reader = new StreamReader(stream);



            //    if (new FileInfo(ruta_archivo_servicio_solicitado_detalle).Length != 0)
            //    {
            //        while (!reader.EndOfStream)
            //        {
            //            var linea = reader.ReadLine();
            //            string[] valores = linea.Split(';');

            //            //detalle = new List<ServicioSolicitadoDetalle>();

            //            if (int.Parse(valores[0]) == idServicio)
            //            {

            //                ServicioSolicitadoDetalle item = new ServicioSolicitadoDetalle();
            //                item.idServicio = idServicio;
            //                item.peso = Decimal.Parse(valores[1]);
            //                item.iva21 = Decimal.Parse(valores[2]);
            //                item.exento = Decimal.Parse(valores[3]);
            //                item.gravado = Decimal.Parse(valores[4]);
            //                item.total = Decimal.Parse(valores[5]);
            //                item.unidad = valores[6];

            //                //MessageBox.Show(item.peso.ToString());

            //                detalle.Add(item);
            //             //   MessageBox.Show(linea);
            //            }
            //        }
            //    }

            ////    MessageBox.Show(detalle.Count.ToString());

            //    stream.Close();

        }

        private string obtenerLineaDatos()
        {
            string linea = "";

            linea = idServicio + ";"
                    + idCliente + ";"
                    + razonSocialReceptor + ";"
                    + celularReceptor + ";"
                    + correoElectronicoReceptor + ";"
                    + direccionDestino + ";"
                    + retiroPorSucursal + ";"
                    + idSucursalDeDestino + ";"
                    + provincia + ";"
                    + localidad + ";"
                    + codigoPostal + ";"
                    + region + ";"
                    + fechaDeLaSolicitud + ";"
                    + tipoEnvio + ";"
                    + urgencia + ";"
                    + estadoServicio + ";"
                    + gravado + ";"
                    + exento + ";"
                    + iva21 + ";"
                    + total + ";"
                    + retiroEnPuerta + ";"
                    + internacional + ";"
                    + direccionInternacional + ";"
                    + regionInternacional;
            return linea;
        }

        private int pedirIdServicio()
        {
            int id_servicio = 0;

            var stream = File.OpenRead(ruta_archivo_servicio_solicitado);
            var reader = new StreamReader(stream);

            if (new FileInfo(ruta_archivo_servicio_solicitado).Length != 0)
            {
                while (!reader.EndOfStream)
                {
                    var linea = reader.ReadLine();
                    string[] valores = linea.Split(';');

                    if (int.Parse(valores[0]) > id_servicio)
                    {
                        id_servicio = int.Parse(valores[0]);
                    }
                }
            }

            stream.Close();

            return id_servicio + 1;
        }

        public void guardarDatos()
        {

            idServicio = pedirIdServicio();

            if (!File.Exists(ruta_archivo_servicio_solicitado))
            {
                MessageBox.Show("Falta el Archivo de ServicioSolicitado, por favor genere el archivo y lanze la aplicación nuevamnete");
                Application.Exit();
            }

            var stream = File.OpenRead(ruta_archivo_servicio_solicitado);
            var reader = new StreamReader(stream);

            List<string> lineas = new List<string>();


            if (new FileInfo(ruta_archivo_servicio_solicitado).Length != 0)
            {
                while (!reader.EndOfStream)
                {
                    var linea = reader.ReadLine();
                    lineas.Add(linea);
                }
            }

            stream.Close();


            using (StreamWriter writer = new StreamWriter(ruta_archivo_servicio_solicitado))
            {
                foreach (string linea in lineas)
                {
                    writer.WriteLine(linea);
                }
                writer.WriteLine(obtenerLineaDatos());
                writer.Close();
            }


            foreach (ServicioSolicitadoDetalle item in detalle)
            {
                item.idServicio = idServicio;
                item.guardarDatos();
            }

            ServicioAFacturar servicioAFacturar = new ServicioAFacturar();
            servicioAFacturar.idServicioAFacturar = idServicio;
            servicioAFacturar.guardarDatos();

        }

        public void listarServiciosCumplidos()
        {

            var stream = File.OpenRead(ruta_archivo_servicio_solicitado);
            var reader = new StreamReader(stream);

            if (new FileInfo(ruta_archivo_servicio_solicitado).Length != 0)
            {
                while (!reader.EndOfStream)
                {
                    var linea = reader.ReadLine();

                    string[] valores = linea.Split(';');

                    if (valores[1].Equals(idCliente.ToString()))
                    {
                        if (valores[15].Equals("Cerrada"))
                        {
                            ServicioSolicitado servicioSolicitado = new ServicioSolicitado();
                            servicioSolicitado.idServicio = int.Parse(valores[0]);
                            servicioSolicitado.idCliente = int.Parse(valores[1]);
                            servicioSolicitado.razonSocialReceptor = valores[2];
                            servicioSolicitado.celularReceptor = valores[3];
                            servicioSolicitado.correoElectronicoReceptor = valores[4];
                            servicioSolicitado.direccionDestino = valores[5];
                            servicioSolicitado.retiroPorSucursal = valores[6];
                            servicioSolicitado.idSucursalDeDestino = int.Parse(valores[7]);
                            servicioSolicitado.provincia = valores[8];
                            servicioSolicitado.localidad = valores[9];
                            servicioSolicitado.codigoPostal = valores[10];
                            servicioSolicitado.region = valores[11];
                            servicioSolicitado.fechaDeLaSolicitud = DateTime.Parse(valores[12]);
                            servicioSolicitado.tipoEnvio = valores[13];
                            servicioSolicitado.urgencia = valores[14];
                            servicioSolicitado.estadoServicio = valores[15];
                            servicioSolicitado.gravado = Decimal.Parse(valores[16]);
                            servicioSolicitado.exento = Decimal.Parse(valores[17]);
                            servicioSolicitado.iva21 = Decimal.Parse(valores[18]);
                            servicioSolicitado.total = Decimal.Parse(valores[19]);
                            servicioSolicitado.retiroEnPuerta = valores[20];
                            servicioSolicitado.internacional = valores[21];
                            servicioSolicitado.direccionInternacional = valores[22];
                            servicioSolicitado.regionInternacional = valores[23];
                            serviciosCumplidos.Add(servicioSolicitado);
                        }

                    }

                }
            }


            stream.Close();
        }

        public void listarServiciosPdtesDeFacturar()
        {

            var stream = File.OpenRead(ruta_archivo_servicio_solicitado);
            var reader = new StreamReader(stream);

            if (new FileInfo(ruta_archivo_servicio_solicitado).Length != 0)
            {
                while (!reader.EndOfStream)
                {
                    var linea = reader.ReadLine();

                    string[] valores = linea.Split(';');

                    if (valores[1].Equals(idCliente.ToString()))
                    {

                        ServicioSolicitado servicioSolicitado = new ServicioSolicitado();
                        servicioSolicitado.idServicio = int.Parse(valores[0]);

                        var stream_a_facturar = File.OpenRead(ruta_archivo_servicios_a_facturar);
                        var reader_a_facturar = new StreamReader(stream_a_facturar);


                        if (new FileInfo(ruta_archivo_servicios_a_facturar).Length != 0)
                        {
                            while (!reader_a_facturar.EndOfStream)
                            {
                                var linea_a_facturar = reader_a_facturar.ReadLine();

                                if (servicioSolicitado.idServicio.ToString().Equals(linea_a_facturar))
                                {
                                    servicioSolicitado.idCliente = int.Parse(valores[1]);
                                    servicioSolicitado.razonSocialReceptor = valores[2];
                                    servicioSolicitado.celularReceptor = valores[3];
                                    servicioSolicitado.correoElectronicoReceptor = valores[4];
                                    servicioSolicitado.direccionDestino = valores[5];
                                    servicioSolicitado.retiroPorSucursal = valores[6];
                                    servicioSolicitado.idSucursalDeDestino = int.Parse(valores[7]);
                                    servicioSolicitado.provincia = valores[8];
                                    servicioSolicitado.localidad = valores[9];
                                    servicioSolicitado.codigoPostal = valores[10];
                                    servicioSolicitado.region = valores[11];
                                    servicioSolicitado.fechaDeLaSolicitud = DateTime.Parse(valores[12]);
                                    servicioSolicitado.tipoEnvio = valores[13];
                                    servicioSolicitado.urgencia = valores[14];
                                    servicioSolicitado.estadoServicio = valores[15];
                                    servicioSolicitado.gravado = Decimal.Parse(valores[16]);
                                    servicioSolicitado.exento = Decimal.Parse(valores[17]);
                                    servicioSolicitado.iva21 = Decimal.Parse(valores[18]);
                                    servicioSolicitado.total = Decimal.Parse(valores[19]);
                                    servicioSolicitado.retiroEnPuerta = valores[20];
                                    servicioSolicitado.internacional = valores[21];
                                    servicioSolicitado.direccionInternacional = valores[22];
                                    servicioSolicitado.regionInternacional = valores[23];
                                    serviciosPendientes.Add(servicioSolicitado);
                                }
                            }
                        }

                        stream_a_facturar.Close();
                    }

                }
            }


            stream.Close();
        }
    }
}
   
