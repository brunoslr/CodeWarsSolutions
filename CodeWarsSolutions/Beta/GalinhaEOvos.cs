using System;

namespace CodeWarsSolutions.Beta
{
   

    public interface IPassaro
    {
        Ovo Botar();
    }

    // Deve implementar IPassaro
    public class Galinha : IPassaro
    {
        public Ovo Botar()
        {
            var ovo = new Ovo(() => new Galinha());
            return ovo;
        }
    }

    public class Ovo
    {
        private readonly Func<IPassaro> criarPassaroDelegate;
        private bool jaChocou;

        public Ovo(Func<IPassaro> criarPassaro)
        {
            criarPassaroDelegate = criarPassaro;
        }

        public IPassaro Chocar()
        {
            if (jaChocou) throw new InvalidOperationException("Ovo so pode ser chocado uma vez.");

            jaChocou = true;
            return criarPassaroDelegate();
        }
    }

}
