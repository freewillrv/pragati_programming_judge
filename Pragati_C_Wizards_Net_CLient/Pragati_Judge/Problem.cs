using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pragati_Judge
{
    class Problem
    {
        int id, marks;
        string name, input, output, desc;

        public override string ToString()
        {
            return Name + ", Marks : " + Marks;
        }

        public Problem(int id, string name, int marks, string input, string output)
        {
            this.id = id;
            this.marks = marks;
            this.name = name;
            this.input = input;
            this.output = output;
        }


        public Problem(int id, string name, int marks, string input, string output,string desc)
        {
            this.id = id;
            this.marks = marks;
            this.name = name;
            this.input = input;
            this.output = output;
            this.desc = desc;
        }

        public int ID
        {
            get { return id; }
        }

        public int Marks
        {
            get { return marks; }
        }

        public string Name
        {
            get { return name; }
        }

        public string Input
        {
            get { return input; }
        }

        public string Output
        {
            get { return output; }
        }

        public string Description
        {
            get { return desc; }
        }

    }
}
