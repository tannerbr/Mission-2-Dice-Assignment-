using DiceAssignment;

int numRoles = 0;

// Welcome & Ask the user for the number of roles
Console.WriteLine("Welcome to the dice throwing simulator!");
Console.WriteLine("");

Console.WriteLine("How many dice rolls would you like to simulate?");
numRoles = int.Parse(Console.ReadLine());

// Call class
CountClass cClass = new CountClass();
cClass.percentFinder(numRoles);
