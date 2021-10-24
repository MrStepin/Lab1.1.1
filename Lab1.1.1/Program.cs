using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            ImmutableType NewImmutableType = new ImmutableType();
            ImmutableType test = null;
            NewImmutableType.GetNewObject = test;
            ImmutableType OneMoreType = NewImmutableType.GetNewObject;
            OneMoreType.Message();
        }
    }
}
