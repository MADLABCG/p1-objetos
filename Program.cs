// See https://aka.ms/new-console-template for more information

transportacion.Carro carro = new("2.4 Litros", 4, 5, 6, true, "gasolina", "rojo", "Honda", 200000);

transportacion.Camion camion = new("7.8 Litros", 16, 2, 2, false, "diesel", "naranja", "MACK", 8000000, 3500, 3);

Console.WriteLine("CARRO:");
Console.WriteLine(carro.ToString());
Console.WriteLine("CAMION:");
Console.WriteLine(camion.ToString());

animales.Gato gato = new("Mamifero", 4, 2, "Gris", "Mauricio", "Angora");

animales.Perro perro = new("Mamifero", 4, 5, "Marron", "Buster", "PitBull");

Console.WriteLine("PERRO:");
Console.WriteLine(perro.ToString());
Console.WriteLine("GATO:");
Console.WriteLine(gato.ToString());
