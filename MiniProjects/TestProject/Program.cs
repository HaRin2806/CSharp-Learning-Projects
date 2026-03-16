// int first = 2;
// string second = "4";
// string result = first + second;
// Console.WriteLine(result);

// int myInt = 3;
// Console.WriteLine($"int: {myInt}");
// decimal myDecimal = myInt;
// Console.WriteLine($"decimal: {myDecimal}");

// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");
// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = 1.23456789m;
// float myFloat = (float)myDecimal;

// Console.WriteLine($"Decimal: {myDecimal}");
// Console.WriteLine($"Float: {myFloat}");

// int first = 5;
// int second = 7;
// string message = first.ToString() + second.ToString();
// Console.WriteLine(message);

// string first = "5";
// string second = "7";
// int sum = int.Parse(first) + int.Parse(second);
// Console.WriteLine(sum);

// string val1 = "5";
// string val2 = "7";
// int result = Convert.ToInt32(val1) * Convert.ToInt32(val2);
// Console.WriteLine(result);

// int val = (int)1.5m; //casting truncates
// Console.WriteLine(val);
// int val2 = Convert.ToInt32(1.5m); //converting rounds up
// Console.WriteLine(val2);

// string val = "bad";
// int result = 0;
// if (int.TryParse(val, out result))
// {
//     Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//     Console.WriteLine("Unable to report the measurement.");
// }
// if (result > 0)
// {
//     Console.WriteLine($"Measurement (w/ offset): {50 + result}");
// }

// string[] vals = {"12.3", "45", "ABC", "11", "DEF"};
// double total = 0;
// string mess = "";
// foreach (string val in vals)
// {
//     double number;
//     if (double.TryParse(val, out number))
//     {
//         total += number;
//     }
//     else
//     {
//         mess += val;
//     }
// }
// Console.WriteLine($"Message: {mess}");
// Console.WriteLine($"Total: {total}");

int val1 = 11;
decimal val2 = 6.2m;
float val3 = 4.3f;
int result1 = Convert.ToInt32(val1 / val2);
Console.WriteLine($"Divide val1 by val2, display as an int: {result1}");

decimal result2 = val2 / (decimal)val3;
Console.WriteLine($"Divide val2 by val3, display as a decimaal: {result2}");

float result3 = val3 / val1;
Console.WriteLine($"Divide val3 by val1, display as a float: {result3}");
