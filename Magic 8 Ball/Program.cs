using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_8_Ball
{
    class Program
    {
        static void OutputResponses(IQuestionable respond)
        {
            respond.Response();
        }

        static void Main(string[] args)
        {
            string question = "Y";
            while (question != "X")
            {
                var happyR = new Happy8Ball();
                var sadR = new Sad8Ball();
                var robotR = new Robot8Ball();

                Random rnd = new Random();
                string[] rnd8Ball = { "HappyB", "SadB", "RobotB" };
                string[] rndBall = rnd8Ball.OrderBy(x => rnd.Next()).ToArray();
                string rnd8balltype = rndBall[0];

                Console.WriteLine("");
                Console.WriteLine("________________________________________________");
                Console.WriteLine("Ask me a Yes or No question, or type 'X' to exit");
                Console.WriteLine("________________________________________________");
                Console.WriteLine("");
                question = Console.ReadLine();
                Console.WriteLine("");

                if (rnd8balltype == "HappyB")
                {
                   
                    OutputResponses(happyR);
                }
                else if (rnd8balltype == "SadB")
                {
                    
                    OutputResponses(sadR);
                }
                else if (rnd8balltype == "RobotB")
                {
                    OutputResponses(robotR);
                }
            }
        }
    }
}


