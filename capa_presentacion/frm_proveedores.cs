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
    public partial class frm_proveedores : Form
    {

        public static frm_proveedores _instancia;
        private bool tamano;
        public  int id_pagina;
        private bool mi_panel_oculto;



        public static frm_proveedores dame_instancia(bool tamano,bool panel_oculto)
        {
            if (_instancia == null)
            {
                _instancia = new frm_proveedores(tamano,panel_oculto);

            }

            return _instancia;

        }


        public frm_proveedores(bool tamano,bool panel_oculto)
        {
            InitializeComponent();
            this.tamano = tamano;
            this.mi_panel_oculto = panel_oculto;

            panel_pagina_2.Hide();
            panel_hover.Hide();

            id_pagina = 1;

            
        }

       

        public void  gestiona_ventana(bool estado)
        {
            if (estado)
            {

                this.BackgroundImage= capa_presentacion.Properties.Resources.fondo_22;
                cambia_tamano(Color.White,new Font("Comic Sans MS",18,FontStyle.Bold));
                cambia_tamano_pag_2(Color.White, new Font("Comic Sans MS", 13, FontStyle.Bold));


            }
            else
            {

                this.BackgroundImage = capa_presentacion.Properties.Resources.fondo_26;
                cambia_tamano(Color.Yellow, new Font("Comic Sans MS", 11, FontStyle.Bold));
                cambia_tamano_pag_2(Color.Yellow, new Font("Comic Sans MS", 11, FontStyle.Bold));
            }



        }

        private void cambia_tamano(Color color,Font fuente)
        {
            this.l_titulo.ForeColor = color;

            this.l_codigo_prov.ForeColor = color;
            this.l_codigo_prov.Font = fuente;

            this.l_razon_social.ForeColor = color;
            this.l_razon_social.Font = fuente;
            this.l_sector_comercial.ForeColor = color;
            this.l_sector_comercial.Font = fuente;
            this.l_tipo_documento.ForeColor = color;
            this.l_tipo_documento.Font = fuente;
            this.l_num_documento.ForeColor = color;
            this.l_num_documento.Font = fuente;
            this.l_direccion.ForeColor = color;
            this.l_direccion.Font = fuente;
            this.l_telefono.ForeColor = color;
            this.l_telefono.Font = fuente;
            this.l_email.ForeColor = color;
            this.l_email.Font = fuente;
            this.l_url.ForeColor = color;
            this.l_url.Font = fuente;

            this.txt_codigo_proveedor.Font = fuente;
            this.txt_codigo_proveedor.ForeColor = color;
            this.txt_razon_social.ForeColor = color;
            this.txt_razon_social.Font = fuente;
            this.txt_sector_comercial.ForeColor = color;
            this.txt_sector_comercial.Font = fuente;
            this.cb_tipo_documento.Font = fuente;
            this.txt_num_documento.ForeColor = color;
            this.txt_num_documento.Font = fuente;
            this.txt_direccion.ForeColor = color;
            this.txt_direccion.Font = fuente;
            this.txt_telefono.ForeColor = color;
            this.txt_telefono.Font = fuente;
            this.txt_email.ForeColor = color;
            this.txt_email.Font = fuente;
            this.txt_busq_url.ForeColor = color;
            this.txt_busq_url.Font = fuente;



        }


        private void cambia_tamano_pag_2(Color color,Font fuente)
        {
            this.l_busq_codigo_proveedor.ForeColor = color;
            this.l_busq_codigo_proveedor.Font = fuente;
            this.l_busq_razon_social.ForeColor = color;
            this.l_busq_sector.ForeColor = color;
            this.l_busq_sector.Font = fuente;
            this.l_busq_razon_social.Font = fuente;
            this.l_busq_tipo_documento.ForeColor = color;
            this.l_busq_tipo_documento.Font = fuente;
            this.l_busq_num_documento.ForeColor = color;
            this.l_busq_num_documento.Font = fuente;
            this.l_busq_direccion.ForeColor = color;
            this.l_busq_direccion.Font = fuente;
            this.l_busq_telefono.ForeColor = color;
            this.l_busq_telefono.Font = fuente;
            this.l_busq_email.ForeColor = color;
            this.l_busq_email.Font = fuente;
            this.l_busq_url.ForeColor = color;
            this.l_busq_url.Font = fuente;

            this.txt_busq_codigo_proveedor.Font = fuente;
            this.txt_busq_razon_social.Font = fuente;
            this.txt_busq_sector.Font = fuente;
            this.cb_busq_tipo_documento.Font = fuente;
            this.txt_busq_num_documento.Font = fuente;
            this.txt_busq_direccion.Font = fuente;
            this.txt_busq_telefono.Font = fuente;
            this.txt_busq_email.Font = fuente;
            this.txt_busq_url.Font = fuente;


        }


      

        



        // MOUSE HOVER 
        private void btn_cargar_MouseEnter(object sender, EventArgs e)
        {
            this.btn_cargar.BackColor = Color.Lime;
            this.btn_cargar.ForeColor = Color.Black;
        }

        private void btn_cargar_MouseLeave(object sender, EventArgs e)
        {
            this.btn_cargar.BackColor = Color.Black;
            this.btn_cargar.ForeColor = Color.Lime;
        }

        private void btn_limpiar_MouseEnter(object sender, EventArgs e)
        {
            this.btn_limpiar.BackColor = Color.Red;
            this.btn_limpiar.ForeColor = Color.Black;
        }

        private void btn_limpiar_MouseLeave(object sender, EventArgs e)
        {
            this.btn_limpiar.BackColor = Color.Black;
            this.btn_limpiar.ForeColor = Color.Red;
        }

        private void btn_cancelar_MouseEnter(object sender, EventArgs e)
        {
            this.btn_cancelar.BackColor = Color.Yellow;
            this.btn_cancelar.ForeColor = Color.Black;
        }

        private void btn_cancelar_MouseLeave(object sender, EventArgs e)
        {
            this.btn_cancelar.BackColor = Color.Black;
            this.btn_cancelar.ForeColor = Color.Yellow;
        }

        private void btn_eliminar_MouseEnter(object sender, EventArgs e)
        {
            this.btn_eliminar.BackColor = Color.Yellow;
            this.btn_eliminar.ForeColor = Color.Black;
        }

        private void btn_eliminar_MouseLeave(object sender, EventArgs e)
        {
            this.btn_eliminar.BackColor = Color.Black;
            this.btn_eliminar.ForeColor = Color.Yellow;
        }

        private void btn_editar_MouseEnter(object sender, EventArgs e)
        {
            this.btn_editar.BackColor = Color.Yellow;
            this.btn_editar.ForeColor = Color.Black;
        }

        private void btn_editar_MouseLeave(object sender, EventArgs e)
        {
            this.btn_editar.BackColor = Color.Black;
            this.btn_editar.ForeColor = Color.Yellow;
        }

        private void btn_nuevo_MouseEnter(object sender, EventArgs e)
        {
            this.btn_nuevo.BackColor = Color.Yellow;
            this.btn_nuevo.ForeColor = Color.Black;
          
        }

        private void btn_nuevo_MouseLeave(object sender, EventArgs e)
        {
            this.btn_nuevo.BackColor = Color.Black;
            this.btn_nuevo.ForeColor = Color.Yellow;

           
        }

        private void pict_next_MouseEnter(object sender, EventArgs e)
        {
            this.pict_next.Image = capa_presentacion.Properties.Resources.next_mediano_verde;
        }

        private void pict_next_MouseLeave(object sender, EventArgs e)
        {
            this.pict_next.Image = capa_presentacion.Properties.Resources.next_grande_naranja;

        }

        

        private void pict_next_Click(object sender, EventArgs e)
        {

            id_pagina = 2;
             
                this.panel_corousell.Controls.Clear();
                this.panel_corousell.Controls.Add(panel_pagina_2);
                this.panel_pagina_2.Show();
                
            
        }

        private void btn_buscar_MouseEnter(object sender, EventArgs e)
        {
            this.btn_buscar.BackColor = Color.DarkOrange;
            this.btn_buscar.ForeColor = Color.Black;
        }

        private void btn_buscar_MouseLeave(object sender, EventArgs e)
        {
            this.btn_buscar.BackColor = Color.Black;
            this.btn_buscar.ForeColor = Color.DarkOrange;
        }
        
        

        public int dame_pagina()
        {
            return id_pagina;
        }

        private void pict_back_MouseEnter_1(object sender, EventArgs e)
        {
            this.pict_back.Image = capa_presentacion.Properties.Resources.back_mediano_verde;
        }

        private void pict_back_MouseLeave(object sender, EventArgs e)
        {
            this.pict_back.Image = capa_presentacion.Properties.Resources.back_grande_naranja;

        }

        private void pict_back_Click(object sender, EventArgs e)
        {
            id_pagina = 1;

            this.panel_pagina_2.Hide();
            this.panel_corousell.Controls.Clear();

            this.panel_lateral.Controls.Add(this.panel_imagen_cargar);
            this.panel_lateral.Dock = DockStyle.Left;

            this.panel_derecha.Controls.Add(this.table_proveedores);
            this.panel_derecha.Dock = DockStyle.Left;

            this.panel_corousell.Controls.Add(this.panel_derecha);
            this.panel_corousell.Controls.Add(this.panel_lateral);

        }

        private void data_listado_Click(object sender, EventArgs e)
        {
            this.panel_hover.Show();
        }

        private void btn_ocultar_Click(object sender, EventArgs e)
        {
            this.panel_hover.Hide();
        }

        private void btn_ocultar_MouseEnter(object sender, EventArgs e)
        {
            this.btn_ocultar.BackColor = Color.Aqua;
            this.btn_ocultar.ForeColor = Color.Black;
        }

        private void btn_ocultar_MouseLeave(object sender, EventArgs e)
        {
            this.btn_ocultar.BackColor = Color.Black;
            this.btn_ocultar.ForeColor = Color.Aqua;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
