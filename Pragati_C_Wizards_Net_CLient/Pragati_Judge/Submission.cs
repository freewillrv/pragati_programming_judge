using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pragati_Judge
{
    class Submission
    {
        int id, teamid, probid, no_of_errors,probMarks;
        string time;

        public Submission(int id, int teamid, int probid, string time, int no_of_errors,int probMarks)
        {
            this.id = id;
            this.teamid = teamid;
            this.probid = probid;
            this.time = time;
            this.no_of_errors = no_of_errors;
            this.probMarks = probMarks;
        }

        public int ProbMarks
        {
            get { return probMarks; }
        }

        public int ID
        {
            get { return id; }
        }

        public int TeamId
        {
            get { return teamid; }
        }

        public int ProbId
        {
            get { return probid; }
        }

        public int NoOfErrors
        {
            get { return no_of_errors; }
        }

        public string Time
        {
            get { return time; }
        }

    }
}
