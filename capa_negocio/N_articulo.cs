using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using capa_datos;

namespace capa_negocio
{
    public class N_articulo
    {



        public static string insertar(string codigo,string nombre, string descripcion,byte [] imagen,int id_categoria,int id_presentacion)
        {

            D_articulo obj = new D_articulo();
            obj.Codigo = codigo;
            obj.Nombre = nombre;
            obj.Descripcion = descripcion;
            obj.Imagen = imagen;
            obj.Id_categoria = id_categoria;
            obj.Id_presentacion = id_presentacion;
            return obj.Insertar(obj);

        }


        public static string Editar(int id_articulo, string codigo, string nombre, string descripcion, byte[] imagen, int id_categoria, int id_presentacion)
        {

            D_articulo obj = new D_articulo();
            obj.Id_articulo = id_articulo;
            obj.Codigo = codigo;
            obj.Nombre = nombre;
            obj.Descripcion = descripcion;
            obj.Imagen = imagen;
            obj.Id_categoria = id_categoria;
            obj.Id_presentacion = id_presentacion;


            return obj.Editar(obj);

        }


        public static string Eliminar(int id_articulo)
        {

            D_articulo obj = new D_articulo();
            obj.Id_articulo = id_articulo;

            return obj.Eliminar(obj);

        }


        public static DataTable Mostrar()
        {
            D_articulo obj = new D_articulo();
            return obj.Mostrar();

        }


        public static DataTable Buscar_texto(string texto_buscar)
        {


            D_articulo obj = new D_articulo();
            obj.Texto_buscar = texto_buscar;

            return obj.Buscar_nombre(obj);

        }




    }
}
