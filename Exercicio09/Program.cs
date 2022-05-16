/* 9 - Desenvolver um algoritmo que leia dois valores, A e B, utilizar operador aritmético de divisão e
   modularização, ou seja, imprimir apenas o resto da divisão; */
float varA2, varB2, resultDivisao;

Console.WriteLine($"Digite o primeiro número: ");
varA2 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o segundo número: ");
varB2 = float.Parse(Console.ReadLine());

resultDivisao = varA2 / varB2;

if (varA2 == 0 || varB2 == 0)
{
    Console.WriteLine($"Indeterminação Matemática!");
}
else
{
    Console.WriteLine($"O resto da divisão é: {varA2 % varB2}");
}
Console.WriteLine();