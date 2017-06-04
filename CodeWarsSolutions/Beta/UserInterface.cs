using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    public class TextInput
    {

        protected List<char> charList;


        public TextInput()
        {
            charList = new List<char>();
        }

        public virtual void Add(char c)
        {
            charList.Add(c);
        }

        public string GetValue()
        {
            return string.Concat(charList);
        }

    }

    public class NumericInput : TextInput
    {

        public NumericInput() : base() { }

        public override void Add(char c)
        {
            if (char.IsDigit(c))
                charList.Add(c);
        }

    }

   /* public class UserInput
    {
        public static void Main(string[] args)
        {
            TextInput input = new NumericInput();
            input.Add('1');
            input.Add('a');
            input.Add('0');
            Console.WriteLine(input.GetValue());
        }
    }*/
}
