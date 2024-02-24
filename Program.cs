Console.Clear();
int score = 0;
int scoreMax = 4;

string question1 = "Paladin";
string question1Alt = "paladin";

string question2 = "lightning";
string question2Alt = "Lightning";

string question3 = "no";
string question3Alt ="No";

String question4 = "6";
Console.WriteLine("Hello to Pathfinder WoTR quizz!");
Console.WriteLine("Question 1: What hero class is Seelah?");

string answer1 = Console.ReadLine();
if(answer1 == question1 || answer1 == question1Alt)
{
    Console.WriteLine("Correct!");
    score ++;
}
else
{
    Console.WriteLine("Wrong!");
}
Console.WriteLine("Question 2: What element are demons immune to?");
string answer2 = Console.ReadLine();
if(answer2 == question2 || answer2 == question2Alt)
{
    Console.WriteLine("Correct!");
    score++;
}
else
{
    Console.WriteLine("Wrong!");
}

Console.WriteLine("Question3: Do you automaticly score critical hit if you roll 20 on d20 dice?");
string answer3 = Console.ReadLine();
if(answer3 == question3 || answer3 == question3Alt)
{
    Console.WriteLine("Correct!");
    score++;
}
else
{
    Console.WriteLine("Wrong!");
}
Console.WriteLine("Let's try something different, how many act are in the game? Write the number(Hint: less than 10)");
string answer4;
do
{
    Console.WriteLine("Provide correct answer");
    answer4 = Console.ReadLine();
}
while(answer4 != question4 );
{
    Console.WriteLine("Correct!");
    score++;
}
Console.WriteLine($"You got {score} out of {scoreMax} points!");