using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
namespace capa_datos
{
    public class D_cliente
    {

        //DECLARO LAS VARIABLES
        private int _id_cliente;
        private string _nombre;
        private string _apellidos;
        private string _sexo;
        private DateTime _fecha_nacimiento;
        private string _tipo_documento;
        private string _num_documento;
        private string _direccion;
        private string _telefono;
        private string _email;


        // METODOS GETTERS Y SETTERS DE LOS CAMPOS
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

        public string Tipo_documento
        {
            get
            {
                return _tipo_documento;
            }

            set
            {
                _tipo_documento = value;
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



        /// CONSTRUCTORES
        public D_cliente() { }

        public D_cliente(int id_cliente,string nombre,string apellidos,string sexo,DateTime fecha_nacimiento,string tipo_documento,string num_documento,string direccion,string telefono,string email)
        {
            this.Id_cliente = id_cliente;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Sexo = sexo;
            this.Fecha_nacimiento = fecha_nacimiento;
            this.Tipo_documento = tipo_documento;
            this.Num_documento = num_documento;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Email = email;

        }


        /////  METODOS PROPIOS

        public string Insertar(D_cliente cliente)
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
                cmd.CommandText = "SP_INSERTAR_CLIENTE";
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter parametro_nombre = new MySqlParameter();
                parametro_nombre.ParameterName = "NOMBRE";
                parametro_nombre.MySqlDbType = MySqlDbType.VarChar;
                parametro_nombre.Size = 50;
                parametro_nombre.Value = cliente.Nombre;

                MySqlParameter parametro_apellidos = new MySqlParameter();
                parametro_apellidos.ParameterName = "APELLIDOS";
                parametro_apellidos.MySqlDbType = MySqlDbType.VarChar;
                parametro_apellidos.Size = 50;
                parametro_apellidos.Value = cliente.Apellidos;


                MySqlParameter parametro_sexo = new MySqlParameter();
                parametro_sexo.ParameterName = "SEXO";
                parametro_sexo.MySqlDbType = MySqlDbType.VarChar;
                parametro_sexo.Size = 1;
                parametro_sexo.Value = cliente.Sexo;


                MySqlParameter parametro_fecha_nacimiento= new MySqlParameter();
                parametro_fecha_nacimiento.ParameterName = "FECHA_NACIMIENTO";
                parametro_fecha_nacimiento.MySqlDbType = MySqlDbType.DateTime;
                parametro_fecha_nacimiento.Value = cliente.Fecha_nacimiento;

                MySqlParameter parametro_tipo_documento = new MySqlParameter();
                parametro_tipo_documento.ParameterName = "TIPO_DOCUMENTO";
                parametro_tipo_documento.MySqlDbType = MySqlDbType.VarChar;
                parametro_tipo_documento.Size = 20;
                parametro_tipo_documento.Value = cliente.Tipo_documento;

                MySqlParameter parametro_num_documento = new MySqlParameter();
                parametro_num_documento.ParameterName = "NUM_DOCUMENTO";
                parametro_num_documento.MySqlDbType = MySqlDbType.VarChar;
                parametro_num_documento.Size = 50;
                parametro_num_documento.Value = cliente.Num_documento;


                MySqlParameter parametro_direccion = new MySqlParameter();
                parametro_direccion.ParameterName = "DIRECCION";
                parametro_direccion.MySqlDbType = MySqlDbType.VarChar;
                parametro_direccion.Size = 100;
                parametro_direccion.Value = cliente.Direccion;

                MySqlParameter parametro_telefono = new MySqlParameter();
                parametro_telefono.ParameterName = "TELEFONO";
                parametro_telefono.MySqlDbType = MySqlDbType.VarChar;
                parametro_telefono.Size = 100;
                parametro_telefono.Value = cliente.Telefono;

                MySqlParameter parametro_email = new MySqlParameter();
                parametro_email.ParameterName = "EMAIL";
                parametro_email.MySqlDbType = MySqlDbType.VarChar;
                parametro_email.Size = 100;
                parametro_email.Value = cliente.Email;


                cmd.Parameters.Add(parametro_nombre);
                cmd.Parameters.Add(parametro_apellidos);
                cmd.Parameters.Add(parametro_sexo);
                cmd.Parameters.Add(parametro_fecha_nacimiento);
                cmd.Parameters.Add(parametro_tipo_documento);
                cmd.Parameters.Add(parametro_num_documento);
                cmd.Parameters.Add(parametro_direccion);
                cmd.Parameters.Add(parametro_telefono);
                cmd.Parameters.Add(parametro_email);


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


        public string Editar(D_cliente cliente)
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
                cmd.CommandText = "SP_UPDATE_CLIENTE";
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter parametro_id_cliente = new MySqlParameter();
                parametro_id_cliente.ParameterName = "_ID_CLIENTE";
                parametro_id_cliente.MySqlDbType = MySqlDbType.Int32;
                parametro_id_cliente.Value = cliente.Id_cliente;


                MySqlParameter parametro_nombre = new MySqlParameter();
                parametro_nombre.ParameterName = "_NOMBRE";
                parametro_nombre.MySqlDbType = MySqlDbType.VarChar;
                parametro_nombre.Size = 50;
                parametro_nombre.Value = cliente.Nombre;

                MySqlParameter parametro_apellidos = new MySqlParameter();
                parametro_apellidos.ParameterName = "_APELLIDOS";
                parametro_apellidos.MySqlDbType = MySqlDbType.VarChar;
                parametro_apellidos.Size = 50;
                parametro_apellidos.Value = cliente.Apellidos;


                MySqlParameter parametro_sexo = new MySqlParameter();
                parametro_sexo.ParameterName = "_SEXO";
                parametro_sexo.MySqlDbType = MySqlDbType.VarChar;
                parametro_sexo.Size = 1;
                parametro_sexo.Value = cliente.Sexo;


                MySqlParameter parametro_fecha_nacimiento = new MySqlParameter();
                parametro_fecha_nacimiento.ParameterName = "_FECHA_NACIMIENTO";
                parametro_fecha_nacimiento.MySqlDbType = MySqlDbType.DateTime;
                parametro_fecha_nacimiento.Value = cliente.Fecha_nacimiento;

                MySqlParameter parametro_tipo_documento = new MySqlParameter();
                parametro_tipo_documento.ParameterName = "_TIPO_DOCUMENTO";
                parametro_tipo_documento.MySqlDbType = MySqlDbType.VarChar;
                parametro_tipo_documento.Size = 20;
                parametro_tipo_documento.Value = cliente.Tipo_documento;

                MySqlParameter parametro_num_documento = new MySqlParameter();
                parametro_num_documento.ParameterName = "_NUM_DOCUMENTO";
                parametro_num_documento.MySqlDbType = MySqlDbType.VarChar;
                parametro_num_documento.Size = 50;
                parametro_num_documento.Value = cliente.Num_documento;


                MySqlParameter parametro_direccion = new MySqlParameter();
                parametro_direccion.ParameterName = "_DIRECCION";
                parametro_direccion.MySqlDbType = MySqlDbType.VarChar;
                parametro_direccion.Size = 100;
                parametro_direccion.Value = cliente.Direccion;

                MySqlParameter parametro_telefono = new MySqlParameter();
                parametro_telefono.ParameterName = "_TELEFONO";
                parametro_telefono.MySqlDbType = MySqlDbType.VarChar;
                parametro_telefono.Size = 100;
                parametro_telefono.Value = cliente.Telefono;

                MySqlParameter parametro_email = new MySqlParameter();
                parametro_email.ParameterName = "_EMAIL";
                parametro_email.MySqlDbType = MySqlDbType.VarChar;
                parametro_email.Size = 100;
                parametro_email.Value = cliente.Email;

                cmd.Parameters.Add(parametro_id_cliente);
                cmd.Parameters.Add(parametro_nombre);
                cmd.Parameters.Add(parametro_apellidos);
                cmd.Parameters.Add(parametro_sexo);
                cmd.Parameters.Add(parametro_fecha_nacimiento);
                cmd.Parameters.Add(parametro_tipo_documento);
                cmd.Parameters.Add(parametro_num_documento);
                cmd.Parameters.Add(parametro_direccion);
                cmd.Parameters.Add(parametro_telefono);
                cmd.Parameters.Add(parametro_email);


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





        public string Eliminar(D_cliente cliente)
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
                cmd.CommandText = "SP_ELIMINAR_CLIENTE";
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter parametro_id_cliente = new MySqlParameter();
                parametro_id_cliente.ParameterName = "_ID_CLIENTE";
                parametro_id_cliente.MySqlDbType = MySqlDbType.Int32;
                parametro_id_cliente.Value = cliente.Id_cliente;

                
                cmd.Parameters.Add(parametro_id_cliente);
                

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

            DataTable data_respuesta = new DataTable("cliente");
            MySqlConnection conexion = new MySqlConnection();

            try
            {

                /// creo conexion
                conexion.ConnectionString = Conexion.Cn;
                conexion.Open();

                /// configuro parametros
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "SP_MOSTRAR_CLIENTE";
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

            DataTable data_respuesta = new DataTable("cliente");
            MySqlConnection conexion = new MySqlConnection();

            try
            {

                /// creo conexion
                conexion.ConnectionString = Conexion.Cn;
                conexion.Open();

                /// configuro parametros
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "SP_BUSCAR_CLIENTE_APELLIDOS";
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



        public DataTable Buscar_dni(string texto_buscar)
        {

            DataTable data_respuesta = new DataTable("cliente");
            MySqlConnection conexion = new MySqlConnection();

            try
            {

                /// creo conexion
                conexion.ConnectionString = Conexion.Cn;
                conexion.Open();

                /// configuro parametros
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "SP_BUSCAR_CLIENTE_DNI";
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
