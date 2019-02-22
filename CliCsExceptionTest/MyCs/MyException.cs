using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCs
{
    public class MyException : Exception
    {
        public string Mes { get; private set; }
        public int Id { get; private set; }
        public MyException(string mes, int id)
        {
            Mes = mes;
            Id = id;
        }
    }
}
