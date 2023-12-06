using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rezka_loader_v2
{
    internal class Translator
    {
        private string name;
        private int id;

        public Translator(string name, int id)
        {
            this.name = name;
            this.id = id;
        }

        public string getName()
        {
            return name;
        }

        public int getId()
        {
            return id;
        }
    }
}
