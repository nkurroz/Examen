//Integrante 1 — Diseño de datos
//Crear los arreglos.
//Definir variables y arreglos.//

string[] dias = {"Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };

// Arreglos paralelos para guardar la información de los 7 días
string[] nombresProductos = new string[7];
int[] cantidades = new int[7];
double[] precios = new double[7];
double[] ventasDiarias = new double[7];

// Variables para cálculos y estadísticas finales
double totalVendidoSemana = 0;
double mayorVenta = 0;
string diaMayorVenta = "";

/*Integrante 2 — Entrada de datos
Programar el ingreso de información.
Validar datos.*/

/*Integrante 3 — Procesamiento
Realizar cálculos y estadísticas.*/

int mayorCantidadUnidades = -1; 
string productoMasVendido = "";

for (int i = 0; i < 7; i++)//7 dias la semana
{
    //subtotal
    ventasDiarias[i] = cantidades[i] * precios[i];

    totalVendidoSemana += ventasDiarias[i];

   //dia con mayor venta
    if (ventasDiarias[i] > mayorVenta)
    {
        mayorVenta = ventasDiarias[i];
        diaMayorVenta = dias[i]; 
    }
    //mayor venta
    if (cantidades[i] > mayorCantidadUnidades)
    {
        mayorCantidadUnidades = cantidades[i];
        productoMasVendido = nombresProductos[i];
        // Guardamos el nombre del producto de ese día
    }
}

//promedio 
double promedio = totalVendidoSemana / 7;
Console.WriteLine($"El promedio de venta es {promedio}");

/*Integrante 4 — Salida y pruebas
Mostrar reportes.
Probar el sistema y corregir errores.*/
