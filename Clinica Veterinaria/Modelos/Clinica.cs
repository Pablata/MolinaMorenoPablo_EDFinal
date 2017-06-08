using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica_Veterinaria.Modelos
{
     class Clinica
    {
        //lista
        private List<Animal> lista;
        private String nombre;

        //Constructor Vacio
        public Clinica(String nombre) {
            this.nombre = nombre;
            this.lista = new List<Animal>();
        }

        public void aniadir(Animal d)
        {
            if (!this.lista.Contains(d))
            {
                this.lista.Add(d);
            }
            else {
                Console.WriteLine ("[ERROR] El Animal " + d.Nombre+ " ya está en la clinica!!!");
            }
            this.lista.Add(d);
        }

        public void quitar(Animal d)
        {

            if (this.lista.Contains(d))
            {
                this.lista.Remove(d);
            }
            else {
                Console.WriteLine("[ERROR] El Animal " + d.Nombre + "  no está en la clinica!!!");
            }
          
            
        }

        private int mostrarMenuInsertar()
        {

            int opcion;

            do
            {
                Console.WriteLine ("/** SUBMENU - CREAR Animal **/");
                Console.WriteLine("1. Perro");
                Console.WriteLine("2. Gato");
                Console.WriteLine("3. Pajaro");
                Console.WriteLine("4. Reptil");

                Console.WriteLine ("¿Qué desea crear?: ");
                opcion = validarEntero();
            } while (opcion > 4 || opcion < 0);
            return opcion;

        }

        private void insertarNuevoAnimal()
        {
           
            int opcion = mostrarMenuInsertar();
            String nombre, fechaNacimiento, comentarios;
            double peso;

            Console.WriteLine("Nombre del animal:");
            nombre = Console.ReadLine();
            Console.WriteLine("Fecha de Nacimiento:");
            fechaNacimiento = Console.ReadLine();
            Console.WriteLine("Comentarios:");
            comentarios = Console.ReadLine();
            Console.WriteLine("Peso:");
            peso = validarDouble();

            switch (opcion)
            {
                // Perro

                case 1:
                    String raza;
                    Console.WriteLine("Raza del perro");
                    raza = Console.ReadLine();

                    String microchip;
                    Console.WriteLine("microchip");
                    microchip = Console.ReadLine();

                    Animal perro = new Perro(nombre, fechaNacimiento, peso, comentarios, raza, microchip);

                    meterAnimal(perro);

                    break;
                // Gato
                case 2:

                    // String raza;
                    Console.WriteLine("Raza del perro");
                    raza = Console.ReadLine();

                    // String microchip;
                    Console.WriteLine("microchip");
                    microchip = Console.ReadLine();

                    Animal gato = new Gato(nombre, fechaNacimiento, peso, comentarios, raza, microchip);

                    meterAnimal(gato);

                    break;
                // pajaro
                case 3:

                    String especie;
                    Console.WriteLine("Especie del pajaro");
                    especie = Console.ReadLine();

                    String cantor ="";

                    Animal pajaro = new Pajaro(nombre, fechaNacimiento, peso, comentarios, especie, cantor);
                    meterAnimal(pajaro);
                    break;

                // Reptil
                case 4:

                    Console.WriteLine("Especie del pajaro");
                    especie = Console.ReadLine();

                    String venenoso = "";

                    Animal reptil = new Reptil(nombre, fechaNacimiento, peso, comentarios, especie, venenoso);
                    meterAnimal(reptil);
                    break;

                default:
                    Console.WriteLine("opcion no contemplada");
                    break;

            }
        }
            private void meterAnimal(Animal v)
        {
            if (!this.lista.Contains(v))
            {
                this.lista.Add(v);
            }
            else {
                Console.WriteLine ("[ERROR] El vehiculo " + v.Nombre + " ya está en la clinica!!!");
            }
        }


        private void listarAnimal()
        {


            lista.ForEach(Console.WriteLine);



        }

        public void ModificaComentarioAnimal()
        {


        }

      public void Menu()
        {
            int opcion;
            string entrada = "";
            Console.WriteLine("Bienvenido a la Clinica");


            do
            {
                Console.WriteLine("********** Menu **********");
                Console.WriteLine("/** MENU **/");
                Console.WriteLine("1. Insertar diferentes animales");
                Console.WriteLine("2. Modificar Comentarios");
                Console.WriteLine("3. Pesar Animal");
                Console.WriteLine("4. Mostrar Ficha de un animal");
                Console.WriteLine("5. Salir");
                entrada = Console.ReadLine();
                Int32.TryParse(entrada, out opcion);
                realizarOpcion(opcion);

            } while (opcion != 5);

        }

        public static void realizarOpcion(int opcion)
        {
            Console.WriteLine("Hola, bienvenido ");
            Clinica c = new Clinica("");
            switch (opcion)
            {
                case 1:
                    c.insertarNuevoAnimal();
                    break;
                case 2:
                    c.ModificaComentarioAnimal();
                    break;
                case 3:
                    c.listarAnimal();
                    break;
                case 4:
                    Console.WriteLine("Adios, vuelva pronto");
                  
                    break;
                default:
                    Console.WriteLine("[ERROR] Opción no válida.");
                    break;
            }

        }

        public int validarEntero() {
            //Validar entero
            string cadena = "";
            bool esCorrecto = false;
            int cantidad = 0;
            do
            {
               
                cadena = Console.ReadLine();
                esCorrecto = Int32.TryParse(cadena, out cantidad);

                if (esCorrecto)
                {

                        esCorrecto = false;

                    



                }

                else
                {
                    Console.WriteLine("introduzca un caracter valido");
                }

            } while (!esCorrecto);

            return cantidad;
        }

        public double validarDouble()
        {
            //Validar entero
            string cadena = "";
            bool esCorrecto = false;
            double cantidad = 0;
            do
            {

               
                cadena = Console.ReadLine();
                esCorrecto = double.TryParse(cadena, out cantidad);

                if (esCorrecto)
                {

                    esCorrecto = false;





                }

                else
                {
                    Console.WriteLine("introduzca un caracter valido");
                }

            } while (!esCorrecto);

            return cantidad;
        }

    }


    }

