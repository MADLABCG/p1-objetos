// See https://aka.ms/new-console-template for more information


vida.Humano humano1 = new("Juan Jose", "Perez Garcia", "Masculino", 24, "12 Agosto 1999", "Marron", "Azul", 6);

vida.Humano humano2 = new("Anelisa Maria", "Urbaez Plasencia", "Femenina", 23, "12 Julio 2000", "Rubio", "Verdes", 5);

vida.Dominicano dominicano1 = new("000-0000000-4", true,"Pedro Jose", "Martinez", "Masculino", 33, "28 Febrero 1990", "Negro", "Marrones", 6);

dominicano1.Nombres = "Samuel";
dominicano1.Apellidos = "Sosa";

Console.WriteLine("Humano 1:");
Console.WriteLine(humano1.ToString());
Console.WriteLine(" ");
Console.WriteLine("Humano 2:");
Console.WriteLine(humano2.ToString());
Console.WriteLine(" ");
Console.WriteLine("Dominicano 1:");
Console.WriteLine(dominicano1.ToString());

string papa1 = "Hola";
string papa2 = "Adios";