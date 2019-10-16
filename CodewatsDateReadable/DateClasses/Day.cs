using CodeWarsDateReadable.Interfaces;

namespace CodeWarsDateReadable.DateClasses
{
    public class Day : IDateComponent
    {
        private const int SecondsInDay = 24 * 60 * 60;

        private readonly int _days;

        public Day(ref int seconds)
        {
            _days = seconds / SecondsInDay;

            seconds -= _days * SecondsInDay;
        }

        /// <exception cref="T:System.OverflowException"><paramref name="value" /> equals <see cref="F:System.Int32.MinValue" />.</exception>
        public string GetDateString()
        {
            return _days == 0 ? null : _days.GetDateString("day");
        }
    }
}
