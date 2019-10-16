using System;
using CodeWarsDateReadable.Interfaces;

namespace CodeWarsDateReadable.DateClasses
{
    public class Second : IDateComponent
    {
        private readonly int _seconds;

        /// <exception cref="T:System.ArgumentException"></exception>
        public Second(ref int seconds)
        {
            if(seconds >= 60)
                throw new ArgumentException($"Duration, longer than a minute came in: {seconds} seconds");

            _seconds = seconds;
        }

        /// <exception cref="T:System.OverflowException"><paramref name="value" /> equals <see cref="F:System.Int32.MinValue" />.</exception>
        public string GetDateString()
        {
            return _seconds == 0 ? null : _seconds.GetDateString("second");
        }
    }
}
