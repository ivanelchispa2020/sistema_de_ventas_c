using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using capa_datos;
namespace capa_negocio
{
    public class N_presentacion
    {


        public static string insertar(int id_presentacion, string nombre, string descripcion)
        {

            D_presentacion obj = new D_presentacion();
            obj.Id_presentacion = id_presentacion;
            obj.Nombre = nombre;
            obj.Descripcion = descripcion;

            return obj.Insertar(obj);

        }


        public static string Editar(int id_presentacion, string nombre, string descripcion)
        {

            D_presentacion obj = new D_presentacion();
            obj.Id_presentacion = id_presentacion;
            obj.Nombre = nombre;
            obj.Descripcion = descripcion;


            return obj.Editar(obj);

        }


        public static string Eliminar(int id_presentacion)
        {

            D_presentacion obj = new D_presentacion();
            obj.Id_presentacion = id_presentacion;

            return obj.Eliminar(obj);

        }


        public static DataTable Mostrar()
        {
            D_presentacion obj = new D_presentacion();
            return obj.Mostrar();

        }


        public static DataTable Buscar_texto(string texto_buscar)
        {


            D_presentacion obj = new D_presentacion();

            return obj.Buscar_nombre(texto_buscar);

        }


    }
}
