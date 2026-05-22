/*Una tienda de tecnología desea registrar las ventas realizadas durante una semana.
El sistema será desarrollado en equipos de 4 estudiantes utilizando arreglos en C#.*/

/*Integrante 1 — Diseño de datos
Crear los arreglos.
Definir variables y arreglos*/

string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };

// Arreglos paralelos para guardar la información de los 7 días
string[] nombresProductos = new string[7];
int[] cantidades = new int[7];
double[] precios = new double[7];
double[] ventasDiarias = new double[7];

// Variables para cálculos y estadísticas finales
double totalVendidoSemana = 0;
double mayorVenta = 0;
string diaMayorVenta = "";

Console.Clear();

/*Integrante 2 — Entrada de datos
Programar el ingreso de información.
Validar datos */

for (int i = 0; i < 7; i++)
{
    Console.WriteLine($"\n--- Registro del día {dias[i]} ---");

    try
    {
        Console.Write("Ingrese el nombre del producto: ");
        nombresProductos[i] = Console.ReadLine()!;
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ERROR: PARÁMETROS NO VÁLIDOS");
        i--;
        Console.ResetColor();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"ERROR{ex.Message}");
    }

    // Validación: La cantidad debe ser mayor a 0
    try
    {

        do
        {
            Console.Write("Ingrese la cantidad del producto: ");
            cantidades[i] = int.Parse(Console.ReadLine()!);

            if (cantidades[i] < 0)
            {
                Console.WriteLine("Error: La cantidad no puede ser negativa. Intente de nuevo.");
            }
        } while (cantidades[i] < 0);
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ERROR: PARÁMETROS NO VÁLIDOS");
        i--;
        Console.ResetColor();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"ERROR{ex.Message}");
    }


    // Validación: El precio debe ser mayor a 0
    try
    {
        do
        {
            Console.Write("Ingrese el precio del producto: ");
            precios[i] = double.Parse(Console.ReadLine()!);

            if (precios[i] < 0)
            {
                Console.WriteLine("Error: El precio no puede ser negativo. Intente de nuevo.");
            }
        } while (precios[i] < 0);
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ERROR: PARÁMETROS NO VÁLIDOS");
        i--;
        Console.ResetColor();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"ERROR{ex.Message}");
    }


}


/*Integrante 3 — Procesamiento
Realizar cálculos y estadísticas.*/

for (int i = 0; i < 7; i++)
{
    // Calcular el subtotal de ese día (cantidad * precio)
    ventasDiarias[i] = cantidades[i] * precios[i];

    // Sumarlo al acumulador total de la semana
    totalVendidoSemana += ventasDiarias[i];

    // Estadística: Buscar el día con la mayor venta
    if (ventasDiarias[i] > mayorVenta)
    {
        mayorVenta = ventasDiarias[i];
        diaMayorVenta = dias[i]; 
    }
}


/*Integrante 4 — Salida y pruebas
Mostrar reportes.
Probar el sistema y corregir errores.*/

Console.WriteLine("==============================================================");
Console.WriteLine("               REPORTE DE VENTAS DE LA SEMANA                 ");
Console.WriteLine("==============================================================");

// Mostrar el detalle día por día
for (int i = 0; i < 7; i++)
{
    Console.WriteLine($"{dias[i],-10} | Producto: {nombresProductos[i],-10} | Cant: {cantidades[i],-3} | Precio: C${precios[i],-5} | Total: C${ventasDiarias[i]}");
}

Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine($"Total recaudado en la semana: C${totalVendidoSemana}");

// Evitamos mostrar el mensaje de mayor venta si no se vendió nada en toda la semana
if (totalVendidoSemana > 0)
{
    Console.WriteLine($"El día de mayor venta fue el {diaMayorVenta} con un total de C${mayorVenta}");
}
else
{
    Console.WriteLine("No hubo ventas esta semana.");
}
Console.WriteLine("==============================================================");

Console.ReadLine();
