using System;
using System.Collections.Generic;
using System.Text;

namespace UsoMethodsClassString.includes
{
    internal class Funciones
    {
        #region Devuelve true o false, si una frase o palabra existe dentro de ella
        public String existeCadena(String texto, String cadena)
        {
            return ((texto.Contains(cadena))
                ? "La frase o palabra existe en el texto"
                : "Frase o Palabra no encontrada");
        }
        #endregion



        #region Determina si al final de un texto, existe dentro de ella
        public bool terminaCon(String texto, String cadena)
        {
            return texto.EndsWith(cadena) ? true : false;
        }
        #endregion



        /**
         * Convierte el valor de los objetos en cadenas según los formatos especificados por 
         * nosotros, y los insertas en otra cadena.
         */
        public String formatoCadena(char tecla)
        {
            return String.Format("Mi nombre es Lucas Zuñiga{0}", tecla);
        }



        #region Recorre un string hasta encontrar el caracter solicitado
        /**
         * Devuelve como resultado la posicion del caracter, si no encuentra el caracter, este
         * devuelve un -1 (entero), al igual que el lastIndexOf pero a la inversa
         */
        public String existeCharacter(String cadena, String tecla)
        {
            int arroba = cadena.IndexOf(tecla);

            return ((arroba == -1)
                ? $"El caracter {tecla} es valido"
                : $"El caracter {tecla} se encuentra en la posicion [{arroba}]");
        }
        #endregion



        #region Rellena con caracteres especificados por nosotros al comienzo del texto actual
        public String addCharacter(String texto, int longitud, char tecla)
        {
            return texto.PadLeft(longitud, tecla);
        }
        #endregion



        #region Quita n caracteres de una cadena de texto desde la derecha, según la posicion indicada
        public String quitarCharacter(String texto, int posicion)
        {
            return texto.Remove(posicion);
        }
        #endregion



        #region Remplaza un texto o caracteres por otro
        public String remplazarTexto(String texto, String cadena, String texto_remplazo)
        {
            return texto.Replace(cadena, texto_remplazo);
        }
        #endregion



        #region Determina si al inicio de una cadena de texto, coincide con el texto o caracter especificado
        public bool iniciaCon(String texto, String tecla)
        {
            return texto.StartsWith(tecla) ? true : false;
        }
        #endregion



        #region Recupera una subcadena de esta instancia
        public String subCadena(String texto, int inicio, int longitud, String cadena)
        {
            return (texto.Substring(inicio, longitud) == cadena)
                ? "El correo termina con el formato correcto"
                : "!!Invalid email";
        }
        #endregion



        #region Obtiene el numero de caracteres de un string
        public int tamanhoCadena(String texto)
        {
            return texto.Length;
        }
        #endregion



        #region Limpia caracteres del inicio y final de un string
        public String deleteCaracteres(String texto)
        {
            return texto.Trim();
        }
        #endregion
    }
}
