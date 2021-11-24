using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    class Model
    {
        private int s;

        public string Tick()
        {
            s++;
            return s >= 60 ? (s / 60) + " мин " + s % 60 + " сек" : s.ToString();
        }
        public void Reset()
        {
            s = 0;
        }
    }
}
