/* 
//There is a problem with the program below, after some time from its init. The system suddenly crashes

//   A customer complained that the memory usage of the following component constantly increases although
//   the number of workers and tarefas remains constant.

//   Fix the problems.

using System;
using System.Collections.Generic;

public class Trabalhador : IDisposable
{
    private List<string> tarefas = new List<string>();

    public int Id { get; private set; }

    public IEnumerable<string> Tasks { get { return this.tarefas; } }

    public Trabalhador(int id)
    {
        this.Id = id;
    }

    public void PerformTask(string task)
    {
        if (this.tarefas == null)
            throw new ObjectDisposedException(this.GetType().Name);

        this.tarefas.Add(task);
    }

    public void Dispose()
    {
        this.tarefas = null;
    }
}

public class Dispatcher
{
    private readonly Dictionary<int, Trabalhador> workers = new Dictionary<int, Trabalhador>();

    public IEnumerable<Trabalhador> Workers { get { return this.workers.Values; } }

    public Trabalhador AcquireWorker(int id)
    {
        Trabalhador w = null;
        if (!this.workers.TryGetValue(id, out w))
        {
            w = new Trabalhador(id);
            this.workers.Add(id, w);
        }

        return w;
    }

    public void ReleaseWorker(int id)
    {
        Trabalhador w = null;
        if (!this.workers.TryGetValue(id, out w))
            throw new ArgumentException();
        w.Dispose();
    }

    public static void Main(string[] args)
    {
        var d = new Dispatcher();

        d.AcquireWorker(1).PerformTask("Task11");
        d.AcquireWorker(2).PerformTask("Task21");
        Console.WriteLine(string.Join(", ", d.AcquireWorker(2).Tasks));
        d.ReleaseWorker(2);
        d.AcquireWorker(1).PerformTask("Task12");
        Console.WriteLine(string.Join(", ", d.AcquireWorker(1).Tasks));
        d.ReleaseWorker(1);
    }
}
*/

using System;
using System.Collections.Generic;

namespace CodeWarsSolutions.Beta
{

    using System;
    using System.Collections.Generic;

    public class Trabalhador : IDisposable
    {
        private List<string> tarefas = new List<string>();

        public int Id { get; private set; }

        public IEnumerable<string> Tarefas { get { return this.tarefas; } }

        public Trabalhador(int id)
        {
            this.Id = id;
        }

        public void EfetuarTarefa(string task)
        {
            if (this.tarefas == null)
                throw new ObjectDisposedException(this.GetType().Name);

            this.tarefas.Add(task);
        }

        public void Dispose()
        {
            this.tarefas = null;
        }
    }

    public class Despachante
    {
        private readonly Dictionary<int, Trabalhador> trabalhadores = new Dictionary<int, Trabalhador>();

        public IEnumerable<Trabalhador> Trabalhadores { get { return this.trabalhadores.Values; } }

        public Trabalhador AlocarTrabalhador(int id)
        {
            Trabalhador w = null;
            if (!this.trabalhadores.TryGetValue(id, out w))
            {
                w = new Trabalhador(id);
                this.trabalhadores.Add(id, w);
            }

            return w;
        }

        public void LiberarTrabalhador(int id)
        {
            Trabalhador w = null;
            if (!this.trabalhadores.TryGetValue(id, out w))
                throw new ArgumentException();
            if (!this.trabalhadores.Remove(id))
                Console.WriteLine($"Id nao removido - {id}");
            w.Dispose();
        }

        public static void DispatcherMain(string[] args)
        {
            var d = new Despachante();

            d.AlocarTrabalhador(1).EfetuarTarefa("Task11");
            d.AlocarTrabalhador(2).EfetuarTarefa("Task21");
            Console.WriteLine(string.Join(", ", d.AlocarTrabalhador(2).Tarefas));
            d.LiberarTrabalhador(2);
            d.AlocarTrabalhador(1).EfetuarTarefa("Task12");
            Console.WriteLine(string.Join(", ", d.AlocarTrabalhador(1).Tarefas));
            d.LiberarTrabalhador(1);
        }
    }
}


/*
// Removing IDisposable as we have no unmanaged resources
using System;
using System.Collections.Generic;

namespace CodeWarsSolutions.Beta
{
    public class Trabalhador 
    {
        bool disposed = false;

        private List<string> tarefas = new List<string>();

        public int Id { get; private set; }

        public IEnumerable<string> Tasks { get { return this.tarefas; } }

        public Trabalhador(int id)
        {
            this.Id = id;
        }

        public void PerformTask(string task)
        {
            if (this.tarefas == null)
                throw new ObjectDisposedException(this.GetType().Name);

            this.tarefas.Add(task);
        }

    }

    public class Dispatcher
    {
        private readonly Dictionary<int, Trabalhador> workers = new Dictionary<int, Trabalhador>();

        public IEnumerable<Trabalhador> Workers { get { return this.workers.Values; } }

        public Trabalhador AcquireWorker(int id)
        {
            Trabalhador w = null;
            if (!this.workers.TryGetValue(id, out w))
            {
                w = new Trabalhador(id);
                this.workers.Add(id, w);
            }

            return w;
        }

        public void ReleaseWorker(int id)
        {
            Trabalhador w = null;
            if (!this.workers.TryGetValue(id, out w))
                throw new ArgumentException();
            this.workers.Remove(id);
        }

        public static void Main(string[] args)
        {
            var d = new Dispatcher();
            Random number = new Random();
            d.AcquireWorker(1).PerformTask("Task11");
            d.AcquireWorker(2).PerformTask("Task21");
            Console.WriteLine(string.Join(", ", d.AcquireWorker(2).Tasks));
            d.ReleaseWorker(2);
            d.AcquireWorker(1).PerformTask("Task12");
            Console.WriteLine(string.Join(", ", d.AcquireWorker(1).Tasks));
            d.ReleaseWorker(1);
        }
    }
}
*/
