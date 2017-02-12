using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;


namespace capa_datos
{
    public class D_categoria
    {

        // ENCAPSULO LAS VARIABLES

        private int _id_categoria;
        private string _nombre;
        private string _descripcion;
        

        //METODOS GETTERS Y SETTERS
        public int Id_categoria
        {
            get
            {
                return _id_categoria;
            }

            set
            {
                _id_categoria = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                _nombre = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return _descripcion;
            }

            set
            {
                _descripcion = value;
            }
        }

        
        
        
        // CONSTRUCTORES 
        public D_categoria() { }

        public D_categoria(int id_categoria,string nombre,string descripcion)
        {
            this.Id_categoria = id_categoria;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
        }


        // METODOS PROPIOS


        public string Insertar(D_categoria categoria)
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
                cmd.CommandText = "SP_INSERTAR_CATEGORIA";
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter parametro_nombre = new MySqlParameter();
                parametro_nombre.ParameterName = "NOMBRE";
                parametro_nombre.MySqlDbType = MySqlDbType.VarChar;
                parametro_nombre.Value =categoria.Nombre ;

                MySqlParameter parametro_descripcion = new MySqlParameter();
                parametro_descripcion.ParameterName = "DESCRIPCION";
                parametro_descripcion.MySqlDbType = MySqlDbType.VarChar;
                parametro_descripcion.Value = categoria.Descripcion;



                cmd.Parameters.Add(parametro_nombre);
                cmd.Parameters.Add(parametro_descripcion);

                
                
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



        public string Editar(D_categoria categoria)
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
                cmd.CommandText = "SP_UPDATE_CATEGORIA";
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter parametro_categoria = new MySqlParameter();
                parametro_categoria.ParameterName = "_ID_CATEGORIA";
                parametro_categoria.MySqlDbType = MySqlDbType.Int32;
                parametro_categoria.Value = categoria.Id_categoria;

                MySqlParameter parametro_nombre = new MySqlParameter();
                parametro_nombre.ParameterName = "_NOMBRE";
                parametro_nombre.MySqlDbType = MySqlDbType.VarChar;
                parametro_nombre.Value = categoria.Nombre;

                MySqlParameter parametro_descripcion = new MySqlParameter();
                parametro_descripcion.ParameterName = "_DESCRIPCION";
                parametro_descripcion.MySqlDbType = MySqlDbType.VarChar;
                parametro_descripcion.Value = categoria.Descripcion;



                cmd.Parameters.Add(parametro_categoria);
                cmd.Parameters.Add(parametro_nombre);
                cmd.Parameters.Add(parametro_descripcion);



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



        public string Eliminar(D_categoria categoria)
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
                cmd.CommandText = "SP_ELIMINAR_CATEGORIA";
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter parametro_categoria = new MySqlParameter();
                parametro_categoria.ParameterName = "_ID_CATEGORIA";
                parametro_categoria.MySqlDbType = MySqlDbType.Int32;
                parametro_categoria.Value = categoria.Id_categoria;
                
                cmd.Parameters.Add(parametro_categoria);
                


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
                cmd.CommandText = "SP_MOSTRAR_CATEGORIA";
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
