// MINECRAFT QUIZ
Console.Clear();
#nullable disable


// WELCOME
Console.WriteLine("Welcome to the amazing minecraft quiz!!!");
int score = 0;


// INPUT
Console.WriteLine("\n1. Name a green hostile mob.");
Console.Write("Q1 Answer: ");
string ans1 = Console.ReadLine().ToLower();
if (ans1 == "zombie" || ans1 == "creeper" || ans1 == "slime")
{
    score++;
    Console.WriteLine("CORRECT!");
}
else
{
    Console.WriteLine("INCORRECT!");
}


Console.WriteLine("\n2. What experience level do you start at?");
Console.Write("Q2 Answer: ");
int ans2 = Convert.ToInt32(Console.ReadLine());
if (ans2 == 0)
{
    score++;
    Console.WriteLine("CORRECT!");
}
else
{
    Console.WriteLine("INCORRECT!");
}

Console.WriteLine("\n3. Which material makes armour with the most protection given?");
Console.Write("Q3 Answer: ");
string ans3 = Console.ReadLine().ToLower();
if (ans3 == "diamond" || ans3 == "netherite")
{
    score++;
    Console.WriteLine("CORRECT!");
}
else
{
    Console.WriteLine("INCORRECT!");
}

Console.WriteLine("\n4. How many netherite scraps do you need for a full set of armour?");
Console.Write("Q4 Answer: ");
int ans4 = Convert.ToInt32(Console.ReadLine());
if (ans4 == 20)
{
    score++;
    Console.WriteLine("CORRECT!");
}
else
{
    Console.WriteLine("INCORRECT!");
}

Console.WriteLine($"YOU SCORED {score}/4 !");
if (score < 3)
{
    Console.WriteLine("Try Again");
}
else
{
    Console.WriteLine("GOOD JOB");
}

