using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQtoJSON
{
    class Topic
    {
        public int topicID { get; set; }
        public string topicDescription { get; set; }

        public Topic(int topicID,string topicDesc)
        {
            this.topicID = topicID;
            this.topicDescription = topicDesc;

        }
    }
}
