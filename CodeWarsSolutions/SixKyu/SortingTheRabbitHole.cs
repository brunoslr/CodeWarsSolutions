using System.Linq;

namespace CodeWarsSolutions.SixKyu
{
    class SortingTheRabbitHole

    {
        public static object[] DeepSort(object[] arr, bool asc = false)
        {
            var a = arr.Select(p => p is int ? p : DeepSort((object[])p, asc)).ToArray();
            return asc ? a.OrderBy(p => SumSort(p)).ToArray() : a.OrderByDescending(p => SumSort(p)).ToArray();
        }

        public static int SumSort(object myObject, bool asc = false)
        {
            if (myObject is int)
            {
                return (int)myObject;
            }
            return ((object[])myObject).Select(p => SumSort(p)).Sum();
        }
    }
}
