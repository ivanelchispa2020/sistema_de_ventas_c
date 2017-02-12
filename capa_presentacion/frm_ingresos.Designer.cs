namespace capa_presentacion
{
    partial class frm_ingresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ingresos));
            this.panel_botones = new System.Windows.Forms.Panel();
            this.flow_panel_botones = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.panel_titulo = new System.Windows.Forms.Panel();
            this.panel_titulo_cent = new System.Windows.Forms.Panel();
            this.l_titulo = new System.Windows.Forms.Label();
            this.panel_titulo_der = new System.Windows.Forms.Panel();
            this.panel_titulo_izq = new System.Windows.Forms.Panel();
            this.panel_lista_articulos = new System.Windows.Forms.Panel();
            this.table_detalles_ingresos = new System.Windows.Forms.TableLayoutPanel();
            this.l_fecha_vencimiento = new System.Windows.Forms.Label();
            this.dt_fecha_produccion = new System.Windows.Forms.DateTimePicker();
            this.l_fecha_produccion = new System.Windows.Forms.Label();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.l_stock = new System.Windows.Forms.Label();
            this.txt_precio_venta = new System.Windows.Forms.TextBox();
            this.l_precio_venta = new System.Windows.Forms.Label();
            this.txt_precio_compra = new System.Windows.Forms.TextBox();
            this.l_precio_compra = new System.Windows.Forms.Label();
            this.dt_fecha_vencimiento = new System.Windows.Forms.DateTimePicker();
            this.panel_botones_arriba = new System.Windows.Forms.Panel();
            this.panel_btn_next_lista_arriba = new System.Windows.Forms.Panel();
            this.pict_arriba_next = new System.Windows.Forms.PictureBox();
            this.panel_btn_back_lista_arriba = new System.Windows.Forms.Panel();
            this.pict_arriba_back = new System.Windows.Forms.PictureBox();
            this.panel_lista = new System.Windows.Forms.Panel();
            this.panel_btn_abajo_lista = new System.Windows.Forms.Panel();
            this.btn_next_abajo = new System.Windows.Forms.PictureBox();
            this.panel_btn_abajo_lista_back = new System.Windows.Forms.Panel();
            this.pict_btn_back_abajo = new System.Windows.Forms.PictureBox();
            this.panel_ingresos = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.table_ingresos = new System.Windows.Forms.TableLayoutPanel();
            this.l_iva = new System.Windows.Forms.Label();
            this.l_correlativo = new System.Windows.Forms.Label();
            this.l_serie = new System.Windows.Forms.Label();
            this.l_tipo_comprobante = new System.Windows.Forms.Label();
            this.l_codigo_trabajador = new System.Windows.Forms.Label();
            this.l_codigo_ingreso = new System.Windows.Forms.Label();
            this.txt_codigo_ingreso = new System.Windows.Forms.TextBox();
            this.txt_codigo_trabajador = new System.Windows.Forms.TextBox();
            this.txt_codigo_proveedor = new System.Windows.Forms.TextBox();
            this.l_codigo_proveedor = new System.Windows.Forms.Label();
            this.l_fecha = new System.Windows.Forms.Label();
            this.dt_fecha = new System.Windows.Forms.DateTimePicker();
            this.cb_comprobante = new System.Windows.Forms.ComboBox();
            this.txt_serie = new System.Windows.Forms.TextBox();
            this.txt_correlativo = new System.Windows.Forms.TextBox();
            this.n_iva = new System.Windows.Forms.NumericUpDown();
            this.panel_centro = new System.Windows.Forms.Panel();
            this.panel_botones.SuspendLayout();
            this.flow_panel_botones.SuspendLayout();
            this.panel_titulo.SuspendLayout();
            this.panel_titulo_cent.SuspendLayout();
            this.panel_lista_articulos.SuspendLayout();
            this.table_detalles_ingresos.SuspendLayout();
            this.panel_botones_arriba.SuspendLayout();
            this.panel_btn_next_lista_arriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict_arriba_next)).BeginInit();
            this.panel_btn_back_lista_arriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict_arriba_back)).BeginInit();
            this.panel_lista.SuspendLayout();
            this.panel_btn_abajo_lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_next_abajo)).BeginInit();
            this.panel_btn_abajo_lista_back.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict_btn_back_abajo)).BeginInit();
            this.panel_ingresos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.table_ingresos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n_iva)).BeginInit();
            this.panel_centro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_botones
            // 
            this.panel_botones.Controls.Add(this.flow_panel_botones);
            this.panel_botones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_botones.Location = new System.Drawing.Point(0, 348);
            this.panel_botones.Name = "panel_botones";
            this.panel_botones.Size = new System.Drawing.Size(671, 55);
            this.panel_botones.TabIndex = 0;
            // 
            // flow_panel_botones
            // 
            this.flow_panel_botones.Controls.Add(this.btn_nuevo);
            this.flow_panel_botones.Controls.Add(this.btn_editar);
            this.flow_panel_botones.Controls.Add(this.btn_eliminar);
            this.flow_panel_botones.Controls.Add(this.btn_cancelar);
            this.flow_panel_botones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow_panel_botones.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flow_panel_botones.Location = new System.Drawing.Point(0, 0);
            this.flow_panel_botones.Name = "flow_panel_botones";
            this.flow_panel_botones.Padding = new System.Windows.Forms.Padding(40, 5, 0, 0);
            this.flow_panel_botones.Size = new System.Drawing.Size(671, 55);
            this.flow_panel_botones.TabIndex = 0;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.Color.Black;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.ForeColor = System.Drawing.Color.HotPink;
            this.btn_nuevo.Location = new System.Drawing.Point(529, 8);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(99, 35);
            this.btn_nuevo.TabIndex = 17;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            this.btn_nuevo.MouseEnter += new System.EventHandler(this.btn_nuevo_MouseEnter);
            this.btn_nuevo.MouseLeave += new System.EventHandler(this.btn_nuevo_MouseLeave);
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.Black;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.Color.HotPink;
            this.btn_editar.Location = new System.Drawing.Point(424, 8);
            this.btn_editar.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(99, 35);
            this.btn_editar.TabIndex = 16;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.MouseEnter += new System.EventHandler(this.btn_editar_MouseEnter);
            this.btn_editar.MouseLeave += new System.EventHandler(this.btn_editar_MouseLeave);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.Black;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.HotPink;
            this.btn_eliminar.Location = new System.Drawing.Point(312, 8);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(99, 35);
            this.btn_eliminar.TabIndex = 15;
            this.btn_eliminar.Text = "Elminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.MouseEnter += new System.EventHandler(this.btn_eliminar_MouseEnter);
            this.btn_eliminar.MouseLeave += new System.EventHandler(this.btn_eliminar_MouseLeave);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Black;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.HotPink;
            this.btn_cancelar.Location = new System.Drawing.Point(200, 8);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(99, 35);
            this.btn_cancelar.TabIndex = 14;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            this.btn_cancelar.MouseEnter += new System.EventHandler(this.btn_cancelar_MouseEnter);
            this.btn_cancelar.MouseLeave += new System.EventHandler(this.btn_cancelar_MouseLeave);
            // 
            // panel_titulo
            // 
            this.panel_titulo.Controls.Add(this.panel_titulo_cent);
            this.panel_titulo.Controls.Add(this.panel_titulo_der);
            this.panel_titulo.Controls.Add(this.panel_titulo_izq);
            this.panel_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_titulo.Location = new System.Drawing.Point(0, 0);
            this.panel_titulo.Name = "panel_titulo";
            this.panel_titulo.Size = new System.Drawing.Size(671, 31);
            this.panel_titulo.TabIndex = 1;
            // 
            // panel_titulo_cent
            // 
            this.panel_titulo_cent.Controls.Add(this.l_titulo);
            this.panel_titulo_cent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_titulo_cent.Location = new System.Drawing.Point(234, 0);
            this.panel_titulo_cent.Name = "panel_titulo_cent";
            this.panel_titulo_cent.Size = new System.Drawing.Size(237, 31);
            this.panel_titulo_cent.TabIndex = 2;
            // 
            // l_titulo
            // 
            this.l_titulo.AutoSize = true;
            this.l_titulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_titulo.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_titulo.ForeColor = System.Drawing.Color.HotPink;
            this.l_titulo.Location = new System.Drawing.Point(0, 0);
            this.l_titulo.Name = "l_titulo";
            this.l_titulo.Size = new System.Drawing.Size(134, 31);
            this.l_titulo.TabIndex = 0;
            this.l_titulo.Text = "Ingresos";
            // 
            // panel_titulo_der
            // 
            this.panel_titulo_der.BackColor = System.Drawing.Color.Transparent;
            this.panel_titulo_der.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_titulo_der.Location = new System.Drawing.Point(471, 0);
            this.panel_titulo_der.Name = "panel_titulo_der";
            this.panel_titulo_der.Size = new System.Drawing.Size(200, 31);
            this.panel_titulo_der.TabIndex = 1;
            // 
            // panel_titulo_izq
            // 
            this.panel_titulo_izq.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_titulo_izq.Location = new System.Drawing.Point(0, 0);
            this.panel_titulo_izq.Name = "panel_titulo_izq";
            this.panel_titulo_izq.Size = new System.Drawing.Size(234, 31);
            this.panel_titulo_izq.TabIndex = 0;
            // 
            // panel_lista_articulos
            // 
            this.panel_lista_articulos.Controls.Add(this.table_detalles_ingresos);
            this.panel_lista_articulos.Controls.Add(this.panel_botones_arriba);
            this.panel_lista_articulos.Controls.Add(this.panel_lista);
            this.panel_lista_articulos.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_lista_articulos.Location = new System.Drawing.Point(0, 31);
            this.panel_lista_articulos.Name = "panel_lista_articulos";
            this.panel_lista_articulos.Size = new System.Drawing.Size(271, 317);
            this.panel_lista_articulos.TabIndex = 2;
            // 
            // table_detalles_ingresos
            // 
            this.table_detalles_ingresos.ColumnCount = 2;
            this.table_detalles_ingresos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.73438F));
            this.table_detalles_ingresos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.26563F));
            this.table_detalles_ingresos.Controls.Add(this.l_fecha_vencimiento, 0, 4);
            this.table_detalles_ingresos.Controls.Add(this.dt_fecha_produccion, 1, 3);
            this.table_detalles_ingresos.Controls.Add(this.l_fecha_produccion, 0, 3);
            this.table_detalles_ingresos.Controls.Add(this.txt_stock, 1, 2);
            this.table_detalles_ingresos.Controls.Add(this.l_stock, 0, 2);
            this.table_detalles_ingresos.Controls.Add(this.txt_precio_venta, 1, 1);
            this.table_detalles_ingresos.Controls.Add(this.l_precio_venta, 0, 1);
            this.table_detalles_ingresos.Controls.Add(this.txt_precio_compra, 1, 0);
            this.table_detalles_ingresos.Controls.Add(this.l_precio_compra, 0, 0);
            this.table_detalles_ingresos.Controls.Add(this.dt_fecha_vencimiento, 1, 4);
            this.table_detalles_ingresos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_detalles_ingresos.Location = new System.Drawing.Point(0, 33);
            this.table_detalles_ingresos.Name = "table_detalles_ingresos";
            this.table_detalles_ingresos.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.table_detalles_ingresos.RowCount = 5;
            this.table_detalles_ingresos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table_detalles_ingresos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table_detalles_ingresos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table_detalles_ingresos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table_detalles_ingresos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table_detalles_ingresos.Size = new System.Drawing.Size(271, 251);
            this.table_detalles_ingresos.TabIndex = 5;
            // 
            // l_fecha_vencimiento
            // 
            this.l_fecha_vencimiento.AutoSize = true;
            this.l_fecha_vencimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_fecha_vencimiento.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_fecha_vencimiento.ForeColor = System.Drawing.Color.HotPink;
            this.l_fecha_vencimiento.Location = new System.Drawing.Point(8, 187);
            this.l_fecha_vencimiento.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.l_fecha_vencimiento.Name = "l_fecha_vencimiento";
            this.l_fecha_vencimiento.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.l_fecha_vencimiento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.l_fecha_vencimiento.Size = new System.Drawing.Size(128, 64);
            this.l_fecha_vencimiento.TabIndex = 36;
            this.l_fecha_vencimiento.Text = "Fecha Vecimieto:";
            this.l_fecha_vencimiento.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dt_fecha_produccion
            // 
            this.dt_fecha_produccion.CalendarFont = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_fecha_produccion.CalendarForeColor = System.Drawing.Color.Yellow;
            this.dt_fecha_produccion.CalendarMonthBackground = System.Drawing.Color.DarkOliveGreen;
            this.dt_fecha_produccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dt_fecha_produccion.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_fecha_produccion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fecha_produccion.Location = new System.Drawing.Point(142, 137);
            this.dt_fecha_produccion.Margin = new System.Windows.Forms.Padding(3, 14, 3, 3);
            this.dt_fecha_produccion.Name = "dt_fecha_produccion";
            this.dt_fecha_produccion.Size = new System.Drawing.Size(116, 30);
            this.dt_fecha_produccion.TabIndex = 4;
            // 
            // l_fecha_produccion
            // 
            this.l_fecha_produccion.AutoSize = true;
            this.l_fecha_produccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_fecha_produccion.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_fecha_produccion.ForeColor = System.Drawing.Color.HotPink;
            this.l_fecha_produccion.Location = new System.Drawing.Point(8, 128);
            this.l_fecha_produccion.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.l_fecha_produccion.Name = "l_fecha_produccion";
            this.l_fecha_produccion.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.l_fecha_produccion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.l_fecha_produccion.Size = new System.Drawing.Size(128, 54);
            this.l_fecha_produccion.TabIndex = 35;
            this.l_fecha_produccion.Text = "Fecha Producción:";
            this.l_fecha_produccion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_stock
            // 
            this.txt_stock.BackColor = System.Drawing.Color.Black;
            this.txt_stock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_stock.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stock.ForeColor = System.Drawing.Color.Yellow;
            this.txt_stock.Location = new System.Drawing.Point(142, 92);
            this.txt_stock.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(116, 28);
            this.txt_stock.TabIndex = 3;
            // 
            // l_stock
            // 
            this.l_stock.AutoSize = true;
            this.l_stock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_stock.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_stock.ForeColor = System.Drawing.Color.HotPink;
            this.l_stock.Location = new System.Drawing.Point(8, 87);
            this.l_stock.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.l_stock.Name = "l_stock";
            this.l_stock.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.l_stock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.l_stock.Size = new System.Drawing.Size(128, 36);
            this.l_stock.TabIndex = 33;
            this.l_stock.Text = "Precio Venta:";
            this.l_stock.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_precio_venta
            // 
            this.txt_precio_venta.BackColor = System.Drawing.Color.Black;
            this.txt_precio_venta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_precio_venta.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio_venta.ForeColor = System.Drawing.Color.Yellow;
            this.txt_precio_venta.Location = new System.Drawing.Point(142, 51);
            this.txt_precio_venta.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txt_precio_venta.Name = "txt_precio_venta";
            this.txt_precio_venta.Size = new System.Drawing.Size(116, 28);
            this.txt_precio_venta.TabIndex = 2;
            // 
            // l_precio_venta
            // 
            this.l_precio_venta.AutoSize = true;
            this.l_precio_venta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_precio_venta.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_precio_venta.ForeColor = System.Drawing.Color.HotPink;
            this.l_precio_venta.Location = new System.Drawing.Point(8, 46);
            this.l_precio_venta.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.l_precio_venta.Name = "l_precio_venta";
            this.l_precio_venta.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.l_precio_venta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.l_precio_venta.Size = new System.Drawing.Size(128, 36);
            this.l_precio_venta.TabIndex = 31;
            this.l_precio_venta.Text = "Precio Venta:";
            this.l_precio_venta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_precio_compra
            // 
            this.txt_precio_compra.BackColor = System.Drawing.Color.Black;
            this.txt_precio_compra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_precio_compra.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio_compra.ForeColor = System.Drawing.Color.Yellow;
            this.txt_precio_compra.Location = new System.Drawing.Point(142, 10);
            this.txt_precio_compra.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txt_precio_compra.Name = "txt_precio_compra";
            this.txt_precio_compra.Size = new System.Drawing.Size(116, 28);
            this.txt_precio_compra.TabIndex = 1;
            // 
            // l_precio_compra
            // 
            this.l_precio_compra.AutoSize = true;
            this.l_precio_compra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_precio_compra.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_precio_compra.ForeColor = System.Drawing.Color.HotPink;
            this.l_precio_compra.Location = new System.Drawing.Point(8, 5);
            this.l_precio_compra.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.l_precio_compra.Name = "l_precio_compra";
            this.l_precio_compra.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.l_precio_compra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.l_precio_compra.Size = new System.Drawing.Size(128, 36);
            this.l_precio_compra.TabIndex = 21;
            this.l_precio_compra.Text = "Precio Compra:";
            this.l_precio_compra.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dt_fecha_vencimiento
            // 
            this.dt_fecha_vencimiento.CalendarFont = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_fecha_vencimiento.CalendarForeColor = System.Drawing.Color.Yellow;
            this.dt_fecha_vencimiento.CalendarMonthBackground = System.Drawing.Color.DarkOliveGreen;
            this.dt_fecha_vencimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dt_fecha_vencimiento.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_fecha_vencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fecha_vencimiento.Location = new System.Drawing.Point(142, 196);
            this.dt_fecha_vencimiento.Margin = new System.Windows.Forms.Padding(3, 14, 3, 3);
            this.dt_fecha_vencimiento.Name = "dt_fecha_vencimiento";
            this.dt_fecha_vencimiento.Size = new System.Drawing.Size(116, 30);
            this.dt_fecha_vencimiento.TabIndex = 5;
            // 
            // panel_botones_arriba
            // 
            this.panel_botones_arriba.Controls.Add(this.panel_btn_next_lista_arriba);
            this.panel_botones_arriba.Controls.Add(this.panel_btn_back_lista_arriba);
            this.panel_botones_arriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_botones_arriba.Location = new System.Drawing.Point(0, 0);
            this.panel_botones_arriba.Name = "panel_botones_arriba";
            this.panel_botones_arriba.Size = new System.Drawing.Size(271, 33);
            this.panel_botones_arriba.TabIndex = 1;
            // 
            // panel_btn_next_lista_arriba
            // 
            this.panel_btn_next_lista_arriba.Controls.Add(this.pict_arriba_next);
            this.panel_btn_next_lista_arriba.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_btn_next_lista_arriba.Location = new System.Drawing.Point(227, 0);
            this.panel_btn_next_lista_arriba.Name = "panel_btn_next_lista_arriba";
            this.panel_btn_next_lista_arriba.Size = new System.Drawing.Size(44, 33);
            this.panel_btn_next_lista_arriba.TabIndex = 1;
            // 
            // pict_arriba_next
            // 
            this.pict_arriba_next.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pict_arriba_next.Image = global::capa_presentacion.Properties.Resources.next_mediano_verde;
            this.pict_arriba_next.Location = new System.Drawing.Point(0, 0);
            this.pict_arriba_next.Name = "pict_arriba_next";
            this.pict_arriba_next.Size = new System.Drawing.Size(44, 33);
            this.pict_arriba_next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pict_arriba_next.TabIndex = 2;
            this.pict_arriba_next.TabStop = false;
            // 
            // panel_btn_back_lista_arriba
            // 
            this.panel_btn_back_lista_arriba.Controls.Add(this.pict_arriba_back);
            this.panel_btn_back_lista_arriba.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_btn_back_lista_arriba.Location = new System.Drawing.Point(0, 0);
            this.panel_btn_back_lista_arriba.Name = "panel_btn_back_lista_arriba";
            this.panel_btn_back_lista_arriba.Size = new System.Drawing.Size(45, 33);
            this.panel_btn_back_lista_arriba.TabIndex = 0;
            // 
            // pict_arriba_back
            // 
            this.pict_arriba_back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pict_arriba_back.Image = global::capa_presentacion.Properties.Resources.back_mediano_verde;
            this.pict_arriba_back.Location = new System.Drawing.Point(0, 0);
            this.pict_arriba_back.Name = "pict_arriba_back";
            this.pict_arriba_back.Size = new System.Drawing.Size(45, 33);
            this.pict_arriba_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pict_arriba_back.TabIndex = 1;
            this.pict_arriba_back.TabStop = false;
            // 
            // panel_lista
            // 
            this.panel_lista.Controls.Add(this.panel_btn_abajo_lista);
            this.panel_lista.Controls.Add(this.panel_btn_abajo_lista_back);
            this.panel_lista.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_lista.Location = new System.Drawing.Point(0, 284);
            this.panel_lista.Name = "panel_lista";
            this.panel_lista.Size = new System.Drawing.Size(271, 33);
            this.panel_lista.TabIndex = 2;
            // 
            // panel_btn_abajo_lista
            // 
            this.panel_btn_abajo_lista.Controls.Add(this.btn_next_abajo);
            this.panel_btn_abajo_lista.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_btn_abajo_lista.Location = new System.Drawing.Point(227, 0);
            this.panel_btn_abajo_lista.Name = "panel_btn_abajo_lista";
            this.panel_btn_abajo_lista.Size = new System.Drawing.Size(44, 33);
            this.panel_btn_abajo_lista.TabIndex = 1;
            // 
            // btn_next_abajo
            // 
            this.btn_next_abajo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_next_abajo.Image = global::capa_presentacion.Properties.Resources.next_mediano_verde;
            this.btn_next_abajo.Location = new System.Drawing.Point(0, 0);
            this.btn_next_abajo.Name = "btn_next_abajo";
            this.btn_next_abajo.Size = new System.Drawing.Size(44, 33);
            this.btn_next_abajo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_next_abajo.TabIndex = 2;
            this.btn_next_abajo.TabStop = false;
            // 
            // panel_btn_abajo_lista_back
            // 
            this.panel_btn_abajo_lista_back.Controls.Add(this.pict_btn_back_abajo);
            this.panel_btn_abajo_lista_back.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_btn_abajo_lista_back.Location = new System.Drawing.Point(0, 0);
            this.panel_btn_abajo_lista_back.Name = "panel_btn_abajo_lista_back";
            this.panel_btn_abajo_lista_back.Size = new System.Drawing.Size(45, 33);
            this.panel_btn_abajo_lista_back.TabIndex = 0;
            // 
            // pict_btn_back_abajo
            // 
            this.pict_btn_back_abajo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pict_btn_back_abajo.Image = global::capa_presentacion.Properties.Resources.back_mediano_verde;
            this.pict_btn_back_abajo.Location = new System.Drawing.Point(0, 0);
            this.pict_btn_back_abajo.Name = "pict_btn_back_abajo";
            this.pict_btn_back_abajo.Size = new System.Drawing.Size(45, 33);
            this.pict_btn_back_abajo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pict_btn_back_abajo.TabIndex = 1;
            this.pict_btn_back_abajo.TabStop = false;
            // 
            // panel_ingresos
            // 
            this.panel_ingresos.Controls.Add(this.pictureBox1);
            this.panel_ingresos.Controls.Add(this.table_ingresos);
            this.panel_ingresos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ingresos.Location = new System.Drawing.Point(271, 31);
            this.panel_ingresos.Name = "panel_ingresos";
            this.panel_ingresos.Size = new System.Drawing.Size(400, 317);
            this.panel_ingresos.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::capa_presentacion.Properties.Resources.frm_ingresos_grande_3;
            this.pictureBox1.Location = new System.Drawing.Point(350, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(50, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // table_ingresos
            // 
            this.table_ingresos.AutoSize = true;
            this.table_ingresos.ColumnCount = 2;
            this.table_ingresos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.table_ingresos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.table_ingresos.Controls.Add(this.l_iva, 0, 7);
            this.table_ingresos.Controls.Add(this.l_correlativo, 0, 6);
            this.table_ingresos.Controls.Add(this.l_serie, 0, 5);
            this.table_ingresos.Controls.Add(this.l_tipo_comprobante, 0, 4);
            this.table_ingresos.Controls.Add(this.l_codigo_trabajador, 0, 1);
            this.table_ingresos.Controls.Add(this.l_codigo_ingreso, 0, 0);
            this.table_ingresos.Controls.Add(this.txt_codigo_ingreso, 1, 0);
            this.table_ingresos.Controls.Add(this.txt_codigo_trabajador, 1, 1);
            this.table_ingresos.Controls.Add(this.txt_codigo_proveedor, 1, 2);
            this.table_ingresos.Controls.Add(this.l_codigo_proveedor, 0, 2);
            this.table_ingresos.Controls.Add(this.l_fecha, 0, 3);
            this.table_ingresos.Controls.Add(this.dt_fecha, 1, 3);
            this.table_ingresos.Controls.Add(this.cb_comprobante, 1, 4);
            this.table_ingresos.Controls.Add(this.txt_serie, 1, 5);
            this.table_ingresos.Controls.Add(this.txt_correlativo, 1, 6);
            this.table_ingresos.Controls.Add(this.n_iva, 1, 7);
            this.table_ingresos.Dock = System.Windows.Forms.DockStyle.Left;
            this.table_ingresos.Location = new System.Drawing.Point(0, 0);
            this.table_ingresos.Name = "table_ingresos";
            this.table_ingresos.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.table_ingresos.RowCount = 8;
            this.table_ingresos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table_ingresos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table_ingresos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table_ingresos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table_ingresos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table_ingresos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table_ingresos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table_ingresos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table_ingresos.Size = new System.Drawing.Size(350, 317);
            this.table_ingresos.TabIndex = 2;
            // 
            // l_iva
            // 
            this.l_iva.AutoSize = true;
            this.l_iva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_iva.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_iva.ForeColor = System.Drawing.Color.HotPink;
            this.l_iva.Location = new System.Drawing.Point(8, 288);
            this.l_iva.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.l_iva.Name = "l_iva";
            this.l_iva.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.l_iva.Size = new System.Drawing.Size(159, 29);
            this.l_iva.TabIndex = 28;
            this.l_iva.Text = "Iva:";
            this.l_iva.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // l_correlativo
            // 
            this.l_correlativo.AutoSize = true;
            this.l_correlativo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_correlativo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_correlativo.ForeColor = System.Drawing.Color.HotPink;
            this.l_correlativo.Location = new System.Drawing.Point(8, 247);
            this.l_correlativo.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.l_correlativo.Name = "l_correlativo";
            this.l_correlativo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.l_correlativo.Size = new System.Drawing.Size(159, 31);
            this.l_correlativo.TabIndex = 26;
            this.l_correlativo.Text = "Correlativo:";
            this.l_correlativo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // l_serie
            // 
            this.l_serie.AutoSize = true;
            this.l_serie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_serie.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_serie.ForeColor = System.Drawing.Color.HotPink;
            this.l_serie.Location = new System.Drawing.Point(8, 206);
            this.l_serie.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.l_serie.Name = "l_serie";
            this.l_serie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.l_serie.Size = new System.Drawing.Size(159, 31);
            this.l_serie.TabIndex = 24;
            this.l_serie.Text = "Serie:";
            this.l_serie.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // l_tipo_comprobante
            // 
            this.l_tipo_comprobante.AutoSize = true;
            this.l_tipo_comprobante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_tipo_comprobante.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_tipo_comprobante.ForeColor = System.Drawing.Color.HotPink;
            this.l_tipo_comprobante.Location = new System.Drawing.Point(8, 169);
            this.l_tipo_comprobante.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.l_tipo_comprobante.Name = "l_tipo_comprobante";
            this.l_tipo_comprobante.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.l_tipo_comprobante.Size = new System.Drawing.Size(159, 27);
            this.l_tipo_comprobante.TabIndex = 22;
            this.l_tipo_comprobante.Text = "Tipo Comprobante";
            this.l_tipo_comprobante.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // l_codigo_trabajador
            // 
            this.l_codigo_trabajador.AutoSize = true;
            this.l_codigo_trabajador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_codigo_trabajador.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_codigo_trabajador.ForeColor = System.Drawing.Color.HotPink;
            this.l_codigo_trabajador.Location = new System.Drawing.Point(8, 51);
            this.l_codigo_trabajador.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.l_codigo_trabajador.Name = "l_codigo_trabajador";
            this.l_codigo_trabajador.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.l_codigo_trabajador.Size = new System.Drawing.Size(159, 31);
            this.l_codigo_trabajador.TabIndex = 16;
            this.l_codigo_trabajador.Text = "Codigo Trabajador:";
            this.l_codigo_trabajador.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // l_codigo_ingreso
            // 
            this.l_codigo_ingreso.AutoSize = true;
            this.l_codigo_ingreso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_codigo_ingreso.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_codigo_ingreso.ForeColor = System.Drawing.Color.HotPink;
            this.l_codigo_ingreso.Location = new System.Drawing.Point(8, 10);
            this.l_codigo_ingreso.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.l_codigo_ingreso.Name = "l_codigo_ingreso";
            this.l_codigo_ingreso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.l_codigo_ingreso.Size = new System.Drawing.Size(159, 31);
            this.l_codigo_ingreso.TabIndex = 14;
            this.l_codigo_ingreso.Text = "Codigo Ingreso:";
            this.l_codigo_ingreso.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_codigo_ingreso
            // 
            this.txt_codigo_ingreso.BackColor = System.Drawing.Color.Black;
            this.txt_codigo_ingreso.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo_ingreso.ForeColor = System.Drawing.Color.Yellow;
            this.txt_codigo_ingreso.Location = new System.Drawing.Point(173, 10);
            this.txt_codigo_ingreso.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txt_codigo_ingreso.Name = "txt_codigo_ingreso";
            this.txt_codigo_ingreso.Size = new System.Drawing.Size(104, 28);
            this.txt_codigo_ingreso.TabIndex = 6;
            // 
            // txt_codigo_trabajador
            // 
            this.txt_codigo_trabajador.BackColor = System.Drawing.Color.Black;
            this.txt_codigo_trabajador.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo_trabajador.ForeColor = System.Drawing.Color.Yellow;
            this.txt_codigo_trabajador.Location = new System.Drawing.Point(173, 51);
            this.txt_codigo_trabajador.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txt_codigo_trabajador.Name = "txt_codigo_trabajador";
            this.txt_codigo_trabajador.Size = new System.Drawing.Size(104, 28);
            this.txt_codigo_trabajador.TabIndex = 7;
            // 
            // txt_codigo_proveedor
            // 
            this.txt_codigo_proveedor.BackColor = System.Drawing.Color.Black;
            this.txt_codigo_proveedor.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo_proveedor.ForeColor = System.Drawing.Color.Yellow;
            this.txt_codigo_proveedor.Location = new System.Drawing.Point(173, 92);
            this.txt_codigo_proveedor.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txt_codigo_proveedor.Name = "txt_codigo_proveedor";
            this.txt_codigo_proveedor.Size = new System.Drawing.Size(104, 28);
            this.txt_codigo_proveedor.TabIndex = 8;
            // 
            // l_codigo_proveedor
            // 
            this.l_codigo_proveedor.AutoSize = true;
            this.l_codigo_proveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_codigo_proveedor.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_codigo_proveedor.ForeColor = System.Drawing.Color.HotPink;
            this.l_codigo_proveedor.Location = new System.Drawing.Point(8, 92);
            this.l_codigo_proveedor.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.l_codigo_proveedor.Name = "l_codigo_proveedor";
            this.l_codigo_proveedor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.l_codigo_proveedor.Size = new System.Drawing.Size(159, 31);
            this.l_codigo_proveedor.TabIndex = 18;
            this.l_codigo_proveedor.Text = "Codigo Prveedor:";
            this.l_codigo_proveedor.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // l_fecha
            // 
            this.l_fecha.AutoSize = true;
            this.l_fecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_fecha.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_fecha.ForeColor = System.Drawing.Color.HotPink;
            this.l_fecha.Location = new System.Drawing.Point(8, 133);
            this.l_fecha.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.l_fecha.Name = "l_fecha";
            this.l_fecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.l_fecha.Size = new System.Drawing.Size(159, 26);
            this.l_fecha.TabIndex = 20;
            this.l_fecha.Text = "Fecha:";
            this.l_fecha.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dt_fecha
            // 
            this.dt_fecha.CalendarFont = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_fecha.CalendarForeColor = System.Drawing.Color.Yellow;
            this.dt_fecha.CalendarMonthBackground = System.Drawing.Color.DarkOliveGreen;
            this.dt_fecha.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fecha.Location = new System.Drawing.Point(173, 126);
            this.dt_fecha.Name = "dt_fecha";
            this.dt_fecha.Size = new System.Drawing.Size(104, 30);
            this.dt_fecha.TabIndex = 9;
            // 
            // cb_comprobante
            // 
            this.cb_comprobante.BackColor = System.Drawing.Color.Black;
            this.cb_comprobante.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_comprobante.ForeColor = System.Drawing.Color.Yellow;
            this.cb_comprobante.FormattingEnabled = true;
            this.cb_comprobante.Location = new System.Drawing.Point(173, 162);
            this.cb_comprobante.Name = "cb_comprobante";
            this.cb_comprobante.Size = new System.Drawing.Size(164, 31);
            this.cb_comprobante.TabIndex = 10;
            // 
            // txt_serie
            // 
            this.txt_serie.BackColor = System.Drawing.Color.Black;
            this.txt_serie.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_serie.ForeColor = System.Drawing.Color.Yellow;
            this.txt_serie.Location = new System.Drawing.Point(173, 206);
            this.txt_serie.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txt_serie.Name = "txt_serie";
            this.txt_serie.Size = new System.Drawing.Size(164, 28);
            this.txt_serie.TabIndex = 11;
            // 
            // txt_correlativo
            // 
            this.txt_correlativo.BackColor = System.Drawing.Color.Black;
            this.txt_correlativo.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correlativo.ForeColor = System.Drawing.Color.Yellow;
            this.txt_correlativo.Location = new System.Drawing.Point(173, 247);
            this.txt_correlativo.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txt_correlativo.Name = "txt_correlativo";
            this.txt_correlativo.Size = new System.Drawing.Size(164, 28);
            this.txt_correlativo.TabIndex = 12;
            // 
            // n_iva
            // 
            this.n_iva.BackColor = System.Drawing.Color.Black;
            this.n_iva.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_iva.ForeColor = System.Drawing.Color.Yellow;
            this.n_iva.Location = new System.Drawing.Point(173, 281);
            this.n_iva.Name = "n_iva";
            this.n_iva.Size = new System.Drawing.Size(67, 30);
            this.n_iva.TabIndex = 13;
            this.n_iva.Value = new decimal(new int[] {
            21,
            0,
            0,
            0});
            // 
            // panel_centro
            // 
            this.panel_centro.BackColor = System.Drawing.Color.Transparent;
            this.panel_centro.Controls.Add(this.panel_ingresos);
            this.panel_centro.Controls.Add(this.panel_lista_articulos);
            this.panel_centro.Controls.Add(this.panel_titulo);
            this.panel_centro.Controls.Add(this.panel_botones);
            this.panel_centro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_centro.Location = new System.Drawing.Point(0, 0);
            this.panel_centro.Name = "panel_centro";
            this.panel_centro.Size = new System.Drawing.Size(671, 403);
            this.panel_centro.TabIndex = 0;
            // 
            // frm_ingresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(671, 403);
            this.Controls.Add(this.panel_centro);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_ingresos";
            this.Text = "frm_ingresos";
            this.panel_botones.ResumeLayout(false);
            this.flow_panel_botones.ResumeLayout(false);
            this.panel_titulo.ResumeLayout(false);
            this.panel_titulo_cent.ResumeLayout(false);
            this.panel_titulo_cent.PerformLayout();
            this.panel_lista_articulos.ResumeLayout(false);
            this.table_detalles_ingresos.ResumeLayout(false);
            this.table_detalles_ingresos.PerformLayout();
            this.panel_botones_arriba.ResumeLayout(false);
            this.panel_btn_next_lista_arriba.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pict_arriba_next)).EndInit();
            this.panel_btn_back_lista_arriba.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pict_arriba_back)).EndInit();
            this.panel_lista.ResumeLayout(false);
            this.panel_btn_abajo_lista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_next_abajo)).EndInit();
            this.panel_btn_abajo_lista_back.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pict_btn_back_abajo)).EndInit();
            this.panel_ingresos.ResumeLayout(false);
            this.panel_ingresos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.table_ingresos.ResumeLayout(false);
            this.table_ingresos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n_iva)).EndInit();
            this.panel_centro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_botones;
        private System.Windows.Forms.FlowLayoutPanel flow_panel_botones;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Panel panel_titulo;
        private System.Windows.Forms.Panel panel_titulo_cent;
        private System.Windows.Forms.Label l_titulo;
        private System.Windows.Forms.Panel panel_titulo_der;
        private System.Windows.Forms.Panel panel_titulo_izq;
        private System.Windows.Forms.Panel panel_lista_articulos;
        private System.Windows.Forms.Panel panel_botones_arriba;
        private System.Windows.Forms.Panel panel_btn_next_lista_arriba;
        private System.Windows.Forms.PictureBox pict_arriba_next;
        private System.Windows.Forms.Panel panel_btn_back_lista_arriba;
        private System.Windows.Forms.PictureBox pict_arriba_back;
        private System.Windows.Forms.Panel panel_lista;
        private System.Windows.Forms.Panel panel_btn_abajo_lista;
        private System.Windows.Forms.PictureBox btn_next_abajo;
        private System.Windows.Forms.Panel panel_btn_abajo_lista_back;
        private System.Windows.Forms.PictureBox pict_btn_back_abajo;
        private System.Windows.Forms.Panel panel_ingresos;
        private System.Windows.Forms.Panel panel_centro;
        private System.Windows.Forms.TableLayoutPanel table_detalles_ingresos;
        private System.Windows.Forms.Label l_fecha_vencimiento;
        private System.Windows.Forms.DateTimePicker dt_fecha_produccion;
        private System.Windows.Forms.Label l_fecha_produccion;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.Label l_stock;
        private System.Windows.Forms.TextBox txt_precio_venta;
        private System.Windows.Forms.Label l_precio_venta;
        private System.Windows.Forms.TextBox txt_precio_compra;
        private System.Windows.Forms.Label l_precio_compra;
        private System.Windows.Forms.DateTimePicker dt_fecha_vencimiento;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel table_ingresos;
        private System.Windows.Forms.Label l_iva;
        private System.Windows.Forms.Label l_correlativo;
        private System.Windows.Forms.Label l_serie;
        private System.Windows.Forms.Label l_tipo_comprobante;
        private System.Windows.Forms.Label l_codigo_trabajador;
        private System.Windows.Forms.Label l_codigo_ingreso;
        private System.Windows.Forms.TextBox txt_codigo_ingreso;
        private System.Windows.Forms.TextBox txt_codigo_trabajador;
        private System.Windows.Forms.TextBox txt_codigo_proveedor;
        private System.Windows.Forms.Label l_codigo_proveedor;
        private System.Windows.Forms.Label l_fecha;
        private System.Windows.Forms.DateTimePicker dt_fecha;
        private System.Windows.Forms.ComboBox cb_comprobante;
        private System.Windows.Forms.TextBox txt_serie;
        private System.Windows.Forms.TextBox txt_correlativo;
        private System.Windows.Forms.NumericUpDown n_iva;
    }
}