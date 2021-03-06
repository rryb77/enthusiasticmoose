﻿using System;
using System.Collections.Generic;

Main();

void Main()
{
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine("|                                          |");
    Console.WriteLine("|             Choose an Option             |");
    Console.WriteLine("|                                          |");
    Console.WriteLine("| 1. Questions                             |");
    Console.WriteLine("| 2. Magic Moose (8Ball)                   |");
    Console.WriteLine("| 3. Rock, Paper, Scissors                 |");
    Console.WriteLine("| 4. Exit                                  |");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();
    Console.Write("Choice: ");
    string answer = Console.ReadLine();

    if (answer == "1")
    {
        Questions();
    }
    else if (answer == "2")
    {
        MagicMoose();
    }
    else if (answer == "3")
    {
        RockPaperScissors();
    }
    else if (answer == "4")
    {
        Environment.Exit(-1);
    }

}

void RockPaperScissors()
{

    int PlayerScore = 0;
    int CPUScore = 0;
    bool noWinner = true;

    while (noWinner)
    {

        Console.WriteLine("---------------------------");
        Console.WriteLine($"|  Player: {PlayerScore}  |  CPU: {CPUScore}   |");
        Console.WriteLine("---------------------------");
        Console.WriteLine("|                         |");
        Console.WriteLine("| 1. Rock                 |");
        Console.WriteLine("| 2. Paper                |");
        Console.WriteLine("| 3. Scissors             |");
        Console.WriteLine("|                         |");
        Console.WriteLine("---------------------------");
        Console.WriteLine();

        if (PlayerScore == 3 || CPUScore == 3)
        {
            Environment.Exit(-1);
        }

        Console.Write("Choice: ");
        string PlayerChoice = Console.ReadLine();


        Random r = new Random();
        int generated = r.Next(0, 2) + 1;
        string CpuChoice = generated.ToString();

        if (PlayerChoice == CpuChoice)
        {
            ChoiceVisualGenerator(PlayerChoice);
            Console.WriteLine();
            Console.WriteLine("VS");
            Console.WriteLine();
            ChoiceVisualGenerator(CpuChoice);
            Console.WriteLine();
            Console.WriteLine("It's a TIE!");
        }
        else if (PlayerChoice == "1")
        {
            ChoiceVisualGenerator(PlayerChoice);
            Console.WriteLine();
            Console.WriteLine("VS");
            Console.WriteLine();
            if (CpuChoice == "2")
            {
                ChoiceVisualGenerator(CpuChoice);
                Console.WriteLine();
                Console.WriteLine("YOU LOSE!");
                ++CPUScore;
            }
            else
            {
                ChoiceVisualGenerator(CpuChoice);
                Console.WriteLine();
                Console.WriteLine("YOU WIN!");
                ++PlayerScore;
            }
        }
        else if (PlayerChoice == "2")
        {
            ChoiceVisualGenerator(PlayerChoice);
            Console.WriteLine();
            Console.WriteLine("VS");
            Console.WriteLine();

            if (CpuChoice == "1")
            {
                ChoiceVisualGenerator(CpuChoice);
                Console.WriteLine();
                Console.WriteLine("YOU WIN!");
                ++PlayerScore;
            }
            else
            {
                ChoiceVisualGenerator(CpuChoice);
                Console.WriteLine();
                Console.WriteLine("YOU LOSE!");
                ++CPUScore;
            }
        }
        else if (PlayerChoice == "3")
        {
            ChoiceVisualGenerator(PlayerChoice);
            Console.WriteLine();
            Console.WriteLine("VS");
            Console.WriteLine();

            if (CpuChoice == "1")
            {
                ChoiceVisualGenerator(CpuChoice);
                Console.WriteLine();
                Console.WriteLine("YOU LOSE!");
                ++CPUScore;
            }
            else
            {
                ChoiceVisualGenerator(CpuChoice);
                Console.WriteLine();
                Console.WriteLine("YOU WIN!");
                ++PlayerScore;
            }
        }
    }


}

void ChoiceVisualGenerator(string choice)
{
    if (choice == "1")
    {
        Rock();
    }
    else if (choice == "2")
    {
        Paper();
    }
    else if (choice == "3")
    {
        Scissors();
    }
}

void Rock()
{
    Console.WriteLine(@"
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)
");
}

void Paper()
{
    Console.WriteLine(@"
     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)    
    ");
}

void Scissors()
{
    Console.WriteLine(@"
        _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)
");
}

void MagicMoose()
{
    List<string> MagicAnswers = new List<string>();
    MagicAnswers.Add("As I see it, yes.");
    MagicAnswers.Add("Ask again later.");
    MagicAnswers.Add("Better not tell you now.");
    MagicAnswers.Add("Cannot predict now.");
    MagicAnswers.Add("Concentrate and ask again.");
    MagicAnswers.Add("Don’t count on it.");
    MagicAnswers.Add("It is certain.");
    MagicAnswers.Add("It is decidedly so.");
    MagicAnswers.Add("Most likely.");
    MagicAnswers.Add("My reply is no.");
    MagicAnswers.Add("My sources say no.");
    MagicAnswers.Add("Outlook not so good.");
    MagicAnswers.Add("Outlook good.");
    MagicAnswers.Add("Reply hazy, try again.");
    MagicAnswers.Add("Signs point to yes.");
    MagicAnswers.Add("Very doubtful.");
    MagicAnswers.Add("Without a doubt.");
    MagicAnswers.Add("Yes.");
    MagicAnswers.Add("Yes - definitely");
    MagicAnswers.Add("You may rely on it");

    bool playing = true;

    while (playing)
    {

        Console.Write($"What question do you seek answers to? ");
        string answer = Console.ReadLine();

        Random r = new Random();
        int genRand = r.Next(0, 19);

        if (String.IsNullOrWhiteSpace(answer))
        {
            // Main();
            playing = false;
            Environment.Exit(-1);
        }
        else
        {
            MooseSays(MagicAnswers[genRand]);
        }
    }

}


void Questions()
{

    List<string> questions = new List<string>();
    questions.Add("Is Canada real?"); // adding elements using add() method
    questions.Add("Are you enthusiastic?");
    questions.Add("Do you love C# yet?");
    questions.Add("Do you want to know a secret?");

    List<string> answers = new List<string>();
    answers.Add("Really? It seems very unlikely.");
    answers.Add("I  K N E W  I T !!!");
    answers.Add("Yay!");
    answers.Add("You should try it!");
    answers.Add("Good job sucking up to your instructor!");
    answers.Add("You will...oh, yes, you will...");
    answers.Add("ME TOO!!!! I love secrets...tell me one!");
    answers.Add("Oh, no...secrets are the best, I love to share them!");

    int AnswerKey = 0;

    foreach (string question in questions)
    {
        bool isTrue = MooseAsks(question);
        if (isTrue)
        {
            MooseSays(answers[AnswerKey]);
        }
        else
        {
            MooseSays(answers[AnswerKey + 1]);
        }

        AnswerKey = AnswerKey + 2;
    }

    Console.Write("Go back to the main menu? (Y/N): ");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n")
    {
        Console.Write("Go back to the main menu? (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }

    if (answer == "y")
    {
        Main();
    }
    else
    {
        Environment.Exit(-1);
    }

}

bool MooseAsks(string question)
{
    Console.Write($"{question} (Y/N): ");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }

    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}

void MooseSays(string message)
{
    Console.WriteLine($@"
                                      _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}

