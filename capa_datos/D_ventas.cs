using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace capa_datos
{
   public class D_ventas
    {
        /// DECLARO LAS VARIABLES ENCAPSULADAS

        private int _id_venta;
        private int _id_cliente;
        private int _id_trabajador;
        private DateTime _fecha;
        private string _tipo_comprobante;
        private string _serie;
        private string _correlativo;
        private decimal _igv;


        // METODOS GETTERS Y SETTERS DE LOS CAMPOS
        public int Id_venta
        {
            get
            {
                return _id_venta;
            }

            set
            {
                _id_venta = value;
            }
        }

        public int Id_cliente
        {
            get
            {
                return _id_cliente;
            }

            set
            {
                _id_cliente = value;
            }
        }

        public int Id_trabajador
        {
            get
            {
                return _id_trabajador;
            }

            set
            {
                _id_trabajador = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return _fecha;
            }

            set
            {
                _fecha = value;
            }
        }

        public string Tipo_comprobante
        {
            get
            {
                return _tipo_comprobante;
            }

            set
            {
                _tipo_comprobante = value;
            }
        }

        public string Serie
        {
            get
            {
                return _serie;
            }

            set
            {
                _serie = value;
            }
        }

        public string Correlativo
        {
            get
            {
                return _correlativo;
            }

            set
            {
                _correlativo = value;
            }
        }

        public decimal Igv
        {
            get
            {
                return _igv;
            }

            set
            {
                _igv = value;
            }
        }


        // CONSTRUCTORES
        public D_ventas() { }

        public D_ventas(int id_venta, int id_cliente,int id_trabajador,DateTime fecha,string tipo_comprobante,string serie,string correlativo,decimal igv)
        {
            this.Id_venta = id_venta;
            this.Id_cliente = id_cliente;
            this.Id_trabajador = id_trabajador;
            this.Fecha = fecha;
            this.Tipo_comprobante = tipo_comprobante;
            this.Serie = serie;
            this.Correlativo = correlativo;
            this.Igv = igv;
            
        }




        // METODOS PROPIOS


        public string Insertar(D_ventas ventas)
        {

            string rspt = "";
            MySqlConnection conexion = new MySqlConnection();

            try
            {

                /// creo conexion
                conexion.ConnectionString = Conexion.Cn;
                conexion.Open();

                /// configuro parametros
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "SP_INSERTAR_VENTA";
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter parametro_id_cliente = new MySqlParameter();
                parametro_id_cliente.ParameterName = "ID_CLIENTE";
                parametro_id_cliente.MySqlDbType = MySqlDbType.Int32;
                parametro_id_cliente.Value = ventas.Id_cliente;

                MySqlParameter parametro_id_trabajador = new MySqlParameter();
                parametro_id_trabajador.ParameterName = "ID_TRABAJADOR";
                parametro_id_trabajador.MySqlDbType = MySqlDbType.Int32;
                parametro_id_trabajador.Value = ventas.Id_trabajador;


                MySqlParameter parametro_fecha = new MySqlParameter();
                parametro_fecha.ParameterName = "FECHA";
                parametro_fecha.MySqlDbType = MySqlDbType.DateTime;
                parametro_fecha.Value = ventas.Fecha;

                MySqlParameter parametro_tipo_comprobante = new MySqlParameter();
                parametro_tipo_comprobante.ParameterName = "TIPO_COMPROBANTE";
                parametro_tipo_comprobante.MySqlDbType = MySqlDbType.VarChar;
                parametro_tipo_comprobante.Size =20;
                parametro_tipo_comprobante.Value = ventas.Tipo_comprobante;

                MySqlParameter parametro_serie = new MySqlParameter();
                parametro_serie.ParameterName = "SERIE";
                parametro_serie.MySqlDbType = MySqlDbType.VarChar;
                parametro_serie.Size = 4;
                parametro_serie.Value = ventas.Serie;

                MySqlParameter parametro_correlativo = new MySqlParameter();
                parametro_correlativo.ParameterName = "CORRELATIVO";
                parametro_correlativo.MySqlDbType = MySqlDbType.VarChar;
                parametro_correlativo.Size = 7;
                parametro_correlativo.Value = ventas.Correlativo;


                MySqlParameter parametro_igv = new MySqlParameter();
                parametro_igv.ParameterName = "IGV";
                parametro_igv.MySqlDbType = MySqlDbType.Decimal;
                parametro_igv.Precision = 4;
                parametro_igv.Scale = 2;
                parametro_igv.Value = ventas.Igv;




                cmd.Parameters.Add(parametro_id_cliente);
                cmd.Parameters.Add(parametro_id_trabajador);
                cmd.Parameters.Add(parametro_fecha);
                cmd.Parameters.Add(parametro_tipo_comprobante);
                cmd.Parameters.Add(parametro_serie);
                cmd.Parameters.Add(parametro_correlativo);
                cmd.Parameters.Add(parametro_igv);


                // ejecutamos
                if (cmd.ExecuteNonQuery() == 1)
                {
                    rspt = "Ok";
                }
                else
                {
                    rspt = "NO SE HA PODIDO INSERTAR";
                }



            }
            catch (Exception ex)
            {
                rspt = ex.Message;
            }
            finally
            {

                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return rspt;

        }



        public string Editar(D_ventas ventas)
        {

            string rspt = "";
            MySqlConnection conexion = new MySqlConnection();

            try
            {

                /// creo conexion
                conexion.ConnectionString = Conexion.Cn;
                conexion.Open();

                /// configuro parametros
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "SP_UPDATE_VENTAS";
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter parametro_id_venta = new MySqlParameter();
                parametro_id_venta.ParameterName = "_ID_VENTA";
                parametro_id_venta.MySqlDbType = MySqlDbType.Int32;
                parametro_id_venta.Value = ventas.Id_venta;


                MySqlParameter parametro_id_cliente = new MySqlParameter();
                parametro_id_cliente.ParameterName = "_ID_CLIENTE";
                parametro_id_cliente.MySqlDbType = MySqlDbType.Int32;
                parametro_id_cliente.Value = ventas.Id_cliente;

                MySqlParameter parametro_id_trabajador = new MySqlParameter();
                parametro_id_trabajador.ParameterName = "_ID_TRABAJADOR";
                parametro_id_trabajador.MySqlDbType = MySqlDbType.Int32;
                parametro_id_trabajador.Value = ventas.Id_trabajador;


                MySqlParameter parametro_fecha = new MySqlParameter();
                parametro_fecha.ParameterName = "_FECHA";
                parametro_fecha.MySqlDbType = MySqlDbType.DateTime;
                parametro_fecha.Value = ventas.Fecha;

                MySqlParameter parametro_tipo_comprobante = new MySqlParameter();
                parametro_tipo_comprobante.ParameterName = "_TIPO_COMPROBANTE";
                parametro_tipo_comprobante.MySqlDbType = MySqlDbType.VarChar;
                parametro_tipo_comprobante.Size = 20;
                parametro_tipo_comprobante.Value = ventas.Tipo_comprobante;

                MySqlParameter parametro_serie = new MySqlParameter();
                parametro_serie.ParameterName = "_SERIE";
                parametro_serie.MySqlDbType = MySqlDbType.VarChar;
                parametro_serie.Size = 4;
                parametro_serie.Value = ventas.Serie;

                MySqlParameter parametro_correlativo = new MySqlParameter();
                parametro_correlativo.ParameterName = "_CORRELATIVO";
                parametro_correlativo.MySqlDbType = MySqlDbType.VarChar;
                parametro_correlativo.Size = 7;
                parametro_correlativo.Value = ventas.Correlativo;


                MySqlParameter parametro_igv = new MySqlParameter();
                parametro_igv.ParameterName = "_IGV";
                parametro_igv.MySqlDbType = MySqlDbType.Decimal;
                parametro_igv.Precision = 4;
                parametro_igv.Scale = 2;
                parametro_igv.Value = ventas.Igv;




                cmd.Parameters.Add(parametro_id_venta);
                cmd.Parameters.Add(parametro_id_cliente);
                cmd.Parameters.Add(parametro_id_trabajador);
                cmd.Parameters.Add(parametro_fecha);
                cmd.Parameters.Add(parametro_tipo_comprobante);
                cmd.Parameters.Add(parametro_serie);
                cmd.Parameters.Add(parametro_correlativo);
                cmd.Parameters.Add(parametro_igv);


                // ejecutamos
                if (cmd.ExecuteNonQuery() == 1)
                {
                    rspt = "Ok";
                }
                else
                {
                    rspt = "NO SE HA PODIDO EDITAR";
                }



            }
            catch (Exception ex)
            {
                rspt = ex.Message;
            }
            finally
            {

                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return rspt;

        }



        public string Eliminar(D_ventas ventas)
        {

            string rspt = "";
            MySqlConnection conexion = new MySqlConnection();

            try
            {

                /// creo conexion
                conexion.ConnectionString = Conexion.Cn;
                conexion.Open();

                /// configuro parametros
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "SP_ELIMINAR_VENTA";
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter parametro_id_venta = new MySqlParameter();
                parametro_id_venta.ParameterName = "_ID_VENTA";
                parametro_id_venta.MySqlDbType = MySqlDbType.Int32;
                parametro_id_venta.Value = ventas.Id_venta;

                cmd.Parameters.Add(parametro_id_venta);



                // ejecutamos
                if (cmd.ExecuteNonQuery() == 1)
                {
                    rspt = "Ok";
                }
                else
                {
                    rspt = "NO SE HA PODIDO ELIMINAR";
                }



            }
            catch (Exception ex)
            {
                rspt = ex.Message;
            }
            finally
            {

                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return rspt;

        }



        public DataTable Mostrar()
        {

            DataTable data_respuesta = new DataTable("venta");
            MySqlConnection conexion = new MySqlConnection();

            try
            {

                /// creo conexion
                conexion.ConnectionString = Conexion.Cn;
                conexion.Open();

                /// configuro parametros
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "SP_MOSTRAR_VENTA";
                cmd.CommandType = CommandType.StoredProcedure;


                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(data_respuesta);



            }
            catch (Exception ex)
            {
                data_respuesta = null;
            }
            finally
            {

                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return data_respuesta;


        }

        public DataTable Buscar_nombre(string texto_buscar)
        {

            DataTable data_respuesta = new DataTable("categoria");
            MySqlConnection conexion = new MySqlConnection();

            try
            {

                /// creo conexion
                conexion.ConnectionString = Conexion.Cn;
                conexion.Open();

                /// configuro parametros
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "SP_BUSCAR_CATEGORIA";
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter parametro_buscar = new MySqlParameter();
                parametro_buscar.ParameterName = "BUSCAR";
                parametro_buscar.MySqlDbType = MySqlDbType.VarChar;
                parametro_buscar.Size = 50;
                parametro_buscar.Value = texto_buscar;




                cmd.Parameters.Add(parametro_buscar);


                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(data_respuesta);



            }
            catch (Exception ex)
            {
                data_respuesta = null;
            }
            finally
            {

                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return data_respuesta;

        }






    }
}
