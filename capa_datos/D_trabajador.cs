using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace capa_datos
{
    public class D_trabajador
    {
        /// DECLARO LAS VARIABLES
        private int _id_trabajador;
        private string _nombre;
        private string _apellidos;
        private string _sexo;
        private DateTime _fecha_nacimiento;
        private string _num_documento;
        private string _direccion;
        private string _telefono;
        private string _email;
        private string _acceso;
        private string _usuario;
        private string _password;
        private string _texto_buscar;

        //METODO GETTERS Y SETTERS
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

        public string Apellidos
        {
            get
            {
                return _apellidos;
            }

            set
            {
                _apellidos = value;
            }
        }

        public string Sexo
        {
            get
            {
                return _sexo;
            }

            set
            {
                _sexo = value;
            }
        }

        public DateTime Fecha_nacimiento
        {
            get
            {
                return _fecha_nacimiento;
            }

            set
            {
                _fecha_nacimiento = value;
            }
        }

        public string Num_documento
        {
            get
            {
                return _num_documento;
            }

            set
            {
                _num_documento = value;
            }
        }

        public string Direccion
        {
            get
            {
                return _direccion;
            }

            set
            {
                _direccion = value;
            }
        }

        public string Telefono
        {
            get
            {
                return _telefono;
            }

            set
            {
                _telefono = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }

        public string Acceso
        {
            get
            {
                return _acceso;
            }

            set
            {
                _acceso = value;
            }
        }

        public string Usuario
        {
            get
            {
                return _usuario;
            }

            set
            {
                _usuario = value;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
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

        //CONSTRUCTORES
        public D_trabajador() { }

        public D_trabajador(int id_trabajador,string nombre,string apellidos,string sexo,DateTime fecha_nacimiento,string num_documento,string direccion,string telefono,string email,string acceso,string usuario,string password) {
            this.Id_trabajador = id_trabajador;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Sexo = sexo;
            this.Fecha_nacimiento = fecha_nacimiento;
            this.Num_documento = num_documento;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Email = email;
            this.Acceso = acceso;
            this.Usuario = usuario;
            this.Password = password;

        }


        public D_trabajador(int id_trabajador, string nombre, string apellidos, string sexo, DateTime fecha_nacimiento, string num_documento, string direccion, string telefono, string email, string acceso, string usuario, string password,string texto_buscar)
        {
            this.Id_trabajador = id_trabajador;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Sexo = sexo;
            this.Fecha_nacimiento = fecha_nacimiento;
            this.Num_documento = num_documento;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Email = email;
            this.Acceso = acceso;
            this.Usuario = usuario;
            this.Password = password;
            this.Texto_buscar = Texto_buscar;
        }


        //METODOS GETTERS Y SETTERS

        public string Insertar(D_trabajador trabajador)
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
                cmd.CommandText = "SP_INSERTAR_TRABAJADOR";
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter parametro_nombre = new MySqlParameter();
                parametro_nombre.ParameterName = "NOMBRE";
                parametro_nombre.MySqlDbType = MySqlDbType.VarChar;
                parametro_nombre.Size = 50;
                parametro_nombre.Value = trabajador.Nombre;

                MySqlParameter parametro_apellido = new MySqlParameter();
                parametro_apellido.ParameterName = "APELLIDOS";
                parametro_apellido.MySqlDbType = MySqlDbType.VarChar;
                parametro_apellido.Size = 50;
                parametro_apellido.Value = trabajador.Apellidos;

                MySqlParameter parametro_sexo = new MySqlParameter();
                parametro_sexo.ParameterName = "SEXO";
                parametro_sexo.MySqlDbType = MySqlDbType.VarChar;
                parametro_sexo.Size = 1;
                parametro_sexo.Value = trabajador.Sexo;


                MySqlParameter parametro_fecha_nacimiento = new MySqlParameter();
                parametro_fecha_nacimiento.ParameterName = "FECHA_NACIMIENTO";
                parametro_fecha_nacimiento.MySqlDbType = MySqlDbType.Datetime;
                parametro_fecha_nacimiento.Value = trabajador.Fecha_nacimiento;

                MySqlParameter parametro_num_documento = new MySqlParameter();
                parametro_num_documento.ParameterName = "NUM_DOCUMENTO";
                parametro_num_documento.MySqlDbType = MySqlDbType.VarChar;
                parametro_num_documento.Size = 50;
                parametro_num_documento.Value = trabajador.Num_documento;


                MySqlParameter parametro_direccion = new MySqlParameter();
                parametro_direccion.ParameterName = "DIRECCION";
                parametro_direccion.MySqlDbType = MySqlDbType.VarChar;
                parametro_direccion.Size = 100;
                parametro_direccion.Value = trabajador.Direccion;

                MySqlParameter parametro_telefono = new MySqlParameter();
                parametro_telefono.ParameterName = "TELEFONO";
                parametro_telefono.MySqlDbType = MySqlDbType.VarChar;
                parametro_telefono.Size = 100;
                parametro_telefono.Value = trabajador.Telefono;

                MySqlParameter parametro_email = new MySqlParameter();
                parametro_email.ParameterName = "EMAIL";
                parametro_email.MySqlDbType = MySqlDbType.VarChar;
                parametro_email.Size = 100;
                parametro_email.Value = trabajador.Email;

                MySqlParameter parametro_acceso = new MySqlParameter();
                parametro_acceso.ParameterName = "ACCESO";
                parametro_acceso.MySqlDbType = MySqlDbType.VarChar;
                parametro_acceso.Size = 50;
                parametro_acceso.Value = trabajador.Acceso;

                MySqlParameter parametro_usuario = new MySqlParameter();
                parametro_usuario.ParameterName = "USUARIO";
                parametro_usuario.MySqlDbType = MySqlDbType.VarChar;
                parametro_usuario.Size = 50;
                parametro_usuario.Value = trabajador.Usuario;

                MySqlParameter parametro_password = new MySqlParameter();
                parametro_password.ParameterName = "PASSWORDS";
                parametro_password.MySqlDbType = MySqlDbType.VarChar;
                parametro_password.Size = 50;
                parametro_password.Value = trabajador.Password;

                cmd.Parameters.Add(parametro_nombre);
                cmd.Parameters.Add(parametro_apellido);
                cmd.Parameters.Add(parametro_sexo);
                cmd.Parameters.Add(parametro_fecha_nacimiento);
                cmd.Parameters.Add(parametro_num_documento);
                cmd.Parameters.Add(parametro_direccion);
                cmd.Parameters.Add(parametro_telefono);
                cmd.Parameters.Add(parametro_email);
                cmd.Parameters.Add(parametro_acceso);
                cmd.Parameters.Add(parametro_usuario);
                cmd.Parameters.Add(parametro_password);

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

        /// EDITAR 
        public string Editar(D_trabajador trabajador)
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
                cmd.CommandText = "SP_UPDATE_TRABAJADOR";
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter parametro_id_trabajador = new MySqlParameter();
                parametro_id_trabajador.ParameterName = "_ID_TRABAJADOR";
                parametro_id_trabajador.MySqlDbType = MySqlDbType.VarChar;
                parametro_id_trabajador.Size = 11;
                parametro_id_trabajador.Value = trabajador.Id_trabajador;

                MySqlParameter parametro_nombre = new MySqlParameter();
                parametro_nombre.ParameterName = "_NOMBRE";
                parametro_nombre.MySqlDbType = MySqlDbType.VarChar;
                parametro_nombre.Size = 50;
                parametro_nombre.Value = trabajador.Nombre;

                MySqlParameter parametro_apellido = new MySqlParameter();
                parametro_apellido.ParameterName = "_APELLIDOS";
                parametro_apellido.MySqlDbType = MySqlDbType.VarChar;
                parametro_apellido.Size = 50;
                parametro_apellido.Value = trabajador.Apellidos;

                MySqlParameter parametro_sexo = new MySqlParameter();
                parametro_sexo.ParameterName = "_SEXO";
                parametro_sexo.MySqlDbType = MySqlDbType.VarChar;
                parametro_sexo.Size = 1;
                parametro_sexo.Value = trabajador.Sexo;


                MySqlParameter parametro_fecha_nacimiento = new MySqlParameter();
                parametro_fecha_nacimiento.ParameterName = "_FECHA_NACIMIENTO";
                parametro_fecha_nacimiento.MySqlDbType = MySqlDbType.Datetime;
                parametro_fecha_nacimiento.Value = trabajador.Fecha_nacimiento;

                MySqlParameter parametro_num_documento = new MySqlParameter();
                parametro_num_documento.ParameterName = "_NUM_DOCUMENTO";
                parametro_num_documento.MySqlDbType = MySqlDbType.VarChar;
                parametro_num_documento.Size = 50;
                parametro_num_documento.Value = trabajador.Num_documento;


                MySqlParameter parametro_direccion = new MySqlParameter();
                parametro_direccion.ParameterName = "_DIRECCION";
                parametro_direccion.MySqlDbType = MySqlDbType.VarChar;
                parametro_direccion.Size = 100;
                parametro_direccion.Value = trabajador.Direccion;

                MySqlParameter parametro_telefono = new MySqlParameter();
                parametro_telefono.ParameterName = "_TELEFONO";
                parametro_telefono.MySqlDbType = MySqlDbType.VarChar;
                parametro_telefono.Size = 100;
                parametro_telefono.Value = trabajador.Telefono;

                MySqlParameter parametro_email = new MySqlParameter();
                parametro_email.ParameterName = "_EMAIL";
                parametro_email.MySqlDbType = MySqlDbType.VarChar;
                parametro_email.Size = 100;
                parametro_email.Value = trabajador.Email;

                MySqlParameter parametro_acceso = new MySqlParameter();
                parametro_acceso.ParameterName = "_ACCESO";
                parametro_acceso.MySqlDbType = MySqlDbType.VarChar;
                parametro_acceso.Size = 50;
                parametro_acceso.Value = trabajador.Acceso;

                MySqlParameter parametro_usuario = new MySqlParameter();
                parametro_usuario.ParameterName = "_USUARIO";
                parametro_usuario.MySqlDbType = MySqlDbType.VarChar;
                parametro_usuario.Size = 50;
                parametro_usuario.Value = trabajador.Usuario;

                MySqlParameter parametro_password = new MySqlParameter();
                parametro_password.ParameterName = "_PASSWORDS";
                parametro_password.MySqlDbType = MySqlDbType.VarChar;
                parametro_password.Size = 50;
                parametro_password.Value = trabajador.Password;

                cmd.Parameters.Add(parametro_id_trabajador);
                cmd.Parameters.Add(parametro_nombre);
                cmd.Parameters.Add(parametro_apellido);
                cmd.Parameters.Add(parametro_sexo);
                cmd.Parameters.Add(parametro_fecha_nacimiento);
                cmd.Parameters.Add(parametro_num_documento);
                cmd.Parameters.Add(parametro_direccion);
                cmd.Parameters.Add(parametro_telefono);
                cmd.Parameters.Add(parametro_email);
                cmd.Parameters.Add(parametro_acceso);
                cmd.Parameters.Add(parametro_usuario);
                cmd.Parameters.Add(parametro_password);

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


        // ELIMINAR 
        public string ELIMINAR(D_trabajador trabajador)
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
                cmd.CommandText = "SP_ELIMINAR_TRABAJADOR";
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter parametro_id_trabajador = new MySqlParameter();
                parametro_id_trabajador.ParameterName = "_ID_TRABAJADOR";
                parametro_id_trabajador.MySqlDbType = MySqlDbType.VarChar;
                parametro_id_trabajador.Size = 11;
                parametro_id_trabajador.Value = trabajador.Id_trabajador;


                cmd.Parameters.Add(parametro_id_trabajador);

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


        //// BUSCAR POR APELLIDO
        public DataTable Buscar_apellidos(D_trabajador trabajador)
        {

            DataTable data_respuesta = new DataTable("trabajador");
            MySqlConnection conexion = new MySqlConnection();

            try
            {

                /// creo conexion
                conexion.ConnectionString = Conexion.Cn;
                conexion.Open();

                /// configuro parametros
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "SP_BUSCAR_TRABAJADOR_APELLIDO";
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter parametro_buscar = new MySqlParameter();
                parametro_buscar.ParameterName = "BUSCAR";
                parametro_buscar.MySqlDbType = MySqlDbType.VarChar;
                parametro_buscar.Size = 50;
                parametro_buscar.Value = trabajador.Texto_buscar;




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


        //// BUSCAR POR APELLIDO
        public DataTable Buscar_dni(D_trabajador trabajador)
        {

            DataTable data_respuesta = new DataTable("trabajador");
            MySqlConnection conexion = new MySqlConnection();

            try
            {

                /// creo conexion
                conexion.ConnectionString = Conexion.Cn;
                conexion.Open();

                /// configuro parametros
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "SP_BUSCAR_TRABAJADOR_DNI";
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter parametro_buscar = new MySqlParameter();
                parametro_buscar.ParameterName = "BUSCAR";
                parametro_buscar.MySqlDbType = MySqlDbType.VarChar;
                parametro_buscar.Size = 50;
                parametro_buscar.Value = trabajador.Texto_buscar;




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


        // MOSTRAR 
        public DataTable Mostrar()
        {

            DataTable data_respuesta = new DataTable("trabajador");
            MySqlConnection conexion = new MySqlConnection();

            try
            {

                /// creo conexion
                conexion.ConnectionString = Conexion.Cn;
                conexion.Open();

                /// configuro parametros
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "SP_MOSTRAR_TRABAJADOR";
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

        /// LOGIN
        public DataTable LOGIN(string usuario,string password)
        {

            DataTable data_respuesta = new DataTable("trabajador");
            MySqlConnection conexion = new MySqlConnection();

            try
            {

                /// creo conexion
                conexion.ConnectionString = Conexion.Cn;
                conexion.Open();

                /// configuro parametros
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "SP_LOGIN";
                cmd.CommandType = CommandType.StoredProcedure;


                MySqlParameter parametro_usuario = new MySqlParameter();
                parametro_usuario.ParameterName = "_USUARIO";
                parametro_usuario.MySqlDbType = MySqlDbType.VarChar;
                parametro_usuario.Size = 50;
                parametro_usuario.Value = usuario;


                MySqlParameter parametro_password = new MySqlParameter();
                parametro_password.ParameterName = "_PASSWORDS";
                parametro_password.MySqlDbType = MySqlDbType.VarChar;
                parametro_password.Size = 50;
                parametro_password.Value = password;


                cmd.Parameters.Add(parametro_usuario);
                cmd.Parameters.Add(parametro_password);



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
