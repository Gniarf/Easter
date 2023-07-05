using EasterApi;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Merci de saisir une année");
string read = Console.ReadLine() ?? string.Empty;
Console.WriteLine($"L'année {read}, le jour de Pâques est le : {Computer.ComputeEaster(int.Parse(read))}");
Console.WriteLine("appuyez sur une entrer pour fermer le programme...1");
Console.ReadLine();