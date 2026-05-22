/*Una tienda de tecnología desea registrar las ventas realizadas durante una semana.
El sistema será desarrollado en equipos de 4 estudiantes utilizando arreglos en C#*/

/*Integrante 1 — Diseño de datos
Crear los arreglos.
Definir variables y arreglos.*/

string[] dias = {"Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };

string[] nombresProductos = new string[7];
int[] cantidades = new int[7];
double[] precios = new double[7];
double[] ventasDiarias = new double[7];

double totalVendidoSemana = 0;
double mayorVenta = 0;
string diaMayorVenta = "";

/*Integrante 2 — Entrada de datos
Programar el ingreso de información.
Validar datos.*/
for (int i = 0; i < dias.Length; i++)
{
    try
    {
    Console.WriteLine($"Ingrese el nombre del producto vendido el {dias[i]}:");
    nombresProductos[i] = Console.ReadLine();

    Console.WriteLine($"Ingrese la cantidad vendida el {dias[i]}:");
    cantidades[i] = int.Parse(Console.ReadLine());

    Console.WriteLine($"Ingrese el precio del producto el {dias[i]}:");
    precios[i] = double.Parse(Console.ReadLine());
}
catch (FormatException)
{
    Console.WriteLine("Error: Ingrese un valor válido.");
}
}

/*Integrante 3 — Procesamiento
Realizar cálculos y estadísticas.*/

/*Integrante 4 — Salida y pruebas
Mostrar reportes.
Probar el sistema y corregir errores.*/
