using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capa_negocio;


namespace capa_presentacion
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.White;
            this.button1.ForeColor = Color.Blue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.Blue;
            this.button1.ForeColor = Color.White;
        }

        private void btn_salir_MouseEnter(object sender, EventArgs e)
        {
            this.btn_salir.BackColor = Color.White;
            this.btn_salir.ForeColor = Color.DarkRed;
        }

        private void btn_salir_MouseLeave(object sender, EventArgs e)
        {
            this.btn_salir.BackColor = Color.DarkRed;
            this.btn_salir.ForeColor = Color.White;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }



        public void verifica_usuario()
        {

            string usuario = this.txt_usuario.Text.Trim();
            string password = this.txt_password.Text.Trim();

            DataTable dt = N_trabajador.acceso_usuario(usuario, password);

            if (dt == null)
            {
                MessageBox.Show("No hay acceso a la base de datos..revise","Sistema de ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (dt.Rows.Count == 0)
                {

                    MessageBox.Show("Lo siento pero no tienes acceso al sistema..", "Sistema de ventas ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DataRow dr = dt.Rows[0];
                    int id_trabajador = Convert.ToInt32(dr["id_trabajador"].ToString());
                    string nombre = dr["nombre"].ToString();
                    string apellidos = dr["apellidos"].ToString();
                    string email = dr["email"].ToString();
                    string usuario_valor = dr["usuario"].ToString();
                    string acceso = dr["acceso"].ToString();

                    frm_principal frm = new frm_principal();
                    frm.id_trabajador = id_trabajador;
                    frm.nombre = nombre;
                    frm.apellidos = apellidos;
                    frm.email = email;
                    frm.usuario = usuario_valor;
                    frm.acceso = acceso;
                    frm.Show();
                    this.Hide();

                }




            }






        }

        public void gestiona_acceso() {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            verifica_usuario();
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                verifica_usuario();

            }
        }
    }
}
