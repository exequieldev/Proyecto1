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
        private int _cantidad;
        private List<Movimiento> _movimientos = new List<Movimiento>();


        public Producto(string idProducto,string nomrbe, int cantidad)
        {
            _idProducto = idProducto;
            _nomrbe = nomrbe;
            _cantidad = cantidad;
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


        public int Cantidad {

            get { return _cantidad; }
            set
            {
                if (value > 0)
                {
                    _cantidad = value;
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
            return $"Id:{ID},Nombre: {Nombre},Cantidad: {Cantidad}";
        }

        public void CargarMovimientos(List<Movimiento> listaMovimientos)
        {
            _movimientos = listaMovimientos;
        }

        public Movimiento restarUnidades(string idMovimiento, int cantidadUnidades,
            DateTime fecha)
        {
            // Se genera el objeto para registrar el movimiento
            Movimiento descarga = new Movimiento(idMovimiento, -cantidadUnidades,
                fecha);
            // Se carga el movimiento en la lista del objeto
            _movimientos.Add(descarga);
            return descarga;
        }

    }
}
