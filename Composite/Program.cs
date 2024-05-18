using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Archivos ObjArchivo1 = new Archivos("Musica", 20, ".mp3");
            Archivos ObjArchivo2 = new Archivos("Foto", 108, ".jpg");
            Archivos ObjArchivo3 = new Archivos("Documento", 380, ".pdf");

            DirectorioComposite ObjDir1 = new DirectorioComposite("Escritorio");
            ObjDir1.Add(ObjArchivo1);
            ObjDir1.Add(ObjArchivo2);
            ObjDir1.Add(ObjArchivo3);
            Console.WriteLine("\n----------------*--------------------");
            Console.WriteLine("El peso del directorio llamado: " + ObjDir1.Nombre + " es de: " + ObjDir1.PesoTotal + " mb");
            ObjDir1.MostrarContenido();

            DirectorioComposite ObjDir2 = new DirectorioComposite("Papelera Reciclaje");
            ObjDir2.Add(ObjArchivo1);
            ObjDir2.Add(ObjDir2);
            Console.WriteLine("\n----------------*--------------------");
            Console.WriteLine("El peso del directorio que tiene archivos \ny otros directorios, el cual se llama: " + ObjDir2.Nombre + " es de: " + ObjDir2.PesoTotal + " mb");
            ObjDir2.MostrarContenido();

            Console.ReadLine();
        }
    }
}
