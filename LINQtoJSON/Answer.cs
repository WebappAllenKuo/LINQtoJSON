using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQtoJSON
{
    class Answer
    {
        public Topic topic { get; set; }
        public Question question { get; set;}

        public int answerID { get; set; }
        public string answerDescription { get; set; }

        public Answer(Topic topic,Question question,int answerID,string answerDescription)
        {
            this.topic = topic;
            this.question = question;
            this.answerID = answerID;
            this.answerDescription = answerDescription;
        }
    }
}
