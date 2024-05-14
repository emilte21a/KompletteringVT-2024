
User user1 = new User();

OwnList<ConsoleColor> consoleColors = new OwnList<ConsoleColor>();
consoleColors.values.Add(ConsoleColor.Red);
consoleColors.values.Add(ConsoleColor.Blue);
consoleColors.values.Add(ConsoleColor.Yellow);
consoleColors.values.Add(ConsoleColor.Green);

int maxCharactersPerName = 15;

System.Console.WriteLine("Hello!!! welcome to game");
System.Console.WriteLine("Tell me your name: ");
user1.Name = Console.ReadLine();

while (!IsValidInput(user1.Name))
    user1.Name = Console.ReadLine();

Console.Clear();

System.Console.WriteLine("Hello " + user1.Name);
System.Console.WriteLine("How old are you?!");

string inputAge = Console.ReadLine();

while (!isValidAge(inputAge))
{
    inputAge = Console.ReadLine();
    user1.Age = StringToInt(inputAge);
}
Console.Clear();
user1.Age = StringToInt(inputAge);

System.Console.WriteLine("WOW! " + user1.Name + " is " + user1.Age + " Years old!!");

System.Console.WriteLine("Now tell me your favourite color!");
for (int i = 0; i < consoleColors.values.Count; i++)
    System.Console.WriteLine(i + 1 + ": " + consoleColors.values[i]);

int consoleColor = StringToInt(Console.ReadLine()) - 1;

while (!IsValidColor(consoleColor))
{
    System.Console.WriteLine("Write one of the numbers..");
    consoleColor = StringToInt(Console.ReadLine()) - 1;
}
Console.Clear();
Console.BackgroundColor = consoleColors.values[consoleColor];

System.Console.WriteLine("WOW now the background is " + consoleColors.values[consoleColor]);

Console.ReadLine();

bool IsValidInput(string input)
{
    if (user1.Name == "")
    {
        System.Console.WriteLine("You need to write at least 1 letter!");
        return false;
    }

    else if (user1.Name.Length >= maxCharactersPerName)
    {
        System.Console.WriteLine("Write a shorter name!");
        return false;
    }
    return true;
}

bool IsValidColor(int index)
{
    if (index < 0)
    {
        System.Console.WriteLine("Write something bigger than 0");
        return false;
    }
    else if (index > consoleColors.values.Count)
    {
        System.Console.WriteLine("Write something smaller than " + consoleColors.values.Count);
        return false;
    }
    return true;
}

bool isValidAge(string ageInput)
{
    int a;
    if (int.TryParse(ageInput, out a))
    {
        if (a <= 0)
        {
            System.Console.WriteLine("Write something greater than 0");
            return false;
        }
    }
    else
    {
        System.Console.WriteLine("Write a number");
        return false;
    }

    return true;
}

int StringToInt(string input)
{
    int a;
    bool possibleConvert = int.TryParse(input, out a);

    if (possibleConvert)
        return a;


    return 0;
}