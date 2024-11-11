﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_prueba
{
    internal static class ProductosService
    {
        static string GetAppPath()
        {
            return AppContext.BaseDirectory;
        }

         public static void GuardarProducto(Producto unProducto)
        {
            // Se establece el nombre del archivo a escribir
            string fileName = Path.Combine(GetAppPath(), "datos.txt");

            if (!File.Exists(fileName))
            {
                // Se crea y escribe el archivo ya que no existe
                // Se genera un StreamWriter para controlar la escritura de datos
                using (StreamWriter archivoSalida = new StreamWriter(fileName))
                {
                    // Se recorre la colección de cadenas de caracteres y se escribe al archivo
                    string data = $"{unProducto.ID};{unProducto.Nombre}";
                    archivoSalida.WriteLine(data);


                }
            }
            else
            {
                // Se añaden datos al archivo ya que existe, para eso se establece el segundo parámetro
                using (StreamWriter archivoSalida = new StreamWriter(fileName, true))
                {
                    string datos = $"{unProducto.ID};{unProducto.Nombre}";
                    archivoSalida.WriteLine(datos);
                }
            }
        }

        public static List<Producto> LeerProductos()
        {
            // Se establece el nombre del archivo a leer
            string fileName = Path.Combine(GetAppPath(), "datos.txt");
            if (File.Exists(fileName))
            {
                // Se lee el archivo ya que existe
                // Se genera un StreamReader para controlar la lectura de datos
                //using (StreamReader archivoEntrada = new StreamReader(fileName))
                //{
                // Se lee el archivo completo
                //    string contenido = archivoEntrada.ReadLine();
                //    Console.WriteLine(contenido);
                //}
                List<Producto> productos = new List<Producto>();
                string[] lineas = File.ReadAllLines(fileName);
                foreach (string productoComoTexto in lineas)
                {
                    var datos = productoComoTexto.Split(";");
                    // si se cambia (eliminando) el campo de cantidad se tiene que modificar acá la lectura
                    Producto unProducto = new Producto(datos[0], datos[1]);
                    productos.Add(unProducto);
                }
                return productos;
            }
            else
            {
                
                throw new Exception("No hay producto disponible");
            }
        }
    }
}
