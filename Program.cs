using System.IO.Compression;

string mes = "";
int dias = 0;
Console.WriteLine("---------------");
Console.WriteLine("Dias de um mês");
Console.WriteLine("---------------\n");

Console.Write("Informe o mês por extenso: ");
mes = Console.ReadLine()! .ToUpper();

switch(mes)
{
    case "JANEIRO":
        dias = 31;
        break;
    case "FEVEREIRO":
        dias = 28;
        break;
    case "MARÇO":
        dias = 31;
        break;
    case "ABRIL":
        dias = 30;
        break;
    case "MAIO":
        dias = 31;
        break;
    case "JUNHO":
        dias = 30;
        break;
    case "JULHO":
        dias = 31;
        break;
    case "AGOSTO":
        dias = 31;
        break;
    case "SETEMBRO":
        dias = 30;
        break;
    case "OUTUBRO":
        dias = 31;
        break;
    case "NOVEMBRO":
        dias = 30;
        break;
    case "DEZEMBRO":
        dias = 31;
        break;
    default:
        Console.WriteLine("Mês inválido");
        break;
}

if (dias > 0)
{
    Console.WriteLine($"mês do {mes} possui {dias} dias");
}
