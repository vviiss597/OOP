Console.WriteLine("Welcome to Student Information System!");
Console.WriteLine("================================");

List<int> grades = new List<int>();

Console.WriteLine("Press Enter after each input.");
Console.WriteLine("Press Enter on an empty line to finish");
Console.WriteLine("================================");
Console.WriteLine("Press any key to continue...");
Console.ReadKey();

bool running = true;
while (running)
{
    if (grades.Count < 5)
    {   
        Console.WriteLine("Enter the grades of the students:");
        int grade = int.Parse(Console.ReadLine());
        if (grade < 0)
        {
            Console.WriteLine("Invalid input. Please enter a non-negative grade.");
        }
        else
        {   
            grades.Add(grade);
            Console.WriteLine($"You have entered {grades.Count} grades.");
        }
        
    }
    else
    {
        Console.WriteLine("You have already entered 5 grades. Please press Enter to finish.");
        Console.ReadKey();
        running =false;
    }
}

int maxgrade = grades.Max();
int mingrade = grades.Min();
double averagegrade = grades.Average();


Console.WriteLine($"The maximum grade is: {maxgrade}");