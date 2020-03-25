// using System;
// using System.Linq;
// using System.Collections.Generic;

// namespace count_chars
// {
//     class Program2
//     {
//         static void Main(string[] args)
//         {
//             string data = "gwvuv syrbk sjrwf yspsm akpki yhznw wkpbt kpboq rjlpe nejku sxteo ihufz lgsiu jlypa lgqin ubave hjxav mgoeu gddnp mdicm dynxu pkcyf plubt aotmi ymbtr yczgi eacns oklwp buvve naymc wrbgv yjdif fjcgp xcyxs pnlcx fgrjt jvuzh pcvqq zhgwq keuyd cwdam weptg uidvz pfoug uvmaq wuzho utbln arsoj nnwid bjfeu mnqmp mziej phacb nymoz uqbzr fdzjp gmshg ckvjs jyeik xfgyp";

//             //Char count by char
//             Dictionary<char, int> countByChar = new Dictionary<char, int>();

//             //For each char in data
//             foreach (var c in data)
//             {
//                 //TODO: Count chars!

//                 //Para obtener el conteo actual almacenado en el diccionario
//                 // if (countByChar.TryGetValue(c, out int currentCount)) {
//                     //currentCount tiene el valor actual
//                 // }

//                 //Para agregar algo que no existe al diccionario
//                 //countByChar.Add(caracter, cantidad);

//                 //Revisar si existe en el diccionario
//                 //countByChar.ContainsKey(caracter)

//                 //Para agregar si ya existía:
//                 //countByChar.Remove(caracter)
//                 //countByChar.Add(caracter, cantidad)

//                 //Solamente nos interesan aquellos caracteres que no sean espacio vacío
//                 int count = 0;
//                 if (c != ' ') {
//                     if (countByChar.ContainsKey(c)) {
//                         //Sumar +1 al conteo actual
//                         if (countByChar.TryGetValue(c, out int currentCount)) {
//                             //currentCount tiene el valor actual
//                             count = currentCount + 1;
//                         }
//                     } else {
//                         //Conteo es igual a 1
//                         count = 1;
//                     }
//                 }

//                 //TODO: Actualizar el valor en el diccionario
//                 //Si ya existía un valor, remover y después agregar
//                 //Si no existía un valor, solamente agregar
//             }

//             //TODO: Imprimir diccionario
//         }
//     }
// }
