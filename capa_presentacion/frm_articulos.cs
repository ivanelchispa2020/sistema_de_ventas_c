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
    public partial class frm_articulos : Form
    {

        public static frm_articulos _instancia;
        private bool tamano;
        public int id_pagina;
        private bool mi_panel_oculto;



        public static frm_articulos dame_instancia(bool tamano, bool panel_oculto)
        {
            if (_instancia == null)
            {
                _instancia = new frm_articulos(tamano, panel_oculto);

            }

            return _instancia;

        }


        public frm_articulos(bool tamano, bool panel_oculto)
        {
            InitializeComponent();
            this.tamano = tamano;
           
            panel_pagina_2.Hide();
            panel_hover.Hide();

            id_pagina = 1;


        }



        public frm_articulos()
        {
            InitializeComponent();
        }


        public void gestiona_ventana(bool estado)
        {
            if (estado)
            {

                this.BackgroundImage = capa_presentacion.Properties.Resources.fondo_frm_articulos;
                cambia_tamano(Color.White, new Font("Comic Sans MS", 18, FontStyle.Bold));
                cambia_tamano_pag_2(Color.White, new Font("Comic Sans MS", 13, FontStyle.Bold));
                this.txt_descripcion.Size = new Size(350, 200);

            }
            else
            {

                this.BackgroundImage = capa_presentacion.Properties.Resources.frm_articulos_2;
                cambia_tamano(Color.White, new Font("Comic Sans MS", 11, FontStyle.Bold));
                cambia_tamano_pag_2(Color.White, new Font("Comic Sans MS", 11, FontStyle.Bold));
                this.txt_descripcion.Size = new Size(200, 130);
            }



        }

        private void cambia_tamano(Color color, Font fuente)
        {

            // LABELS
            this.l_codigo_art.ForeColor = color;
            this.l_codigo_art.Font = fuente;
            this.l_codigo.ForeColor = color;
            this.l_codigo.Font = fuente;
            this.l_nombre.ForeColor = color;
            this.l_nombre.Font = fuente;
            this.l_seccion.ForeColor = color;
            this.l_seccion.Font = fuente;
            this.l_descripcion.ForeColor = color;
            this.l_descripcion.Font = fuente;
            this.l_categoria.ForeColor = color;
            this.l_categoria.Font = fuente;
            this.l_presentacion.ForeColor = color;
            this.l_presentacion.Font = fuente;

            // CAJAS DE TEXTO
            this.txt_id_articulo.Font = fuente;
            this.txt_codigo_articulo.Font = fuente;
            this.txt_nombre.Font = fuente;
            this.cb_seccion.Font = fuente;
            this.txt_descripcion.Font = fuente;
            this.txt_categoria.Font = fuente;
            this.txt_presentacion.Font = fuente;
            

        }


        private void cambia_tamano_pag_2(Color color, Font fuente)
        {

            // LABELS
            this.l_busq_codigo_proveedor.ForeColor = color;
            this.l_busq_codigo_proveedor.Font = fuente;
            this.l_busq_codigo.ForeColor = color;
            this.l_busq_codigo.Font = fuente;
            this.l_busq_nombre.ForeColor = color;
            this.l_busq_nombre.Font = fuente;
            this.l_busq_seccion.ForeColor = color;
            this.l_busq_seccion.Font = fuente;
            this.l_busq_descripcion.ForeColor = color;
            this.l_busq_descripcion.Font = fuente;
            this.l_busq_categoria.ForeColor = color;
            this.l_busq_categoria.Font = fuente;
            this.l_busq_presentacion.ForeColor = color;
            this.l_busq_presentacion.Font = fuente;

            // CAJAS DE TEXTO
            this.txt_busqueda.Font = fuente;
            this.txt_busq_codigo_articulo.Font = fuente;
            this.txt_busq_codigo.Font = fuente;
            this.txt_busq_nombre.Font = fuente;
            this.txt_busq_descripcion.Font = fuente;
            this.txt_busq_categoria.Font = fuente;
            this.txt_busq_presentacion.Font = fuente;


        }

        // BOTONES HOVER
        private void btn_cancelar_MouseEnter(object sender, EventArgs e)
        {
            this.btn_cancelar.BackColor = Color.Aqua;
            this.btn_cancelar.ForeColor = Color.Black;
        }

        private void btn_cancelar_MouseLeave(object sender, EventArgs e)
        {
            this.btn_cancelar.BackColor = Color.Black;
            this.btn_cancelar.ForeColor = Color.Aqua;

        }

        private void btn_eliminar_MouseEnter(object sender, EventArgs e)
        {
            this.btn_eliminar.BackColor = Color.Aqua;
            this.btn_eliminar.ForeColor = Color.Black;
        }

        private void btn_eliminar_MouseLeave(object sender, EventArgs e)
        {
            this.btn_eliminar.BackColor = Color.Black;
            this.btn_eliminar.ForeColor = Color.Aqua;
        }

        private void btn_editar_MouseEnter(object sender, EventArgs e)
        {
            this.btn_editar.BackColor = Color.Aqua;
            this.btn_editar.ForeColor = Color.Black;
        }

        private void btn_editar_MouseLeave(object sender, EventArgs e)
        {
            this.btn_editar.BackColor = Color.Black;
            this.btn_editar.ForeColor = Color.Aqua;
        }

        private void btn_nuevo_MouseEnter(object sender, EventArgs e)
        {
            this.btn_nuevo.BackColor = Color.Aqua;
            this.btn_nuevo.ForeColor = Color.Black;
        }

        private void btn_nuevo_MouseLeave(object sender, EventArgs e)
        {
            this.btn_nuevo.BackColor = Color.Black;
            this.btn_nuevo.ForeColor = Color.Aqua;
        
         }

        private void btn_buscar_MouseEnter(object sender, EventArgs e)
        {
            this.btn_buscar.BackColor = Color.OrangeRed;
            this.btn_buscar.ForeColor = Color.Black;
        }

        private void btn_buscar_MouseLeave(object sender, EventArgs e)
        {
            this.btn_buscar.BackColor = Color.Black;
            this.btn_buscar.ForeColor = Color.OrangeRed;
        }

        private void btn_ocultar_MouseEnter_1(object sender, EventArgs e)
        {
            this.btn_ocultar.BackColor = Color.White;
            this.btn_ocultar.ForeColor = Color.Black;
        }

        private void btn_ocultar_MouseLeave_1(object sender, EventArgs e)
        {
            this.btn_ocultar.BackColor = Color.Black;
            this.btn_ocultar.ForeColor = Color.White;

        }


        // IMAGENES HOVER
        private void pict_back_MouseEnter(object sender, EventArgs e)
        {
            this.pict_back.Image= capa_presentacion.Properties.Resources.back_mediano_verde; 
        }

        private void pict_back_MouseLeave(object sender, EventArgs e)
        {
            this.pict_back.Image = capa_presentacion.Properties.Resources.back_grande_naranja;
        }

        private void pict_next_MouseEnter(object sender, EventArgs e)
        {
        this.pict_next.Image = capa_presentacion.Properties.Resources.next_mediano_verde;

        }

        private void pict_next_MouseLeave(object sender, EventArgs e)
        {
            this.pict_next.Image = capa_presentacion.Properties.Resources.next_grande_naranja;

        }


        // CLICK IMAGEN PAGINACION

        private void pict_next_Click(object sender, EventArgs e)
        {
            id_pagina = 2;

            this.panel_corousell.Controls.Clear();
            this.panel_corousell.Controls.Add(panel_pagina_2);
            this.panel_pagina_2.Show();

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





        // CLICK DATALISTADO
        private void data_listado_Click(object sender, EventArgs e)
        {
            this.panel_hover.Show();
        }


        // CLICK BOTONES
        private void btn_ocultar_Click(object sender, EventArgs e)
        {
            this.panel_hover.Hide();
        }

        
    }
}
