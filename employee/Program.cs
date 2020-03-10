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

            Console.WriteLine("Please Enter Employee Number: ");
            int Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter evaluation score: ");
            double eval = Convert.ToDouble(Console.ReadLine());

            Emp Employee1 = new Emp(firstName,lastname,Id,eval);
            Employee1.print();
        }
    }
}
