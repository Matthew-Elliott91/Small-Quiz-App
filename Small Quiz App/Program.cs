// See https://aka.ms/new-console-template for more information
string question1 = "What is the capital of the UK";
string answer1 = "london";

string question2 = "What is the biggest country in the world by landmass";
string answer2 = "russia";

string question3 = "Which country has the largest population";
string answer3 = "china";

int score = 0;

Console.WriteLine(question1);
string userAnswer1 = Console.ReadLine();
if (answer1.ToLower() == userAnswer1.Trim().ToLower())
{
    score ++;
    Console.WriteLine($"Answer was correct. Your score is {score}");
}
else
{
    Console.WriteLine($"Answer was incorrect. The correct answer is {answer1} Your score is {score}");
}

Console.WriteLine(question2);
string userAnswer2 = Console.ReadLine();
if (answer2.ToLower() == userAnswer2.Trim().ToLower())
{
    score++;
    Console.WriteLine($"Answer was correct. Your score is {score}");
}
else
{
    Console.WriteLine($"Answer was incorrect. The correct answer is {answer2} Your score is {score}");
}

Console.WriteLine(question3);
string userAnswer3 = Console.ReadLine();
if (answer3.ToLower() == userAnswer3.Trim().ToLower())
{
    score++;
    Console.WriteLine($"Answer was correct. Your score is {score}");
}
else
{
    Console.WriteLine($"Answer was incorrect. The correct answer is {answer3} Your score is {score}");
}

Console.WriteLine($"The quiz is over your final score was {score}");

if (score == 3)
{ 
    Console.WriteLine("Congratulations, you answered everything correctly"); 
}
else if (score > 0)
{
    Console.WriteLine("Good job, but keep learning!");
}
else
{
    Console.WriteLine("You need to study much harder!");
}
Console.ReadKey();
