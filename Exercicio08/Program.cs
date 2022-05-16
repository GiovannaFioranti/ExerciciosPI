/* 8 - Desenvolver um algoritmo que leia dois valores, A e B, utilizar operador aritmético de subtração
   e imprimir o total;[OPCIONAL]: Se o valor for negativo, imprimir TOTAL NEGATIVO senão TOTAL POSITIVO; */
double varA;
double varB;

Console.WriteLine($"Insira um valor para A: ");
varA = double.Parse(Console.ReadLine());

Console.WriteLine($"Insira um valor para B: ");
varB = double.Parse(Console.ReadLine());

double resultado = varA - varB;
Console.WriteLine($"{resultado}");

if (resultado > 0)
{
    Console.WriteLine($"Resultado positivo");
}
else
{
    Console.WriteLine($"Resultado negativo");
}
Console.WriteLine();