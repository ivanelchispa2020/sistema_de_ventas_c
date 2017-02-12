using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using capa_datos;

namespace capa_negocio
{
    public class N_detalle_ingreso
    {



        public static string insertar(int id_detallle_ingreso,int id_ingreso,int id_articulo,decimal precio_compra,decimal precio_venta,int stock_inicial,int stock_actual,DateTime fecha_produccion, DateTime fecha_vencimiento)
        {

            D_detalle_ingreso obj = new D_detalle_ingreso();
            obj.Id_detalle_ingreso = id_detallle_ingreso;
            obj.Id_ingreso = id_ingreso;
            obj.Id_articulo = id_articulo;
            obj.Precio_compra = precio_compra;
            obj.Precio_venta = precio_venta;
            obj.Stock_inicial = stock_inicial;
            obj.Stock_actual = stock_actual;
            obj.Fecha_produccion = fecha_produccion;
            obj.Fecha_vencimiento = fecha_vencimiento;

            return obj.Insertar(obj);

        }

        public static string editar(int id_detallle_ingreso, int id_ingreso, int id_articulo, decimal precio_compra, decimal precio_venta, int stock_inicial, int stock_actual, DateTime fecha_produccion, DateTime fecha_vencimiento)
        {

            D_detalle_ingreso obj = new D_detalle_ingreso();
            obj.Id_detalle_ingreso = id_detallle_ingreso;
            obj.Id_ingreso = id_ingreso;
            obj.Id_articulo = id_articulo;
            obj.Precio_compra = precio_compra;
            obj.Precio_venta = precio_venta;
            obj.Stock_inicial = stock_inicial;
            obj.Stock_actual = stock_actual;
            obj.Fecha_produccion = fecha_produccion;
            obj.Fecha_vencimiento = fecha_vencimiento;

            return obj.Editar(obj);

        }

        public static string Eliminar(int id_detalle_ingreso)
        {

            D_detalle_ingreso obj = new D_detalle_ingreso();
            obj.Id_detalle_ingreso = id_detalle_ingreso;

            return obj.Eliminar(obj);

        }


        public static DataTable Mostrar()
        {
            D_detalle_ingreso obj = new D_detalle_ingreso();

            return obj.Mostrar_detalle_ingreso(obj);

        }


        

    }

}
