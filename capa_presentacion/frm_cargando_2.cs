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
    public partial class frm_cargando_2 : Form
    {

        private int contador = 0;

        public frm_cargando_2()
        {
            InitializeComponent();
        }

        private void frm_cargando_2_Load(object sender, EventArgs e)
        {
            this.temp_loading.Start();
            this.panel_centrado.Location = new Point(
                this.ClientSize.Width / 2 - this.panel_centrado.Size.Width / 2,
                this.ClientSize.Height / 2 - this.panel_centrado.Size.Height / 2);
            this.panel_centrado.Anchor = AnchorStyles.None;
        }

        private void temp_loading_Tick(object sender, EventArgs e)
        {
            contador++;

            if (contador >= 25) {
                this.Hide();
            }

        }

     
    }
}
