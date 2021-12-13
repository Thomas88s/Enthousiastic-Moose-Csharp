using System;

Main();

void Main()
{

    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    System.Console.WriteLine();

    MooseSays("H I, I'M  E N T H U S I A S T I C !");
    MooseSays("I really am enthusiastic");

    Question("Is Canada real?", "Really? It seems very unlikely.", "I  K N E W  I T !!!");
    Question("Are you enthusiastic?", "Yay!", "You should try it!");
    Question("Do you love C# yet?", "Good job sucking up to your instructor!", "You will...oh, yes, you will...");
    Question("Do you want to know a secret?", "ME TOO!!! I love secrets...tell me one!", "Oh, no...secrets are the best, I love to share them!");

    // CanadaQuestion();
    // EnthusiasticQuestion();
    // LoveCSharpQuestion();
    // SecretQuestion();
}

// uses MooseAsk() to return a value and give the appropriate answer
// first parameter is the question asked 
// second parameter is the true answer return statement
// third parameter is the false answer return statement

void Question(string question, string trueAnswer, string falseAnswer)
{
    bool isTrue = MooseAsks(question);
    if (isTrue)
    {
        MooseSays(trueAnswer);
    }
    else
    {
        MooseSays(falseAnswer);
    }

}

// //uses 'MooseAsk() to ask a question and retruns a value according to the answer given'
// void CanadaQuestion()
// {
//     //this takes the returned value from MooseAsk()
//     bool isTrue = MooseAsks("Is Canada real?");

//     //if 'isTrue' equates to True or False the corresponding statement is displayed
//     if (isTrue)
//     {
//         MooseSays("Really? It seems very unlikely.");
//     }
//     else
//     {
//         MooseSays("I  K N E W  I T !!!");
//     }

// }

// void EnthusiasticQuestion()
// {
//     bool isEnthusiastic = MooseAsks("Are you enthusiastic?");
//     if (isEnthusiastic)
//     {
//         MooseSays("Yay!");
//     }
//     else
//     {
//         MooseSays("You should try it!");
//     }
// }

// void LoveCSharpQuestion()
// {
//     bool doesLoveCSharp = MooseAsks("Do you love C# yet?");
//     if (doesLoveCSharp)
//     {
//         MooseSays("Good job sucking up to your instructor!");
//     }
//     else
//     {
//         MooseSays("You will...oh, yes, you will...");
//     }
// }

// void SecretQuestion()
// {
//     bool wantsSecret = MooseAsks("Do you want to know a secret?");
//     if (wantsSecret)
//     {
//         MooseSays("ME TOO!!! I love secrets...tell me one!");
//     }
//     else
//     {
//         MooseSays("Oh, no...secrets are the best, I love to share them!");
//     }
// }

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

bool MooseAsks(string question)
{

    // this writes the question to the command line and stores the user input
    // into the string 'answer' in lower case form
    Console.Write($"{question} (Y/N): ");
    string answer = Console.ReadLine().ToLower();

    //this checks for a simple y or n answer
    // if anything else is entered, the question is repeated
    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }

    //this returns a bool value according to the answer given 
    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}
