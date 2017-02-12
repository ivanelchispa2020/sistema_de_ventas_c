using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace capa_datos
{
   public class D_ingresos
    {
        // VARIABLES ENCAPSULADAS
        private int _id_ingreso;
        private int _id_trabajador;
        private int _id_proveedor;
        private DateTime _fecha;
        private string _tipo_comprobante;
        private string _serie;
        private string _correlativo;
        private decimal _igv;
        private string _estado;

        // METODOS GETTERS Y SETTERS
        public int Id_ingreso
        {
            get
            {
                return _id_ingreso;
            }

            set
            {
                _id_ingreso = value;
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

        public int Id_proveedor
        {
            get
            {
                return _id_proveedor;
            }

            set
            {
                _id_proveedor = value;
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

        public string Estado
        {
            get
            {
                return _estado;
            }

            set
            {
                _estado = value;
            }
        }
        

        // CONSTRUCTORES
        public D_ingresos() { }

        public D_ingresos(int id_ingreso,int id_trabajador,int id_proveedor,DateTime fecha,string tipo_comprobante,string serie,string correlativo,decimal igv,string estado)
        {
            this.Id_ingreso = id_ingreso;
            this.Id_trabajador = id_trabajador;
            this.Id_proveedor = id_proveedor;
            this.Fecha = fecha;
            this.Tipo_comprobante = tipo_comprobante;
            this.Serie = serie;
            this.Correlativo = correlativo;
            this.Igv = igv;
            this.Estado = estado;
        }



        ///METODOS PROPIOS
        //
        public string Insertar(D_ingresos ingreso)
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
                cmd.CommandText = "SP_INSERTAR_INGRESO";
                cmd.CommandType = CommandType.StoredProcedure;

               

                MySqlParameter parametro_id_trabajador = new MySqlParameter();
                parametro_id_trabajador.ParameterName = "ID_TRABAJADOR";
                parametro_id_trabajador.MySqlDbType = MySqlDbType.Int32;
                parametro_id_trabajador.Value = ingreso.Id_trabajador;

                MySqlParameter parametro_id_proveedor = new MySqlParameter();
                parametro_id_proveedor.ParameterName = "ID_PROVEEDOR";
                parametro_id_proveedor.MySqlDbType = MySqlDbType.Int32;
                parametro_id_proveedor.Value = ingreso.Id_proveedor;

                MySqlParameter parametro_fecha = new MySqlParameter();
                parametro_fecha.ParameterName = "FECHA";
                parametro_fecha.MySqlDbType = MySqlDbType.DateTime;
                parametro_fecha.Value = ingreso.Fecha;

                MySqlParameter parametro_tipo_comprobante = new MySqlParameter();
                parametro_tipo_comprobante.ParameterName = "TIPO_COMPROBANTE";
                parametro_tipo_comprobante.MySqlDbType = MySqlDbType.VarChar;
                parametro_tipo_comprobante.Size = 20;
                parametro_tipo_comprobante.Value = ingreso.Tipo_comprobante;

                MySqlParameter parametro_serie = new MySqlParameter();
                parametro_serie.ParameterName = "SERIE";
                parametro_serie.MySqlDbType = MySqlDbType.VarChar;
                parametro_serie.Size = 4;
                parametro_serie.Value = ingreso.Serie;

                MySqlParameter parametro_correlativo = new MySqlParameter();
                parametro_correlativo.ParameterName = "CORRELATIVO";
                parametro_correlativo.MySqlDbType = MySqlDbType.VarChar;
                parametro_correlativo.Size = 7;
                parametro_correlativo.Value = ingreso.Correlativo;

                MySqlParameter parametro_igv = new MySqlParameter();
                parametro_igv.ParameterName = "IGV";
                parametro_igv.MySqlDbType = MySqlDbType.Decimal;
                parametro_igv.Precision = 4;
                parametro_igv.Scale = 2;
                parametro_igv.Value = ingreso.Igv;


                MySqlParameter parametro_estado = new MySqlParameter();
                parametro_estado.ParameterName = "ESTADO";
                parametro_estado.MySqlDbType = MySqlDbType.VarChar;
                parametro_estado.Size = 7;
                parametro_estado.Value = ingreso.Estado;



                cmd.Parameters.Add(parametro_id_trabajador);
                cmd.Parameters.Add(parametro_id_proveedor);
                cmd.Parameters.Add(parametro_fecha);
                cmd.Parameters.Add(parametro_tipo_comprobante);
                cmd.Parameters.Add(parametro_serie);
                cmd.Parameters.Add(parametro_correlativo);
                cmd.Parameters.Add(parametro_igv);
                cmd.Parameters.Add(parametro_estado);


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


        public string Editar(D_ingresos ingreso)
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
                cmd.CommandText = "SP_UPDATE_INGRESO";
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter parametro_id_ingreso = new MySqlParameter();
                parametro_id_ingreso.ParameterName = "_ID_INGRESO";
                parametro_id_ingreso.MySqlDbType = MySqlDbType.Int32;
                parametro_id_ingreso.Value = ingreso.Id_ingreso;

                MySqlParameter parametro_id_trabajador = new MySqlParameter();
                parametro_id_trabajador.ParameterName = "_ID_TRABAJADOR";
                parametro_id_trabajador.MySqlDbType = MySqlDbType.Int32;
                parametro_id_trabajador.Value = ingreso.Id_trabajador;

                MySqlParameter parametro_id_proveedor = new MySqlParameter();
                parametro_id_proveedor.ParameterName = "_ID_PROVEEDOR";
                parametro_id_proveedor.MySqlDbType = MySqlDbType.Int32;
                parametro_id_proveedor.Value = ingreso.Id_proveedor;

                MySqlParameter parametro_fecha = new MySqlParameter();
                parametro_fecha.ParameterName = "_FECHA";
                parametro_fecha.MySqlDbType = MySqlDbType.DateTime;
                parametro_fecha.Value = ingreso.Fecha;

                MySqlParameter parametro_tipo_comprobante = new MySqlParameter();
                parametro_tipo_comprobante.ParameterName = "_TIPO_COMPROBANTE";
                parametro_tipo_comprobante.MySqlDbType = MySqlDbType.VarChar;
                parametro_tipo_comprobante.Size = 20;
                parametro_tipo_comprobante.Value = ingreso.Tipo_comprobante;

                MySqlParameter parametro_serie = new MySqlParameter();
                parametro_serie.ParameterName = "_SERIE";
                parametro_serie.MySqlDbType = MySqlDbType.VarChar;
                parametro_serie.Size = 4;
                parametro_serie.Value = ingreso.Serie;

                MySqlParameter parametro_correlativo = new MySqlParameter();
                parametro_correlativo.ParameterName = "_CORRELATIVO";
                parametro_correlativo.MySqlDbType = MySqlDbType.VarChar;
                parametro_correlativo.Size = 7;
                parametro_correlativo.Value = ingreso.Correlativo;

                MySqlParameter parametro_igv = new MySqlParameter();
                parametro_igv.ParameterName = "_IGV";
                parametro_igv.MySqlDbType = MySqlDbType.Decimal;
                parametro_igv.Precision = 4;
                parametro_igv.Scale = 2;
                parametro_igv.Value = ingreso.Igv;


                MySqlParameter parametro_estado = new MySqlParameter();
                parametro_estado.ParameterName = "_ESTADO";
                parametro_estado.MySqlDbType = MySqlDbType.VarChar;
                parametro_estado.Size = 7;
                parametro_estado.Value = ingreso.Estado;


                cmd.Parameters.Add(parametro_id_ingreso);
                cmd.Parameters.Add(parametro_id_trabajador);
                cmd.Parameters.Add(parametro_id_proveedor);
                cmd.Parameters.Add(parametro_fecha);
                cmd.Parameters.Add(parametro_tipo_comprobante);
                cmd.Parameters.Add(parametro_serie);
                cmd.Parameters.Add(parametro_correlativo);
                cmd.Parameters.Add(parametro_igv);
                cmd.Parameters.Add(parametro_estado);


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


        public string Anular(D_ingresos ingreso)
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
                cmd.CommandText = "SP_ANULAR_INGRESO";
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter parametro_id_ingreso = new MySqlParameter();
                parametro_id_ingreso.ParameterName = "_ID_INGRESO";
                parametro_id_ingreso.MySqlDbType = MySqlDbType.Int32;
                parametro_id_ingreso.Value = ingreso.Id_ingreso;


                cmd.Parameters.Add(parametro_id_ingreso);


                // ejecutamos
                if (cmd.ExecuteNonQuery() == 1)
                {
                    rspt = "Ok";
                }
                else
                {
                    rspt = "NO SE HA PODIDO ANULAR";
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



        public DataTable Mostrar_ingreso()
        {

            DataTable data_respuesta = new DataTable("ingreso");
            MySqlConnection conexion = new MySqlConnection();

            try
            {

                /// creo conexion
                conexion.ConnectionString = Conexion.Cn;
                conexion.Open();

                /// configuro parametros
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "SP_MOSTRAR_INGRESO";
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






        public DataTable Buscar_ingreso_por_fecha(string fecha_1,string fecha_2)
        {

            DataTable data_respuesta = new DataTable("ingreso");
            MySqlConnection conexion = new MySqlConnection();

            try
            {

                /// creo conexion
                conexion.ConnectionString = Conexion.Cn;
                conexion.Open();

                /// configuro parametros
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "SP_BUSCAR_INGRESO_FECHA";
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter parametro_fecha_1 = new MySqlParameter();
                parametro_fecha_1.ParameterName = "FECHA_1";
                parametro_fecha_1.MySqlDbType = MySqlDbType.VarChar;
                parametro_fecha_1.Size = 20;
                parametro_fecha_1.Value = fecha_1;

                MySqlParameter parametro_fecha_2 = new MySqlParameter();
                parametro_fecha_2.ParameterName = "FECHA_2";
                parametro_fecha_2.MySqlDbType = MySqlDbType.VarChar;
                parametro_fecha_2.Size = 20;
                parametro_fecha_2.Value = fecha_2;



                cmd.Parameters.Add(parametro_fecha_1);
                cmd.Parameters.Add(parametro_fecha_2);

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
