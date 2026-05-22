/*Una tienda de tecnología desea registrar las ventas realizadas durante una semana.
El sistema será desarrollado en equipos de 4 estudiantes utilizando arreglos en C#*/

/*Integrante 1 — Diseño de datos
Crear los arreglos.
Definir variables y arreglos.*/

using System;

int [] ventas = new int[7];
int[,] productos = new int[3, 3];
string nombreProducto = "";
int precio = 0;
int cantidad = 0;
int menu = 0;

/*Integrante 2 — Entrada de datos
Programar el ingreso de información.
Validar datos.*/

/*Integrante 3 — Procesamiento
Realizar cálculos y estadísticas.*/

/*Integrante 4 — Salida y pruebas
Mostrar reportes.
Probar el sistema y corregir errores.*/
Console.WriteLine("Bienvenido a la tienda de tecnologia");

Console.WriteLine("Ingrese el nombre del producto");
nombreProducto = Console.ReadLine();

Console.WriteLine("Ingrese el precio del producto");
precio = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad del producto");
cantidad = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el dia de la semana (1-7)");
menu = int.Parse(Console.ReadLine());

ventas[menu - 1] += precio * cantidad;

productos[0, 0] = precio;
productos[0, 1] = cantidad;
productos[0, 2] = precio * cantidad;

Console.WriteLine("Venta registrada exitosamente");

