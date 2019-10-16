namespace CodeWarsDateReadable.Interfaces
{
    public interface IDateComponent
    {
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than 0.-or-<paramref name="index" /> is equal to or greater than <see cref="P:System.Collections.Generic.List`1.Count" />.</exception>
        /// <exception cref="T:System.OverflowException"><paramref name="value" /> equals <see cref="F:System.Int32.MinValue" />.</exception>
        string GetDateString();
    }
}
