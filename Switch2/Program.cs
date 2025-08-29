int carreras;
string nombCarreras;


Console.Write("Ingrese un numero: ");
carreras = int.Parse(Console.ReadLine());

switch (carreras)

{
    case 1:
        nombCarreras = "Medicina";
        break;
    case 2:
        nombCarreras = "Arquitectura";
        break;
    case 3:
        nombCarreras = "Sistemas";
        break;
    default:
        nombCarreras = "Numero invalido";
        break;
}

Console.WriteLine(nombCarreras);

