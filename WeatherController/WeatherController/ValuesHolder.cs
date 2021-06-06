using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherController
{
    public class ValuesHolder
    {

       public ValuesHolder1[] args = new ValuesHolder1[1000];


        public  ValuesHolder(    ) 
        {

            // для хранения показателей температуры и времени создан массив 

            for (int i = 0; i < args.Length; i++) { args[i].Temperature = null; args[i].timespin = DateTime.Now;    } // инициализируем поля массива






        }



       






    }
}
