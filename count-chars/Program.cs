using System;
using System.Linq;
using System.Collections.Generic;

namespace count_chars
{
    class Program
    {
        static void Main(string[] args)
        {
            //paso 1: revisar si existe
            //no -> paso 2: en caso de que no exista. agregarlo = valor de 1
            //si -> paso 3: ya existia?. agregale 1 tras consultar valor  y acerlo en valor actual
            //paso 4: registrar en diccionario = borrar y reescrivir el registro con nuevo balor
            
            string data = "este string solo es una prueba para confirmar que el codigo puede continuar funsionande, por lo cual, este string debe de ser ignorado apesar de cualquier afirmasion o demostracion de su importancia";
            
            Dictionary<char, int> countByChar = new Dictionary<char, int>();
            
            
            //iterar char
            foreach (var c in data)
            {
                //ignora los espacios
                if(c == ' ')
                {
                    continue;
                }
                if(c == 'p')
                {
                    continue;
                }
                //count chars
                //conteiskey = pregunta si tine tal llave
                if (countByChar.ContainsKey(c))
                {
                    countByChar.TryGetValue(c, out int curentcount);
                    int nextcount = curentcount + 1;

                    countByChar.Remove(c);
                    countByChar.Add(c, nextcount);
                }
                else
                {
                    countByChar.Add(c, 1);
                }

            }
            char highestrepitchar = ' ';
            int highestrepitcount = 0;

            foreach (var item in countByChar)
            {
                if (item.Value > highestrepitcount)
                {
                    highestrepitchar = item.Key;
                    highestrepitcount = item.Value;
                }
                System.Console.WriteLine($"{item.Key} -> {item.Value}");
            }
            System.Console.WriteLine($"most repitet leter: { highestrepitchar} -> {highestrepitcount}");

            //todo: que no salga el espacio
            char lowestrepitchar = ' ';
            int lowestrepitcount = 1;

            foreach (var item in countByChar)
            {
                if (item.Value <= lowestrepitcount)
                {
                    lowestrepitchar = item.Key;
                    lowestrepitcount = item.Value;
                }
                System.Console.WriteLine($"{item.Key} -> {item.Value}");
            }
            System.Console.WriteLine($"leest repitet leter: { lowestrepitchar} -> {lowestrepitcount}");
        }
    }
}
