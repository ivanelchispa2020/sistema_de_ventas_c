using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capa_presentacion
{
    public partial class frm_panel_principal_grande : Form
    {
        public frm_panel_principal_grande()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            t_mensaje.SetToolTip(link_ingresos,"Abre el formulario de Ingresos de Mercaderias");
      t_mensaje.SetToolTip(link_proveedores,"Abre el formulario de proveedores");
            t_mensaje.SetToolTip(link_datos_de_ingreso,"Contiene datos estadisticos sobre los ingresos en el sistema");
            t_mensaje.SetToolTip(link_articulos,"Abre el formulario de Articulos");
            t_mensaje.SetToolTip(link_categorias,"Abre el formulario de Categorias");
            t_mensaje.SetToolTip(link_almacen, "Contiene datos estadisticos sobre los ingresos de la mercaderias");
            t_mensaje.SetToolTip(link_ventas,"Abre el formulario de Ventas");
            t_mensaje.SetToolTip(link_cliente,"Abre el formulario Cliente");
            t_mensaje.SetToolTip(link_consulta,"Abre el formulario de consultas.");
            t_mensaje.SetToolTip(link_datos_de_venta, "Contiene datos estadisticos sobre los egresos en el sistema");
            t_mensaje.SetToolTip(link_base_de_datos,"Accede al mantenimiento de la base de datos del sistema");
            t_mensaje.SetToolTip(link_trabajadores, "Abre el formulario de trabajadores");
            t_mensaje.SetToolTip(link_contacto,"Brinda información sobre las formas de contactar ante cualquier imprevisto.");
        }

       
    }
}
