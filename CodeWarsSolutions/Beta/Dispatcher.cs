﻿/* // AC - 22m
//There is a problem with the program below, after some time from its init. The system suddenly crashes

//   A customer complained that the memory usage of the following component constantly increases although
//   the number of workers and tasks remains constant.

//   Fix the problems.

using System;
using System.Collections.Generic;

public class Worker : IDisposable
{
    private List<string> tasks = new List<string>();

    public int Id { get; private set; }

    public IEnumerable<string> Tasks { get { return this.tasks; } }

    public Worker(int id)
    {
        this.Id = id;
    }

    public void PerformTask(string task)
    {
        if (this.tasks == null)
            throw new ObjectDisposedException(this.GetType().Name);

        this.tasks.Add(task);
    }

    public void Dispose()
    {
        this.tasks = null;
    }
}

public class Dispatcher
{
    private readonly Dictionary<int, Worker> workers = new Dictionary<int, Worker>();

    public IEnumerable<Worker> Workers { get { return this.workers.Values; } }

    public Worker AcquireWorker(int id)
    {
        Worker w = null;
        if (!this.workers.TryGetValue(id, out w))
        {
            w = new Worker(id);
            this.workers.Add(id, w);
        }

        return w;
    }

    public void ReleaseWorker(int id)
    {
        Worker w = null;
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

    public class Worker : IDisposable
    {
        private List<string> tasks = new List<string>();

        public int Id { get; private set; }

        public IEnumerable<string> Tasks { get { return this.tasks; } }

        public Worker(int id)
        {
            this.Id = id;
        }

        public void PerformTask(string task)
        {
            if (this.tasks == null)
                throw new ObjectDisposedException(this.GetType().Name);

            this.tasks.Add(task);
        }

        public void Dispose()
        {
            this.tasks = null;
        }
    }

    public class Dispatcher
    {
        private readonly Dictionary<int, Worker> workers = new Dictionary<int, Worker>();

        public IEnumerable<Worker> Workers { get { return this.workers.Values; } }

        public Worker AcquireWorker(int id)
        {
            Worker w = null;
            if (!this.workers.TryGetValue(id, out w))
            {
                w = new Worker(id);
                this.workers.Add(id, w);
            }

            return w;
        }

        public void ReleaseWorker(int id)
        {
            Worker w = null;
            if (!this.workers.TryGetValue(id, out w))
                throw new ArgumentException();
            if (!this.workers.Remove(id))
                Console.WriteLine($"Id nao removido - {id}");
            w.Dispose();
        }

        public static void DispatcherMain(string[] args)
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
}


/*
// Removing IDisposable as we have no unmanaged resources
using System;
using System.Collections.Generic;

namespace CodeWarsSolutions.Beta
{
    public class Worker 
    {
        bool disposed = false;

        private List<string> tasks = new List<string>();

        public int Id { get; private set; }

        public IEnumerable<string> Tasks { get { return this.tasks; } }

        public Worker(int id)
        {
            this.Id = id;
        }

        public void PerformTask(string task)
        {
            if (this.tasks == null)
                throw new ObjectDisposedException(this.GetType().Name);

            this.tasks.Add(task);
        }

    }

    public class Dispatcher
    {
        private readonly Dictionary<int, Worker> workers = new Dictionary<int, Worker>();

        public IEnumerable<Worker> Workers { get { return this.workers.Values; } }

        public Worker AcquireWorker(int id)
        {
            Worker w = null;
            if (!this.workers.TryGetValue(id, out w))
            {
                w = new Worker(id);
                this.workers.Add(id, w);
            }

            return w;
        }

        public void ReleaseWorker(int id)
        {
            Worker w = null;
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
