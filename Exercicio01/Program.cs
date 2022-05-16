/* 1 - Desenvolver um  algoritmo  que  calcule  a  idade  média  dos  alunos  de  uma  classe  da  faculdade,
   sabendo que o aluno mais novo tem 20 anos e o mais velho tem 50 anos,
   utilize a seguinte fórmula para calcular: MEDIA ALUNO = (IDADE MÍNIMA + IDADE MÁXIMA) / 2; */
int alunoMaisNovo = 20;
int alunoMaisVelho = 50;
double mediaAlunos;

mediaAlunos = (alunoMaisNovo + alunoMaisVelho) / 2;

Console.WriteLine($"A média dos alunos é de: {mediaAlunos}");
Console.WriteLine();