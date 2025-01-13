using System;

namespace DiceAssignment
{
    internal class CountClass
    {
        // Random number generator
        private static Random random = new Random();

        public int[] RollDice(int rolls)
        {
            // Array to keep track of the sum of the roll
            int[] sumArray = new int[11]; // Indices 0-10 correspond to sums 2-12

            // Loop for number of rolls
            for (int i = 0; i < rolls; i++)
            {
                // Generate random number for both dice from 1 to 6
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);

                // Generate sum from the roll
                int rollSum = dice1 + dice2;

                // Increment the count of the sum in sumArray
                sumArray[rollSum - 2]++;
            }

            return sumArray;
        }
    }
}
