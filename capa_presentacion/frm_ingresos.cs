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
    public partial class frm_ingresos : Form
    {

        private bool estado;
        public static frm_ingresos _instancia;

        public static frm_ingresos dame_instancia(bool estado) {

            if (_instancia == null)
            {
                _instancia = new frm_ingresos(estado);
            }

            return _instancia;

        }


        

        public frm_ingresos(bool mi_estado)
        {
            InitializeComponent();
            this.estado = mi_estado;
            
        }


        public void gestiona_ventana(bool mi_estado)
        {
            this.estado = mi_estado;

            if (this.estado)
            {
                this.BackgroundImage = null;
                this.BackColor = Color.DarkGreen;
                cambia_controles(Color.Purple, new Font("Comic Sans Ms", 15, FontStyle.Bold));
                this.table_detalles_ingresos.BackColor = Color.GreenYellow;
                this.table_ingresos.BackColor = Color.LimeGreen;
                

            }
            else
            {
                this.BackColor = Color.Black;
                this.BackgroundImage = capa_presentacion.Properties.Resources.fondo_24;
                 cambia_controles(Color.HotPink, new Font("Comic Sans Ms", 11, FontStyle.Bold));
                this.table_ingresos.BackColor =Color.Transparent;
                this.table_detalles_ingresos.BackColor = Color.Transparent;
              

            }

        }


        private void cambia_controles(Color color,Font fuente)
        {
            this.l_titulo.ForeColor = color;
                

            this.l_precio_compra.ForeColor = color;
            this.l_precio_compra.Font = fuente;
            this.l_precio_venta.ForeColor = color;
            this.l_precio_venta.Font = fuente;
            this.l_stock.ForeColor = color;
            this.l_stock.Font = fuente;
            this.l_fecha_produccion.ForeColor = color;
            this.l_fecha_produccion.Font = fuente;
            this.l_fecha_vencimiento.ForeColor = color;
            this.l_fecha_vencimiento.Font = fuente;
            this.l_codigo_ingreso.ForeColor = color;
            this.l_codigo_ingreso.Font = fuente;
            this.l_codigo_trabajador.ForeColor = color;
            this.l_codigo_trabajador.Font = fuente;
            this.l_codigo_proveedor.ForeColor = color;
            this.l_codigo_proveedor.Font = fuente;
            this.l_fecha.ForeColor = color;
            this.l_fecha.Font = fuente;
            this.l_tipo_comprobante.ForeColor = color;
            this.l_tipo_comprobante.Font = fuente;
            this.l_serie.ForeColor = color;
            this.l_serie.Font = fuente;
            this.l_correlativo.ForeColor = color;
            this.l_correlativo.Font = fuente;
            this.l_iva.ForeColor = color;
            this.l_iva.Font = fuente;


            this.txt_precio_compra.Font = fuente;
            this.txt_precio_venta.Font = fuente;
            this.txt_stock.Font = fuente;
            this.dt_fecha_produccion.Font = fuente;
            this.dt_fecha_vencimiento.Font = fuente;
            this.txt_codigo_ingreso.Font = fuente;
            this.txt_codigo_trabajador.Font = fuente;
            this.txt_codigo_proveedor.Font = fuente;
            this.dt_fecha.Font = fuente;
            this.cb_comprobante.Font = fuente;
            this.txt_serie.Font = fuente;
            this.txt_correlativo.Font = fuente;
            this.n_iva.Font = fuente;

            this.btn_nuevo.Font = fuente;
            this.btn_editar.Font = fuente;
            this.btn_eliminar.Font = fuente;
            this.btn_cancelar.Font = fuente;

        }


       


        /// HOVER BOTONES
        private void btn_cancelar_MouseEnter(object sender, EventArgs e)
        {
            this.btn_cancelar.BackColor = Color.HotPink;
            this.btn_cancelar.ForeColor = Color.Black;
        }

        private void btn_cancelar_MouseLeave(object sender, EventArgs e)
        {
            this.btn_cancelar.BackColor = Color.Black;
            this.btn_cancelar.ForeColor = Color.HotPink;
        }

        private void btn_eliminar_MouseEnter(object sender, EventArgs e)
        {
            this.btn_eliminar.BackColor = Color.HotPink;
            this.btn_eliminar.ForeColor = Color.Black;
        }

        private void btn_eliminar_MouseLeave(object sender, EventArgs e)
        {
            this.btn_eliminar.BackColor = Color.Black;
            this.btn_eliminar.ForeColor = Color.HotPink;
        }

        private void btn_editar_MouseEnter(object sender, EventArgs e)
        {
            this.btn_editar.BackColor = Color.HotPink;
            this.btn_editar.ForeColor = Color.Black;
        }

        private void btn_editar_MouseLeave(object sender, EventArgs e)
        {
            this.btn_editar.BackColor = Color.Black;
            this.btn_editar.ForeColor = Color.HotPink;
        }

        private void btn_nuevo_MouseEnter(object sender, EventArgs e)
        {
            this.btn_nuevo.BackColor = Color.HotPink;
            this.btn_nuevo.ForeColor = Color.Black;
        }

        private void btn_nuevo_MouseLeave(object sender, EventArgs e)
        {
            this.btn_nuevo.BackColor = Color.Black;
            this.btn_nuevo.ForeColor = Color.HotPink;
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
