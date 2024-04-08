global using _06libPedidos;
using _06AplicaciónPedidos;
int opcion = 0;
do
{
    Console.WriteLine("Menú de opciones");
    Console.WriteLine();
    Console.WriteLine("1. Ejemplo de cliente");
    Console.WriteLine("2. Ejemplo de record de productos");
    Console.WriteLine("3. Ejemplo de paso de parámetros a un método");
    Console.WriteLine("4 Ejemplo de colecciones de cliente");
    Console.WriteLine("5. Ejemplo de diccionario de productos");
    Console.WriteLine("20. Salir del programa");
    opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            FuncionesPrincipales.EjemploClientes();
            break;
        case 2:
            FuncionesPrincipales.EjemploRecordProducto(); 
            break;
        case 3:
            FuncionesPrincipales.EjemploDesglosaImpuesto();
            break;
        case 4:
            FuncionesPrincipales.EjemploColeccionesClientes();
            break;
        case 5:
            FuncionesPrincipales.EjemploDiccionario();
            break;
        default:
            break;
    }
} while (opcion != 20);
