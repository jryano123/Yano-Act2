Console.WriteLine("Please enter score #1");
int score = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter score #2");
score += Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter score #3");
score += Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter score #4");
score += Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter score #5");
score += Convert.ToInt32(Console.ReadLine());

var finalscore = score;

Console.WriteLine("Your Average score is:" + finalscore);

if(score >= 75)
{
    Console.WriteLine("Passed");
}
else
{
    Console.WriteLine("Failed");
}