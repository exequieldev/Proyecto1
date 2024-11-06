using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_prueba
{
    internal class Movimiento
    {
        public string Id { get; }
        public int Cantidad { get; }
        public DateTime Fecha { get; }

        public Movimiento(string id, int cantidad,
            DateTime fecha)
        {
            Id = id;
            Cantidad = cantidad;
            Fecha = fecha;
        }


    }
}
