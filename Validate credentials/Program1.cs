using System;

namespace Validate_credentials
{
    class Program1
    {
        static void Main(string[] args)
        {
            string userid, pwd;
            string tempuser, temppwd;
            string loweruser;
            int count = 0;
            tempuser = "Abhinav";
            temppwd = "HelloWorld";

            while (true)
            {
                Console.WriteLine("Enter your credentials");
                Console.WriteLine("userid");
                userid = Convert.ToString(Console.ReadLine());
                Console.WriteLine("password");
                pwd = Convert.ToString(Console.ReadLine());
                loweruser = userid.ToLower();

                if (count <= 3)
                {
                    if ((tempuser.Equals(loweruser) && pwd == temppwd))
                        Console.WriteLine("you're logged in");
                    else
                        count++;
                }
                else
                {
                    Console.WriteLine("attempts are done");
                    break;
                }
            }


        }
    }
}
