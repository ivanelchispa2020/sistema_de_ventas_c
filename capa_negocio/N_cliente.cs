using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using capa_datos;
namespace capa_negocio
{
    public class N_cliente
    {


        public static string insertar(int id_cliente, string nombre, string apellidos,string sexo,DateTime fecha_nacimiento,string tipo_documento,string num_documento,string direccion,string telefono,string email)
        {

            D_cliente obj = new D_cliente();
            obj.Id_cliente = id_cliente;
            obj.Nombre = nombre;
            obj.Apellidos = apellidos;
            obj.Sexo = sexo;
            obj.Fecha_nacimiento = fecha_nacimiento;
            obj.Tipo_documento = tipo_documento;
            obj.Num_documento = num_documento;
            obj.Direccion = direccion;
            obj.Telefono = telefono;
            obj.Email = email;

            return obj.Insertar(obj);

        }


        public static string Editar(int id_cliente, string nombre, string apellidos, string sexo, DateTime fecha_nacimiento, string tipo_documento, string num_documento, string direccion, string telefono, string email)
        {

            D_cliente obj = new D_cliente();
            obj.Id_cliente = id_cliente;
            obj.Nombre = nombre;
            obj.Apellidos = apellidos;
            obj.Sexo = sexo;
            obj.Fecha_nacimiento = fecha_nacimiento;
            obj.Tipo_documento = tipo_documento;
            obj.Num_documento = num_documento;
            obj.Direccion = direccion;
            obj.Telefono = telefono;
            obj.Email = email;

            
            return obj.Editar(obj);

        }


        public static string Eliminar(int id_cliente)
        {

            D_cliente obj = new D_cliente();
            obj.Id_cliente = id_cliente;

            return obj.Eliminar(obj);

        }


        public static DataTable Mostrar()
        {
            D_cliente obj = new D_cliente();
            return obj.Mostrar();

        }


        public static DataTable Buscar_nombre(string texto_buscar)
        {


            D_cliente obj = new D_cliente();

            return obj.Buscar_nombre(texto_buscar);

        }


        public static DataTable Buscar_dni(string texto_buscar)
        {


            D_cliente obj = new D_cliente();

            return obj.Buscar_dni(texto_buscar);

        }



    }



}
