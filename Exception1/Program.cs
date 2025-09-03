//Un grupo de estudiantes de la UAM viaja a León para una visita técnica. Deben repartir equitativamente los costos (combustible, peajes, refrigerios).
//Solicite: costo total (C$) y número de participantes.
//Calcule costo por persona.
//Maneje división entre cero mostrando un mensaje claro y registrando el incidente





internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            int Costo, estudiantes;
            double costoPersona;
            Console.Write("Ingrese el Costo total: ");
            Costo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el numero de participantes: ");
            estudiantes = Convert.ToInt32(Console.ReadLine());
            costoPersona = Costo / estudiantes;
            Console.WriteLine("El costo por persona es de: " + costoPersona);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: No se puede dividir entre cero");
        }
        finally
        {
            Console.WriteLine("Este bloque siempre se ejecuta");
        }
    }
}
