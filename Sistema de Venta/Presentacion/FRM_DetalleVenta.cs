﻿using Sistema_de_Venta.Datos;
using Sistema_de_Venta.Entidades;
using System;
using System.Data;
using System.Windows.Forms;

namespace Sistema_de_Venta.Presentacion
{
    public partial class FRM_DetalleVenta : Form
    {

        private static DataTable dt = new DataTable();
        public static FRM_DetalleVenta _instancia = null;
        string tipoCliente;
        public FRM_DetalleVenta()
        {
            InitializeComponent();
        }
        public static FRM_DetalleVenta GetInstance()
        {
            if (_instancia == null)
                _instancia = new FRM_DetalleVenta();

            return _instancia;
        }


        internal void SetVenta(Venta venta)
        {
            textVentaId.Text = venta.Id.ToString();
            text_ClienteId.Text = venta.Cliente.Id.ToString();
            text_ClienteNombre.Text = venta.Cliente.Nombre;
            text_fecha.Text = venta.FechaVenta.ToString();
            text_NumeroDoc.Text = Convert.ToString(venta.NumeroDocumento);
        }

        private void FRM_DetalleVenta_Load(object sender, EventArgs e)
        {            
            try
            {
                if (txtFlag.Text != " ")
                {

                    DataSet ds = FDetalleVenta.GetAll(Convert.ToInt32((textVentaId.Text)));
                    dt = ds.Tables[0];
                    dgvVentas.DataSource = dt;
                    dgvVentas.Columns["VentaId"].Visible = false;
                    dgvVentas.Columns["ProductoId"].Visible = false;
                    dgvVentas.Columns["Id"].Visible = false;
                    dgvVentas.Columns["PrecioVenta"].Visible = false;

                    try
                    {
                        tipoCliente = dgvVentas.Rows[0].Cells["TipoCliente"].Value.ToString();
                    }
                    catch (Exception)
                    {
                    }
                    dgvVentas.Columns["TipoCliente"].Visible = false;

                    if (dt.Rows.Count > 0)
                    {

                        noencontrado.Visible = false;
                        // dgvVentas_CellClick(null, null);
                    }
                    else
                    {
                        noencontrado.Visible = true;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error inesperado, Favor cerrar y volver a abrir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            CMB_Buscar.Text = "Nombre";
            cbx_ProdSer.Focus();
            cbx_ProdSer.Text = "Producto";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string sresultado;
            try
            {
                sresultado = ValidarDatos();

                if (sresultado == "")
                {
                    DetalleVenta Dventa = new DetalleVenta();

                    Dventa.Venta.Id = Convert.ToInt32(textVentaId.Text);
                    Dventa.Producto.Id = Convert.ToInt32(text_ProductoId.Text);
                    Dventa.Cantidad = Convert.ToInt32(text_Cantidad.Text);
                    Dventa.PrecioUnitario = Convert.ToDouble(text_PrecioUnitario.Text);
                    Dventa.DescripcionVenta = text_DescripcionVenta.Text;

                    int iDVentaId = FDetalleVenta.Insertar(Dventa);

                    if (iDVentaId > 0)
                    {
                        if (cbx_ProdSer.Text == "Producto")
                        {
                            //obteniento nuevo stock
                            int currentStock = Convert.ToInt32(text_stock.Text);
                            string newStock = Convert.ToString(currentStock - Dventa.Cantidad);
                            text_stock.Text = newStock;
                        }


                        //este es el metodo para guardar el log con la accion Detalle de ventas agregados
                        Form1.Log(Usuario.Nombreusuario, "Detalle de ventas agregados ");


                        FRM_DetalleVenta_Load(null, null);
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("El Producto no fue agregado, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }

                else
                {
                    MessageBox.Show(sresultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {                
                if (text_PrecioUnitario.Text == "")
                {
                    MessageBox.Show("Favor seleccionar algún " + cbx_ProdSer.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    text_PrecioUnitario.Focus();
                }
                else
                {
                    MessageBox.Show("Algo salio mal, Favor llenar campos correctamente e intentar denuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            FRM_DetalleVenta_Load(null, null);

        }

        private void Limpiar()
        {
            text_ProductoId.Clear();
            text_ProductoDescripcion.Clear();
            text_stock.Text = "0";
            text_Cantidad.Text = "1";
            text_PrecioUnitario.Clear();

        }

        private string ValidarDatos()
        {
            string Resultado = "";
            if (text_ProductoId.Text == "")
            {
                Resultado = Resultado + " Debe Seleccionar al menos un " + cbx_ProdSer.Text + ". \n";
            }
            if (cbx_ProdSer.Text == "Producto")
            {
                if (Convert.ToInt32(text_Cantidad.Text) > Convert.ToInt32(text_stock.Text))
                {
                    Resultado = Resultado + " La cantidad que intenta vender supera el stock. \n";
                    text_Cantidad.Focus();
                    text_Cantidad.Value = Convert.ToInt32(text_stock.Text);
                }
            }


            return Resultado;
        }

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvVentas.Columns["Eliminar"].Index)
            {
                try
                {
                    DataGridViewCheckBoxCell chkEliminar =
                    (DataGridViewCheckBoxCell)dgvVentas.Rows[e.RowIndex].Cells["Eliminar"];
                    chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
                }
                catch (Exception)
                {                    
                    MessageBox.Show("Algo está mal, Favor intentar denuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Esta seguro de eliminar los productos seleccionados?", "Eliminacion de Producto", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    foreach (DataGridViewRow row in dgvVentas.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Eliminar"].Value))
                        {
                            DetalleVenta Dventa = new DetalleVenta();
                            Dventa.Producto.Id = Convert.ToInt32(row.Cells["ProductoId"].Value);
                            Dventa.Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);

                            Dventa.Id = Convert.ToInt32(row.Cells["Id"].Value);
                            if (!(FDetalleVenta.Eliminar(Dventa) > 0))
                            {
                                MessageBox.Show("El producto no pudo ser quitado de la venta. Intente nuevamente", "Eliminacion de Producto",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    FRM_DetalleVenta_Load(null, null);
                    Limpiar();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Algo está mal, Favor intentar denuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            FRM_ReporteVenta frmRepVenta = new FRM_ReporteVenta();
            frmRepVenta.SetVentaId_y_TipoCliente(Convert.ToInt32(textVentaId.Text), tipoCliente);
            frmRepVenta.ShowDialog();
            //este es el metodo para guardar el log con la accion Facturar
            Form1.Log(Usuario.Nombreusuario, "Facturar venta ");
        }

        private void text_ProductoDescripcion_MouseClick(object sender, MouseEventArgs e)
        {        
            FRM_Producto FRMPro = new FRM_Producto();
            FRMPro.SetFlag("1");
            FRMPro.ProdServ(cbx_ProdSer.Text == "Producto" ? 0 : 1); // si es un producto es = 0, si es un servicio = 1
            FRMPro.WindowState = FormWindowState.Maximized;
            DialogResult res = FRMPro.ShowDialog(); //abrimos el Categoría como cuadro de dialogo modal

            if (res == DialogResult.OK)
            {
                //recuperando la variable publica del formulario Categoría
                text_ProductoId.Text = FRMPro.id_Producto;//asignamos al texbox el dato de la variable
                text_ProductoDescripcion.Text = FRMPro.nombre_Producto;
                text_stock.Text = FRMPro.stock_Producto;
                text_PrecioUnitario.Text = FRMPro.precioVenta_Producto;                
            }
        }

        private void Buscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = new DataView(dt.Copy());
                if (CMB_Buscar.Text == "Nombre")
                {
                    dv.RowFilter = CMB_Buscar.Text + " LIKE '" + Buscar.Text + "%'";
                }
                else if (Buscar.Text != "")
                {
                    if (Buscar.Text != "")
                    {
                        try
                        {
                            if (Convert.ToInt32(Buscar.Text) >= 0)
                                dv.RowFilter = CMB_Buscar.Text + " = " + Buscar.Text;
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Favor escribir un valor correcto", "Texto incorrecto");
                            Buscar.Text = "";
                            Buscar.Focus();
                        }
                    }
                }

                dgvVentas.DataSource = dv;

                if (dv.Count == 0)
                {
                    noencontrado.Visible = true;
                }
                else
                {
                    noencontrado.Visible = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Favor escribir un valor correcto", "Texto incorrecto");
                Buscar.Text = "";
                Buscar.Focus();
            }
        }

        private void CMB_Buscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Buscar_TextChanged(null, null);
            Buscar.Focus();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ProdSev_Limpiar(bool limpiar)
        {
            lab_Cantidad.Visible = limpiar;
            lab_stock.Visible = limpiar;
            text_Cantidad.Visible = limpiar;
            text_stock.Visible = limpiar;
        }

        private void cbx_ProdSer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_ProdSer.Text == "Servicio")
            {
                ProdSev_Limpiar(false);
                lab_valor.Text = "Valor/Sev";
            }
            else
            {
                ProdSev_Limpiar(true);
                lab_valor.Text = "Valor/Prod";
            }

            text_ProductoDescripcion.Text = "<< HACER CLIC >>";
            text_PrecioUnitario.Text = "";
        }

        private void text_ProductoDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validadores.EnterPress_Tab(e);
        }

        private void text_PrecioUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validadores.EnterPress_TabyValidar(e, "0123456789.\b");
        }

        private void text_DescripcionVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validadores.EnterPress_Tab(e);
        }

        private void text_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validadores.EnterPress_TabyValidar(e, "0123456789\b");
            
            // 'e' almacena la tecla presionada
            if (e.KeyChar == (char)13) //si la tecla pesionada es igual a ENTER (13)
            {
                e.Handled = true; //.Handled significa que nosotros nos haremos cargo del codigo
                                  //al ser true, evita que apareca la tecla presionada
                btnAgregar.PerformClick(); // permite hacer clic en el boton por codigo.
            }
        }

        private void text_stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validadores.EnterPress_TabyValidar(e, "0123456789\b");
        }
    }
}
