

using Gomez_Garcia_hotfix;

Personaje personaje = new Personaje
{
    Nombre = "Guerrero",
    Vida = 100,
    Ataque = 20,
    Defensa = 10,
    Nivel = 1
};

Console.WriteLine($"Nombre: {personaje.Nombre}");
Console.WriteLine($"Vida: {personaje.Vida}");
Console.WriteLine($"Ataque: {personaje.Ataque}");
Console.WriteLine($"Defensa: {personaje.Defensa}");
Console.WriteLine($"Nivel: {personaje.Nivel}");
