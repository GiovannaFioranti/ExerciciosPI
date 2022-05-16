/* 7 - Desenvolver  um  algoritmo  que  leia quatro notas de um aluno,
   calcular a  média e imprimir. [OPCIONAL]: A  pontuação  deste  exercício  será  maior  para
   quem  imprimir  se  o  aluno  for APROVADO ou REPROVADO; [CRITÉRIO APROVAÇÃO]: Média > 7 */
double[] notas = new double[4];

Console.WriteLine($"Insira suas 4 notas: ");

for (int i = 0; i < 4; i++)
{
    notas[i] = double.Parse(Console.ReadLine());
}

double media = (notas[0] + notas[1] + notas[2] + notas[3]) / 4;

if (media > 7)
{
    Console.WriteLine($"Sua média é de: {media}");
    Console.WriteLine($"Aluno aprovado!");
}
else
{
    Console.WriteLine($"Sua média é de: {media}");
    Console.WriteLine($"Aluno reprovado!");
}
Console.WriteLine();