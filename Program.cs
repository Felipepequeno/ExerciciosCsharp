string permission = "Manager";
int level = 55;

if (permission.Contains("Admin"))
{
    Console.WriteLine((level > 55)? "Welcome, Super Admin user." : "Welcome, Admin user.");
}
else if (permission.Contains("Manager"))
{
    Console.WriteLine((level >=20)? "Contact an Admin for acess" : "You do not have sufficient privileges.");

}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}