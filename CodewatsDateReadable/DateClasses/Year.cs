using CodeWarsDateReadable.Interfaces;

namespace CodeWarsDateReadable.DateClasses
{
    public class Year : IDateComponent
    {
        private const int SecondsInYear = 365 * 24 * 60 * 60;

        private readonly int _years;

        public Year(ref int seconds)
        {
            _years = seconds / SecondsInYear;

            seconds -= _years * SecondsInYear;
        }

        /// <exception cref="T:System.OverflowException"><paramref name="value" /> equals <see cref="F:System.Int32.MinValue" />.</exception>
        public string GetDateString()
        {
            return _years == 0 ? null : _years.GetDateString("year");
        }
    }
}
