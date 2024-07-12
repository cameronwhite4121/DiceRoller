using DiceRoller;

// Construct die with number of sides
Console.WriteLine("This program simply simulates rolling a die.");
Die die1 = new Die();

// Simulate rolling the die
bool keepRolling = true;
while (keepRolling == true) {
	Console.Write("Your die rolled a ");
	Console.WriteLine(die1.RollDie());
	Console.Write("Keep rolling? (y/n) ");
	string response = Console.ReadLine();
	if(response.Equals("n"))
	{
		keepRolling = false; 
	}
}
