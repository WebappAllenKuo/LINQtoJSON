using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQtoJSON
{
    class Question
    {
        public Topic topic { get; set; }
        public int questionID { get; set; }
        public string questionDescription { get; set; }

        public Question(Topic topic,int questionID,string questionDescription)
        {
            this.topic = topic;
            this.questionID = questionID;
            this.questionDescription = questionDescription;

        }
    }
}
