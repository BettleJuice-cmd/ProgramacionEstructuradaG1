//Desarrolle un programa que calcule el área total en manzanas de un terreno rectangular en una finca nicaragüense, 
//donde el usuario ingresa la longitud y el ancho en varas (1 manzana = 1,428.8 varas²), 
//utilizando una cantidad fija de 5 varas de ancho y la longitud como entrada.


int ancho = 5;
double result2;
double manzana = 1428.8;
int longitud, result;
Console.Write("Ingrese la longitud de su terreno: ");
longitud = Convert.ToInt32(Console.ReadLine());

result = ancho * longitud;
result2 = Convert.ToDouble( manzana / result);

Console.WriteLine("El area total de su terreno en manzanas es de: " + result2);

