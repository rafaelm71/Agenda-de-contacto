using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace AgendaTelefonica
{
    class Class3
    {
        public static StreamReader LeerArchivo;
        public string linea = "";
        public string Dui;
        public int MENU;
        public bool re = false;

        public void Buscar()
        {

            do
            {
                Console.Clear();
                Dui = "";
                Console.WriteLine("Introduzca Dui: ");
                Dui = Console.ReadLine();
                Dui = "Dui: " + Dui;

//Abre el archivo Agenda.txt y busca la linea con el numero de dui ingresado
                LeerArchivo = new StreamReader("Agenda.txt", true);
                while (LeerArchivo.EndOfStream == false)
                {
                    linea = LeerArchivo.ReadLine();

                    if (Dui == linea)
                    {
                        Console.WriteLine("DATOS PERSONALES");
                        Console.WriteLine(Dui);

//Inprime los datos correspontientes ala persona con ese dui
                        for (int i = 1; i <= 12; i++)

                        {

                            Console.WriteLine(LeerArchivo.ReadLine());

                        }


                    }
                                        

                }
                

                LeerArchivo.Close();

//Pregunta al usuario si quiere realisar otra busqueda o salir de la opcion buscar
                do
                {
                    Console.WriteLine("**********Que desea hacer*****************");
                    Console.WriteLine("Digite 3 para realizar una nueva búsqueda:");
                    Console.WriteLine("Digite 4 para salir de la búsqueda:");

                    MENU = int.Parse(Console.ReadLine());
                    re = (MENU == 4 || MENU == 3);

                    if (re == false)
                    {

                        Console.WriteLine("Opcion no valida");
                    }
                } while (re == false);

            } while (MENU == 3);

        }
    }
}
