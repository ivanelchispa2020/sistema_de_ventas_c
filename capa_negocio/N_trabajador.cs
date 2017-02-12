using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using capa_datos;
using System.Windows.Forms;

namespace capa_negocio
{
    public class N_trabajador
    {



        public static string insertar(string nombre, string apellidos, string sexo, DateTime fecha_nacimiento, string num_documento, string direccion, string telefono, string email, string acceso, string usuario, string password)
        {

            D_trabajador obj = new D_trabajador();
            obj.Nombre = nombre;
            obj.Apellidos = apellidos;
            obj.Sexo = sexo;
            obj.Fecha_nacimiento = fecha_nacimiento;
            obj.Num_documento = num_documento;
            obj.Direccion = direccion;
            obj.Telefono = telefono;
            obj.Email = email;
            obj.Acceso = acceso;
            obj.Usuario = usuario;
            obj.Password = password;

            return obj.Insertar(obj);

        }


        public static string Editar(int id_trabajador, string nombre, string apellidos, string sexo, DateTime fecha_nacimiento, string num_documento, string direccion, string telefono, string email, string acceso, string usuario, string password)
        {

            D_trabajador obj = new D_trabajador();
            obj.Id_trabajador = id_trabajador;
            obj.Nombre = nombre;
            obj.Apellidos = apellidos;
            obj.Sexo = sexo;
            obj.Fecha_nacimiento = fecha_nacimiento;
            obj.Num_documento = num_documento;
            obj.Direccion = direccion;
            obj.Telefono = telefono;
            obj.Email = email;
            obj.Acceso = acceso;
            obj.Usuario = usuario;
            obj.Password = password;

            return obj.Editar(obj);
        }


        public static string Eliminar(int id_trabajador)
        {

            D_trabajador obj = new D_trabajador();
            obj.Id_trabajador = id_trabajador;

            return obj.ELIMINAR(obj);

        }


        public static DataTable Mostrar()
        {
            D_trabajador obj = new D_trabajador();
            return obj.Mostrar();

        }


        public static DataTable Buscar_apellido(string texto_buscar)
        {


            D_trabajador obj = new D_trabajador();
            obj.Texto_buscar = texto_buscar;

            return obj.Buscar_apellidos(obj);

        }

        public static DataTable Buscar_dni(string texto_buscar)
        {


            D_trabajador obj = new D_trabajador();
            obj.Texto_buscar = texto_buscar;

            return obj.Buscar_dni(obj);

        }

        public static DataTable acceso_usuario(string usuario,string password)
        {


            D_trabajador obj = new D_trabajador();


            return obj.LOGIN(usuario,password);

        }

    }

}
