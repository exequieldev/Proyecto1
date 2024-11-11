using System.Windows.Forms;

namespace C2_prueba
{
    public partial class Form1 : Form
    {
        private List<Producto> _ListaProductos = new List<Producto>();
        private Producto _unProducto;
        public Form1()
        {
            InitializeComponent();
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
            this.lstProductos.Items.Clear();
          


            try
            {
                _ListaProductos = ProductosController.LeerProductos();
                foreach (var producto in _ListaProductos)
                {
                    this.lstProductos.Items.Add(producto);
                }
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
            if (this.lstProductos.SelectedIndex != -1) {
               
                _unProducto = this._ListaProductos[this.lstProductos.SelectedIndex];
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
