//Faça um programa que peça uma nota, entre zero e dez. Mostre uma mensagem caso o valor seja invalido e continue pedindo ate que o usuario informe um valor valido.

//Entrada
Console.WriteLine($"Insira uma nota de 0 a 10: ");
float nota = float.Parse(Console.ReadLine());

//Processamento
while (nota < 0 || nota > 10)
{
Console.WriteLine($"Por favor insira um valor valido !");
Console.WriteLine($"Insira uma nota de 0 a 10: ");
nota = float.Parse(Console.ReadLine());
}
Console.WriteLine($"Nota valida, parabéns !");

//Saida