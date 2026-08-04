string email = "beginner.dev@gmail.com";

Console.WriteLine(EmailExtrator(email));

static string EmailExtrator(string email)
{
    int index = email.IndexOf("@");

    if (index == -1)
    {
        return "Invalid email";
    }

    return email.Substring(index + 1);
}