using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using capa_datos;


namespace capa_negocio
{
   public class N_ventas
    {



        public static string insertar(int id_venta, int id_cliente,int id_trabajador,DateTime fecha, string tipo_comprobante,string serie,string correlativo,decimal igv)
        {

            D_ventas obj = new D_ventas();
            obj.Id_venta = id_venta;
            obj.Id_cliente = id_cliente;
            obj.Id_trabajador = id_trabajador;
            obj.Fecha = fecha;
            obj.Tipo_comprobante = tipo_comprobante;
            obj.Serie = serie;
            obj.Correlativo = correlativo;
            obj.Igv=igv;


            return obj.Insertar(obj);

        }


        public static string editar(int id_venta, int id_cliente, int id_trabajador, DateTime fecha, string tipo_comprobante, string serie, string correlativo, decimal igv)
        {

            D_ventas obj = new D_ventas();
            obj.Id_venta = id_venta;
            obj.Id_cliente = id_cliente;
            obj.Id_trabajador = id_trabajador;
            obj.Fecha = fecha;
            obj.Tipo_comprobante = tipo_comprobante;
            obj.Serie = serie;
            obj.Correlativo = correlativo;
            obj.Igv = igv;


            return obj.Editar(obj);

        }


        public static string Eliminar(int id_venta)
        {

            D_ventas obj = new D_ventas();
            obj.Id_venta = id_venta;

            return obj.Eliminar(obj);

        }


        public static DataTable Mostrar()
        {
            D_ventas obj = new D_ventas();
            return obj.Mostrar();

        }




    }
}
