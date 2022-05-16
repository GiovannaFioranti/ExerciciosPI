/* 10 - Desenvolver um algoritmo todos os algoritmos acima de forma dinâmica nos valores das variáveis,
   ou seja, obtendo a informação digitada pelo teclado por um usuário e não declarando a variável com
   um valor fixo. DICA: Pesquisar sobre Console.Readline() este método irá ajudá-los(as); */
// 1
Console.WriteLine($"Exercício 1 (Refeito) - Qual a idade do aluno mais novo? ");
int alunoNovo = int.Parse(Console.ReadLine());

Console.WriteLine($"Qual a idade do aluno mais velho? ");
int alunoVelho = int.Parse(Console.ReadLine());

double mediaAlunos2 = (alunoNovo + alunoVelho) / 2;

Console.WriteLine($"A média da idade entre os alunos é de: {mediaAlunos2}");
Console.WriteLine();

// 2
Console.WriteLine($"Exercício 2 (Refeito) - Qual o valor do euro hoje (digite o valor em reais)? ");
double cotEuro = double.Parse(Console.ReadLine());

Console.WriteLine($"Digite quantos Euros gostaria de converter: ");
double quantEuro = double.Parse(Console.ReadLine());

double totalCotacao = cotEuro * quantEuro;

Console.WriteLine($"O valor total é de: R$ {totalCotacao}");
Console.WriteLine();

// 3
double valVendaProdutos;
double valComissao;
double totalComissaoMes;

Console.WriteLine($"Exercício 3 (Refeito) - Insira o valor total dos produtos vendidos: ");
valVendaProdutos = double.Parse(Console.ReadLine());

Console.WriteLine($"Insira o percentual da sua comissão: Ex: 0.05");
valComissao = double.Parse(Console.ReadLine());

totalComissaoMes = valVendaProdutos * valComissao;

Console.WriteLine($"Exercício 3 - O valor da comissão é de R$: {totalComissaoMes}");
Console.WriteLine();