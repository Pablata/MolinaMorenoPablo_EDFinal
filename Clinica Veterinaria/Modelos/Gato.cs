using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica_Veterinaria
{
    public class Gato : Animal
    {
        //heredables
        private string nombre;
        private string fechaNacimiento;
        private double peso;
        private string comentarios;

        private string raza;
        private string microchip;

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

        // constructor
        public Gato(String nombre, String fechaNacimiento, double peso, String comentarios, String raza, String microchip)
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
            return string.Format("Ficha Del Gato: Nombre={0}, Raza={1}, Fecha Nacimiento={2}, Peso={3}, MicroChip={4}, Comentarios={5}", nombre, raza, fechaNacimiento, peso, microchip, comentarios);
        }

    }
}
