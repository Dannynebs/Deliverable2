using System.ComponentModel.Design;
// #1
Console.WriteLine("What is your name?");
string name = Console.ReadLine();

//#2
Console.WriteLine("Welcome " +name+ ". Do you want to do the COIN FLIP CHALLENGE? Type Yes or No ");
string answer = Console.ReadLine();

int heads = 0;
int tails = 0;
int score = 0;
// #3
// #4
if (answer == "No")
{
    //Name throughout program - #2 on rubric
    Console.WriteLine("You are a coward " + name);
}
else if (answer == "Yes")
{
    // #5
    int i;
    for (i = 1; i <= 5; i++)
    {
        // #6
        Random coinFlip = new Random();
        int randNum = coinFlip.Next(0, 2);

        // #7
        Console.WriteLine("Guess Heads or Tails");
        string guess = Console.ReadLine();

        // The results is heads
        if (randNum == 0)
        {
            heads++;

            if (guess == "Heads")
            {
                // #9
                score++;
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Wrong!");
            }
        }
        // The result is tails
        else if (randNum == 1)
        {
            tails++;

            if (guess == "Tails")
            {
                // #9
                score++;
                Console.WriteLine("Correct!");
            }else
            {
                Console.WriteLine("Wrong!");
            }
        }
    }
    // #2
    Console.WriteLine("Well done " +name+ "! The coin landed on heads " +heads+ " times and landed on tails " +tails+ " times.");
    // #10, #2
    Console.WriteLine(name+ " You got a score of " +score+ "!");
}