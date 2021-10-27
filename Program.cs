using System;

namespace MyInheritance
{
     
     interface WhoAmI{ 
     
        string name;
        void Me();
     }
     
     public class EmployeeType : WhoAmI{ 
       
       string name; 

       public void Me()
        {
            Console.WriteLine($"***{name}***");
        }

     }
     
     interface EmpAcc
    {

        int UId;
        int AccountNumbers;
        void AccountDetails();
    }

     public class EmployeeAccount : EmpAcc{ 

        public int UId;

        public int AccountNumber;

        public void TakeDetails(){ 
           
            UId = Console.ReadLine();

            AccountNumber = Console.ReadLine();
        
        }


        public void AccountDetails()
        {

            Console.WriteLine($"User ID: {UId}");
            Console.WriteLine($"Acc No.: {AccountNumber}");
        }


      }
     

     interface EmpRole{

        string ERole;
        string ETeam;
        void EmployeeTypeDetails();
    }
     
     public class EmployeeRole : EmpRole{

        public string ERole;

        public string ETeam;

        public void EmployeeTypeDetails()
        {

            Console.WriteLine($"Emp Role : {ERole}");
            Console.WriteLine($"Emp Team : {ETeam}");
        }

     }

     public class Employee : EmployeeAccount, EmployeeRole , EmployeeType {

         
         public static int bonus = 1000;

         public static int SalaryCalculation(int num){

             num += 10000;

             return num;

         }

     }
    

    public class Developer : Employee{

        public int DeveloperBaseSalary = 50000;

        //public int FinalSalary = Calc(DeveloperBaseSalary);

    }

    public class HR : Employee{

        public int baseSal = 40000;


    }
    class Program
    {
        static void Main(string[] args)
        {

            Developer dev = new Developer();
            
            string name = dev.name;
        }
    }

}

