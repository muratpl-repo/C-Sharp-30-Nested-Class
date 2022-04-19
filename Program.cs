using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _74DersIcIceSiniflar
{
    class Program
    {
        //Nested Classes: Ic Ice Siniflar
        class Araba
        {
            public string model;
            public Motor motor;
            public Araba(string modeli)
            {
                motor = new Motor(); //Instructor metot'ta Instance olusturduk.
            }
            public class Motor // Ic ice sinif olusturduk. Ancak bu sinifin motorGucu field'ine ulasabilmek icin Araba sinifinde bir Instance olsuturduk.
            {
                public int motorGucu;
            }
        }
        static void Main(string[] args)
        {
            Araba a1 = new Araba("2015");
            a1.motor.motorGucu = 1500;
            Console.WriteLine(a1.motor.motorGucu);
        }
    }
}
