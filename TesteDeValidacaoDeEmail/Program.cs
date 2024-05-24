using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine(" ** Digite um email para verificação: ** \n");
        string email = Console.ReadLine();

        string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,6}$";
        Regex regex = new Regex(emailPattern);

        if (regex.IsMatch(email))
        {
            Console.WriteLine($"\n{email} é um email válido.");
        }
        else
        {
            Console.WriteLine($"\n{email} é um email inválido.");
        }
    }
}
