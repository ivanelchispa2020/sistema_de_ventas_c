using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;


namespace capa_datos
{
    public class D_proveedor
    {

        /// DECLARO LAS VARIABLES ENCAPSULADAS
        private int _id_proveedor;
        private string _razon_social;
        private string _sector_comercial;
        private string _tipo_documento;
        private string _num_documento;
        private string _direccion;
        private string _telefono;
        private string _email;
        private string _url;


        /// METODOS GETTERS Y SETTERS DE LOS CAMPOS
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

        public string Razon_social
        {
            get
            {
                return _razon_social;
            }

            set
            {
                _razon_social = value;
            }
        }

        public string Sector_comercial
        {
            get
            {
                return _sector_comercial;
            }

            set
            {
                _sector_comercial = value;
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

        public string Url
        {
            get
            {
                return _url;
            }

            set
            {
                _url = value;
            }
        }


        // CONSTRUCTORES
        public D_proveedor() { }

        public D_proveedor(int id_proveedor,string razon_social,string sector_comercial,string tipo_documento,string num_documento,string direccion,string telefono,string email,string url)
        {
            this.Id_proveedor = id_proveedor;
            this.Razon_social = razon_social;
            this.Sector_comercial = sector_comercial;
            this.Tipo_documento = tipo_documento;
            this.Num_documento = num_documento;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Email = email;
            this.Url = url;
        }


        /// METODOS PROPIOS


        public string Insertar(D_proveedor proveedor)
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
                cmd.CommandText = "SP_INSERTAR_PROVEEDOR";
                cmd.CommandType = CommandType.StoredProcedure;


                MySqlParameter parametro_razon_social = new MySqlParameter();
                parametro_razon_social.ParameterName = "RAZON_SOCIAL";
                parametro_razon_social.MySqlDbType = MySqlDbType.VarChar;
                parametro_razon_social.Size = 100;
                parametro_razon_social.Value = proveedor.Razon_social;

                MySqlParameter parametro_sector_comercial = new MySqlParameter();
                parametro_sector_comercial.ParameterName = "SECTOR_COMERCIAL";
                parametro_sector_comercial.MySqlDbType = MySqlDbType.VarChar;
                parametro_sector_comercial.Size = 100;
                parametro_sector_comercial.Value = proveedor.Sector_comercial;


                MySqlParameter parametro_tipo_documento = new MySqlParameter();
                parametro_tipo_documento.ParameterName = "TIPO_DOCUMENTO";
                parametro_tipo_documento.MySqlDbType = MySqlDbType.VarChar;
                parametro_tipo_documento.Size = 20;
                parametro_tipo_documento.Value = proveedor.Tipo_documento;

                MySqlParameter parametro_num_documento = new MySqlParameter();
                parametro_num_documento.ParameterName = "NUM_DOCUMENTO";
                parametro_num_documento.MySqlDbType = MySqlDbType.VarChar;
                parametro_num_documento.Size = 50;
                parametro_num_documento.Value = proveedor.Num_documento;


                MySqlParameter parametro_direccion = new MySqlParameter();
                parametro_direccion.ParameterName = "DIRECCION";
                parametro_direccion.MySqlDbType = MySqlDbType.VarChar;
                parametro_direccion.Size = 100;
                parametro_direccion.Value = proveedor.Direccion;

                MySqlParameter parametro_telefono = new MySqlParameter();
                parametro_telefono.ParameterName = "TELEFONO";
                parametro_telefono.MySqlDbType = MySqlDbType.VarChar;
                parametro_telefono.Size = 100;
                parametro_telefono.Value = proveedor.Telefono;

                MySqlParameter parametro_email = new MySqlParameter();
                parametro_email.ParameterName = "EMAIL";
                parametro_email.MySqlDbType = MySqlDbType.VarChar;
                parametro_email.Size = 100;
                parametro_email.Value = proveedor.Email;

                MySqlParameter parametro_url = new MySqlParameter();
                parametro_url.ParameterName = "URL";
                parametro_url.MySqlDbType = MySqlDbType.VarChar;
                parametro_url.Size = 100;
                parametro_url.Value = proveedor.Url;

                cmd.Parameters.Add(parametro_razon_social);
                cmd.Parameters.Add(parametro_sector_comercial);
                cmd.Parameters.Add(parametro_tipo_documento);
                cmd.Parameters.Add(parametro_num_documento);
                cmd.Parameters.Add(parametro_direccion);
                cmd.Parameters.Add(parametro_telefono);
                cmd.Parameters.Add(parametro_email);
                cmd.Parameters.Add(parametro_url);

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


        public string Editar(D_proveedor proveedor)
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
                cmd.CommandText = "SP_UPDATE_PROVEEDOR";
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter parametro_id_proveedor = new MySqlParameter();
                parametro_id_proveedor.ParameterName = "_ID_PROVEEDOR";
                parametro_id_proveedor.MySqlDbType = MySqlDbType.Int32;
                parametro_id_proveedor.Value = proveedor.Id_proveedor;

                MySqlParameter parametro_razon_social = new MySqlParameter();
                parametro_razon_social.ParameterName = "_RAZON_SOCIAL";
                parametro_razon_social.MySqlDbType = MySqlDbType.VarChar;
                parametro_razon_social.Size = 100;
                parametro_razon_social.Value = proveedor.Razon_social;

                MySqlParameter parametro_sector_comercial = new MySqlParameter();
                parametro_sector_comercial.ParameterName = "_SECTOR_COMERCIAL";
                parametro_sector_comercial.MySqlDbType = MySqlDbType.VarChar;
                parametro_sector_comercial.Size = 100;
                parametro_sector_comercial.Value = proveedor.Sector_comercial;


                MySqlParameter parametro_tipo_documento = new MySqlParameter();
                parametro_tipo_documento.ParameterName = "_TIPO_DOCUMENTO";
                parametro_tipo_documento.MySqlDbType = MySqlDbType.VarChar;
                parametro_tipo_documento.Size = 20;
                parametro_tipo_documento.Value = proveedor.Tipo_documento;

                MySqlParameter parametro_num_documento = new MySqlParameter();
                parametro_num_documento.ParameterName = "_NUM_DOCUMENTO";
                parametro_num_documento.MySqlDbType = MySqlDbType.VarChar;
                parametro_num_documento.Size = 50;
                parametro_num_documento.Value = proveedor.Num_documento;


                MySqlParameter parametro_direccion = new MySqlParameter();
                parametro_direccion.ParameterName = "_DIRECCION";
                parametro_direccion.MySqlDbType = MySqlDbType.VarChar;
                parametro_direccion.Size = 100;
                parametro_direccion.Value = proveedor.Direccion;

                MySqlParameter parametro_telefono = new MySqlParameter();
                parametro_telefono.ParameterName = "_TELEFONO";
                parametro_telefono.MySqlDbType = MySqlDbType.VarChar;
                parametro_telefono.Size = 100;
                parametro_telefono.Value = proveedor.Telefono;

                MySqlParameter parametro_email = new MySqlParameter();
                parametro_email.ParameterName = "_EMAIL";
                parametro_email.MySqlDbType = MySqlDbType.VarChar;
                parametro_email.Size = 100;
                parametro_email.Value = proveedor.Email;

                MySqlParameter parametro_url = new MySqlParameter();
                parametro_url.ParameterName = "_URL";
                parametro_url.MySqlDbType = MySqlDbType.VarChar;
                parametro_url.Size = 100;
                parametro_url.Value = proveedor.Url;

                cmd.Parameters.Add(parametro_id_proveedor);
                cmd.Parameters.Add(parametro_razon_social);
                cmd.Parameters.Add(parametro_sector_comercial);
                cmd.Parameters.Add(parametro_tipo_documento);
                cmd.Parameters.Add(parametro_num_documento);
                cmd.Parameters.Add(parametro_direccion);
                cmd.Parameters.Add(parametro_telefono);
                cmd.Parameters.Add(parametro_email);
                cmd.Parameters.Add(parametro_url);



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





        public string Eliminar(D_proveedor proveedor)
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
                cmd.CommandText = "SP_ELIMINAR_PROVEEDOR";
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter parametro_id_proveedor = new MySqlParameter();
                parametro_id_proveedor.ParameterName = "_ID_PROVEEDOR";
                parametro_id_proveedor.MySqlDbType = MySqlDbType.Int32;
                parametro_id_proveedor.Value = proveedor.Id_proveedor;


                cmd.Parameters.Add(parametro_id_proveedor);


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

            DataTable data_respuesta = new DataTable("proveedor");
            MySqlConnection conexion = new MySqlConnection();

            try
            {

                /// creo conexion
                conexion.ConnectionString = Conexion.Cn;
                conexion.Open();

                /// configuro parametros
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "SP_MOSTRAR_PROVEEDOR";
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

        public DataTable Buscar_razon_social(string texto_buscar)
        {

            DataTable data_respuesta = new DataTable("proveedor");
            MySqlConnection conexion = new MySqlConnection();

            try
            {

                /// creo conexion
                conexion.ConnectionString = Conexion.Cn;
                conexion.Open();

                /// configuro parametros
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "SP_BUSCAR_PROVEEDOR_RAZON_SOCIAL";
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

            DataTable data_respuesta = new DataTable("proveedor");
            MySqlConnection conexion = new MySqlConnection();

            try
            {

                /// creo conexion
                conexion.ConnectionString = Conexion.Cn;
                conexion.Open();

                /// configuro parametros
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "SP_BUSCAR_PROVEEDOR_NUM_DOCUMENTO";
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
