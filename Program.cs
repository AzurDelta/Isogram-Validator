start:
Console.WriteLine("enter string to validate");
string stringToValidate = Console.ReadLine();

if (stringToValidate == null)
    goto start;

if (stringToValidate.Length == stringToValidate.Distinct().Count())
    Console.WriteLine("string is isogram");
else
    Console.WriteLine("string is not isogram");