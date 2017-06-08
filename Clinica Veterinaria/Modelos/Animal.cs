using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica_Veterinaria
{
    public abstract class Animal : Pesable
    {
        public string nombre;
        public string fechaNacimiento;
        public double peso;
        public string comentarios;

        /*
        public Animal(String nombre, String fechaNacimiento, double peso, String comentarios)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.peso = peso;
            this.Comentarios = comentarios;
          
        }
       */
        public string Nombre
        {
            get
            {
                if (nombre == null)
                {
                    throw new Exception("ERROR: Introduzca nombre");
                }
                return nombre;
            }

          
        }

        public string FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }

          
        }

        public double Peso
        {
            get
            {
                if (peso <=0) {
                    throw new Exception("ERROR: Peso incorrecto");
                }
             

                return peso;
            }

        }

        public string Comentarios
        {
            get
            {
                return comentarios;
            }

            set
            {
                comentarios = value;
            }
        }

        public void Pesar(double pesar)
        {
            throw new NotImplementedException();
        }
    }
}
