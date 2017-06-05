using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions.Beta
{
    using System;

    public interface IBird
    {
        Egg Lay();
    }

    // Should implement IBird
    public class Chicken : IBird
    {
        public Egg Lay()
        {
            var egg = new Egg(() => new Chicken());
            return egg;
        }
    }

    public class Egg
    {
        private readonly Func<IBird> createBirdDelegate;
        private bool hasHatched;

        public Egg(Func<IBird> createBird)
        {
            createBirdDelegate = createBird;
        }

        public IBird Hatch()
        {
            if (hasHatched) throw new InvalidOperationException("Egg can only be hatched once.");

            hasHatched = true;
            return createBirdDelegate();
        }
    }

}
