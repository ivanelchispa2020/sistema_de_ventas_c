namespace capa_presentacion
{
    partial class frm_cargando
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cargando));
            this.temp_loading = new System.Windows.Forms.Timer(this.components);
            this.panel_centrado = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.barra_progreso_loading = new System.Windows.Forms.ProgressBar();
            this.panel_centrado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // temp_loading
            // 
            this.temp_loading.Tick += new System.EventHandler(this.temp_loading_Tick);
            // 
            // panel_centrado
            // 
            this.panel_centrado.Controls.Add(this.label1);
            this.panel_centrado.Controls.Add(this.pictureBox1);
            this.panel_centrado.Controls.Add(this.barra_progreso_loading);
            this.panel_centrado.Location = new System.Drawing.Point(194, 79);
            this.panel_centrado.Name = "panel_centrado";
            this.panel_centrado.Size = new System.Drawing.Size(270, 135);
            this.panel_centrado.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Magenta;
            this.label1.Location = new System.Drawing.Point(68, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cargando...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::capa_presentacion.Properties.Resources.cargando;
            this.pictureBox1.Location = new System.Drawing.Point(66, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // barra_progreso_loading
            // 
            this.barra_progreso_loading.BackColor = System.Drawing.Color.Magenta;
            this.barra_progreso_loading.ForeColor = System.Drawing.Color.Magenta;
            this.barra_progreso_loading.Location = new System.Drawing.Point(15, 112);
            this.barra_progreso_loading.Name = "barra_progreso_loading";
            this.barra_progreso_loading.Size = new System.Drawing.Size(233, 23);
            this.barra_progreso_loading.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.barra_progreso_loading.TabIndex = 3;
            // 
            // frm_cargando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(896, 482);
            this.Controls.Add(this.panel_centrado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_cargando";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_cargando_Load);
            this.panel_centrado.ResumeLayout(false);
            this.panel_centrado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer temp_loading;
        private System.Windows.Forms.Panel panel_centrado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar barra_progreso_loading;
    }
}