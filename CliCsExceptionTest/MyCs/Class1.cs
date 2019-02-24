using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCs
{
    public class Class1
    {
        public int Add(int a, int b)
        {
            throw new MyException("ダメですぞ！", 10);
            return a + b;
        }
    }
}
