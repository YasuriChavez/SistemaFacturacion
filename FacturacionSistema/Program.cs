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
            string nombreProducto;
            int tipoCliente;
            double precioBase, descuento, igv, precioFinal;

            Console.WriteLine("Sistema de Facturacion - Tienda de Tecnologia");

            //Tarea 1 - Capturar datos (producto, precio, tipo cliente)
            Console.WriteLine("Ingrese el nombre del producto: ");
            nombreProducto = Console.ReadLine();
            Console.WriteLine("Ingrese el precio base del producto: ");
            precioBase = double.Parse(Console.ReadLine());
            Console.WriteLine("Tipo de cliente : 1 = Frecuente, 2 = Nuevo , 3 = Corporativo");
            Console.WriteLine("Ingrese el tipo de cliente: ");
            tipoCliente = int.Parse(Console.ReadLine());

            //Tarea 2 - Calcular descuento segun tipo cliente
            switch (tipoCliente)
            {
                case 1: // Frecuente
                    descuento = 0.10; break;
                case 2: // Nuevo
                    descuento = 0.00; break;
                case 3: // Corporativo
                    descuento = 0.15; break;
                default:
                    Console.WriteLine("Error: Tipo de cliente no válido. Use 1, 2 o 3.");
                    return;
            }
            //Tarea 3 - Calcular IGV y precio final
            igv = 0.0;
            precioFinal = 0.0;


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
