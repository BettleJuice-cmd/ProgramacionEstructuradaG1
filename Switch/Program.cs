int diaSemana;
string nombreDia;

Console.Write("Ingrese un numero: ");
diaSemana = int.Parse(Console.ReadLine());

switch (diaSemana)
{
    case 1:
        nombreDia = "Lunes";
        break;
    case 2:
        nombreDia = "Martes";
        break;
    case 3:
        nombreDia = "Miercoles";
        break;
    case 4:
        nombreDia = "Jueves";
        break;
    case 5:
        nombreDia = "Viernes";
        break;
    case 6:
        nombreDia = "Sabado";
        break;
    case 7:
        nombreDia = "Domingo";
        break;
    default:
        nombreDia = "Dia invalido";
        break;
}

Console.WriteLine(nombreDia);