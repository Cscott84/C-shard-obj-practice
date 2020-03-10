using System;

public class Emp
{

    public string fName;

    public string lName;

    public int Id;

    public double score;
    
    
    public Emp(string firstName, string lastName, int ID, double Score)
	{
        fName = firstName;
        lName = lastName;
        Id = ID;
        score = Score;
	}

    public static int validInt(string askForInt)
    {
        int result;
        Console.WriteLine(askForInt);
        string input1 = Console.ReadLine();

        while(!Int32.TryParse(input1, out result))
        {
            Console.WriteLine("Invalid input, Please enter a numeric value: ");
            Console.WriteLine(askForInt);
            input1 = Console.ReadLine();

        }

        return result;
    }


    public static double validDouble(string askForDouble)
    {
        double result;
        Console.WriteLine(askForDouble);
        string input2 = Console.ReadLine();

        while(!double.TryParse(input2, out result))
        {
            Console.WriteLine("Invalid input, Please enter numeric value: ");
            Console.WriteLine(askForDouble);
            input2 = Console.ReadLine();
        }

        return result;

    }

    public void print()
    {
        Console.WriteLine($"Employee First Name: {fName}");
        Console.WriteLine($"Employee Last name: {lName}");
        Console.WriteLine($"Employee Identification number: {Id}");
        Console.WriteLine($"Employee Evaluation Score: {score}");



    }


}
