using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using capa_datos;

namespace capa_negocio
{
    public class N_detalle_ventas
    {


        public static string insertar(int id_detalle_venta, int id_venta, int id_detalle_ingreso,int cantidad,decimal precio_venta,decimal descuento)
        {

            D_detalle_venta obj = new D_detalle_venta();
            obj.Id_detalle_venta = id_detalle_venta;
            obj.Id_venta = id_venta;
            obj.Id_detalle_ingreso= id_detalle_ingreso;
            obj.Cantidad = cantidad;
            obj.Precio_venta = precio_venta;
            obj.Descuento = descuento;

            return obj.Insertar(obj);

        }


        public static string editar(int id_detalle_venta, int id_venta, int id_detalle_ingreso, int cantidad, decimal precio_venta, decimal descuento)
        {

            D_detalle_venta obj = new D_detalle_venta();
            obj.Id_detalle_venta = id_detalle_venta;
            obj.Id_venta = id_venta;
            obj.Id_detalle_ingreso = id_detalle_ingreso;
            obj.Cantidad = cantidad;
            obj.Precio_venta = precio_venta;
            obj.Descuento = descuento;

            return obj.Editar(obj);

        }



        public static string Eliminar(int id_detalle_venta)
        {

            D_detalle_venta obj = new D_detalle_venta();
            obj.Id_detalle_venta = id_detalle_venta;

            return obj.Eliminar(obj);

        }


        public static DataTable Mostrar()
        {
            D_detalle_venta obj = new D_detalle_venta();
            return obj.Mostrar();

        }




    }
}
