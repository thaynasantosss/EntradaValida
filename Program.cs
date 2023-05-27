Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("*** Entrada Válida ***");
Console.WriteLine();
Console.ResetColor();
int numeroDigitado = -1;

while (numeroDigitado < 0 || numeroDigitado > 9)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Digite um número entre 1 e 9 (ou 0 para cancelar): ");
    numeroDigitado = Convert.ToInt32(Console.ReadLine());
    Console.ResetColor();
}

if (numeroDigitado == 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine();
    Console.WriteLine("Operação cancelada.");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine();
    Console.WriteLine($"Numero selecionado = {numeroDigitado}");
    Console.ResetColor();
}
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Volte sempre!");
Console.ResetColor();
Console.ReadKey();

Console.Clear();
