using System;

namespace MyInheritance
{

     public class Employee {

         public static int Calc(int num){

             num += 10000;

             return num;

         }

         virtual public void myBase(){

             Console.WriteLine("Employee Base");

         }

        }
    

    public class SDE : Employee{

        static int baseSal = 50000;

        public int mySal = Calc(baseSal);

        public void myBase(){

            //base.myBase();

            Console.WriteLine("SDE Base");

        }


    }
    class Program
    {
        static void Main(string[] args)
        {

            SDE s = new SDE();

            Console.WriteLine(s.mySal); 

            s.myBase();           
        }
    }

}

