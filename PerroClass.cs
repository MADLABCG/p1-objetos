using System;
namespace animales
{
	public class PerroClass
	{
		public PerroClass(string nombre, string edad, string color)
		{
            this.edad = edad;
            this.nombre = nombre;
            this.color = color;
		}

        private string? nombre;
        private string? edad;
        private string? color;
        private string? raza;

        public string getNombre()
        {
            return this.nombre;
        }

        public string getEdad()
        {
            return this.edad;
        }

        public string getColor()
        {
            return this.color;
        }

        public string getRaza()
        {
            return this.raza;
        }


        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void setEdad(string edad)
        {
            this.edad = edad;
        }

        public void setColor(string color)
        {
            this.color = color;
        }

        public void setRaza(string raza)
        {
            this.raza = raza;
        }

    }
}

