using System;

namespace Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";
            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }
            int count = 0;
            while ( count<4)
            {
                string Inputpassword = Console.ReadLine();
                count++;


                if (Inputpassword == password) { Console.WriteLine($"User {username} logged in.");break; }

                else if (count == 4) { Console.WriteLine($"User {username} blocked!"); break; }
                else  if (Inputpassword != password)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
              
            }
      
        }
    }
}
