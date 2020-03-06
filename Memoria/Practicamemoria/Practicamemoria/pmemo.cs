using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace calculadora1
{
    class Memoria
    {
        public void memo()
        {
            string archivoDB = "../../../db.json";
            StreamReader reader = new StreamReader(archivoDB);
            var dbJSON = reader.ReadToEnd();
            var dbObject = JObject.Parse(dbJSON);
            // Prueba de lectura de archivo db.json
            //var result = dbObject.ToString();
            //var result = dbObject["arreglo"].ToString();
            //var result = dbObject["arreglo"][0].ToString();
            // Lectura de json iterable
            foreach (var item in dbObject)
            {
                // Iteración individual de cada grupo de datos del objeto json.
                Console.WriteLine("Dato en memoria:");
                MemoriaData memoriaData = new MemoriaData(item.Key.ToString(), item.Value["operacion"].ToString(), item.Value["resultado"].ToString());
                Console.WriteLine("{0} - {1}", memoriaData.fecha.ToLongDateString(),
                memoriaData.fecha.ToLongTimeString());
                Console.WriteLine(memoriaData.resultado.ToString());
                Console.WriteLine("----------------- \n");
            }
        }
        public void arreglo()
        {
            string [] colores = {"rojo", "blanco", "morado"};
                Array.Reverse(colores);
                Array.ForEach(colores, (item)=> {
                    Console.WriteLine(item);
                    });
            String color = Array.Find(colores, (item) => {
                return item.Length > 4;
                    });
            Console.WriteLine(color);
            Console.WriteLine("accede a tus colores y separalaos con comas(,)");
            string coloruser = Console.ReadLine();
            string[] newColors = coloruser.Split(',');
            Console.WriteLine(newColors);
        }
        public void multidimensional()
        {
            int [,] array =  new int [4,2];
            Console.WriteLine(array);
        }
    }
    class MemoriaData
    {
        public DateTime fecha;
        public String operacion;
        public int resultado;

        public MemoriaData(String date, String operation, String result)
        {
            fecha = DateTime.Parse(date);
            operacion = operation;
            resultado = int.Parse(result);
        }
    }
}

