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

    public void print()
    {
        Console.WriteLine($"Employee First Name: {fName}");
        Console.WriteLine($"Employee Last name: {lName}");
        Console.WriteLine($"Employee Identification number: {Id}");
        Console.WriteLine($"Employee Evaluation Score: {score}");



    }


}
