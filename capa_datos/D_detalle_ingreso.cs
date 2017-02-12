using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;


namespace capa_datos
{
    public class D_detalle_ingreso
    {

        // DECLARO LAS VARIABLES ENCAPSULADAS
        private int _id_detalle_ingreso;
        private int _id_ingreso;
        private int _id_articulo;
        private decimal _precio_compra;
        private decimal _precio_venta;
        private int _stock_inicial;
        private int _stock_actual;
        private DateTime _fecha_produccion;
        private DateTime _fecha_vencimiento;


        // METODOS GETTERS Y SETTER DE LOS CAMPOS
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

        public int Id_articulo
        {
            get
            {
                return _id_articulo;
            }

            set
            {
                _id_articulo = value;
            }
        }

        public decimal Precio_compra
        {
            get
            {
                return _precio_compra;
            }

            set
            {
                _precio_compra = value;
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

        public int Stock_inicial
        {
            get
            {
                return _stock_inicial;
            }

            set
            {
                _stock_inicial = value;
            }
        }

        public int Stock_actual
        {
            get
            {
                return _stock_actual;
            }

            set
            {
                _stock_actual = value;
            }
        }

        public DateTime Fecha_produccion
        {
            get
            {
                return _fecha_produccion;
            }

            set
            {
                _fecha_produccion = value;
            }
        }

        public DateTime Fecha_vencimiento
        {
            get
            {
                return _fecha_vencimiento;
            }

            set
            {
                _fecha_vencimiento = value;
            }
        }


        // CONSTRUCTORES
        public D_detalle_ingreso() { }

        public D_detalle_ingreso(int id_detalle_ingreso,int id_ingreso,int id_articulo,decimal precio_compra,decimal precio_venta,int stock_inicial,int stock_actual,DateTime fecha_produccion,DateTime fecha_vencimiento)
        {
            this.Id_detalle_ingreso = id_detalle_ingreso;
            this.Id_ingreso = id_ingreso;
            this.Id_articulo = id_articulo;
            this.Precio_compra = precio_compra;
            this.Precio_venta = precio_venta;
            this.Stock_inicial = stock_inicial;
            this.Stock_actual = _stock_actual;
            this.Fecha_produccion = fecha_produccion;
            this.Fecha_vencimiento = fecha_vencimiento;


        }



        //// METODOS
        public string Insertar(D_detalle_ingreso d_ingreso)
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
                cmd.CommandText = "SP_INSERTAR_DETALLE_INGRESO";
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter parametro_id_ingreso = new MySqlParameter();
                parametro_id_ingreso.ParameterName = "ID_INGRESO";
                parametro_id_ingreso.MySqlDbType = MySqlDbType.Int32;
                parametro_id_ingreso.Value = d_ingreso.Id_ingreso;

                MySqlParameter parametro_id_articulo = new MySqlParameter();
                parametro_id_articulo.ParameterName = "ID_ARTICULO";
                parametro_id_articulo.MySqlDbType = MySqlDbType.Int32;
                parametro_id_articulo.Value = d_ingreso.Id_articulo;


                MySqlParameter parametro_precio_compra = new MySqlParameter();
                parametro_precio_compra.ParameterName = "PRECIO_COMPRA";
                parametro_precio_compra.MySqlDbType = MySqlDbType.Decimal;
                parametro_precio_compra.Precision = 4;
                parametro_precio_compra.Scale = 2;
                parametro_precio_compra.Value = d_ingreso.Precio_compra;



                MySqlParameter parametro_precio_venta = new MySqlParameter();
                parametro_precio_compra.ParameterName = "PRECIO_VENTA";
                parametro_precio_compra.MySqlDbType = MySqlDbType.Decimal;
                parametro_precio_compra.Precision = 4;
                parametro_precio_compra.Scale = 2;
                parametro_precio_compra.Value = d_ingreso.Precio_venta;



                MySqlParameter parametro_stock_inicial = new MySqlParameter();
                parametro_stock_inicial.ParameterName = "STOCK_INICIAL";
                parametro_stock_inicial.MySqlDbType = MySqlDbType.Int32;
                parametro_stock_inicial.Value = d_ingreso.Stock_inicial;

                MySqlParameter parametro_stock_actual = new MySqlParameter();
                parametro_stock_actual.ParameterName = "STOCK_ACTUAL";
                parametro_stock_actual.MySqlDbType = MySqlDbType.Int32;
                parametro_stock_actual.Value = d_ingreso.Stock_actual;

                MySqlParameter parametro_fecha_produccion = new MySqlParameter();
                parametro_fecha_produccion.ParameterName = "FECHA_PRODUCCION";
                parametro_fecha_produccion.MySqlDbType = MySqlDbType.DateTime;
                parametro_fecha_produccion.Value = d_ingreso.Fecha_produccion;

                MySqlParameter parametro_fecha_vencimiento = new MySqlParameter();
                parametro_fecha_vencimiento.ParameterName = "FECHA_VENCIMIENTO";
                parametro_fecha_vencimiento.MySqlDbType = MySqlDbType.DateTime;
                parametro_fecha_vencimiento.Value = d_ingreso.Fecha_vencimiento;



                cmd.Parameters.Add(parametro_id_ingreso);
                cmd.Parameters.Add(parametro_id_articulo);
                cmd.Parameters.Add(parametro_precio_compra);
                cmd.Parameters.Add(parametro_precio_venta);
                cmd.Parameters.Add(parametro_stock_inicial);
                cmd.Parameters.Add(parametro_stock_actual);
                cmd.Parameters.Add(parametro_fecha_produccion);
                cmd.Parameters.Add(parametro_fecha_vencimiento);


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


        public string Editar(D_detalle_ingreso d_ingreso)
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
                cmd.CommandText = "SP_UPDATE_DETALLE_INGRESO";
                cmd.CommandType = CommandType.StoredProcedure;


                MySqlParameter parametro_id_detalle_ingreso = new MySqlParameter();
                parametro_id_detalle_ingreso.ParameterName = "_ID_DETALLE_INGRESO";
                parametro_id_detalle_ingreso.MySqlDbType = MySqlDbType.Int32;
                parametro_id_detalle_ingreso.Value = d_ingreso.Id_detalle_ingreso;


                MySqlParameter parametro_id_ingreso = new MySqlParameter();
                parametro_id_ingreso.ParameterName = "_ID_INGRESO";
                parametro_id_ingreso.MySqlDbType = MySqlDbType.Int32;
                parametro_id_ingreso.Value = d_ingreso.Id_ingreso;

                MySqlParameter parametro_id_articulo = new MySqlParameter();
                parametro_id_articulo.ParameterName = "_ID_ARTICULO";
                parametro_id_articulo.MySqlDbType = MySqlDbType.Int32;
                parametro_id_articulo.Value = d_ingreso.Id_articulo;


                MySqlParameter parametro_precio_compra = new MySqlParameter();
                parametro_precio_compra.ParameterName = "_PRECIO_COMPRA";
                parametro_precio_compra.MySqlDbType = MySqlDbType.Decimal;
                parametro_precio_compra.Precision = 4;
                parametro_precio_compra.Scale = 2;
                parametro_precio_compra.Value = d_ingreso.Precio_compra;



                MySqlParameter parametro_precio_venta = new MySqlParameter();
                parametro_precio_compra.ParameterName = "_PRECIO_VENTA";
                parametro_precio_compra.MySqlDbType = MySqlDbType.Decimal;
                parametro_precio_compra.Precision = 4;
                parametro_precio_compra.Scale = 2;
                parametro_precio_compra.Value = d_ingreso.Precio_venta;



                MySqlParameter parametro_stock_inicial = new MySqlParameter();
                parametro_stock_inicial.ParameterName = "_STOCK_INICIAL";
                parametro_stock_inicial.MySqlDbType = MySqlDbType.Int32;
                parametro_stock_inicial.Value = d_ingreso.Stock_inicial;

                MySqlParameter parametro_stock_actual = new MySqlParameter();
                parametro_stock_actual.ParameterName = "_STOCK_ACTUAL";
                parametro_stock_actual.MySqlDbType = MySqlDbType.Int32;
                parametro_stock_actual.Value = d_ingreso.Stock_actual;

                MySqlParameter parametro_fecha_produccion = new MySqlParameter();
                parametro_fecha_produccion.ParameterName = "_FECHA_PRODUCCION";
                parametro_fecha_produccion.MySqlDbType = MySqlDbType.DateTime;
                parametro_fecha_produccion.Value = d_ingreso.Fecha_produccion;

                MySqlParameter parametro_fecha_vencimiento = new MySqlParameter();
                parametro_fecha_vencimiento.ParameterName = "_FECHA_VENCIMIENTO";
                parametro_fecha_vencimiento.MySqlDbType = MySqlDbType.DateTime;
                parametro_fecha_vencimiento.Value = d_ingreso.Fecha_vencimiento;


                cmd.Parameters.Add(parametro_id_detalle_ingreso);
                cmd.Parameters.Add(parametro_id_ingreso);
                cmd.Parameters.Add(parametro_id_articulo);
                cmd.Parameters.Add(parametro_precio_compra);
                cmd.Parameters.Add(parametro_precio_venta);
                cmd.Parameters.Add(parametro_stock_inicial);
                cmd.Parameters.Add(parametro_stock_actual);
                cmd.Parameters.Add(parametro_fecha_produccion);
                cmd.Parameters.Add(parametro_fecha_vencimiento);


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





        public string Eliminar(D_detalle_ingreso d_ingreso)
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
                cmd.CommandText = "SP_UPDATE_DETALLE_INGRESO";
                cmd.CommandType = CommandType.StoredProcedure;


                MySqlParameter parametro_id_detalle_ingreso = new MySqlParameter();
                parametro_id_detalle_ingreso.ParameterName = "_ID_DETALLE_INGRESO";
                parametro_id_detalle_ingreso.MySqlDbType = MySqlDbType.Int32;
                parametro_id_detalle_ingreso.Value = d_ingreso.Id_detalle_ingreso;

                
                cmd.Parameters.Add(parametro_id_detalle_ingreso);
                

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





        public DataTable Mostrar_detalle_ingreso(D_detalle_ingreso d_ingreso)
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
