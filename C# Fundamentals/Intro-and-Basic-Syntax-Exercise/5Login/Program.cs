using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            //On the first line, you will be given a username and your task is to try to log in the user. The user's password is the username reversed. On the next lines, you will receive passwords:
            //If the password is incorrect, print "Incorrect password. Try again.".
            //If the password is correct, print "User {username} logged in." and stop the program.
            //Keep in mind that if the password is still incorrect on the fourth attempt, you should print: "User {username} blocked!".
            //Then the program stops.
            int wrongGuesses = 0;
            bool logedIn = false;
            string username = Console.ReadLine();
            while (!logedIn)
            {
                string password = Console.ReadLine();
                for (int i = 0, j = username.Length-1; i < username.Length; i++, j--)
                {
                    if (password[i] != username[j])
                    {
                        wrongGuesses++;
                        if(wrongGuesses < 4)
                            Console.WriteLine("Incorrect password. Try again.");
                        logedIn = false;
                        break;
                    }
                    logedIn = true;
                }
                if(wrongGuesses == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
            }
            if(logedIn)
                Console.WriteLine($"User {username} logged in.");

        }
    }
}
