int calificacion;

Console.Write("Ingrese su calificacion: ");
calificacion = int.Parse(Console.ReadLine());

if (calificacion >= 90)
{
    Console.WriteLine("Excelente");
}
else if (calificacion >= 80)
{
    Console.WriteLine("Muy bien");
}
else if (calificacion >= 70)
{
    Console.Write("Bien");
}
else
{
    Console.WriteLine("Necesitas mejorar...");
}