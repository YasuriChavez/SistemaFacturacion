using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionSistema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de Facturacion - Tienda de Tecnologia");

            //Tarea 1 - Capturar datos (producto, precio, tipo cliente)
            string nombreProducto = "";
            double precioBase = 0.0;
            int tipoCliente = 0;


            //Tarea 2 - Calcular descuento segun tipo cliente
            double descuento = 0.0;


            //Tarea 3 - Calcular IGV y precio final
            double igv = 0.0;
            double precioFinal = 0.0;


            //Resultados
            Console.WriteLine("\n--- Factura ---");
            Console.WriteLine("Producto: " + nombreProducto);
            Console.WriteLine("Precio base: " + precioBase.ToString("F2"));
            Console.WriteLine("Descuento aplicado: " + descuento.ToString("F2"));
            Console.WriteLine("IGV (18%): " + igv.ToString("F2"));
            Console.WriteLine("Precio final: " + precioFinal.ToString("F2"));
        }
    }
}
