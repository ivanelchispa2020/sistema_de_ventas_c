using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using capa_datos;


namespace capa_negocio
{
    public class N_ingreso
    {


        public static string insertar(int id_ingreso,int id_trabajador,int id_proveedor,DateTime fecha,string tipo_comprobante,string serie,string correlativo,decimal igv, string estado)
        {

            D_ingresos obj = new D_ingresos();
            obj.Id_ingreso = id_ingreso;
            obj.Id_trabajador = id_trabajador;
            obj.Id_proveedor = id_proveedor;
            obj.Fecha = fecha;
            obj.Tipo_comprobante = tipo_comprobante;
            obj.Serie = serie;
            obj.Correlativo = correlativo;
            obj.Igv = igv;
            obj.Estado = estado;

            return obj.Insertar(obj);

        }


        public static string editar(int id_ingreso, int id_trabajador, int id_proveedor, DateTime fecha, string tipo_comprobante, string serie, string correlativo, decimal igv, string estado)
        {

            D_ingresos obj = new D_ingresos();
            obj.Id_ingreso = id_ingreso;
            obj.Id_trabajador = id_trabajador;
            obj.Id_proveedor = id_proveedor;
            obj.Fecha = fecha;
            obj.Tipo_comprobante = tipo_comprobante;
            obj.Serie = serie;
            obj.Correlativo = correlativo;
            obj.Igv = igv;
            obj.Estado = estado;

            return obj.Editar(obj);

        }

        public static string Eliminar(int id_ingreso)
        {

            D_ingresos obj = new D_ingresos();
            obj.Id_ingreso = id_ingreso;

            return obj.Anular(obj);

        }


        public static DataTable Mostrar()
        {
            D_ingresos obj = new D_ingresos();
            return obj.Mostrar_ingreso();

        }


        public static DataTable Buscar_fecha(string fecha_1,string fecha_2)
        {


            D_ingresos obj = new D_ingresos();

            return obj.Buscar_ingreso_por_fecha(fecha_1,fecha_2);

        }




    }



}
