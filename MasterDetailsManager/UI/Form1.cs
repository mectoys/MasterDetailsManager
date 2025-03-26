using BLL;
using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace UI
{
    public partial class MasterDetails : Form
    {
        int Tipo = 0;
        bool Modostatusedit;
        private FacturaBLL _facturaBLL = new FacturaBLL();
        private List<FacturaDetalle> _detalles = new List<FacturaDetalle>();
        DataSet dsdatos;

        public MasterDetails()
        {
            InitializeComponent();

            detalle.ColumnCount = 5;
            detalle.Columns[0].Name = "producto";
            detalle.Columns[1].Name = "Precio";
            detalle.Columns[2].Name = "Cantidad";
            detalle.Columns[3].Name = "Id";
            detalle.Columns[4].Name = "Total";
            dsdatos = _facturaBLL.ObtenerFactura();
            listado.DataSource = dsdatos;
            listado.DataMember = "Factura";
            detalle.Columns[3].Visible = false;
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            decimal varTotal;

            if (producto.Text.Length==0)
            {
                MessageBox.Show("Ingrese Producto", "Master Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                producto.Focus();
                return;
            }
            if (cantidad.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Cantidad", "Master Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cantidad.Focus();
                return;
            }
            if (precio.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Precio", "Master Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                precio.Focus(); 
                return;
            }
            varTotal = Convert.ToDecimal(cantidad.Text) * Convert.ToDecimal(precio.Text);

            if (Modostatusedit == false)
            {
                var detalleX = new FacturaDetalle
                {

                    Producto = producto.Text,
                    Cantidad = Convert.ToInt16(cantidad.Text),
                    Precio = Convert.ToDecimal(precio.Text)
                };
                _detalles.Add(detalleX);
                
                detalle.Rows.Add(producto.Text, precio.Text, cantidad.Text, 0, varTotal);
            }
            else
            {
                varTotal = Convert.ToDecimal(cantidad.Text) * Convert.ToDecimal(precio.Text);
                detalle["producto", detalle.CurrentCell.RowIndex].Value = producto.Text;
                detalle["Precio", detalle.CurrentCell.RowIndex].Value = precio.Text;
                detalle["Cantidad", detalle.CurrentCell.RowIndex].Value = cantidad.Text;
                detalle["Total", detalle.CurrentCell.RowIndex].Value = varTotal;
            }
            Modostatusedit = false;
            producto.Clear();
            precio.Clear();
            cantidad.Clear();
            producto.Focus();
            CalcularTotal();

        }


        private List<FacturaDetalle> ObtenerDetallesDesdeUI()
        {
            var detalles = new List<FacturaDetalle>();

            foreach (DataGridViewRow row in detalle.Rows)
            {
                // Saltar filas vacías (por ejemplo, la última fila si está vacía).
                if (row.IsNewRow) continue;

                detalles.Add(new FacturaDetalle
                {
                    Id = Convert.ToInt32(row.Cells["Id"].Value),// Si el ID es 0, se trata de un nuevo detalle.
                    FacturaId = Convert.ToInt16(codigo.Text),
                    Producto = Convert.ToString(row.Cells["producto"].Value),
                    Cantidad = Convert.ToInt32(row.Cells["cantidad"].Value),
                    Precio = Convert.ToDecimal(row.Cells["precio"].Value)
                });
            }

            return detalles;
        }

        private void detalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (detalle.RowCount > 0)
            {
                if (detalle["producto", detalle.CurrentCell.RowIndex].Value != null)
                {
                    producto.Text = detalle["producto", detalle.CurrentCell.RowIndex].Value.ToString();
                    precio.Text = detalle["Precio", detalle.CurrentCell.RowIndex].Value.ToString();
                    cantidad.Text = detalle["Cantidad", detalle.CurrentCell.RowIndex].Value.ToString();
                    Modostatusedit = true;
                }
            }
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            if (cliente.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Cliente", "Master Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cliente.Focus();
                return;
            }
            if (detalle.Rows.Count==0)
            {
                MessageBox.Show("Ingrese datos al detalle", "Master Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cliente.Focus();
                return;
            }

            if (Tipo == 0)
            {
                var factura = new Factura
                {
                    Cliente = cliente.Text,
                    Fecha = fecha.Value,
                    Detalles = _detalles

                };

                codigo.Text= _facturaBLL.CrearFactura(factura).ToString();
            }
            else if (Tipo == 1)
            {
                var factura = new Factura
                {
                    Id = Convert.ToInt16(codigo.Text),
                    Cliente = cliente.Text,
                    Fecha = fecha.Value,
                    Detalles = ObtenerDetallesDesdeUI()

                };
                _facturaBLL.ActualizarFactura(factura);

            }
            Tipo = 1;
            CalcularTotal();
            MessageBox.Show("Operaación realizada", "Master Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TabMasterDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabMasterDetails.SelectedIndex == 0)
            {
                dsdatos = _facturaBLL.ObtenerFactura();
                listado.DataSource = dsdatos;
                listado.DataMember = "Factura";
            }
        }

        private void listado_DoubleClick(object sender, EventArgs e)
        {
            Tipo = 1;
            codigo.Text = listado["Id", listado.CurrentCell.RowIndex].Value.ToString();
            cliente.Text = listado["Cliente", listado.CurrentCell.RowIndex].Value.ToString();
            fecha.Value = Convert.ToDateTime(listado["Fecha", listado.CurrentCell.RowIndex].Value.ToString());

            //Llama a la capa BLL para obtener el detalle
            var details = _facturaBLL.ObtenerDetalleFactura(Convert.ToInt32(codigo.Text));
            //detalle.DataSource = detalles;
            detalle.Rows.Clear();
            foreach (var detail in details)
            {
                detalle.Rows.Add(detail.Producto, detail.Precio, detail.Cantidad, detail.Id,detail.Total);
            }
            CalcularTotal();
            TabMasterDetails.SelectedIndex = 1;
        }

        private void retirar_Click(object sender, EventArgs e)
        {
            if (detalle.RowCount > 0)
            {
                DialogResult resultado = MessageBox.Show("Desea eliminar el item?", Application.ProductName, MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    if (detalle["producto", 0].Value != null) detalle.Rows.RemoveAt(detalle.SelectedCells[0].RowIndex);
                    CalcularTotal();
                }
            }
        }

        private void BuscarInformacion(TextBox valorBuscar)
        {
            DataView dv = null;
            dv = new DataView(dsdatos.Tables["Factura"], "Cliente LIKE '*" + valorBuscar.Text.Replace("'", "") + "*' ", "Cliente Desc", DataViewRowState.CurrentRows);
            listado.DataSource = dv;
        }

        private void busqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) BuscarInformacion(busqueda);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (codigo.Text.Length > 0)
            {
                DialogResult resultado = MessageBox.Show("Desea Anular el registro?", Application.ProductName, MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var factura = new Factura
                    {
                        Id = Convert.ToInt32(codigo.Text)
                    };
                    _facturaBLL.AnularFactura(factura);
                    Limpiar();
                    MessageBox.Show("Operaación realizada", "Master Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            TabMasterDetails.SelectedIndex = 1;
        }
        private void Limpiar()
        {
            Tipo = 0;
            codigo.Clear();
            cliente.Clear();
            fecha.Value = DateTime.Now;
            producto.Clear();
            cantidad.Clear();
            precio.Clear();
            detalle.Rows.Clear();
            Modostatusedit = false;
        }

        private void MasterDetails_Load(object sender, EventArgs e)
        {

        }

        private void CalcularTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in detalle.Rows)
            {
                if (row.Cells["Total"].Value != null)
                {
                    decimal valor;
                    if (decimal.TryParse(row.Cells["Total"].Value.ToString(), out valor))
                    {
                        total += valor;
                    }
                }
            }

            totales.Text = "Total: " + total.ToString("N2"); // Formato con 2 decimales
        }

        private void detalle_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo números y la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada del carácter no permitido
            }
        }

        private void precio_KeyPress(object sender, KeyPressEventArgs e)
        {
                // Permitir números, un solo punto decimal y la tecla de retroceso
    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
    {
        e.Handled = true;
    }

    // Evitar múltiples puntos decimales
    if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
    {
        e.Handled = true;
    }
        }
    }
}
