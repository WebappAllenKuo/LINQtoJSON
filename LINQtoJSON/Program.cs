using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LINQtoJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Topic> topicsList = new List<Topic>();
            List<Question> questionList = new List<Question>();
            List<Answer> answerList = new List<Answer>();

            for(int i=1;i<10;i++)
            {
                string topicDescriptionItem = "Topic Description " + i;
                Topic topicItem = new Topic(i, topicDescriptionItem);
                topicsList.Add(topicItem);

                for(int j=1;j<20;j++)
                {
                    string questionDescription = "Question Description " + j;
                    Question questionItem = new Question(topicItem,j, questionDescription);
                    questionList.Add(questionItem);

                    for(int k=1;k<5;k++)
                    {
                        string answerDescription = "Answer Description " + k;
                        Answer answerItem = new Answer(topicItem,questionItem,k,answerDescription);
                        answerList.Add(answerItem);
                    }
                }

            }


            //string json_topics = JsonConvert.SerializeObject(from t in topicsList where t.topicID < 10
            //                                                 select new
            //                                                 {
            //                                                     topicID = t.topicID,
            //                                                     topicDescription = t.topicDescription
            //                                                 });


            //string json_topics = JsonConvert.SerializeObject(from t in topicsList
            //                                                 from q in questionList.Where(q1 => q1.topic == t)
            //                                                 from a in answerList.Where(a1 => a1.question == q && a1.topic == t)
            //                                                 //where t.topicID < 10
            //                                                 select new
            //                                                 {
            //                                                     topicID = t.topicID,
            //                                                     topicDescription = t.topicDescription,
            //                                                     questionID = q.questionID,
            //                                                     questionDescription = q.questionDescription,
            //                                                     answerID = a.answerID,
            //                                                     answerDescription = a.answerDescription
            //                                                 });

            string json_topics = JsonConvert.SerializeObject(from t in topicsList
                                                             select new
                                                             {
                                                                 topicID = t.topicID,
                                                                 topicDescription = t.topicDescription,
                                                                 question = (from q in questionList
                                                                             where q.topic == t
                                                                             select new
                                                                             {
                                                                                 questionID = q.questionID,
                                                                                 questionDesc = q.questionDescription,
                                                                                 answer = (from a in answerList
                                                                                           where a.question == q && a.topic == t
                                                                                           select new
                                                                                           {
                                                                                               answerID = a.answerID,
                                                                                               answerDesc = a.answerDescription
                                                                                           }
                                                                                           )
                                                                             }
                                                                            )                                                             
                                                             }
                                                            );
          

            Console.WriteLine(json_topics);
            System.IO.File.WriteAllText(@"C:\Jags\test\json_file.txt", json_topics);
            Console.ReadLine();
        }
    }
}
