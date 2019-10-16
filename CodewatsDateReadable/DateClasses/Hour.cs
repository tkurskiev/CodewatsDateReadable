using CodeWarsDateReadable.Interfaces;

namespace CodeWarsDateReadable.DateClasses
{
    public class Hour : IDateComponent
    {
        private const int SecondsInHour = 60 * 60;

        private readonly int _hours;

        public Hour(ref int seconds)
        {
            _hours = seconds / SecondsInHour;

            seconds -= _hours * SecondsInHour;
        }

        /// <exception cref="T:System.OverflowException"><paramref name="value" /> equals <see cref="F:System.Int32.MinValue" />.</exception>
        public string GetDateString()
        {
            return _hours == 0 ? null : _hours.GetDateString("hour");
        }
    }
}
