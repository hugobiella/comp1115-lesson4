/*
Console.Write("Enter you quiz score: ");
int quizScore = int.Parse(Console.ReadLine());

string bonus = "none";

if (quizScore > 1000)
{
    bonus = "Double points";
}

Console.Write($"Your bonus is {bonus}");
*/

/*
int round1Score;
int round2Score;

Console.Write("Enter your 1st round score: ");
round1Score = int.Parse(Console.ReadLine());
Console.Write("Enter your 2nd round score: ");
round2Score = int.Parse(Console.ReadLine());

if (round2Score > round1Score)
{
    Console.WriteLine("You've improved");
}
else if (round1Score > round2Score)
{
    Console.WriteLine("You are on a slide");
    if (round2Score < 50)
    {
        Console.WriteLine("You must redo Round 2");
    }
}
else
{
    Console.WriteLine("You're stagnant");
}

if (round1Score > 80 && round2Score > 80)
{
    Console.WriteLine("You've made into the Leaderboard!");
}
*/

int difficulty;
double multiplier;
string difficultyName;

Console.WriteLine("Enter difficulty: 1-Easy, 2-Medium, 3-Hard");
difficulty = int.Parse(Console.ReadLine());

switch (difficulty)
{
    case 1:
        difficultyName = "Easy";
        multiplier = 1;
        break;
    case 2:
        difficultyName = "Medium";
        multiplier = 1.5;
        break;
    case 3:
        difficultyName = "Hard";
        multiplier = 2;
        break;
    default:
        difficultyName = "Invalid option";
        multiplier = 0;
        break;
}

Console.WriteLine($"Difficulty: {difficultyName} - {multiplier}x multiplier");
