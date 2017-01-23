using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_8_Ball
{
    class Sad8Ball:IQuestionable
    {

        public void Response()
        {
            SadResponse();
        }

        private void SadResponse()
        {
            string[] sadAnswers = {"It is certain. The 8 ball is Depressed", "Without a doubt. Also you are nothing special",
                                       "Outlook good. Today you are below average", "Reply hazy try again, or not I don't care",
                                       "Better not tell you now... Ugly","Don't count on it, or anything else in life.",
                                     "My sources say no, and so does my heart ", "Outlook not so good. Like your personality"};
            Random rnd = new Random();
            string[] rndsadResponse = sadAnswers.OrderBy(x => rnd.Next()).ToArray();
            Console.WriteLine(rndsadResponse[0]);
        }
    }
}
