//written by Mikiyas on 4/21/23
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProblems
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Calculator aCalc = new Calculator();

            //Test cases for all the methods
            Console.WriteLine(aCalc.changeEnough(new double[] { 25, 20, 5, 0 }, 4.25));

            Console.WriteLine(aCalc.secondLargest(new int[] {26 ,22, 24, 23}));

            int[] evenNumber = aCalc.noOdds(new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10});
            foreach (var s in evenNumber)
            {
                Console.Write(s + "\t");
            }
            Console.WriteLine();

            Console.WriteLine(aCalc.flipEndChars("Theword"));

            

            Console.WriteLine(aCalc.findZip("zip is zip and zip "));
        }
    }
    public class Calculator
    {
        public bool changeEnough(double[] coins, double totalDue)
        {
            //changes coins amounts into dollars
            double quarters = coins[0] * 0.25;
            double dimes = coins[1] * 0.1;
            double nickels = coins[2] * 0.05;
            double pennies = coins[3] * 0.01;
            double sumOfCoins = quarters + dimes + nickels + pennies;

            //compare the sum of coins with the total due
            if (sumOfCoins >= totalDue)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int secondLargest(int[] nums)
        {
            //there will be atleast 2 number in array so i set the first 2 values to a variable
            int Max = nums[0];
            int sMax = nums[1];

            for (int i = 0; i < nums.Length; i++)
            {
                //sets Max variable to largest number in array
                if (nums[i] > Max)
                {
                    sMax = Max; //also sets second max variable to the same number
                    Max = nums[i];
                }
                else if (nums[i] > sMax && nums[i] < Max)
                {
                    //checks if the number is second largest and sets it
                    sMax = nums[i];
                }
            }
            return sMax;
        }
        public int[] noOdds(int[] nums)
        {
            //stores the count of even number in the array
            int count = 0;
            //loops through and count even numbers
            for (int i = 0; i < nums.Length; i++)
            {

                if ((nums[i] % 2) == 0)
                {
                    count++;
                }
            }
            //creates array using the count
            int[] newNums = new int[count];
            //index to keep track 
            int index = 0;
            //loops through and sets the even number to the array
            for (int i = 0; i < nums.Length; i++)
            {
                if ((nums[i] % 2) == 0)
                {
                    newNums[index] = nums[i];
                    index++;
                }
            }
            return newNums;
        }
        public string flipEndChars(string word)
        {
            //new string to store
            string newWord = "";
            //concatenates the last char first
            newWord += word[word.Length - 1];
            //loop thorugh and concatenates every char except the first and last
            for (int i = 1; i < word.Length - 1; i++)
            {
                newWord += word[i];
            }
            //concatenates the first char last
            newWord += word[0];
            return newWord;
        }
        public int findZip(string word)
        {
            //counter for zip occuring
            int count = 0;
            //loops through with condition length - 2 because
            //the check for the word zip are i, i+1 and i+2 
            for (int i = 0; i < word.Length - 2; i++)
            {
                //counts if 'z' 'i' 'p' occur together
                if (word[i] == 'z' && word[i + 1] == 'i' && word[i + 2] == 'p')
                {
                    count++;
                    //return index after the a second zip is counted
                    if (count == 2)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
    }
}
