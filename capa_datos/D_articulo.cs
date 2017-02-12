using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;



namespace capa_datos
{
    public class D_articulo
    {

        // variables encapsuladas
        private int _id_articulo;
        private string _codigo;
        private string _nombre;
        private string _descripcion;
        private byte [] _imagen;
        private int _id_categoria;
        private int _id_presentacion;
        private string seccion;
        private string _texto_buscar;



        // Metodos getters y setters
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

        public string Codigo
        {
            get
            {
                return _codigo;
            }

            set
            {
                _codigo = value;
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

        public byte[] Imagen
        {
            get
            {
                return _imagen;
            }

            set
            {
                _imagen = value;
            }
        }

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

        public int Id_presentacion
        {
            get
            {
                return _id_presentacion;
            }

            set
            {
                _id_presentacion = value;
            }
        }

        public string Texto_buscar
        {
            get
            {
                return _texto_buscar;
            }

            set
            {
                _texto_buscar = value;
            }
        }

        public string Seccion
        {
            get
            {
                return seccion;
            }

            set
            {
                seccion = value;
            }
        }


        // constructores
        public D_articulo() {

        }

        public D_articulo(int id_articulo,string codigo,string nombre,string descripcion,byte [] imagen,string seccion,int id_categoria,int id_presentacion) {
            this.Id_articulo = id_articulo;
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Imagen = imagen;
            this.Seccion = seccion;
            this.Id_categoria = id_categoria;
            this.Id_presentacion = id_presentacion;
        }

        public D_articulo(int id_articulo, string codigo, string nombre, string descripcion, byte[] imagen, string seccion,  int id_categoria, int id_presentacion,string texto_buscar)
        {
            this.Id_articulo = id_articulo;
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Imagen = imagen;
            this.Seccion = seccion;
            this.Id_categoria = id_categoria;
            this.Id_presentacion = id_presentacion;
            this.Texto_buscar = texto_buscar;
        }



        // METODOS
        public string Insertar(D_articulo articulo)
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
                cmd.CommandText = "SP_INSERTAR_ARTICULO";
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter parametro_codigo = new MySqlParameter();
                parametro_codigo.ParameterName = "CODIGO";
                parametro_codigo.MySqlDbType = MySqlDbType.VarChar;
                parametro_codigo.Size = 50;
                parametro_codigo.Value = articulo.Codigo;


                MySqlParameter parametro_nombre = new MySqlParameter();
                parametro_nombre.ParameterName = "NOMBRE";
                parametro_nombre.MySqlDbType = MySqlDbType.VarChar;
                parametro_nombre.Size = 100;
                parametro_nombre.Value = articulo.Nombre;



                MySqlParameter parametro_descripcion = new MySqlParameter();
                parametro_descripcion.ParameterName = "DESCRIPCION";
                parametro_descripcion.MySqlDbType = MySqlDbType.Text;
                parametro_descripcion.Value = articulo.Descripcion;


                MySqlParameter parametro_imagen= new MySqlParameter();
                parametro_imagen.ParameterName = "IMAGEN";
                parametro_imagen.MySqlDbType = MySqlDbType.LongBlob;
                parametro_imagen.Value = articulo.Imagen;

                MySqlParameter parametro_seccion = new MySqlParameter();
                parametro_seccion.ParameterName = "SECCION";
                parametro_seccion.MySqlDbType = MySqlDbType.Text;
                parametro_seccion.Value = articulo.Seccion;



                MySqlParameter parametro_id_categoria = new MySqlParameter();
                parametro_id_categoria.ParameterName = "ID_CATEGORIA";
                parametro_id_categoria.MySqlDbType = MySqlDbType.Int32;
                parametro_id_categoria.Value = articulo.Id_categoria;

                MySqlParameter parametro_id_presentacion = new MySqlParameter();
                parametro_id_presentacion.ParameterName = "ID_PRESENTACION";
                parametro_id_presentacion.MySqlDbType = MySqlDbType.Int32;
                parametro_id_presentacion.Value = articulo.Id_presentacion;



                cmd.Parameters.Add(parametro_codigo);
                cmd.Parameters.Add(parametro_nombre);
                cmd.Parameters.Add(parametro_descripcion);
                cmd.Parameters.Add(parametro_imagen);
                cmd.Parameters.Add(parametro_seccion);
                cmd.Parameters.Add(parametro_id_categoria);
                cmd.Parameters.Add(parametro_id_presentacion);


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

        public string Editar(D_articulo articulo)
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
                cmd.CommandText = "SP_UPDATE_ARTICULO";
                cmd.CommandType = CommandType.StoredProcedure;


                MySqlParameter parametro_id_articulo = new MySqlParameter();
                parametro_id_articulo.ParameterName = "_ID_ARTICULO";
                parametro_id_articulo.MySqlDbType = MySqlDbType.Int32;
                parametro_id_articulo.Value = articulo.Id_articulo;


                MySqlParameter parametro_codigo = new MySqlParameter();
                parametro_codigo.ParameterName = "_CODIGO";
                parametro_codigo.MySqlDbType = MySqlDbType.VarChar;
                parametro_codigo.Size = 50;
                parametro_codigo.Value = articulo.Codigo;


                MySqlParameter parametro_nombre = new MySqlParameter();
                parametro_nombre.ParameterName = "_NOMBRE";
                parametro_nombre.MySqlDbType = MySqlDbType.VarChar;
                parametro_nombre.Size = 100;
                parametro_nombre.Value = articulo.Nombre;



                MySqlParameter parametro_descripcion = new MySqlParameter();
                parametro_descripcion.ParameterName = "_DESCRIPCION";
                parametro_descripcion.MySqlDbType = MySqlDbType.Text;
                parametro_descripcion.Value = articulo.Descripcion;


                MySqlParameter parametro_imagen = new MySqlParameter();
                parametro_imagen.ParameterName = "_IMAGEN";
                parametro_imagen.MySqlDbType = MySqlDbType.LongBlob;
                parametro_imagen.Value = articulo.Imagen;

                MySqlParameter parametro_seccion = new MySqlParameter();
                parametro_seccion.ParameterName = "_SECCION";
                parametro_seccion.MySqlDbType = MySqlDbType.Text;
                parametro_seccion.Value = articulo.Seccion;



                MySqlParameter parametro_id_categoria = new MySqlParameter();
                parametro_id_categoria.ParameterName = "_ID_CATEGORIA";
                parametro_id_categoria.MySqlDbType = MySqlDbType.Int32;
                parametro_id_categoria.Value = articulo.Id_categoria;

                MySqlParameter parametro_id_presentacion = new MySqlParameter();
                parametro_id_presentacion.ParameterName = "_ID_PRESENTACION";
                parametro_id_presentacion.MySqlDbType = MySqlDbType.Int32;
                parametro_id_presentacion.Value = articulo.Id_presentacion;



                cmd.Parameters.Add(parametro_id_articulo);
                cmd.Parameters.Add(parametro_codigo);
                cmd.Parameters.Add(parametro_nombre);
                cmd.Parameters.Add(parametro_descripcion);
                cmd.Parameters.Add(parametro_imagen);
                cmd.Parameters.Add(parametro_seccion);
                cmd.Parameters.Add(parametro_id_categoria);
                cmd.Parameters.Add(parametro_id_presentacion);




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

        public string Eliminar(D_articulo articulo)
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
                cmd.CommandText = "SP_ELIMINAR_ARTICULO";
                cmd.CommandType = CommandType.StoredProcedure;


                MySqlParameter parametro_id = new MySqlParameter();
                parametro_id.ParameterName = "_ID_ARTICULO";
                parametro_id.MySqlDbType = MySqlDbType.Int32;
                parametro_id.Value = articulo.Id_articulo;




                cmd.Parameters.Add(parametro_id);


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

        public DataTable Mostrar()
        {

            DataTable data_respuesta = new DataTable("articulo");
            MySqlConnection conexion = new MySqlConnection();

            try
            {

                /// creo conexion
                conexion.ConnectionString = Conexion.Cn;
                conexion.Open();

                /// configuro parametros
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "SP_MOSTRAR_ARTICULO";
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

        public DataTable Buscar_nombre(D_articulo articulo)
        {

            DataTable data_respuesta = new DataTable("articulo");
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
                parametro_buscar.Value = articulo.Texto_buscar;




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
