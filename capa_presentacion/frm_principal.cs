using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Speech.Synthesis;
using System.Threading;




namespace capa_presentacion
{
    public partial class frm_principal : Form
    {
        private int childFormNumber = 0;

        /// PARA LOS DATOS DEL USUARIO  IMPRESOS EN PANTALA
        public int id_trabajador = 0; 
        public string nombre = "";
        public string apellidos = "";
        public string email = "";
        public string usuario = "";
        public string acceso = "";


        // PARA GESTIONAR LOS FORMULARIOS
        private bool frm_ventana_ingreso = false;
        private bool frm_ventana_proveedor = false;


        // CONTATORES NECESARIOS PARA LA PAGINACION
        public static int id_numero_pagina=0;
        public static int id_numero_pagina_grande = 1;
        public static int contador_loading = 0;
        public int id_pagina_frm_proveedores = 1;

        // PARA GESTIONAR  EL ESTADO DE LAS VENTANAS DE LOS FORMULARIOS
        private bool estado_ventana = false;
        public  int mi_formulario;

        // PARA LA BIENVENIDA Y EL ADIOS
        private SpeechSynthesizer audio;


        // HILOS 
        private Thread hilo_1;
        private Thread hilo_2;
        private Thread hilo_form_loading;
        private Thread hilo_form_loading_2;
       

        public frm_principal()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }



        // LOS DEJO PORQUE PUEDEN SER UTILES MAS ADELANTE
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }


        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); //// CIERRA PROGRAMA
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void presentacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void articuloToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void trabajadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private String dame_mes(int mes)
        {

            String[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            return meses[mes];

        }

        private void ingresoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frm_principal_FormClosing(object sender, FormClosingEventArgs e)
        {

            try
            {
                audio.Speak("que tengas un buen dia " + this.nombre + " " + this.apellidos);
            }
            catch (Exception ex)
            { }


        }

        private void frm_principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }


        private void pict_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pict_maximizar_Click(object sender, EventArgs e)
        {
            this.estado_ventana = true;
            if (mi_formulario == 1)
            {
                mi_formulario = 2;
            }

          

            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gestiona_formularios_ventana(mi_formulario, true,true);
        }


        private void pict_normal_Click(object sender, EventArgs e)
        {
            this.estado_ventana = false;

            if (mi_formulario == 2)
            {
                mi_formulario = 1;
            }


            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.gestiona_formularios_ventana(mi_formulario, false,true);


            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;



        }

        private void pict_minimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
          

        }


        private void pict_minimizar_MouseEnter(object sender, EventArgs e)
        {
            this.pict_minimizar.BackColor = Color.DarkRed;
            this.pict_minimizar.Refresh();
        }

        private void pict_minimizar_MouseLeave(object sender, EventArgs e)
        {
            this.pict_minimizar.BackColor = Color.Transparent;
            this.pict_minimizar.Refresh();
        }

        private void pict_normal_MouseEnter(object sender, EventArgs e)
        {
            this.pict_normal.BackColor = Color.DarkRed;
            this.pict_normal.Refresh();

        }

        private void pict_normal_MouseLeave(object sender, EventArgs e)
        {
            this.pict_normal.BackColor = Color.Transparent;
            this.pict_normal.Refresh();
        }

        private void pict_maximizar_MouseEnter(object sender, EventArgs e)
        {
            this.pict_maximizar.BackColor = Color.DarkRed;
            this.pict_maximizar.Refresh();
        }

        private void pict_maximizar_MouseLeave(object sender, EventArgs e)
        {
            this.pict_maximizar.BackColor = Color.Transparent;
            this.pict_maximizar.Refresh();

        }

        private void pict_salir_MouseEnter(object sender, EventArgs e)
        {
            this.pict_salir.BackColor = Color.DarkRed;
            this.pict_salir.Refresh();

        }

        private void pict_salir_MouseLeave(object sender, EventArgs e)
        {
            this.pict_salir.BackColor = Color.Transparent;
            this.pict_salir.Refresh();
        }

        private void l_usuario_MouseEnter(object sender, EventArgs e)
        {

            this.panel_identificacion.Show();
            this.l_usuario.ForeColor = Color.Lime;
        }

        private void l_usuario_MouseLeave(object sender, EventArgs e)
        {
            this.panel_identificacion.Hide();
            this.l_usuario.ForeColor = Color.Black;
        }

        private void pict_menu_close_MouseEnter(object sender, EventArgs e)
        {

            pict_menu_close.Image = capa_presentacion.Properties.Resources.menu_abierto;
            pict_menu_close.Refresh();
        }

        private void pict_menu_close_MouseLeave(object sender, EventArgs e)
        {
            pict_menu_close.Image = capa_presentacion.Properties.Resources.menu_cerrado;
            pict_menu_close.Refresh();
        }

        private void pict_menu_close_logo_MouseEnter(object sender, EventArgs e)
        {
            pict_menu_close_logo.Image = capa_presentacion.Properties.Resources.menu_abierto;
            pict_menu_close_logo.Refresh();

        }

        private void pict_menu_close_logo_MouseLeave(object sender, EventArgs e)
        {
            pict_menu_close_logo.Image = capa_presentacion.Properties.Resources.menu_cerrado;
            pict_menu_close_logo.Refresh();
        }

        private void pict_menu_close_Click(object sender, EventArgs e)
        {
            this.panel_iconos.Hide();
            this.panel_lateral.Show();
            
            

        }

        private void pict_menu_close_logo_Click(object sender, EventArgs e)
        {

            if (this.WindowState == System.Windows.Forms.FormWindowState.Normal)
            {
                this.panel_iconos.Show();
                this.panel_lateral.Hide();
                this.panel_formularios.Refresh();
            }



            


        }

        private void pict_icono_compras_MouseEnter(object sender, EventArgs e)
        {
            pict_icono_compras.Image = capa_presentacion.Properties.Resources.compras_icono_verde;
            pict_icono_compras.Refresh();

        }

        private void pict_icono_compras_MouseLeave(object sender, EventArgs e)
        {
            pict_icono_compras.Image = capa_presentacion.Properties.Resources.compras_icono_naranja;
            pict_icono_compras.Refresh();
        }

        private void pict_icono_almacen_MouseEnter(object sender, EventArgs e)
        {
            pict_icono_almacen.Image = capa_presentacion.Properties.Resources.almacen_logo_verde;
            pict_icono_almacen.Refresh();

        }

        private void pict_icono_almacen_MouseLeave(object sender, EventArgs e)
        {
            pict_icono_almacen.Image = capa_presentacion.Properties.Resources.almacen_logo_naranja;
            pict_icono_almacen.Refresh();

        }

        private void pict_icono_venta_MouseEnter(object sender, EventArgs e)
        {
            pict_icono_venta.Image = capa_presentacion.Properties.Resources.ventas_icono_verde;
            pict_icono_almacen.Refresh();
        }

        private void pict_icono_venta_MouseLeave(object sender, EventArgs e)
        {
            pict_icono_venta.Image = capa_presentacion.Properties.Resources.ventas_icono_naranja;
            pict_icono_almacen.Refresh();

        }

        private void pict_icono_mantenimiento_MouseEnter(object sender, EventArgs e)
        {
            pict_icono_mantenimiento.Image = capa_presentacion.Properties.Resources.mantenimiento_logo_verde;
            pict_icono_mantenimiento.Refresh();

        }

        private void pict_icono_mantenimiento_MouseLeave(object sender, EventArgs e)
        {
            pict_icono_mantenimiento.Image = capa_presentacion.Properties.Resources.mantenimiento_logo_naranja;
            pict_icono_mantenimiento.Refresh();

        }

        private void pict_icono_consulta_MouseEnter(object sender, EventArgs e)
        {
            pict_icono_consulta.Image = capa_presentacion.Properties.Resources.presentation_icono_verde;
            pict_icono_consulta.Refresh();

        }

        private void pict_icono_consulta_MouseLeave(object sender, EventArgs e)
        {
            pict_icono_consulta.Image = capa_presentacion.Properties.Resources.presentation_icono_naranja;
            pict_icono_consulta.Refresh();

        }

        private void pict_base_datos_MouseEnter(object sender, EventArgs e)
        {
            pict_base_datos.Image = capa_presentacion.Properties.Resources.base_de_datos_icono_verde;
            pict_base_datos.Refresh();

        }

        private void pict_base_datos_MouseLeave(object sender, EventArgs e)
        {
            pict_base_datos.Image = capa_presentacion.Properties.Resources.base_de_datos_icono_naranja;
            pict_base_datos.Refresh();
        }

        private void pict_soporte_tecnico_MouseEnter(object sender, EventArgs e)
        {
            pict_soporte_tecnico.Image = capa_presentacion.Properties.Resources.soporte_tecnico_verde;
            pict_soporte_tecnico.Refresh();

        }

        private void pict_soporte_tecnico_MouseLeave(object sender, EventArgs e)
        {
            pict_soporte_tecnico.Image = capa_presentacion.Properties.Resources.soporte_tecnico_naranja;
            pict_soporte_tecnico.Refresh();

        }

        private void pict_menu_grande_MouseEnter(object sender, EventArgs e)
        {
            pict_menu_grande.Image = capa_presentacion.Properties.Resources.menu_abierto;
            pict_menu_grande.Refresh();

        }

        private void pict_menu_grande_MouseLeave(object sender, EventArgs e)
        {
            pict_menu_grande.Image = capa_presentacion.Properties.Resources.menu_cerrado;
            pict_menu_grande.Refresh();

        }

        private void pict_next_grande_MouseEnter(object sender, EventArgs e)
        {
            pict_next_grande.Image = capa_presentacion.Properties.Resources.next_grande_naranja;
            pict_next_grande.Refresh();

        }

        private void pict_next_grande_MouseLeave(object sender, EventArgs e)
        {
            pict_next_grande.Image = capa_presentacion.Properties.Resources.next2;
            pict_next_grande.Refresh();

        }

        private void pict_home_grande_MouseEnter(object sender, EventArgs e)
        {
            pict_home_grande.Image = capa_presentacion.Properties.Resources.main_grande_naranja;
            pict_home_grande.Refresh();

        }

        private void pict_home_grande_MouseLeave(object sender, EventArgs e)
        {
            pict_home_grande.Image = capa_presentacion.Properties.Resources.main;
            pict_home_grande.Refresh();

        }

        private void pict_back_grande_MouseEnter(object sender, EventArgs e)
        {
            pict_back_grande.Image = capa_presentacion.Properties.Resources.back_grande_naranja;
            pict_back_grande.Refresh();

        }

        private void pict_back_grande_MouseLeave(object sender, EventArgs e)
        {
            pict_back_grande.Image = capa_presentacion.Properties.Resources.back;
            pict_back_grande.Refresh();

        }

        private void pict_mediano_back_MouseEnter(object sender, EventArgs e)
        {
            pict_mediano_back.Image = capa_presentacion.Properties.Resources.back_mediano_verde;
            pict_mediano_back.Refresh();


        }

        private void pict_mediano_back_MouseLeave(object sender, EventArgs e)
        {
            pict_mediano_back.Image = capa_presentacion.Properties.Resources.back_grande_naranja;
            pict_mediano_back.Refresh();

        }

        private void pict_mediano_next_MouseEnter(object sender, EventArgs e)
        {
            pict_mediano_next.Image = capa_presentacion.Properties.Resources.next_mediano_verde;
            pict_mediano_next.Refresh();

        }

        private void pict_mediano_next_MouseLeave(object sender, EventArgs e)
        {
            pict_mediano_next.Image = capa_presentacion.Properties.Resources.next_grande_naranja;
            pict_mediano_next.Refresh();

        }


        private void panel_formulario_1_MouseEnter(object sender, EventArgs e)
        {

            this.panel_formulario_1.BackgroundImage = capa_presentacion.Properties.Resources.degradado_fondo_1;
            this.l_titulo_grande_1.ForeColor = Color.Lime;

        }

        private void panel_formulario_1_MouseLeave(object sender, EventArgs e)
        {

            this.panel_formulario_1.BackgroundImage = null;
            this.l_titulo_grande_1.ForeColor = Color.DarkOrange;

        }

        private void panel_formulario_2_MouseEnter(object sender, EventArgs e)
        {
            this.panel_formulario_2.BackgroundImage = capa_presentacion.Properties.Resources.degradado_fondo_1;
            this.l_titulo_grande_2.ForeColor = Color.Lime;

        }

        private void panel_formulario_2_MouseLeave(object sender, EventArgs e)
        {

            this.panel_formulario_2.BackgroundImage = null;
            this.l_titulo_grande_2.ForeColor = Color.DarkOrange;


        }

        private void panel_formulario_3_MouseEnter(object sender, EventArgs e)
        {
            this.panel_formulario_3.BackgroundImage = capa_presentacion.Properties.Resources.degradado_fondo_1;
            this.l_titulo_grande_3.ForeColor = Color.Lime;

        }

        private void panel_formulario_3_MouseLeave(object sender, EventArgs e)
        {
            this.panel_formulario_3.BackgroundImage = null;
            this.l_titulo_grande_3.ForeColor = Color.DarkOrange;

        }


        private void pict_next_grande_Click(object sender, EventArgs e)
        {
            id_numero_pagina_grande += 1;
            if (id_numero_pagina_grande > 4)
            {
                id_numero_pagina_grande = 1;
            }
            this.gestiona_menu_grande();

        }

        private void pict_back_grande_Click(object sender, EventArgs e)
        {
            id_numero_pagina_grande -= 1;
            if (id_numero_pagina_grande < 1)
            {
                id_numero_pagina_grande = 4;
            }
            this.gestiona_menu_grande();
        }

        private void pict_home_grande_Click(object sender, EventArgs e)
        {
            id_numero_pagina_grande = 1;
            this.gestiona_menu_grande();
        }

        private void pict_formulario_grande_1_MouseEnter(object sender, EventArgs e)
        {
            this.panel_formulario_1.BackgroundImage = capa_presentacion.Properties.Resources.degradado_fondo_1;
            this.l_titulo_grande_1.ForeColor = Color.Lime;
        }

        private void pict_formulario_grande_1_MouseLeave(object sender, EventArgs e)
        {
            this.panel_formulario_1.BackgroundImage = capa_presentacion.Properties.Resources.degradado;
            this.l_titulo_grande_1.ForeColor = Color.DarkOrange;
        }

        private void l_titulo_grande_1_MouseEnter(object sender, EventArgs e)
        {
            this.panel_formulario_1.BackgroundImage = capa_presentacion.Properties.Resources.degradado_fondo_1;
            this.l_titulo_grande_1.ForeColor = Color.Lime;

        }

        private void l_titulo_grande_1_MouseLeave(object sender, EventArgs e)
        {
            this.panel_formulario_1.BackgroundImage = capa_presentacion.Properties.Resources.degradado;
            this.l_titulo_grande_1.ForeColor = Color.DarkOrange;
        }

        private void pict_formulario_grande_2_MouseEnter(object sender, EventArgs e)
        {
            this.panel_formulario_2.BackgroundImage = capa_presentacion.Properties.Resources.degradado_fondo_1;
            this.l_titulo_grande_2.ForeColor = Color.Lime;

        }

        private void pict_formulario_grande_2_MouseLeave(object sender, EventArgs e)
        {
            this.panel_formulario_2.BackgroundImage = capa_presentacion.Properties.Resources.degradado;
            this.l_titulo_grande_2.ForeColor = Color.DarkOrange;

        }

        private void l_titulo_grande_2_MouseEnter(object sender, EventArgs e)
        {
            this.panel_formulario_2.BackgroundImage = capa_presentacion.Properties.Resources.degradado_fondo_1;
            this.l_titulo_grande_2.ForeColor = Color.Lime;

        }

        private void l_titulo_grande_2_MouseLeave(object sender, EventArgs e)
        {
            this.panel_formulario_2.BackgroundImage = capa_presentacion.Properties.Resources.degradado;
            this.l_titulo_grande_2.ForeColor = Color.DarkOrange;

        }

        private void pict_formulario_grande_3_MouseEnter(object sender, EventArgs e)
        {
            this.panel_formulario_3.BackgroundImage = capa_presentacion.Properties.Resources.degradado_fondo_1;
            this.l_titulo_grande_3.ForeColor = Color.Lime;

        }

        private void pict_formulario_grande_3_MouseLeave(object sender, EventArgs e)
        {
            this.panel_formulario_3.BackgroundImage = capa_presentacion.Properties.Resources.degradado;
            this.l_titulo_grande_3.ForeColor = Color.DarkOrange;

        }

        private void l_titulo_grande_3_MouseEnter(object sender, EventArgs e)
        {
            this.panel_formulario_3.BackgroundImage = capa_presentacion.Properties.Resources.degradado_fondo_1;
            this.l_titulo_grande_3.ForeColor = Color.Lime;

        }

        private void l_titulo_grande_3_MouseLeave(object sender, EventArgs e)
        {
            this.panel_formulario_3.BackgroundImage = capa_presentacion.Properties.Resources.degradado;
            this.l_titulo_grande_3.ForeColor = Color.DarkOrange;

        }

        private void btn_ir_a_mediano_MouseEnter(object sender, EventArgs e)
        {
            this.btn_ir_a_mediano.BackColor = Color.White;
            this.btn_ir_a_mediano.ForeColor = Color.OrangeRed;
        }

        private void btn_ir_a_mediano_MouseLeave(object sender, EventArgs e)
        {
            this.btn_ir_a_mediano.BackColor = Color.OrangeRed;
            this.btn_ir_a_mediano.ForeColor = Color.White;

        }

        private void saludo()
        {
            try
            {
                audio = new SpeechSynthesizer();
                audio.Speak("Bienvenido " + this.nombre + "  " + this.apellidos);
                audio.Speak("Hoy es " + DateTime.Now.Day.ToString() + " del " + dame_mes(DateTime.Now.Month - 1) + " de " + DateTime.Now.Year.ToString() + ".");
                audio.Speak("Y son las " + DateTime.Now.Hour.ToString() + " con " + DateTime.Now.Minute.ToString() + " minutos y " + DateTime.Now.Second.ToString() + " segundos.");

            }
            catch (Exception ex)
            {

            }
        }




        /// ************************************ 
        // EVENTO LOAD
        private void frm_principal_Load(object sender, EventArgs e)
        {

            // CONTADOR PARA LA PAGINACION
            contador_loading++;

            // EJECUTO LOS HILOS
            hilo_1 = new Thread(saludo);
            hilo_1.Start();

            hilo_2 = new Thread(gestiona_usuario);
            hilo_2.Start();

            // PARA LOS DATOS DEL USUARIO
            this.l_usuario.Text = nombre + " " + apellidos;
            this.l_acceso.Text = acceso;
            this.l_usuario_2.Text = usuario;
            this.l_email.Text = email;
            this.l_nombres.Text = nombre + " " + apellidos;
            this.l_puesto.Text = acceso;


            // PARA LA PRESENTACION
            this.l_dia.Text = "Hoy es " + DateTime.Now.Day.ToString() + " de " + dame_mes(DateTime.Now.Month - 1) + " del " + DateTime.Now.Year.ToString() + ".";
            this.panel_identificacion.Hide();



            // PARA LOS MENUS 
            gestiona_menu_mediano();
            gestiona_menu_grande();

            
            // MENSAJES DE AYUDA
            this.t_mensaje.SetToolTip(pict_icono_compras,"Compras");
            this.t_mensaje.SetToolTip(pict_icono_almacen, "Almacen");
            this.t_mensaje.SetToolTip(pict_icono_consulta, "Consulta");
            this.t_mensaje.SetToolTip(pict_icono_mantenimiento, "Mantenimiento");
            this.t_mensaje.SetToolTip(pict_icono_venta, "Venta");
            this.t_mensaje.SetToolTip(pict_base_datos, "Base e datos");
            this.t_mensaje.SetToolTip(pict_soporte_tecnico, "Soporte Tecnico");


            // FORMULARIO POR DEFECTO 
            mi_formulario = 1;
            this.id_formulario(1);
            gestiona_formularios_ventana(1,true,false); 

        }


        




        private void gestiona_usuario()
        {



            // GESTIONO ACCESO DE USUARIOS 
            // HABILITANDO Y DESABILITANDO BOTONES Y MENUS

        }

        
        private void frm_principal_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == System.Windows.Forms.FormWindowState.Normal)
            {

               
                this.hilo_form_loading = new Thread(carga_frm_loading);
                hilo_form_loading.Start();

                
                this.normaliza_ventana();


                estado_ventana = false;
              
            }
            else
            {

                this.hilo_form_loading_2 = new Thread(carga_frm_loading_2);
                hilo_form_loading_2.Start();

                this.maximiza_ventana();

                estado_ventana = true;
                
            }
        }

        private void normaliza_ventana()
        {

            this.panel_formularios.Controls.Clear();

         

            this.panel_top.Hide();
            this.panel_iconos.Show();
            this.panel_lateral.Hide();
            this.panel_lateral_grande.Hide();
            this.panel_abajo.BackColor = Color.Black;
            this.panel_lateral.BackColor = Color.Black;
            this.panel_lateral.BackgroundImage = capa_presentacion.Properties.Resources.degradado_4; ;
            this.l_dia.Hide();
            this.l_acceso_l.Show();
            this.l_acceso_text.Show();
            this.l_acceso_text.Text = this.acceso;
            this.l_usuario_l.Show();
            this.l_usuario_text.Show();
            this.l_usuario_text.Text = this.nombre + " " + this.apellidos;


        }


        private void maximiza_ventana()
        {

            this.panel_formularios.Controls.Clear();

         
            this.panel_top.Show();
            this.panel_iconos.Hide();
            this.panel_lateral.Hide();
            this.panel_lateral_grande.Show();
            this.panel_abajo.BackColor = Color.White;
            this.panel_lateral.BackgroundImage = null;
            this.panel_lateral.BackColor = Color.White;
            this.l_dia.Show();
            this.l_acceso_l.Hide();
            this.l_acceso_text.Hide();
            this.l_usuario_l.Hide();
            this.l_usuario_text.Hide();

        }

        private void carga_frm_loading()
        {

            estado_ventana = false;

            if (contador_loading <= 1)
            {
                frm_cargando frm = new frm_cargando();
                frm.WindowState = FormWindowState.Normal;

                frm.ShowDialog();
                contador_loading++;
            }
            else
            {
                frm_cargando frm = new frm_cargando();
                frm.ShowDialog();

            }

        }


        private void carga_frm_loading_2()
        {
   
                frm_cargando_2 frm = new frm_cargando_2();
                frm.ShowDialog();

       

        }



        ////// METODOS PROPIOS 

        private void gestiona_menu_mediano() {

            string[] nombres = {"Ingresos","Proveedores","Articulos","Categorias","Presentación","Ventas","Clientes","Trabajadores","Consultas","Base de datos","Soporte Tecnico" };
            string[] descripcion = {"Provee un conjunto de Herramientas para por gestionar el ingreso de mercaderias al sistema.",
                                         "Permite llevar un registro de los Proveedores que existen registrados en el sistema como asi tambien una vision detallada de los mismos.",
                                         "Gestiona los Articulos que ingresan y egresan del Sistema.",
                                         "Accede a una descripción de los Categorias en donde se agrupan los diferentes Articulos para tener una visión más global de los mismos.",
                                         "Permite tener una presentacion de los ventas.",
                                         "Administre las ventas que suceden en la empresa.",
                                         "Permite llevar un registro de los Clientes que existen registrados en el sistema como asi tambien una vision detallada de los mismos.",
                                         "Permite llevar un registro de los Trabajadores que existen registrados en el sistema como asi tambien una vision detallada de los mismos.",
                                         "Accede a las diversas consultas prediceñadas para visualizar lainformación.",
                                         "Gestiona la base de datos  para poder realizar operaciones de control y Backup",
                                         "Brinda información sobre las formas de contactarse con los encargados del Sistema."
            };

            Image[] imagenes = { capa_presentacion.Properties.Resources.ingreso1,
                                    capa_presentacion.Properties.Resources.proveedores,
                                    capa_presentacion.Properties.Resources.articulo1,
                                    capa_presentacion.Properties.Resources.categoria1,
                                    capa_presentacion.Properties.Resources.presentacion1,
                                    capa_presentacion.Properties.Resources.ventas1,
                                    capa_presentacion.Properties.Resources.cliente1,
                                    capa_presentacion.Properties.Resources.trabajador2,
                                    capa_presentacion.Properties.Resources.consultas1,
                                    capa_presentacion.Properties.Resources.base_de_datos1,
                                    capa_presentacion.Properties.Resources.servicio_tecnico

        };
            




            if (id_numero_pagina >=0 && id_numero_pagina<=10)
            {
                this.l_nombre_formulaario.Text = nombres[id_numero_pagina];
                this.l_descripcion_formulario.Text = descripcion[id_numero_pagina];
                this.pict_imagen_formulario.Image = imagenes[id_numero_pagina];    
                this.btn_ir_a_mediano.Text="Ir a " + nombres[id_numero_pagina];
                this.t_mensaje.SetToolTip(btn_ir_a_mediano,"Abre el formulario de " + nombres[id_numero_pagina] );
            }
            else
            {

                id_numero_pagina = 0;
                this.l_nombre_formulaario.Text = nombres[id_numero_pagina];
                this.l_descripcion_formulario.Text = descripcion[id_numero_pagina];
                this.pict_imagen_formulario.Image = imagenes[id_numero_pagina];
                this.btn_ir_a_mediano.Text = "Ir a " + nombres[id_numero_pagina];
                this.t_mensaje.SetToolTip(btn_ir_a_mediano, "Abre el formulario de " + nombres[id_numero_pagina]);

            }


        }

        
        private void pict_mediano_next_Click(object sender, EventArgs e)
        {
            id_numero_pagina += 1;
            this.gestiona_menu_mediano();
        }

        private void pict_mediano_back_Click(object sender, EventArgs e)
        {
            id_numero_pagina -= 1;
            this.gestiona_menu_mediano();
        }


        private void gestiona_menu_grande()
        {

            string[] nombres = { "Ingresos", "Proveedores", "Articulos", "Categorias", "Presentación", "Ventas", "Clientes", "Trabajadores", "Consultas", "Base de datos", "Soporte Tecnico" };

            Image[] imagenes = { capa_presentacion.Properties.Resources.ingreso_grande,
                                    capa_presentacion.Properties.Resources.proveedores_grande,
                                    capa_presentacion.Properties.Resources.articulo1,
                                    capa_presentacion.Properties.Resources.categoria_grande,
                                    capa_presentacion.Properties.Resources.presentacion_grande,
                                    capa_presentacion.Properties.Resources.ventas_grande,
                                    capa_presentacion.Properties.Resources.cliente_grande,
                                    capa_presentacion.Properties.Resources.trabajadores_grande,
                                    capa_presentacion.Properties.Resources.consultas_grande,
                                    capa_presentacion.Properties.Resources.base_de_datos1,
                                    capa_presentacion.Properties.Resources.servicio_tecnico

        };





            if (id_numero_pagina_grande >= 1 && id_numero_pagina_grande <= 4)
            {

                if (id_numero_pagina_grande == 1)
                {
                    this.panel_formulario_3.Show();
                    this.l_titulo_grande_1.Text = nombres[0];
                    this.l_titulo_grande_2.Text = nombres[1];
                    this.l_titulo_grande_3.Text = nombres[2];
                    this.pict_formulario_grande_1.Image = imagenes[0];
                    this.pict_formulario_grande_2.Image = imagenes[1];
                    this.pict_formulario_grande_3.Image = imagenes[2];
                    
                }
                else if (id_numero_pagina_grande == 2)
                {
                    this.panel_formulario_3.Show();

                    this.l_titulo_grande_1.Text = nombres[3];
                    this.l_titulo_grande_2.Text = nombres[4];
                    this.l_titulo_grande_3.Text = nombres[5];
                    this.pict_formulario_grande_1.Image = imagenes[3];
                    this.pict_formulario_grande_2.Image = imagenes[4];
                    this.pict_formulario_grande_3.Image = imagenes[5];
                    

                }
                else if (id_numero_pagina_grande == 3)
                {

                    this.panel_formulario_3.Show();
                    this.l_titulo_grande_1.Text = nombres[6];
                    this.l_titulo_grande_2.Text = nombres[7];
                    this.l_titulo_grande_3.Text = nombres[8];
                    this.pict_formulario_grande_1.Image = imagenes[6];
                    this.pict_formulario_grande_2.Image = imagenes[7];
                    this.pict_formulario_grande_3.Image = imagenes[8];
                    
                }
                else if (id_numero_pagina_grande == 4)
                {
                    this.l_titulo_grande_1.Text = nombres[9];
                    this.l_titulo_grande_2.Text = nombres[10];
                    this.pict_formulario_grande_1.Image = imagenes[9];
                    this.pict_formulario_grande_2.Image = imagenes[10];

                    this.panel_formulario_3.Hide();

                 }
                else
                {
                    id_numero_pagina_grande = 0;
                    this.panel_formulario_3.Show();

                    this.l_titulo_grande_1.Text = nombres[0];
                    this.l_titulo_grande_2.Text = nombres[1];
                    this.l_titulo_grande_3.Text = nombres[2];
                    this.pict_formulario_grande_1.Image = imagenes[0];
                    this.pict_formulario_grande_2.Image = imagenes[1];
                    this.pict_formulario_grande_3.Image = imagenes[2];
                    
                }



            }


        }


        
      
      
        private void trabajadoresToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.panel_formularios.Controls.Clear();
            frm_trabajador frm = new frm_trabajador();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.Dock = DockStyle.Fill;
            this.panel_formularios.Controls.Add(frm);
            frm.Show();

        }

        private void ingresoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

              this.hilo_form_loading = new Thread(carga_frm_loading);
              hilo_form_loading.Start();

              

              this.panel_formularios.Controls.Clear();

            mi_formulario = 3;
            this.id_formulario(3);
             
            this.gestiona_formularios_ventana(3, true,false);

        }

        
        private void proveedorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            this.hilo_form_loading = new Thread(carga_frm_loading);
            hilo_form_loading.Start();


            mi_formulario = 4;
            this.id_formulario(4);
            this.panel_formularios.Controls.Clear();
            this.gestiona_formularios_ventana(4, true,true);




        }

        /// PARTE LOGICA 


        private void gestiona_formularios_ventana(int id,bool estado_ventana,bool panel_oculto)
        {


            if (id == 1)
            {
                frm_panel_principal frm = new frm_panel_principal();
                frm.TopLevel = false;
                frm.AutoScroll = true;
                frm.Dock = DockStyle.Fill;
                this.panel_formularios.Controls.Add(frm);
                frm.Show();
            }

            if (id == 2)
            {
                frm_panel_principal_grande frm = new frm_panel_principal_grande();
                frm.TopLevel = false;
                frm.AutoScroll = true;
                frm.Dock = DockStyle.Fill;
                this.panel_formularios.Controls.Add(frm);
                frm.Show();
            }




            if (id == 3)
            {
                frm_ingresos frm = frm_ingresos.dame_instancia(estado_ventana);
                frm.gestiona_ventana(estado_ventana);
                frm.TopLevel = false;
                frm.AutoScroll = true;
                frm.Dock = DockStyle.Fill;
                this.panel_formularios.Controls.Add(frm);
                frm.Show();
            }
            if (id == 4)
            {
                frm_proveedores frm = frm_proveedores.dame_instancia(estado_ventana,panel_oculto);
                frm.gestiona_ventana(estado_ventana);

                id_pagina_frm_proveedores =frm.dame_pagina();

                frm.TopLevel = false;
                frm.AutoScroll = true;
                frm.Dock = DockStyle.Fill;
                this.panel_formularios.Controls.Add(frm);
                frm.Show();
            }

            if (id == 5)
            {
                frm_articulos frm = frm_articulos.dame_instancia(estado_ventana, panel_oculto);
                frm.gestiona_ventana(estado_ventana);
                
                frm.TopLevel = false;
                frm.AutoScroll = true;
                frm.Dock = DockStyle.Fill;
                this.panel_formularios.Controls.Add(frm);
                frm.Show();
            }



        }




        private int id_formulario(int id_formulario) {
            return id_formulario;
        }

        private void articuloToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.hilo_form_loading = new Thread(carga_frm_loading);
            hilo_form_loading.Start();


            mi_formulario = 5;
            this.id_formulario(5);
            this.panel_formularios.Controls.Clear();
            this.gestiona_formularios_ventana(5, true, true);

        }
    }
}

