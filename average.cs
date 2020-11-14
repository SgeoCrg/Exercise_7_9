using System;

public class Average{
	public static void Main()
	{
		double totalNotes = 0, note, numberOfNotes = 0, average;
		string noteText;
		
		Console.Write("Insert a mark: ");
		noteText = Console.ReadLine();	

		while(noteText != "end")
		{ 
			note = Convert.ToDouble(noteText);
			numberOfNotes++; 
			totalNotes += note;  
			Console.Write("Insert a mark: ");
			noteText = Console.ReadLine();
		}

		if(numberOfNotes != 0)
		{
			average = totalNotes / numberOfNotes;  
			Console.WriteLine("The average is {0}.", average);
		}
	}
}
