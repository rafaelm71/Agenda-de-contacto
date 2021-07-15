using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace AgendaTelefonica
{
    class Program
    {
        static void Main(string[] args)
        {
//Llamar las clases 1,2 y 3
            Class1 Registro = new Class1();
            Class2 Registrados = new Class2();
            Class3 Encontrar = new Class3();
            string Opcion;
            int bandera;
            bool re = false;
            
            //MENU

            int MENU;
            do
            {
                Console.Clear();
                Console.WriteLine("----------------------MENU----------------------");
                Console.WriteLine("Digite 1 para registrar contacto.");
                Console.WriteLine("Digite 2 para mostrar contacto.");
                Console.WriteLine("Digite 3 para buscar contacto.");
                Console.WriteLine("Digite 4 para salir");
                Console.WriteLine("------------------------------------------------");

                do
                {
                    
                    //Validando el ingreso correcto de la opción del menú
                    do
                    {
                        //Controlando excepcion si opción del menu es texto o esta blanco
                        try
                        {

                            Console.WriteLine("Escriba su opción:");
                            
                            MENU = int.Parse(Console.ReadLine());
                            bandera = 1;
                            //Controlando ingreso de opcion de menú solo numeros de 1-4
                            re = (MENU == 1 || MENU == 2 || MENU == 3 || MENU == 4);

                            //Asignando funcion de cada opcion ingresada al menú
                            switch (MENU)

                            {
                                case 1:
                                    Registro.Ingresar();
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("********************************************");
                                    Console.WriteLine("LISTA DE CONTACTOS");
                                    Console.WriteLine("********************************************");
                                    Registrados.Mostrar();
                                    break;

                                case 3:
                                    Console.Clear();
                                    Encontrar.Buscar();
                                    break;

                                case 4:
                                    Environment.Exit(4);
                                    break;
                            }

                            //fin asignacion de funciones
                           
                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            Console.WriteLine("----------------------MENU----------------------");
                            Console.WriteLine("Digite 1 para registrar contacto.");
                            Console.WriteLine("Digite 2 para mostrar contacto.");
                            Console.WriteLine("Digite 3 para buscar contacto.");
                            Console.WriteLine("Digite 4 para salir");
                            Console.WriteLine("------------------------------------------------");
                            Console.WriteLine("Opción no válida, escriba numeros entre 1 y 4");
                            
                            bandera = 0;
                            
                        }

                       
                    } while (bandera == 0);

                    //Fin validación del menú




                    if (re == false)
                        {
                        Console.Clear();
                        Console.WriteLine("----------------------MENU----------------------");
                        Console.WriteLine("Digite 1 para registrar contacto.");
                        Console.WriteLine("Digite 2 para mostrar contacto.");
                        Console.WriteLine("Digite 3 para buscar contacto.");
                        Console.WriteLine("Digite 4 para salir");
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine("Opción no válida, escriba numeros entre 1 y 4");
                        }
                    } while (re == false);

                do
                {
                    Console.WriteLine("Desea volver al menu? (S/N)");
                    Opcion = Console.ReadLine();
                    re = (Opcion == "S" || Opcion == "s" || Opcion == "N" || Opcion == "n");

                    if (re == false)
                    {

                        Console.WriteLine("Opcion no válida");
                    }
                } while (re == false);
                if (Opcion == "N" || Opcion == "n")
                {
                    Environment.Exit(4);
                }

            } while (Opcion == "S" || Opcion == "s");
            Console.ReadKey();

        }
    }
}


