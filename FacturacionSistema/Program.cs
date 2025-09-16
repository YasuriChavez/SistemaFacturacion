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

            Console.WriteLine("=== Sistema de Facturacion - Tienda de Tecnologia ===");

            //Tarea 1 - Capturar datos (producto, precio, tipo cliente)
            Console.WriteLine("Ingrese el nombre del producto: ");
            nombreProducto = Console.ReadLine();

            Console.WriteLine("Ingrese el precio base del producto: ");
            if(!double.TryParse(Console.ReadLine(), out precioBase) || precioBase <= 0)
            {
                Console.WriteLine("Error: Ingrese un precio valido.");
                return;
            }

            Console.WriteLine("Tipo de cliente : 1 = Frecuente, 2 = Nuevo , 3 = Corporativo");
            Console.WriteLine("Ingrese el tipo de cliente: ");
            if(!int.TryParse(Console.ReadLine(), out tipoCliente))
            {
                Console.WriteLine("Error: Debe ingresar un numero valido.");
            }

            //Tarea 2 - Calcular descuento segun tipo cliente
            double porcentajeDescuento;
            switch (tipoCliente)
            {
                case 1: // Frecuente
                    porcentajeDescuento = 0.10; break;
                case 2: // Nuevo
                    porcentajeDescuento = 0.00; break;
                case 3: // Corporativo
                    porcentajeDescuento = 0.15; break;
                default:
                    Console.WriteLine("Error: Tipo de cliente no valido. Use 1, 2 o 3.");
                    return;
            }
            descuento = precioBase * porcentajeDescuento;

            //Tarea 3 - Calcular IGV y precio final
            double precioDescuento = precioBase - descuento;
            igv = precioDescuento * 0.18;
            precioFinal = precioDescuento + igv;



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
