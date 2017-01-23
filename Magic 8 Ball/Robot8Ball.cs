using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_8_Ball
{
    class Robot8Ball:IQuestionable
    {
       

        public void Response()
        {
            RobotResponses();
        }
        private void RobotResponses()
        {
            string[] RobotAnswers = {"Error, Error", "Does not Compute",
                                       "An SSL Error has occured", "A secure connection cannot be made",
                                       "A file with that name already exists.","Error 404",
                                     "The application failed to initialize", "You must restart Windows"};
            Random rnd = new Random();
            string[] rndrobotResponse = RobotAnswers.OrderBy(x => rnd.Next()).ToArray();
            Console.WriteLine(rndrobotResponse[2]);
        }
    }
}
