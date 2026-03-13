string[] myStrings = new string[2]
{
    "I like pizza. I like roast chicken. I like salad.",
    "I like all three of the meny choices."
};

int periodLocation;

foreach (string myString in myStrings)
{
    string tempString = myString;
    periodLocation = tempString.IndexOf(".");

    while (periodLocation != -1)
    {
        string  sentence = tempString.Substring(0, periodLocation);
        Console.WriteLine(sentence.TrimStart());
        tempString = tempString.Remove(0, periodLocation + 1);
        periodLocation = tempString.IndexOf(".");
    }

    if (tempString.Length > 0)
    {
        Console.WriteLine(tempString.TrimStart());
    }
}