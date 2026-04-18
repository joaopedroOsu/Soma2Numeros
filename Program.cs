Console.WriteLine("Calcular numero");
int primeironumero, segundonumero, soma;

Console.Write("Digite o primeiro número:");
primeironumero = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o segundo número:");
segundonumero = Convert.ToInt32(Console.ReadLine());

soma = primeironumero + segundonumero;
Console.WriteLine($"soma: {soma}");
