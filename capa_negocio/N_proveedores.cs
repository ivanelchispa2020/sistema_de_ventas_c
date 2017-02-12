using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using capa_datos;


namespace capa_negocio
{
   public class N_proveedores
    {


        public static string insertar(int id_proveedor, string razon_social, string sector_comercial,string tipo_documento,string num_documento,string direccion,string telefono,string email,string url)
        {

            D_proveedor obj = new D_proveedor();
            obj.Id_proveedor = id_proveedor;
            obj.Razon_social = razon_social;
            obj.Sector_comercial = sector_comercial;
            obj.Tipo_documento = tipo_documento;
            obj.Num_documento = num_documento;
            obj.Direccion = direccion;
            obj.Telefono = telefono;
            obj.Email = email;
            obj.Url = url;
            


            return obj.Insertar(obj);

        }

        public static string editar(int id_proveedor, string razon_social, string sector_comercial, string tipo_documento, string num_documento, string direccion, string telefono, string email, string url)
        {

            D_proveedor obj = new D_proveedor();
            obj.Id_proveedor = id_proveedor;
            obj.Razon_social = razon_social;
            obj.Sector_comercial = sector_comercial;
            obj.Tipo_documento = tipo_documento;
            obj.Num_documento = num_documento;
            obj.Direccion = direccion;
            obj.Telefono = telefono;
            obj.Email = email;
            obj.Url = url;



            return obj.Editar(obj);

        }



        public static string Eliminar(int id_proveedor)
        {

            D_proveedor obj = new D_proveedor();
            obj.Id_proveedor = id_proveedor;

            return obj.Eliminar(obj);

        }


        public static DataTable Mostrar()
        {
            D_proveedor obj = new D_proveedor();
            return obj.Mostrar();

        }


        public static DataTable Buscar_razon_social(string texto_buscar)
        {


            D_proveedor obj = new D_proveedor();

            return obj.Buscar_razon_social(texto_buscar);

        }

        public static DataTable Buscar_dni(string texto_buscar)
        {


            D_proveedor obj = new D_proveedor();

            return obj.Buscar_dni(texto_buscar);

        }






    }
}
