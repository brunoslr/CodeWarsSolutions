/* URL: http://stackoverflow.com/questions/428617/what-are-closures-in-net?noredirect=1&lq=1 by Jon Skeet
In essence, a closure is a block of code which can be executed at a later time, but which maintains the environment in which it was first created - i.e. it can still use the local variables etc of the method which created it, even after that method has finished executing.

The general feature of closures is implemented in C# by anonymous methods and lambda expressions.

Here's an example using an anonymous method:
 */
using System;

namespace CodeWarsSolutions
{
    class ClosureSample
    {
        static void Main()
        {
            Action action = CreateAction();
            action();
            action();
        }

        static Action CreateAction()
        {
            int counter = 0;
            return delegate
            {
                // Yes, it could be done in one statement; 
                // but it is clearer like this.
                counter++;
                Console.WriteLine("counter={0}", counter);
            };
        }
    }
}
