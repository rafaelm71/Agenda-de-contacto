using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace AgendaTelefonica
{
    class Class2
    {
        public static StreamReader LeerArchivo;
        public String DATOS;
        public void Mostrar()
        {

 //Abre el archivo Agenda.txt y muestra los datos que se an registrado





            LeerArchivo = new StreamReader("Agenda.txt", true);
            Console.WriteLine("\nDATOS PERSONALES");
            Console.WriteLine("------------------------------------------------");
            while ((DATOS = LeerArchivo.ReadLine()) != null)
            {
                Console.WriteLine(DATOS);
            }
      
            Console.WriteLine("\n\nFIN DE LOS DATOS.");
            LeerArchivo.Close();





        }

    }
}

