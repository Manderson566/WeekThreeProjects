using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_8_Ball
{
    class Happy8Ball : IQuestionable
    {
        public void Response()
        {
            HappyResponse();
        }
        private void HappyResponse()
        {
            string[] happyAnswers = {"It is certain. The 8 ball loves you", "Without a doubt. Also you are very intellegent",
                                       "Outlook good. Today you are beautiful", "Reply hazy try again cutie",
                                       "Better not tell you now Beautiful","Don't count on it, but you can count on my love for you.",
                                     "My sources say not, but my heart says yes", "Outlook not so good, but you look good"};
            Random rnd = new Random();
            string[] rndHappyResponse = happyAnswers.OrderBy(x => rnd.Next()).ToArray();
            //string rndString = rnd.Next(happyAnswers.Count()).ToString();
            //string randomString = happyAnswers[rndString];

            Console.WriteLine(rndHappyResponse[1]);
        }
    }
}
