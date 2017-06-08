using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica_Veterinaria
{
    public class Pajaro : Animal
    {
        //heredables
        private string nombre;
        private string fechaNacimiento;
        private double peso;
        private string comentarios;


        private string raza;
        private string microchip;
        private string especie;
        private bool cantor = false;


        public string Raza
        {
            get
            {
                return raza;
            }

        }

        public string Microchip
        {
            get
            {
                return microchip;
            }

        }

        public string Especie
        {
            get
            {
                return especie;
            }

            set
            {
                especie = value;
            }
        }

        public bool Cantor
        {
            get
            {
                return cantor;
            }

            set
            {
                cantor = value;
            }
        }

        // constructor
        public Pajaro(String nombre, String fechaNacimiento, double peso, String comentarios, String raza, String microchip)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.peso = peso;
            this.Comentarios = comentarios;
            this.raza = raza;
            this.microchip = microchip;
        }

        public override string ToString()
        {
            return string.Format("Ficha Del Pajaro: Nombre={0}, Raza={1}, Fecha Nacimiento={2}, Peso={3}, MicroChip={4}, Comentarios={5} Especie={6}, Venenoso={7}", nombre, raza, fechaNacimiento, peso, microchip, comentarios, especie, isCantor());
        }

        // atributos
      

        public String getEspecie()
        {
            return Especie;
        }
        
        

        public bool isCantor()
        {
            if (Cantor == true)
            {
                Console.WriteLine("Molesta por las mañanas");
            }
            if (Cantor == false)
            {
                Console.WriteLine("No molesta...");
            }
            return Cantor;
        }

    }
}
