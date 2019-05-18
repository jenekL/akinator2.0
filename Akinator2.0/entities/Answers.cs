using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akinator2._0.entities
{
    public class Answers
    {
        int id;
        string answer;
        int question1_id;
        int question2_id;

        public int Id { get => id; set => id = value; }
        public string Answer { get => answer; set => answer = value; }
        public int Question1_id { get => question1_id; set => question1_id = value; }
        public int Question2_id { get => question2_id; set => question2_id = value; }

        public Answers(int id, string answer, int question1_id, int question2_id)
        {
            this.id = id;
            this.answer = answer;
            this.question1_id = question1_id;
            this.question2_id = question2_id;
        }

        public Answers(string answer, int question1_id, int question2_id)
        {
            this.answer = answer;
            this.question1_id = question1_id;
            this.question2_id = question2_id;
        }


    }
}
