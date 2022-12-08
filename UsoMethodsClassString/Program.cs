using System;
using UsoMethodsClassString.includes;

namespace UsoMethodsClassString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String texto = "La informatica es la disciplina o campo de estudio que abarca el conjunto de conocimientos";
            String fullnameLibro = "Porque caminar si poder volar";
            String idle = "Sublime Text"; // entorno de desarrollo integrado
            String correo = "pedro_quiroz.informatica@gmail.com";
            String fullname = "         Daniel Gomez G.         ";
            char caracter = '.';

            Funciones func = new Funciones();


            Console.WriteLine("Metodo Contains: " + func.existeCadena(texto, "campo"));
            Console.WriteLine("-----------\nMetodo EndsWith: " + func.terminaCon(fullnameLibro, "volare"));
            Console.WriteLine("-----------\nMetodo String.Format: " + func.formatoCadena(caracter));
            Console.WriteLine("-----------\nMetodo IndexOf: " + func.existeCharacter(correo, "@"));
            Console.WriteLine("-----------\nMetodo PadLeft: " 
                + func.addCharacter(idle, 13, '-')); // * Desde 13 en adelante, sino no funciona
            Console.WriteLine("-----------\nMetodo Remove: " + func.quitarCharacter(texto, 7));
            Console.WriteLine("-----------\nMetodo Replace: " + func.remplazarTexto(correo, "pedro_quiroz", "pquiroz"));
            Console.WriteLine("-----------\nMetodo StartsWith: " + func.iniciaCon(fullnameLibro, "T"));
            Console.WriteLine("-----------\nMetodo SubString: " + func.subCadena(correo, 24, 4, ".com"));
            Console.WriteLine("-----------\nMetodo Length (Tamaño  del texto): " + func.tamanhoCadena(texto));
            Console.WriteLine("-----------\nMetodo Trim: " + func.deleteCaracteres(fullname));



            Console.Write("\n\nPresione cualquier tecla para salir... ");
            Console.ReadKey();
        }
    }
}
