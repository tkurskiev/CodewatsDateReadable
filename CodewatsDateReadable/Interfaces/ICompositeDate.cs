namespace CodeWarsDateReadable.Interfaces
{
    public interface ICompositeDate : IDateComponent
    {
        void AddDateComponent(IDateComponent dateComponent);
    }
}
