/* 4 - Desenvolver um  algoritmo  para  converter  a  temperatura  em  graus  Celsius  para  Fahrenheit,
   a fórmula é F = (9 * C + 160) / 5; */
int conversaoTemp;

Console.WriteLine($"Qual é a sua temperatura atual (em Celsius)?");
int tempCelsius = int.Parse(Console.ReadLine());

conversaoTemp = (9 * tempCelsius + 160) / 5;

Console.WriteLine($"Aplicando a conversão de Cº para Fº, a temperatura atual é de: {conversaoTemp}");
Console.WriteLine();