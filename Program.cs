// MINECRAFT QUIZ
Console.Clear();
#nullable disable


// WELCOME
Console.WriteLine("Welcome to the amazing minecraft quiz!!!");
int score = 0;


// INPUT Q1
Console.WriteLine("\n1. Name a green hostile mob.");
Console.Write("Q1 Answer: ");
string ans1 = Console.ReadLine().ToLower();
// Output Q1
if (ans1 == "zombie" || ans1 == "creeper" || ans1 == "slime")
{
    score++;
    Console.WriteLine("CORRECT!");
}
else
{
    Console.WriteLine("INCORRECT!");
}

// INPUT Q2
Console.WriteLine("\n2. What experience level do you start at?");
Console.Write("Q2 Answer: ");
string ans2 = Console.ReadLine();
// Output Q2
if (ans2 == "0")
{
    score++;
    Console.WriteLine("CORRECT!");
}
else
{
    Console.WriteLine("INCORRECT!");
}

// INPUT Q3
Console.WriteLine("\n3. Which material makes armour with the most protection given?");
Console.Write("Q3 Answer: ");
string ans3 = Console.ReadLine().ToLower();
// Output Q3
if (ans3 == "diamond" || ans3 == "netherite")
{
    score++;
    Console.WriteLine("CORRECT!");
}
else
{
    Console.WriteLine("INCORRECT!");
}

// INPUT Q4
Console.WriteLine("\n4. How many netherite scraps do you need for a full set of armour?");
Console.Write("Q4 Answer: ");
string ans4 = Console.ReadLine();
// Output Q4
if (ans4 == "20")
{
    score++;
    Console.WriteLine("CORRECT!");
}
else
{
    Console.WriteLine("INCORRECT!");
}

// Final Score
Console.WriteLine($"YOU SCORED {score}/4 ! ({score / 4 * 100}%)");
if (score < 3)
{
    Console.WriteLine("Try Again");
}
else
{
    Console.WriteLine("GOOD JOB");
}

