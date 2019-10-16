using System.Collections.Generic;
using CodeWarsDateReadable.Interfaces;

namespace CodeWarsDateReadable.DateClasses
{
    public class CompositeDate : ICompositeDate
    {
        private const string Separator = ", ";
        private const string LastSeparator = " and ";

        private readonly List<IDateComponent> _dateComponents;

        public CompositeDate()
        {
            _dateComponents = new List<IDateComponent>();
        }

        /// <exception cref="T:System.OverflowException"><paramref name="value" /> equals <see cref="F:System.Int32.MinValue" />.</exception>
        public void AddDateComponent(IDateComponent dateComponent)
        {
            if(dateComponent != null && !string.IsNullOrWhiteSpace(dateComponent.GetDateString()))
                _dateComponents.Add(dateComponent);
        }

        /// <exception cref="T:System.OverflowException"><paramref name="value" /> equals <see cref="F:System.Int32.MinValue" />.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than 0.-or-<paramref name="index" /> is equal to or greater than <see cref="P:System.Collections.Generic.List`1.Count" />.</exception>
        public string GetDateString()
        {
            var resultString = string.Empty;

            var componentsCount = _dateComponents.Count;

            for (var i = 0; i < componentsCount; i++)
            {
                var dateComponentString = _dateComponents[i].GetDateString();

                resultString += dateComponentString;

                if (componentsCount > i + 2)
                    resultString += Separator;

                else if (componentsCount == i + 2)
                    resultString += LastSeparator;
            }

            return resultString;
        }
    }
}
