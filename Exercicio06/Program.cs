/* 6 - Desenvolver  um  algoritmo  que  leia a  altura  de  um  homem  e  calcule  o  seu  peso  ideal,
   utilize  a seguinte fórmula: PESO IDEAL = (72.7 * H) – 58, onde H = altura */
double pesoIdeal;

Console.WriteLine($"Qual é sua altura (em cm)? Ex: 1.71?");
double alturaH = double.Parse(Console.ReadLine());

pesoIdeal = (72.7 * alturaH) - 58;

Console.WriteLine($"Seu peso ideal é de: {pesoIdeal}");
Console.WriteLine();