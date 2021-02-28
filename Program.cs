using System;
using System.Collections.Generic;

Main();

void Main()
{
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();

    // Let the moose speak!
    MooseSays("H I, I'M  E N T H U S I A S T I C !");
    MooseSays("I really am enthusiastic");

    // Ask a question
    Questions();
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

