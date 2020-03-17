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


            Console.WriteLine("Would you like to add another employee?");

            string answer = Console.ReadLine();

            while (answer == "yes" || answer == "Yes" || answer == "Y" || answer =="y")
            {

            Console.WriteLine("Please Enter Employee First Name: ");
            firstName = Console.ReadLine();

            Console.WriteLine("Please enter Employee's Last Name: ");
            lastname = Console.ReadLine();

            
            Id = Emp.validInt("Please Enter Employee identification number: ");
            
             eval = Emp.validDouble("Please enter Employee Evaluation score: ");

            Emp Employee2 = new Emp(firstName,lastname,Id,eval);
            Employee1.print();
            
            Console.WriteLine("Would you like to add another employee?");

            answer = Console.ReadLine();
            
            }
        }
    }
}
