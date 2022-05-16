/* 5 - Desenvolver um  algoritmo  para  converter  a  temperatura  em  graus Fahrenheit para Celsius,
   a fórmula é C = (F - 32) * 5 / 9; */
int conversaoTemp2;

Console.WriteLine($"Qual é a sua temperatura atual (em Fahrenheit)?");
int tempFahren = int.Parse(Console.ReadLine());

conversaoTemp2 = (tempFahren - 32) * 5 / 9;

Console.WriteLine($"Aplicando a conversão de Fº para Cº, a temperatura atual é de: {conversaoTemp2}");
Console.WriteLine();