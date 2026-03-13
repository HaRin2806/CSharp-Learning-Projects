/*
string? readResult;
int numericValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an interger value between 5 and 10");
do
{
    readResult = Console.ReadLine();

    if (int.TryParse(readResult, out numericValue))
    {
        if (numericValue >= 5 && numericValue <= 10)
        {
            validNumber = true;
        }
        else
        {
            Console.WriteLine($"You entered {numericValue}. Please  enter a number between 5 and 10.");
        }
    }
    else
    {
        Console.WriteLine("Sorry, you enterd an invalid number, please try again.");
    }
}while (!validNumber);

Console.WriteLine($"You input ({numericValue}) has been accepted.");
*/
//c2
string? readResult;
string valueEntered = "";
int numValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    readResult = Console.ReadLine();
    if (readResult != null) 
    {
        valueEntered = readResult;
    }

    validNumber = int.TryParse(valueEntered, out numValue);

    if (validNumber == true)
    {
        if (numValue <= 5 || numValue >= 10)
        {
            validNumber = false;
            Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
        }
    }
    else 
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
} while (validNumber == false);

Console.WriteLine($"Your input value ({numValue}) has been accepted.");

readResult = Console.ReadLine();

