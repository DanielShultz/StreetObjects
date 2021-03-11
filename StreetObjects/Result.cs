using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreetObjects
{
    public class Result
    {
        public int mistakes = 0;
        public int correct = 0;
        int percent = 0;
        int trys = 0;
        public string log;
        public Result()
        {
            this.log = "Попыток: " + trys.ToString() + " | Верно: " + percent.ToString() + "%";
        }
        public void Modify(int mistakes, int correct)
        {
            this.mistakes += mistakes;
            this.correct += correct;
            this.trys++;
            if (mistakes != 0 && correct != 0)
            {
                this.percent = correct * 100 / (correct + mistakes);
            }
            this.log = "Попыток: " + trys.ToString() + " | Верно: " + percent.ToString() + "%";
        }
    }
}
