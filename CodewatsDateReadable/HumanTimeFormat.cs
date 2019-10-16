using CodeWarsDateReadable.DateClasses;
using CodeWarsDateReadable.Interfaces;

namespace CodeWarsDateReadable
{
    public class HumanTimeFormat
    {
        /// <exception cref="T:System.OverflowException"><paramref name="value" /> equals <see cref="F:System.Int32.MinValue" />.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than 0.-or-<paramref name="index" /> is equal to or greater than <see cref="P:System.Collections.Generic.List`1.Count" />.</exception>
        /// <exception cref="T:System.ArgumentException"></exception>
        public static string FormatDuration(int seconds)
        {
            //Enter Code here
            if (seconds == 0)
                return "now";

            ICompositeDate compositeDate = new CompositeDate();

            compositeDate.AddDateComponent(new Year(ref seconds));
            compositeDate.AddDateComponent(new Day(ref seconds));
            compositeDate.AddDateComponent(new Hour(ref seconds));
            compositeDate.AddDateComponent(new Minute(ref seconds));
            compositeDate.AddDateComponent(new Second(ref seconds));

            return compositeDate.GetDateString();
        }
    }
}
