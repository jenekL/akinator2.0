using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akinator2._0.entities
{
    public class Questions
    {
        private int id;
        private string question;
        //private Byte[] image;

        public int Id { get => id; set => id = value; }
        public string Question { get => question; set => question = value; }
        //public byte[] Image { get => image; set => image = value; }

      
      
        public Questions(string question)
        {
            this.question = question;
        }

        public Questions(int id, string question)
        {
            this.id = id;
            this.question = question;
        }
    }
}
