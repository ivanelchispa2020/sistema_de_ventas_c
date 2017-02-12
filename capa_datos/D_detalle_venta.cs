using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;


namespace capa_datos
{
    public class D_detalle_venta
    {

        // DECLARO LAS VARIABLES ENCAPSULADAS
        private int _id_detalle_venta;
        private int _id_venta;
        private int _id_detalle_ingreso;
        private int _cantidad;
        private decimal _precio_venta;
        private decimal _descuento;


        // METODOS GETTERS Y SETTERS DE LOS CAMPOS
        public int Id_detalle_venta
        {
            get
            {
                return _id_detalle_venta;
            }

            set
            {
                _id_detalle_venta = value;
            }
        }

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

        public int Id_detalle_ingreso
        {
            get
            {
                return _id_detalle_ingreso;
            }

            set
            {
                _id_detalle_ingreso = value;
            }
        }

        public int Cantidad
        {
            get
            {
                return _cantidad;
            }

            set
            {
                _cantidad = value;
            }
        }

        public decimal Precio_venta
        {
            get
            {
                return _precio_venta;
            }

            set
            {
                _precio_venta = value;
            }
        }

        public decimal Descuento
        {
            get
            {
                return _descuento;
            }

            set
            {
                _descuento = value;
            }
        }

        // CONSTRUCTORES
        public D_detalle_venta() { }

        public D_detalle_venta(int id_detalle_venta,int id_venta,int id_detalle_ingreso,int cantidad,int precio_venta,int descuento)
        {
            this.Id_detalle_venta = Id_detalle_venta;
            this.Id_venta = id_venta;
            this.Id_detalle_ingreso = id_detalle_ingreso;
            this.Cantidad = cantidad;
            this.Precio_venta = precio_venta;
            this.Descuento = descuento;

        }



        /// METODOS PROPIOS

        public string Insertar(D_detalle_venta d_venta)
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
                cmd.CommandText = "SP_INSERTAR_DETALLE_VENTA";
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter parametro_id_venta = new MySqlParameter();
                parametro_id_venta.ParameterName = "ID_VENTA";
                parametro_id_venta.MySqlDbType = MySqlDbType.Int32;
                parametro_id_venta.Value = d_venta.Id_venta;

                MySqlParameter parametro_id_detalle_ingreso = new MySqlParameter();
                parametro_id_detalle_ingreso.ParameterName = "ID_DETALLE_INGRESO";
                parametro_id_detalle_ingreso.MySqlDbType = MySqlDbType.Int32;
                parametro_id_detalle_ingreso.Value = d_venta.Id_detalle_ingreso;

                MySqlParameter parametro_cantidad = new MySqlParameter();
                parametro_cantidad.ParameterName = "CANTIDAD";
                parametro_cantidad.MySqlDbType = MySqlDbType.Int32;
                parametro_cantidad.Value = d_venta.Cantidad;

                MySqlParameter parametro_precio_venta = new MySqlParameter();
                parametro_precio_venta.ParameterName = "PRECIO_VENTA";
                parametro_precio_venta.MySqlDbType = MySqlDbType.Decimal;
                parametro_precio_venta.Precision = 6;
                parametro_precio_venta.Scale = 2;
                parametro_precio_venta.Value = d_venta.Precio_venta;

                MySqlParameter parametro_descuento = new MySqlParameter();
                parametro_descuento.ParameterName = "DESCUENTO";
                parametro_descuento.MySqlDbType = MySqlDbType.Decimal;
                parametro_descuento.Precision = 4;
                parametro_descuento.Scale = 2;
                parametro_descuento.Value = d_venta.Descuento;
                

                cmd.Parameters.Add(parametro_id_venta);
                cmd.Parameters.Add(parametro_id_detalle_ingreso);
                cmd.Parameters.Add(parametro_cantidad);
                cmd.Parameters.Add(parametro_precio_venta);
                cmd.Parameters.Add(parametro_descuento);
                

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



        public string Editar(D_detalle_venta d_venta)
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
                cmd.CommandText = "SP_UPDATE_DETALLE_VENTA";
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter parametro_id_detalle_venta = new MySqlParameter();
                parametro_id_detalle_venta.ParameterName = "_ID_DETALLE_VENTA";
                parametro_id_detalle_venta.MySqlDbType = MySqlDbType.Int32;
                parametro_id_detalle_venta.Value = d_venta.Id_detalle_venta;


                MySqlParameter parametro_id_venta = new MySqlParameter();
                parametro_id_venta.ParameterName = "_ID_VENTA";
                parametro_id_venta.MySqlDbType = MySqlDbType.Int32;
                parametro_id_venta.Value = d_venta.Id_venta;

                MySqlParameter parametro_id_detalle_ingreso = new MySqlParameter();
                parametro_id_detalle_ingreso.ParameterName = "_ID_DETALLE_INGRESO";
                parametro_id_detalle_ingreso.MySqlDbType = MySqlDbType.Int32;
                parametro_id_detalle_ingreso.Value = d_venta.Id_detalle_ingreso;

                MySqlParameter parametro_cantidad = new MySqlParameter();
                parametro_cantidad.ParameterName = "_CANTIDAD";
                parametro_cantidad.MySqlDbType = MySqlDbType.Int32;
                parametro_cantidad.Value = d_venta.Cantidad;

                MySqlParameter parametro_precio_venta = new MySqlParameter();
                parametro_precio_venta.ParameterName = "_PRECIO_VENTA";
                parametro_precio_venta.MySqlDbType = MySqlDbType.Decimal;
                parametro_precio_venta.Precision = 6;
                parametro_precio_venta.Scale = 2;
                parametro_precio_venta.Value = d_venta.Precio_venta;

                MySqlParameter parametro_descuento = new MySqlParameter();
                parametro_descuento.ParameterName = "_DESCUENTO";
                parametro_descuento.MySqlDbType = MySqlDbType.Decimal;
                parametro_descuento.Precision = 4;
                parametro_descuento.Scale = 2;
                parametro_descuento.Value = d_venta.Descuento;


                cmd.Parameters.Add(parametro_id_venta);
                cmd.Parameters.Add(parametro_id_detalle_ingreso);
                cmd.Parameters.Add(parametro_cantidad);
                cmd.Parameters.Add(parametro_precio_venta);
                cmd.Parameters.Add(parametro_descuento);



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



        public string Eliminar(D_detalle_venta d_detalle)
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
                cmd.CommandText = "SP_ELIMINAR_DETALLE_VENTA";
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter parametro_id_detalle_venta = new MySqlParameter();
                parametro_id_detalle_venta.ParameterName = "_ID_DETALLE_VENTA";
                parametro_id_detalle_venta.MySqlDbType = MySqlDbType.Int32;
                parametro_id_detalle_venta.Value = d_detalle.Id_detalle_venta;

                cmd.Parameters.Add(parametro_id_detalle_venta);

                

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

            DataTable data_respuesta = new DataTable("detalle_ingreso");
            MySqlConnection conexion = new MySqlConnection();

            try
            {

                /// creo conexion
                conexion.ConnectionString = Conexion.Cn;
                conexion.Open();

                /// configuro parametros
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "SP_MOSTRAR_DETALLE_INGRESO";
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
        








    }
}
