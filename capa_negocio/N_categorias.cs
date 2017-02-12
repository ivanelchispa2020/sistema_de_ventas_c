using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using capa_datos;

namespace capa_negocio
{
    public class N_categorias
    {



        public static string insertar(int  id_categoria, string nombre, string descripcion)        {

            D_categoria obj = new D_categoria();
            obj.Id_categoria = id_categoria;
            obj.Nombre = nombre;
            obj.Descripcion = descripcion;

            return obj.Insertar(obj);

        }


        public static string Editar(int id_categoria, string nombre, string descripcion)
        {

            D_categoria obj = new D_categoria();
            obj.Id_categoria = id_categoria;
            obj.Nombre = nombre;
            obj.Descripcion = descripcion;
      

            return obj.Editar(obj);

        }


        public static string Eliminar(int id_categoria)
        {

            D_categoria obj = new D_categoria();
            obj.Id_categoria = id_categoria;

            return obj.Eliminar(obj);

        }


        public static DataTable Mostrar()
        {
            D_categoria obj = new D_categoria();
            return obj.Mostrar();

        }


        public static DataTable Buscar_texto(string texto_buscar)
        {


            D_categoria obj = new D_categoria();
        
            return obj.Buscar_nombre(texto_buscar);

        }



        
    }
}
