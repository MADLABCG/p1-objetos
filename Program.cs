// See https://aka.ms/new-console-template for more information


Console.WriteLine("Clases Programacion 1");

animales.PerroClass perro = new("Lucrecia", "2 años", "Marron Verdoso");


//perro.setNombre("Lucrecia");
perro.setEdad("10 años");
//perro.setColor("Marron Oscuro Verdoso");
perro.setRaza("Gran Danés");


Console.WriteLine("Nombre: " + perro.getNombre());
Console.WriteLine("Edad: " + perro.getEdad());
Console.WriteLine("Color: " + perro.getColor());
Console.WriteLine("Raza: " + perro.getRaza());
