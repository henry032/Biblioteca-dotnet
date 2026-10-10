using System.Reflection;

var assembly = Assembly.GetExecutingAssembly();
var version = assembly.GetName().Version;

Console.WriteLine("=========================================");
Console.WriteLine("|  Sistema de inventario de Biblioteca   |");
Console.WriteLine("=========================================");
Console.WriteLine($"Version del programa: {version}");
