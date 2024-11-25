﻿// See https://aka.ms/new-console-template for more information

Random random = new Random();
bool playAgain = true;
String player;
String computer;
String answer;

while (playAgain)
{
    player = "";
    computer = "";
    answer = "";
    
    while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
    {
        Console.Write("Enter ROCK, PAPER, or SCISSORS: ");
        player = Console.ReadLine();
        player = player.ToUpper();
    }

    switch (random.Next(1, 4))
    {
        case 1:
            computer = "ROCK";
            break;
        case 2:
            computer = "PAPER";
            break;
        case 3:
            computer = "SCISSORS";
            break;
    }
    
    Console.WriteLine("Player: " + player);
    Console.WriteLine("Computer: " + computer);

    switch (player)
    {
        case "ROCK":
            if (computer == "ROCK")
            {
                Console.WriteLine("It's a draw!");
            }
            else if (computer == "PAPER")
            {
                Console.WriteLine("You loose!.");
            }
            else
            {
                Console.WriteLine("You win!");
            }
            break;
        case "PAPER":
            if (computer == "ROCK")
            {
                Console.WriteLine("You win!");
            }
            else if (computer == "PAPER")
            {
                Console.WriteLine("It's a draw!.");
            }
            else
            {
                Console.WriteLine("You loose!");
            }
            break;
        case "SCISSORS":
            if (computer == "ROCK")
            {
                Console.WriteLine("You loose!");
            }
            else if (computer == "PAPER")
            {
                Console.WriteLine("You win!.");
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }
            break;
    }
    
    Console.Write("Would you like to play again? (Y/N) ");
    answer = Console.ReadLine().ToUpper();

    if (answer == "Y")
    {
        playAgain = true;
    }
    else if (answer == "N")
    {
        playAgain = false;
    }
    
}

Console.WriteLine("Thank you for playing!");

Console.ReadKey();