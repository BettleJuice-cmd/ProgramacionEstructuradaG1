//Verificar si hace calor o no hace calor

int temperatura;

Console.Write("Ingresa el valor de la temperatura: ");
temperatura = int.Parse(Console.ReadLine());

if (temperatura >= 25)
{
    Console.WriteLine("Esta haciendo calor.");
}
else
{
    Console.WriteLine("No esta haciendo calor.");
}