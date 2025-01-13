using DiceAssignment;

int numRoles = 0;

// Welcome & Ask the user for the number of roles
Console.WriteLine("Welcome to the dice throwing simulator!");
Console.WriteLine("");

Console.WriteLine("How many dice rolls would you like to simulate?");
numRoles = int.Parse(Console.ReadLine());

// Call class
CountClass cClass = new CountClass();
int[] rollResults = cClass.RollDice(numRoles);

// Output to User
Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
Console.WriteLine("Total number of rolls = " + numRoles);

DisplayHistogram(rollResults, numRoles);

void DisplayHistogram(int[] results, int totalRolls)
{
    for (int i = 0; i < results.Length; i++)
    {
        int rollResult = i + 2;
        double percentage = (double)results[i] / totalRolls * 100;
        int numStars = (int)Math.Round(percentage);
        string stars = new string('*', numStars);

        Console.WriteLine($"{rollResult}: {stars} ({percentage:F2}%)");
    }
}
