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
            var happyR = new Happy8Ball();
            var sadR = new Sad8Ball();
            var robotR = new Robot8Ball();
            string question = "Y";
      
            Console.WriteLine("Welcome to Magic 8 Ball!! Select the type of 8 Ball you want your responses from");
            Console.WriteLine("");
            Console.WriteLine("(Type 'Happy' for a happy 8 ball.) (Type 'Sad' for a depressing 8 ball.) (Type 'Robot' for a robotic 8 ball)");
            Console.WriteLine("____________________________________________________________________________________________________________");
            string typeofEightBallQ = Console.ReadLine();
            Console.Clear();
            if (typeofEightBallQ.ToUpper() == "HAPPY")
            {
                while (question.ToUpper() == "X" )

                Console.WriteLine("");
                Console.WriteLine("Ask the Happy 8 Ball your question. Only yes or no questions please.");
                Console.WriteLine("____________________________________________________________________");
                question = Console.ReadLine();
                Console.WriteLine("");
                OutputResponses(happyR);

            }
            
        }
    }
}


