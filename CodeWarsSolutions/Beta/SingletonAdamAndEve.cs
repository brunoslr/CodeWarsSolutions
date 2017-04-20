/* URL: https://www.codewars.com/kata/singleton-adam-and-eve/train/csharp
 What better way to explain the Singleton pattern than to use the metaphore of the origin of mankind. 
 */
using System;

namespace CodeWarsSolutions.Beta
{
    public sealed class Adam : Male
    {
        private static Adam instance;

        private Adam() : base("Adam") { }

        public static Adam GetInstance()
        {
            if (instance == null)
            {
                instance = new Adam();
            }
            return instance;
        }
    }

    public sealed class Eve : Female
    {
        private static Eve instance;
        private Eve():base("Eve") { }
        public static Eve GetInstance(Male adam)
        {
            if (instance == null)
            {
                instance = new Eve();
                instance.Father = adam;
            }
            return instance;
        }
    }

    public class Male : Human
    {
        protected Male(string name) : base(name) { }
        public Male(string name, Female mother, Male father) : base(name, mother, father) { }
    }

    public class Female : Human
    {
        protected Female(string name) : base(name) { }
        public Female(string name, Female mother, Male father) : base(name, mother, father) {}
    }

    public abstract class Human
    {
        public string Name { get; set; }
        public Male Father { get; set; }
        public Female Mother { get; set; }

        protected Human(string name)
        {
            this.Name = name;
        }

        public Human(string name, Female mother, Male father):this(name)
        {
            if (mother == null || father == null)
                throw new ArgumentNullException();
     
            this.Mother = mother;
            this.Father = father;
        }
    }
}
