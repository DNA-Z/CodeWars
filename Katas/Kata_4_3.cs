
using System.Text;

namespace Katas
{
    internal class Kata_4_3
    {
        // "123456789".equals(new BefungeInterpreter().interpret(">987v>.v\nv456<  :\n>321 ^ _@"
        public string Interpret(string code)
        {
            Stack<string> stack = new Stack<string>();
            StringBuilder s = new StringBuilder();

            for (int i = 0; i < code.Length; i++)
            {
                if (int.TryParse(code[i].ToString(), out int num))
                {
                    stack.Push(code[i].ToString());
                    s.Insert(0, code[i].ToString());
                }
            }

            return s.ToString();
        }
    }
}
