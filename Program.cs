using System;


namespace employee
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please Enter Employee First Name: ");
            String firstName = Console.ReadLine();

            Console.WriteLine("Please enter Employee's Last Name: ");
            String lastname = Console.ReadLine();

            
            int Id = Emp.validInt("Please Enter Employee identification number: ");
            
            double eval = Emp.validDouble("Please enter Employee Evaluation score: ");

            Emp Employee1 = new Emp(firstName,lastname,Id,eval);
            Employee1.print();
        }
    }
}
