//Dada uma data identificar o dia da semana e número do dia do ano da mesma
Console.WriteLine("Digite uma data:");
var entrada = Console.ReadLine();
var dataEntrada = Convert.ToDateTime(entrada);
var diaDaSemana = dataEntrada.DayOfWeek.ToString().ToLower();
switch (diaDaSemana)
{
    case "sunday":
        Console.WriteLine($"Dia da semana: Domingo |Dia do ano: {dataEntrada.DayOfYear}º");
        break;
    case "monday":
        Console.WriteLine($"Dia da semana: Segunda-feira |Dia do ano: {dataEntrada.DayOfYear}º");
        break;
    case "tuesday":
        Console.WriteLine($"Dia da semana: Terça-feira |Dia do ano: {dataEntrada.DayOfYear}º");
        break;
    case "wednesday":
        Console.WriteLine($"Dia da semana: Quarta-feira |Dia do ano: {dataEntrada.DayOfYear}º");
        break;
    case "thursday":
        Console.WriteLine($"Dia da semana: Quinta-feira |Dia do ano: {dataEntrada.DayOfYear}º");
        break;
    case "friday":
        Console.WriteLine($"Dia da semana: Sexta-feira |Dia do ano: {dataEntrada.DayOfYear}º");
        break;
    case "saturday":
        Console.WriteLine($"Dia da semana: Sábado |Dia do ano: {dataEntrada.DayOfYear}º");
        break;
}
