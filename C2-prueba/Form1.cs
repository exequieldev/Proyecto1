using System.Data;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C2_prueba
{
    public partial class Form1 : Form
    {
        private List<Producto> _ListaProductos = new List<Producto>();
        private Producto _unProducto;
        public Form1()
        {
            InitializeComponent();

            dgvProductos.BorderStyle = BorderStyle.FixedSingle;
            dgvProductos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProductos.DefaultCellStyle.BackColor = Color.White;
            dgvProductos.DefaultCellStyle.ForeColor = Color.Black;
            dgvProductos.DefaultCellStyle.Font = new Font("Arial", 9);
            dgvProductos.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgvProductos.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvProductos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            dgvProductos.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgvProductos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProductos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dgvProductos.EnableHeadersVisualStyles = false;

            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.MultiSelect = false;
            dgvProductos.AllowUserToResizeRows = false;
            //dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
           
            dgvProductos.RowTemplate.Height = 30;

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void sincronizarListado()
        {
            // Este metodo carga todos los productos al lisybox de la ui
            //this.lstProductos.Items.Clear();
          
            try
            {
                _ListaProductos = ProductosController.LeerProductos();
                DataTable dataTable = new DataTable();

                //Definimos las columnas
                dataTable.Columns.Add("ID", typeof(int));
                dataTable.Columns.Add("Nombre", typeof(string));
                dataTable.Columns.Add("Stock", typeof(int));

                foreach (var producto in _ListaProductos)
                {
                    //this.lstProductos.Items.Add(producto);
                    
                    dataTable.Rows.Add(producto.ID, producto.Nombre, producto.StockActual);
                }

                dgvProductos.DataSource = dataTable;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hubo un error en la lectura de productos");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Guardar el producto
            string idProducto = txtID.Text;
            string nombreProducto = txtNombre.Text;
            

            Producto unProducto = new Producto(idProducto, nombreProducto);

            ProductosController.GuadarProducto(unProducto);

            txtID.Text = "";
            txtNombre.Text = "";
            

            sincronizarListado();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sincronizarListado();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string idMovimiento = DateTime.Now.ToString().Replace("/", "").Replace(":", "").Replace(" ", "");
            if (dgvProductos.SelectedRows.Count > 0) {
               
                _unProducto = this._ListaProductos[dgvProductos.CurrentCell.RowIndex];
                int cantidadIngresada = (int)this.nupCantidadMovimiento.Value;
                
                if (this.cbxTipoMovimiento.SelectedIndex == 0) {
                    
                    Movimiento unMovimiento = _unProducto.agregarUnidades(idMovimiento, cantidadIngresada, DateTime.Now);
                    ProductosController.AgregarMovimiento(_unProducto, unMovimiento);
                    MessageBox.Show("Se agrego un nuevo movimiento");

                }
                else
                {

                    try
                    {
                        if (_unProducto.StockActual == 0)
                        {
                            MessageBox.Show("Este producto no tiene stock actual");
                        }
                        else {
                            Movimiento unMovimiento = _unProducto.restarUnidades(idMovimiento, cantidadIngresada, DateTime.Now);
                            ProductosController.AgregarMovimiento(_unProducto, unMovimiento);
                            MessageBox.Show("Se resto un nuevo movimiento");
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                // Se actualiza en el listbox la visualizaci�n
                nupCantidadMovimiento.Text = "";
                cbxTipoMovimiento.SelectedIndex = -1;
                this.sincronizarListado();
            }
            else
            {
                MessageBox.Show("Se tiene que seleccionar un Producto desde la lista.");
            }
        }
    }
}
