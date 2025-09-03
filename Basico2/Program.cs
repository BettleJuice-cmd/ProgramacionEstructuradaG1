//Desarrolle un programa que calcule el tiempo total en horas de un viaje en bus desde Managua a Granada, 
//donde el usuario ingresa la velocidad promedio en kilómetros por hora como entrada, 
//asumiendo una distancia fija de 40 kilómetros

int distancia = 40;
int velocidad;
double tiempo;


Console.Write("Ingrese la velocidad a la que se desplaza: ");
velocidad = Convert.ToInt32(Console.ReadLine());

tiempo = distancia / velocidad;

Console.WriteLine("Este es el tiempo total de su viaje en horas: " + tiempo);