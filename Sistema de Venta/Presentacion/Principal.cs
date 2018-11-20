﻿using Sistema_de_Venta.Datos;
using Sistema_de_Venta.Entidades;
using Sistema_de_Venta.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Venta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int childFormNumber = 0;
        FRM_Login login = new FRM_Login();
        string UserTemp = Usuario.Nombre;
        string prodOrServ; 
        string prodOrServ_Before;


        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void vENTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FRM_Ventas>(0);
            //FRM_Ventas frmVenta = FRM_Ventas.GetInstance();
            //frmVenta.ShowDialog(this);
        }

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FRM_Cliente>(0);
            //FRM_Cliente frmCliente = FRM_Cliente.GetInstance();
            //frmCliente.ShowDialog(this);
        }

        private void pRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prodOrServ_Before = prodOrServ;
            prodOrServ = "P";
            AbrirFormulario<FRM_Producto>(0);
            //FRM_Producto frmProducto = FRM_Producto.GetInscance();
            //frmProducto.ShowDialog(this);
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prodOrServ_Before = prodOrServ;
            prodOrServ = "S";
            AbrirFormulario<FRM_Producto>(1);
        }

        private void cATEGORIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FRM_Categoria>(0);
            //FRM_Categoria frmCategoria = FRM_Categoria.GetInstance();
            //frmCategoria.ShowDialog(this);

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FRM_Usuario>(0);
            //FRM_Usuario Usuario = new FRM_Usuario();
            //Usuario.ShowDialog(this);
        }

        private void cERRARToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            //para saber si es el mismo usuario
            UserTemp = Usuario.Nombre;

            if (MessageBox.Show("¿Estás seguro de cerrar sección " +
                Usuario.Nombre + " " + Usuario.Apellido + "?", "Cerrar Sección",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Usuario.Logged = 0; // para desactivar autologgin
                //DESLOGEARSE
                if (!(FLogin.AutoLoginSet(Usuario.Nombreusuario, Usuario.Password, Usuario.Logged) == 1))
                {
                    MessageBox.Show("No se pudo hacer el cerrado de sección", "Cerado Sección");
                }
                else
                {
                    OpenSettings();
                }

            }
        }





        private void OpenSettings()
        {

            try
            {   // para saber si el formulario existe, o sea si está abierto o cerrado
                Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FRM_Login").SingleOrDefault<Form>();

                if (existe != null)

                {
                    existe.Close();
                }


                pnl_Formularios.Controls.Clear(); // para cerrar todas las ventanas abiertas
                pnl_Formularios.Controls.Add(pbx_Logo);



                FRM_Login login = new FRM_Login();
                login.reOpened++;
                this.Hide();
                login.Show();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }



        private void Form1_Load(object sender, EventArgs e)            
                    
        {
            this.Opacity = 0.95;

            if (Usuario.Tipo != "Admin")
            {
                cONFIGURACIONESToolStripMenuItem.Visible = false;
            }
            else
            {
                cONFIGURACIONESToolStripMenuItem.Visible = true;
            }

            toolStripStatusLabel1.Text = "Usuario - " + Usuario.Nombre + " " + Usuario.Apellido;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Mejora para asegurar que el usuario si quiere salir del programa
                if (MessageBox.Show("¿Estás seguro de salir del programa " +
                Usuario.Nombre + " " + Usuario.Apellido + "?", "Salir del Programa",
                      MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Environment.Exit(1);
                }
                else e.Cancel = true;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            // to put the windows normal
            this.WindowState = FormWindowState.Normal;
            btnMaximize.Visible = true;
            btnRestore.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            // to maximize the windows
            this.WindowState = FormWindowState.Maximized;
            btnMaximize.Visible = false;
            btnRestore.Visible = true;
        }

        #region Funcionalidades del form
        // to be able to move the windows-------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO  TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.pnlMain.Region = region;
            this.Invalidate();
        }

        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {

            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(0, 56, 117));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }
        //------------------------------------------------
        #endregion

        //Form dentro del panel
        public void AbrirFormulario<MiForm>(params object[] args) where MiForm : Form, IFormulario, new()
        {
            Form formulario0;
            formulario0 = pnl_Formularios.Controls.OfType<MiForm>().FirstOrDefault(); //Busca en la coleccion el formulario

            if (formulario0 != null)
            {
                if (formulario0.Text == "Mantenimiento de Producto")
                {
                    if (prodOrServ_Before != prodOrServ)
                    {
                        formulario0.Close();
                    }
                }
            }

            formulario0 = null; // destruyendo formulario0 ya que solo es para pruebas


            Form formulario;
            formulario = pnl_Formularios.Controls.OfType<MiForm>().FirstOrDefault(); //Busca en la coleccion el formulario
            

            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                ((IFormulario)formulario).InicializarParametros(args); // para pasarle parametros
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                pnl_Formularios.Controls.Add(formulario);
                pnl_Formularios.Tag = formulario;
                try
                {
                    formulario.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("Favor intentarlo otra vez", "Advertencia");
                }

                formulario.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (UserTemp != Usuario.Nombre)
            {
                UserTemp = Usuario.Nombre;
                Form1_Load(sender, e);
            }
        }
    }
}
