/* 2 - Desenvolver um algoritmo que leia a cotação do euro converta para o Real,
   calcule a compra de 750 euros e imprima o resultado; */
double valReal = 5.29;
double totalConversao;

Console.WriteLine($"Exercício 2 - Digite um valor (em Euro) para converter para Real: ");
double valEuro = double.Parse(Console.ReadLine());

totalConversao = valEuro * valReal;

Console.WriteLine($"O valor da cotação atual é de: {totalConversao}");
Console.WriteLine();