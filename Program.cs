string stringToValidate;
while (true)
{ 
    Console.WriteLine("enter string to validate");
    stringToValidate = Console.ReadLine();
    if (stringToValidate != null)
    break;
}

if (stringToValidate.Length == stringToValidate.Distinct().Count())
    Console.WriteLine("string is isogram");
else
    Console.WriteLine("string is not isogram");