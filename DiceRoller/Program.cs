using DiceRoller;

// Construct die with number of sides
Console.WriteLine("This program simply simulates rolling a die.");
Die die1 = new Die();

// Simulate rolling the die
while (die1.IsHeld == false) {
	Console.Write("Your die rolled a ");
	die1.RollDie();
	Console.WriteLine(die1.FaceValue);
	Console.Write("Hold the die? (y/n) ");
	string response = Console.ReadLine();
	if(response.Equals("y"))
	{
		die1.IsHeld = true; 
	}
}
