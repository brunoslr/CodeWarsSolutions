/* URL: https://www.codewars.com/kata/refactor-out-a-switch-statement-to-a-visitor-pattern/csharp

Mission

The aim of this kata is to refactor out the switch statement and replace it with a the visitor pattern.

Problem

Although switch statements can execute quickly and are a simple construct to grasp they can become unwieldly and a maintenance nightmare as they grow. Also they do not readily encourage the "Open Closed" principle. With this in mind we will remove the switch statment from the code and replace it with the visitor pattern.

Solution

Your solution will replace the switch case statment in the GetStatusDescription() method with a visitor pattern approach.

We will base our status on the following base class, which will accept an interface called IVisitor.

public abstract class Status
{
    public abstract string Accept(IVisitor visitor);
}
You will need to create this interface and also your own concrete implementation of the IVisitor. In a real-world scenario the Visitor would likely be injected into the Kata class, but for this kata, just create your concrete instance when you construct the Kata class.

public class Kata
{
    private readonly IVisitor _visitor = new MyVisitor();
NOTE: Yes the tests will pass by doing nothing and leaving the switch...case construct present, but the idea of this kata is to give you an insight into removing switch statements from your code and looking for alternative constructs, in this case, the visitor pattern.

Enjoy.
 */

namespace CodeWarsSolutions.SixKyu
{
    public class Kata
    {
        private readonly IVisitor _visitor;
        private readonly Status _status;

        public Kata()
        {
            _visitor = new StatusDescriptionVisitor();
            _status = new DefaultStatus();
        }

        public Kata(Status status) : this()
        {
            _status = status;
        }

        public string GetStatusDescription()
        {
            return _status.Accept(_visitor);
        }
    }

    public abstract class Status
    {
        public abstract string Accept(IVisitor visitor);
    }

    public interface IVisitor
    {
        string GetDefaultStatusDescription(DefaultStatus status);
        string GetNewStatusDescription(NewStatus status);
        string GetActiveStatusDescription(ActiveStatus status);
        string GetDeactivatedStatusDescription(DeactivatedStatus status);
    }

    public class DefaultStatus : Status
    {
        public override string Accept(IVisitor visitor)
        {
            return visitor.GetDefaultStatusDescription(this);
        }
    }

    public class ActiveStatus : Status
    {
        public override string Accept(IVisitor visitor)
        {
            return visitor.GetActiveStatusDescription(this);
        }
    }

    public class NewStatus : Status
    {
        public override string Accept(IVisitor visitor)
        {
            return visitor.GetNewStatusDescription(this);
        }
    }

    public class DeactivatedStatus : Status
    {
        public override string Accept(IVisitor visitor)
        {
            return visitor.GetDeactivatedStatusDescription(this);
        }
    }

    public class StatusDescriptionVisitor : IVisitor
    {
        public string GetDefaultStatusDescription(DefaultStatus status)
        {
            return "I have never been set";
        }

        public string GetNewStatusDescription(NewStatus status)
        {
            return "I am new!";
        }

        public string GetActiveStatusDescription(ActiveStatus status)
        {
            return "I am active";
        }

        public string GetDeactivatedStatusDescription(DeactivatedStatus status)
        {
            return "I have been deactivated";
        }
    }
}
