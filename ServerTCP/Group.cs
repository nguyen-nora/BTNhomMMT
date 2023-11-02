using System;
using System.Collections.Generic;
using System.Text;

namespace ServerTCP
{
    class Group
    {
        public List<string> members;
        public string name;

        public Group(string name)
        {
            this.name = name;
            members = new List<string>();
        }
        public Group(string name, List<string> members)
        {
            this.name = name;
            this.members = members;
        }
        public Group(List<string> members)
        {
            this.members = members;
            name = "";
            foreach (string i in members)
            {
                name += i;
                name += '_';
            }
            name.Remove(name.Length - 1);
        }
        public override string ToString()
        {
            string str = "  ";
            str += name;
            foreach (string i in members)
            {
                str += "\n    " + i;
            }
            return str;
        }
    }
}
