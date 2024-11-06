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
            int cantidadInicial = int.Parse(numCantidad.Text);

            Producto unProducto = new Producto(idProducto, nombreProducto, cantidadInicial);

            ProductosController.GuadarProducto(unProducto);
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
            if (this.lstProductos.SelectedIndex != -1) { 
                
                _unProducto = this._ListaProductos[this.lstProductos.SelectedIndex];
                int cantidadIngresada = (int)this.nupCantidadMovimiento.Value;

                if (this.cbxTipoMovimiento.SelectedIndex == 0) {

                    Movimiento unMovimiento = _unProducto.restarUnidades("123", cantidadIngresada, DateTime.Now);
                    ProductosController.AgregarMovimiento(_unProducto, unMovimiento);


                }
                else
                {
                    // TODO: reemplazar ID del movimiento por la opci�n de arriba (fecha como string) u otra
                    // Egreso
                    try
                    {
                        Movimiento unMovimiento = _unProducto.restarUnidades("123", cantidadIngresada, DateTime.Now);
                        ProductosController.AgregarMovimiento(_unProducto, unMovimiento);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                // Se actualiza en el listbox la visualizaci�n
                this.sincronizarListado();
            }
            else
            {
                MessageBox.Show("Se tiene que seleccionar un Producto desde la lista.");
            }
        }
    }
}
