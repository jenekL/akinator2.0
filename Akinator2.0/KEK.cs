using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akinator2._0
{
    class KEK
    {
        private int id1;
        private int id2;
        private int id3;
        private int id4;

        public KEK(int id1, int id2, int id3, int id4)
        {
            this.id1 = id1;
            this.id2 = id2;
            this.id3 = id3;
            this.id4 = id4;
        }

        public int Id1 { get => id1; set => id1 = value; }
        public int Id2 { get => id2; set => id2 = value; }
        public int Id3 { get => id3; set => id3 = value; }
        public int Id4 { get => id4; set => id4 = value; }
    }
}
