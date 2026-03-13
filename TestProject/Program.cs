string? role;
bool validRole = false;

Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

do
{
    role = Console.ReadLine();

    if (role != null)
    {
        role = role.Trim().ToLower();

        if (role == "administrator" || role == "manager" || role == "user")
        {
            validRole = true;
        }
        else
        {
            Console.WriteLine($"The role name that you entered, \"{role} \"is not valid. Enter your role (Administrator, Manager, User)"); 
        }
    }
}while (!validRole);

Console.WriteLine($"Your input value ({role}) has been accpeted.");