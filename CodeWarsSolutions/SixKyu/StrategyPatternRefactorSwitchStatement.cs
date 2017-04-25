/* URL: https://www.codewars.com/kata/refactor-out-a-switch-statement-to-a-strategy-pattern/csharp

Mission

The aim of this kata is to refactor out the switch statement and replace it with a the STRATEGY pattern.

Problem

Although switch statements can execute quickly and are a simple construct to grasp they 
can become unwieldly and a maintenance nightmare as they grow. Also they do not readily encourage the "Open Closed" principle. 
With this in mind we will remove the switch statment from the code and replace it with the strategy pattern.

Solution

Your solution will replace the switch case statment in the GetStatusDescription() method with a strategy pattern approach.

*/

namespace CodeWarsSolutions.SixKyu.StrategyPatternRefactor
{
    public class StrategyKata
    {
        private readonly IStatus _status;

        public StrategyKata()
        {
            _status = new DefaultStatus();
        }

        public StrategyKata(IStatus status) : this()
        {
            _status = status;
        }

        public string GetStatusDescription()
        {
            return _status.GetStatus();
        }
    }

    public interface IStatus
    {
        string GetStatus();
    }


    public class DefaultStatus : IStatus
    {
        public string GetStatus()
        {
            return "I have never been set"; 
        }
    }

    public class ActiveStatus : IStatus
    {
        public string GetStatus()
        {
            return "I am new!";
        }
    }

    public class NewStatus : IStatus
    {
        public string GetStatus()
        {
            return "I am active";
        }
    }

    public class DeactivatedStatus : IStatus
    {
        public string GetStatus()
        {
            return "I have been deactivated";
        }
    }
}
