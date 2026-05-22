/*Una tienda de tecnología desea registrar las ventas realizadas durante una semana.
El sistema será desarrollado en equipos de 4 estudiantes utilizando arreglos en C#*/

/*Integrante 1 — Diseño de datos
Crear los arreglos.
Definir variables y arreglos.*/

/*Integrante 2 — Entrada de datos
Programar el ingreso de información.
Validar datos.*/

/*Integrante 3 — Procesamiento
Realizar cálculos y estadísticas.*/

/*Integrante 4 — Salida y pruebas
Mostrar reportes.
Probar el sistema y corregir errores.*/
Console.WriteLine("==============================================================");
Console.WriteLine("               REPORTE DE VENTAS DE LA SEMANA                 ");
Console.WriteLine("==============================================================");

// Mostrar el detalle día por día
for (int i = 0; i < 7; i++)
{
    Console.WriteLine($"{dias[i],-10} | Producto: {nombresProductos[i],-10} | Cant: {cantidades[i],-3} | Precio: ${precios[i],-5} | Total: ${ventasDiarias[i]}");
}

Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine($"Total recaudado en la semana: ${totalVendidoSemana}");

// Evitamos mostrar el mensaje de mayor venta si no se vendió nada en toda la semana
if (totalVendidoSemana > 0)
{
    Console.WriteLine($"El día de mayor venta fue el {diaMayorVenta} con un total de ${mayorVenta}");
}
else
{
    Console.WriteLine("No hubo ventas esta semana.");
}
Console.WriteLine("==============================================================");

Console.ReadLine();

