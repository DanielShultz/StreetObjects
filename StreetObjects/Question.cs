using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreetObjects
{
    public class Question
    {
        public string question { get; set; }
        public ICollection<string> variants { get; set; }
        public ICollection<string> rightAnswer { get; set; }
        public Question()
        {
            variants = new List<string>();
            rightAnswer = new List<string>();
        }
    }
}
