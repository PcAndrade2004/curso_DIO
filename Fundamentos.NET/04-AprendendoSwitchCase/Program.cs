Console.WriteLine("## Switch Case ##\n");

string diaSemana = "Terça-feira";

switch (diaSemana)
{
    case "Segunda-feira":
        Console.WriteLine("Hoje é segunda-feira");
        break;
    case "Terça-feira":
        Console.WriteLine("Hoje é terça-feira");
        break;
    case "Quarta-feira":
        Console.WriteLine("Hoje é quarta-feira");
        break;
    case "Quinta-feira":
        Console.WriteLine("Hoje é quinta-feira");
        break;
    case "Sexta-feira":
        Console.WriteLine("Hoje é sexta-feira");
        break;
    case "Sábado":
        Console.WriteLine("Hoje é sábado");
        break;
    case "Domingo":
        Console.WriteLine("Hoje é domingo");
        break;
    default:
        Console.WriteLine("Dia da semana inválido");
        break;
}


Console.ReadLine();