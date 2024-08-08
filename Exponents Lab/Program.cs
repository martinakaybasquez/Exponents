/*
 TASK:
    - display a table of powers
    - ask user if they would like to continue
        - loop

BUILD SPECS:
    - prompts user to enter integer
    - displays table of squares/cubes from 1 -> user input
    - prompts user to continue
    - app continues if user agrees
    - reject 0 and negative numbers
        - keep prompting to enter valid number
    - formated strings
    - right align
    - overflow

BRAIN TALK:
    - I COULD PROBABLY MAKE A METHOD TO DO A SQUARE AND CUBE
        - DID NOT WORK -- ASK JUSTIN IF ITS METHODS COULD EVER HAVE USER INPUT
    - METHOD TO LOOP (DOUBLE CHECK THIS)
 */

AskUserForNumber(); 
//AskUserToContinue();

//Console.WriteLine("Please enter a number between 1 and [max number before overflow]. blah");
//int userNum = int.Parse(Console.ReadLine());

static int AskUserForNumber() // method for asking user for a positive number 
{
    int userNum = -1;
    while (userNum < 0) // while result is less than 0 -- making int result = -1 == true 
    {
        Console.WriteLine("Please enter a number between 1 and [max number before overflow].");
        userNum = int.Parse(Console.ReadLine());
        Console.WriteLine();
        for (int i = 1; i <= userNum; i++) // <= (equal to) accounts for the last number 
        {
           Console.WriteLine(i);
        }
        if (userNum < 0) // if the user inputs a number less than zero AKA negative number 
        {
            Console.WriteLine("Invalid entry. Please enter a positive number between 1 and [max number].");
        }
    }
    return userNum;
}

//---------------------------------------------------------------------------------------------------------------------

static bool AskUserToContinue() // method to ask user if they would like to continue
{
    bool result = true; // assigning result to be true 
    while (true) // since result was assigned true above this will infinitely run 
    {
        Console.WriteLine("Would you like to continue? (y/n)");
        string userChoice = Console.ReadLine(); // asked for user input and assigns it to userChoice
        if (userChoice == "y")
        {
            result = true; // result continues to be true 
            break; // breaks out of loop and goes ... where?
        }
        else if (userChoice == "n")
        {
            result = false; // changes result from true to false 
            break;
        }
    }
    return result; // i don't know why this is here -- ask justin 
}
//---------------------------------------------------------------------------------------------------------------------

static int SquaringNumbers(int userNum) // method for squaring whatever the userNum
{
    return i * i;
}

/*
 
//---------------------------------------------------------------------------------------------------------------------
static int CubingNumbers() // method for cubing whatever the userNum

{
    // needs to having something what will loop userNum amount of times
}
*/


































/*
bool runProgram = true;

 static int GetInput()
 {
     int numInput = -1;
     while (numInput < 0) // while result is less than zero
     {
         Console.WriteLine("Please enter enter a number between 1 and 2,000,000,000.");
         numInput = int.Parse(Console.ReadLine()); // overwrites the original -1 number
         if (numInput < 0) // if result is less than zero
         {
             Console.WriteLine("Invalid entry. Please choose a positive number.");
         }
     }
     return numInput;
 }

 // method to ask if they want to keep going
 static bool KeepGoing()
 {
     bool result = true;
     while (true)
     {
         Console.WriteLine("Would you like to keep inputting numbers? (y/n)");
         string userAnswer = Console.ReadLine();
         if (userAnswer == "y")
         {
             result = true;
             break;
         }
         else if (userAnswer == "n")
         {
             result = false;
             break;
         }
         else
         {
             Console.WriteLine("Please choose between choose either 'y' or 'n'. ");
         }
     }
     return result;
 }

 // try catch error
 // 1291
 */