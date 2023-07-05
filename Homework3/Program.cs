


Console.Write("Enter your first name: ");

string? firstName = Console.ReadLine();

if (firstName.ToLower().Equals("tim") || firstName.ToLower().Equals("timothey"))
{
    Console.WriteLine("Welcome Timothey!");
}
else
{
    Console.WriteLine($"Welcome {firstName.ToLower()}");
}


