﻿/*
 The Command Design Pattern can be used, for example, in the StarCraft game to queue actions.

The pattern consists in isolating a command logic in a class, so it can be:

queued: you can queue actions to move a probe to different locations
undone: you can tell a probe to build something and then undo the action stopping it.
validated: you can check if the action can be executed or not, you cannot move to a location if now there is a building over it
Your Task

Complete the code so that a Probe can move and gather with a queue of commands.

In this kata there are no limitations for the move command
The probe is only allowed to gather if the current amount of minerals is 0
Probe should only queue commands without running them
Move will set the probe's position to x,y
Gather will increment the probe's minerals by 5
public class Probe : IUnit
{
    public Queue<ICommand> Commands { get; set; }
    public int Minerals { get; set; }
    public Point Position { get; set; }

    public void Move(int x, int y) { Commands.Enqueue(...) }
    public void Gather() { Commands.Enqueue(...) }
}

public class MoveCommand : ICommand
{
    private IUnit unit;
    private int x;
    private int y;

    public MoveCommand(IUnit unit, int x, int y) { }
    public bool CanExecute() { }
    public void Execute() { }
}

public class GatherCommand : ICommand
{
    private IUnit unit;

    public GatherCommand(IUnit unit) { }
    public bool CanExecute() { }
    public void Execute() { }
}
*/

using System.Collections.Generic;

namespace CodeWarsSolutions.SixKyu
{

    public interface ICommand
    {
        void Execute();
        bool CanExecute();
    }

    public interface IUnitC
    {
        int Minerals { get; set; }
        Point Position { get; set; }

        void Move(int x, int y);
        void Gather();
    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Probe : IUnitC
    {
        public Queue<ICommand> Commands { get; set; }

        public int Minerals { get; set; }

        public Point Position { get; set; }

        public Probe()
        {
            Commands = new Queue<ICommand>();
            Position = new Point();
        }

        public void Move(int x, int y)
        {
            Commands.Enqueue(new MoveCommand(this, x, y));
        }

        public void Gather()
        {
            Commands.Enqueue(new GatherCommand(this));
        }

    }

    public class MoveCommand : ICommand
    {
        private IUnitC unit;
        private int x;
        private int y;

        public MoveCommand(IUnitC unit, int x, int y)
        {
            this.x = x;
            this.y = y;
            this.unit = unit;
        }

        public bool CanExecute() { return true; }

        public void Execute()
        {
            if (CanExecute())
            {
                unit.Position.X = x;
                unit.Position.Y = y;
            }
        }
    }

    public class GatherCommand : ICommand
    {
        private IUnitC unit;

        public GatherCommand(IUnitC unit)
        {
            this.unit = unit;
        }

        public bool CanExecute()
        {
            return unit.Minerals == 0;
        }

        public void Execute()
        {
            if (CanExecute())
                unit.Minerals += 5;
        }
    }
}
