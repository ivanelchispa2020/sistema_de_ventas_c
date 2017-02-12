using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace capa_presentacion
{
    public partial class frm_cargando : Form
    {
        public frm_cargando()
        {
            InitializeComponent();
        }

        private void frm_cargando_Load(object sender, EventArgs e)
        {

            this.temp_loading.Start();
            this.panel_centrado.Location = new Point(
                this.ClientSize.Width / 2 - this.panel_centrado.Size.Width / 2,
                this.ClientSize.Height / 2 - this.panel_centrado.Size.Height / 2);
            this.panel_centrado.Anchor = AnchorStyles.None;

        }

        private void barra_progreso_loading_Click(object sender, EventArgs e)
        {
            ProgressBar pr = new ProgressBar();
        }

        private void temp_loading_Tick(object sender, EventArgs e)
        {
            this.barra_progreso_loading.Increment(5);

            if (this.barra_progreso_loading.Value >= 100) {
                this.temp_loading.Stop();
                this.Hide();
            }

        }
    }
}
