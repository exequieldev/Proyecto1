using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_prueba
{
    internal class Producto
    {
        private string _idProducto;
        private string _nomrbe;
        private List<Movimiento> _movimientos = new List<Movimiento>();


        public Producto(string idProducto,string nomrbe)
        {
            _idProducto = idProducto;
            _nomrbe = nomrbe;
            
        }

        public string Nombre {

            get { return _nomrbe; } 
            set {
                if (value !=  String.Empty)
                {
                    _nomrbe = value;
                }
            } 
        
        }


        

        public string ID
        {

            get { return _idProducto; }
            set
            {
                if (value != String.Empty)
                {
                    _idProducto = value;
                }
            }

        }

        public override string ToString()
        {
            return $"Id:{ID},Nombre: {Nombre}, Stock Actual: {this.StockActual}";
        }

        public int StockActual
        {
            get
            {
                int stockActual = 0;
                foreach (var movimiento in this._movimientos)
                {
                    stockActual += movimiento.Cantidad;
                }
                return stockActual;
            }
        }

        public void CargarMovimientos(List<Movimiento> listaMovimientos)
        {
            _movimientos = listaMovimientos;
        }

        // Se definen los métodos para agregar y restar stock
        public Movimiento agregarUnidades(string idMovimiento, int cantidadUnidades,
            DateTime fecha)
        {
            // Se genera el objeto para registrar el movimiento
            Movimiento carga = new Movimiento(idMovimiento, cantidadUnidades,
                fecha);
            // Se carga el movimiento en la lista del objeto
            _movimientos.Add(carga);
            return carga;
        }

        public Movimiento restarUnidades(string idMovimiento, int cantidadUnidades,
            DateTime fecha)
        {
            // Se genera el objeto para registrar el movimiento
            Movimiento descarga = new Movimiento(idMovimiento, -cantidadUnidades,fecha);
            // Se carga el movimiento en la lista del objeto
            _movimientos.Remove(descarga);

            return descarga;
        }

    }
}
