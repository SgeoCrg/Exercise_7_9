using System;

public class Average{
	public static void Main()
	{
		double totalNotes = 0, note, numberOfNotes = 0, average;
		string option;
		
		Console.Write("Insert a mark: ");
		option = Console.ReadLine();	

		while(option != "end")
		{ 
			note = Convert.ToDouble(option);
			numberOfNotes++; 
			totalNotes += note;  
			Console.Write("Insert a mark: ");
			option = Console.ReadLine();
		}

		if(numberOfNotes != 0)
		{
			average = totalNotes / numberOfNotes;  
			Console.WriteLine("The average is {0}.", average);
		}
	}
}
