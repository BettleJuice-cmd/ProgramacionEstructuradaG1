//Verificar si es mayor o menor de edad

int edad;
Console.Write("Dime tu edad: ");
edad = int.Parse(Console.ReadLine());


if (edad >= 18)
{
    Console.WriteLine("Eres mayor de edad.");
}
else
{
    Console.WriteLine("Eres menor de edad.");
}