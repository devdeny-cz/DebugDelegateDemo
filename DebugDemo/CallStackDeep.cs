using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugExample
{
    internal class CallStackDeep
    {
        public void Deep1()
        {
            Deep2();
        }

        private void Deep2()
        {
            Deep3();
        }
        private void Deep3()
        {
            Deep4();
        }
        private void Deep4()
        {
            Deep5();
        }
        private void Deep5()
        {
            Deep6();
        }
        private void Deep6()
        {
            Throw();
        }


        private void Throw()
        {
            try
            {
                //int a = 1;
                //int b = 0;
                //var zeroException = a / b;
                throw new DarthVaderException("Dark side won!");
            }
            catch (Exception)
            {
            }
        }
    }
    public class DarthVaderException : Exception
    {
        public DarthVaderException(string message) : base(message) { }
        public DarthVaderException(string message, Exception inner) : base(message, inner) { }
    }
}
