using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pragati_Judge
{
    class Team
    {
        private int id, score;
        string name;

        public override string ToString()
        {
            return this.id + ". Team Name : " + this.name;
        }

        public Team(int id, string name)
        {
            this.id = id;
            this.name = name;
        }


        public Team(int id, int score, string name)
        {
            this.id = id;
            this.name = name;
            this.score = score;
        }

        public int ID
        {
            get { return id; }
        }

        public int Score
        {
            get { return score; }
        }

        public string Name
        {
            get { return name; }
        }


    }
}
