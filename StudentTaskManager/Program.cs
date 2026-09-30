Console.WriteLine("Student Task Manager");
Console.WriteLine("====================");

Console.Write("Enter your name: ");
string name = Console.ReadLine();

Console.Write("How many tasks do you want to complete today? ");
int taskGoal = int.Parse(Console.ReadLine());
//.Parse(Console.ReadLine());可以改物件類型
//int.TryParse()可以阻止程式崩潰

Console.Write("How many hours do you have available? ");
double availableHours = double.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine($"Hello {name}!");
Console.WriteLine($"Your goal is {taskGoal} tasks.");
Console.WriteLine($"You have {availableHours} hours available.");
//$和{}是字串插值的語法，$表示字串插值，{}內的變數會被替換成其值。

Console.Write("How many tasks have you completed today? ");
int completedTasks = int.Parse(Console.ReadLine());

if (completedTasks == 0)
{
    Console.WriteLine("Time to get started!");
}
else if (completedTasks < taskGoal )
{
    Console.WriteLine("Good start. Keep going!");
}
else
{
    Console.WriteLine("Great progress!");
}

Console.WriteLine();
Console.WriteLine("1. Add task");
Console.WriteLine("2. View tasks");
Console.WriteLine("3. Complete tasks");
Console.WriteLine("4. Remove tasks");
Console.WriteLine("0. Exit");

Console.Write("Choose an option: ");
int option = int.Parse(Console.ReadLine());

switch (option)
{
    case 1:
        Console.WriteLine("Adding a task...");
        break;

    case 2:
        Console.WriteLine("Showing tasks...");
        break;

    case 3:
        Console.WriteLine("Completing tasks...");
        break;

    case 4:
        Console.WriteLine("Removing tasks...");
        break;
    case 0:
        Console.WriteLine("Goodbye!");
        break;

    default:
        Console.WriteLine("Invalid option.");
        break;
}

