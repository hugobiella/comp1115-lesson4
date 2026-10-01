Console.Write("Enter you quiz score: ");
int quizScore = int.Parse(Console.ReadLine());

string bonus = "none";

if (quizScore > 1000)
{
    bonus = "Double points";
}

Console.Write($"Your bonus is {bonus}");