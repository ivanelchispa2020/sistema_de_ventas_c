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
    public partial class frm_panel_principal : Form
    {




        private static int contador=0;
        private static int contador_carrousell = 0;
        

        public frm_panel_principal()
        {
            InitializeComponent();
        }

        private void frm_panel_principal_Load(object sender, EventArgs e)
        {
            temp_carrousel.Start();
            dame_hover(0);
        }


        //GESTIONA HOVER 

        private void dame_hover(int id) {

            string [] categorias = {"Compras","Almacén","Ventas","Soporte Tecnico"};

            string[] nombres = {"Ingreso" ,"Proveedores","Datos de Ingreso","Articulos","Categorias","Datos de Almacén","Ventas","Clientes","Consultas","Datos de Ventas","Base de datos","Trabajadores","Contacto" };

            string[] descripcion = {"Abre el formulario de ingresos el cual te permite gestionar los ingresos de la mercaderias que han entrado al sistema.",
                                        "Aqui podras acceder a una detallada información de los proveedores registrados en el sistema asi como támbien el acceso para manipularlos.",
                                        "Contiene datos estadisticos de forma detallada y minuciosa sobre los ingresos de mercaderia al sistema.",
                                        "Permite gestionar los articulos del sistema.asi como una lista detallada de los mismos.",
                                        "Permite una lista mas detallada de los articulos que existen en el Almacén permitiendola ver de una manera mas ordenada y legible.",
                                        "Contiene datos estadisticos de forma detallada y minuciosa sobre los articulos existentes en el almacén.(stock,fecha de vencimiento del vencimiento,revelamiento,etc)",
                                        "Abre el formulario de ingresos el cual te permite gestionar los egresos de la mercaderias que han salido del sistema.",
                                        "Aqui podras acceder a una detallada información de los clientes registrados en el sistema asi como támbien el acceso para manipularlos.",
                                        "Contiene todos los reportes sobre las ventas realizadas donde podras imprimir las facturas y reportes necesarios.",
                                        "Contiene datos estadisticos de forma detallada y minuciosa sobre los egresos del sistema.",
                                        "Permite acceder a la base de datos para realizar operaciones de backup y de mantenimineto(Acceso restringido a Administradores).",
                                        "Permite acceder  a una lista detallada de los usuarios del sistema.",
                                        "Contiene los datos necesarios para poder ponerse en contacto con los asesores tecnicos."
            };

            Image[] imagenes = { capa_presentacion.Properties.Resources.ingreso_grande, capa_presentacion.Properties.Resources.proveedores, capa_presentacion.Properties.Resources.consultas_grande, capa_presentacion.Properties.Resources.articulo1, capa_presentacion.Properties.Resources.categoria1, capa_presentacion.Properties.Resources.datos_ingresos, capa_presentacion.Properties.Resources.ventas1, capa_presentacion.Properties.Resources.cliente1, capa_presentacion.Properties.Resources.consultas1, capa_presentacion.Properties.Resources.datos_egresos, capa_presentacion.Properties.Resources.base_de_datos1, capa_presentacion.Properties.Resources.trabajadores_grande, capa_presentacion.Properties.Resources.soporte_tecnico_grande };

            PictureBox[] pictures = { this.pict_ingresos,this.pict_proveedores,this.pict_datos_ingreso,this.pict_articulos,this.pict_categorias,this.pict_datos_almacen,this.pict_ventas,this.pict_clientas,this.pict_consultas,this.pict_datos_venta,this.pict_base_datos,this.pict_trabajadores,this.pict_soperte_tecnico};




            if (id <= 2)
            {
                this.l_categoria.Text = categorias[0];
            }
            else if (id <= 5)
            {
                this.l_categoria.Text = categorias[1];
            }
            else if (id <= 8)
            {
                this.l_categoria.Text = categorias[2];
            }
            else
            {
                this.l_categoria.Text = categorias[3];

            }


            

                this.l_nombre.Text = nombres[id];
                this.l_descripcion.Text = descripcion[id];
                this.pict_imagen.Image = imagenes[id];


                foreach (PictureBox p in pictures)
                {

                    if (p == pictures[id])
                    {
                        p.BackColor = Color.Tomato;
                    }
                    else
                    {
                        p.BackColor = Color.Transparent;
                    }

                }


                



        }






        //MOUSE HOVER
        private void pict_ingresos_MouseEnter(object sender, EventArgs e)
        {
            this.pict_ingresos.BackColor = Color.Tomato;
            this.dame_hover(0);
            this.temp_carrousel.Stop();
        }

        private void pict_ingresos_MouseLeave(object sender, EventArgs e)
        {
            this.pict_ingresos.BackColor = Color.Transparent;
            this.temp_carrousel.Start();
        }

        private void pict_proveedores_MouseEnter(object sender, EventArgs e)
        {
            this.pict_proveedores.BackColor = Color.Tomato;
            this.dame_hover(1);
            this.temp_carrousel.Stop();
        }

        private void pict_proveedores_MouseLeave(object sender, EventArgs e)
        {
            this.pict_proveedores.BackColor = Color.Transparent;
            this.temp_carrousel.Start();
        }

        private void pict_datos_ingreso_MouseEnter(object sender, EventArgs e)
        {
            this.pict_datos_ingreso.BackColor = Color.Tomato;
            this.dame_hover(2);
            this.temp_carrousel.Stop();
        }

        private void pict_datos_ingreso_MouseLeave(object sender, EventArgs e)
        {
            this.pict_datos_ingreso.BackColor = Color.Transparent;
            this.temp_carrousel.Start();
        }

        private void pict_articulos_MouseEnter(object sender, EventArgs e)
        {
            this.pict_articulos.BackColor = Color.Tomato;
            this.dame_hover(3);
            this.temp_carrousel.Stop();
        }

        private void pict_articulos_MouseLeave(object sender, EventArgs e)
        {
            this.pict_articulos.BackColor = Color.Transparent;
            this.temp_carrousel.Start();
        }

        private void pict_categorias_MouseEnter(object sender, EventArgs e)
        {
            this.pict_categorias.BackColor = Color.Tomato;
            this.dame_hover(4);
            this.temp_carrousel.Stop();
        }

        private void pict_categorias_MouseLeave(object sender, EventArgs e)
        {
            this.pict_categorias.BackColor = Color.Transparent;
            this.temp_carrousel.Start();
        }

        private void pict_datos_almacen_MouseEnter(object sender, EventArgs e)
        {
            this.pict_datos_almacen.BackColor = Color.Tomato;
            this.dame_hover(5);
            this.temp_carrousel.Stop();
        }

        private void pict_datos_almacen_MouseLeave(object sender, EventArgs e)
        {
            this.pict_datos_almacen.BackColor = Color.Transparent;
            this.temp_carrousel.Start();
        }

        private void pict_ventas_MouseEnter(object sender, EventArgs e)
        {
            this.pict_ventas.BackColor = Color.Tomato;
            this.dame_hover(6);
            this.temp_carrousel.Stop();
        }

        private void pict_ventas_MouseLeave(object sender, EventArgs e)
        {
            this.pict_ventas.BackColor = Color.Transparent;
            this.temp_carrousel.Start();
        }

        private void pict_clientas_MouseEnter(object sender, EventArgs e)
        {
            this.pict_clientas.BackColor = Color.Tomato;
            this.dame_hover(7);
            this.temp_carrousel.Stop();
        }

        private void pict_clientas_MouseLeave(object sender, EventArgs e)
        {
            this.pict_clientas.BackColor = Color.Transparent;
            this.temp_carrousel.Start();
        }

        private void pict_consultas_MouseEnter(object sender, EventArgs e)
        {
            this.pict_consultas.BackColor = Color.Tomato;
            this.dame_hover(8);
            this.temp_carrousel.Stop();
        }

        private void pict_consultas_MouseLeave(object sender, EventArgs e)
        {
            this.pict_consultas.BackColor = Color.Transparent;
            this.temp_carrousel.Start();
        }

        private void pict_datos_venta_MouseEnter(object sender, EventArgs e)
        {
            this.pict_datos_venta.BackColor = Color.Tomato;
            this.dame_hover(9);
            this.temp_carrousel.Stop();
        }

        private void pict_datos_venta_MouseLeave(object sender, EventArgs e)
        {
            this.pict_datos_venta.BackColor = Color.Transparent;
            this.temp_carrousel.Start();
        }

        private void pict_base_datos_MouseEnter(object sender, EventArgs e)
        {
            this.pict_base_datos.BackColor = Color.Tomato;
            this.dame_hover(10);
            this.temp_carrousel.Stop();
        }

        private void pict_base_datos_MouseLeave(object sender, EventArgs e)
        {
            this.pict_base_datos.BackColor = Color.Transparent;
            this.temp_carrousel.Start();
        }

        private void pict_trabajadores_MouseEnter(object sender, EventArgs e)
        {
            this.pict_trabajadores.BackColor = Color.Tomato;
            this.dame_hover(11);
            this.temp_carrousel.Stop();
        }

        private void pict_trabajadores_MouseLeave(object sender, EventArgs e)
        {
            this.pict_trabajadores.BackColor = Color.Transparent;
            this.temp_carrousel.Start();
        }

        private void pict_soperte_tecnico_MouseEnter(object sender, EventArgs e)
        {
            this.pict_soperte_tecnico.BackColor = Color.Tomato;
            this.dame_hover(12);
            this.temp_carrousel.Stop();
        }

        private void pict_soperte_tecnico_MouseLeave(object sender, EventArgs e)
        {
            this.pict_soperte_tecnico.BackColor = Color.Transparent;
            this.temp_carrousel.Start();
        }




        //GESTIONA CARRUSELL

        private void temp_carrousel_Tick(object sender, EventArgs e)
        {

            contador++;

            if (contador >= 50) {

                dame_hover(contador_carrousell);

                contador_carrousell++;

                if(contador_carrousell >=12)
                {
                    contador_carrousell = 0;
                }

                contador = 0;
            }



        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {

            this.pictureBox2.Image = capa_presentacion.Properties.Resources.next_mediano_verde;
            this.temp_carrousel.Stop();
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox2.Image = capa_presentacion.Properties.Resources.next_grande_naranja;
            this.temp_carrousel.Start();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox1.Image= capa_presentacion.Properties.Resources.back_mediano_verde;
            this.temp_carrousel.Stop();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox1.Image = capa_presentacion.Properties.Resources.back_grande_naranja;
            this.temp_carrousel.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int id_siguiente = contador_carrousell + 1;

            if (id_siguiente > 12)
            {
                id_siguiente = 0;
            }


            dame_hover(id_siguiente);
            contador_carrousell = id_siguiente;
            this.temp_carrousel.Stop();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int id_anterior = contador_carrousell - 1;

            if (id_anterior < 0)
            {
                id_anterior = 12;
            }

            dame_hover(id_anterior);
            contador_carrousell = id_anterior;
            this.temp_carrousel.Stop();
            
        }


    }
}
