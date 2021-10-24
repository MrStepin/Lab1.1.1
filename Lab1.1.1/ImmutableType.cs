using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._1._1
{
    public class ImmutableType
    {
        private ImmutableType newType;

        public void Message()
        {
            Console.WriteLine("Type is created.");
            Console.ReadLine();
        }

        public ImmutableType GetNewObject
        {
            get
            {
                return newType;
            }
            set
            {
                newType = new ImmutableType();
            }
        }

    }
}
