/* URL: https://www.codewars.com/kata/refactor-out-a-switch-statement-to-a-dictionary/train/csharp
 
Mission

The aim of this kata is to refactor out the switch statement and replace it with a dictionary "Jump Table"

Problem

Although switch statements can execute quickly and are a simple construct to grasp they can become unwieldly and a maintenance nightmare as they grow. Also they do not readily encourage the "Open Closed" principle. With this in mind we will remove the switch statment from the code and replace it with a Dictionay which can be used like a "Jump Table".

Solution

Your solution will replace the switch case statment in the GetStatusDescription() method with a call to the dictionary. The dictionary will be declared as beloww:

private readonly Dictionary<Status, string> _statusDescriptions;
Where Status is the following enumeration:

public enum Status
{
    Default = 0,
    New = 1,
    Active = 2,
    Deactivated = 3
}
NOTE: Yes the tests will pass by doing nothing and leaving the switch...case construct present, but the idea of this kata is to give you an insight into removing switch statements from your code and looking for alternative constructs, in this case, a dictionary.

Enjoy.

P.S. If you like this kata then "Refactor out a switch-statement using polymorphism" is of a similar vein.

 */

using System;
using System.Collections.Generic;
namespace CodeWarsSolutions.Beta
{
    public enum Status
    {
        Default = 0,
        New = 1,
        Active = 2,
        Deactivated = 3,
        Undefined = 4
    }
    public class SwitchToDictionary
    {
       
        private readonly Status _status;

        private readonly Dictionary<Status, string> _statusDescriptions =
          new Dictionary<Status, string>(){
          {Status.Default, "I have never been set"},
          {Status.New, "I am new!"},
          {Status.Active, "I am active"},
          {Status.Deactivated, "I have been deactivated"}
          };

        public SwitchToDictionary()
        {
        }

        public SwitchToDictionary(Status status)
        {
            _status = status;
        }

        public string GetStatusDescription()
        {
            string statusDescription;
            if (_statusDescriptions.TryGetValue(_status, out statusDescription))
                return statusDescription;
            else
                throw new InvalidOperationException("Invalid status encountered");
        }
    }
}
