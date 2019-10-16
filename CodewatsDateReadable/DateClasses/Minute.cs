using CodeWarsDateReadable.Interfaces;

namespace CodeWarsDateReadable.DateClasses
{
    public class Minute : IDateComponent
    {
        private const int SecondsInMinute = 60;

        private readonly int _minutes;

        public Minute(ref int seconds)
        {
            _minutes = seconds / SecondsInMinute;

            seconds -= _minutes * SecondsInMinute;
        }

        /// <exception cref="T:System.OverflowException"><paramref name="value" /> equals <see cref="F:System.Int32.MinValue" />.</exception>
        public string GetDateString()
        {
            return _minutes == 0 ? null : _minutes.GetDateString("minute");
        }
    }
}
