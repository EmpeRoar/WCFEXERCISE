using System;

namespace MathServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class MathService : IMathService
    {
        public int Add(MyNumbers obj)
        {
            return (obj.Number1 + obj.Number2);
        }

        public int Substract(MyNumbers obj)
        {
            return (obj.Number1 - obj.Number2);
        }

        public int Mutiply(MyNumbers obj)
        {
            return (obj.Number1 * obj.Number2);
        }
    }
}
