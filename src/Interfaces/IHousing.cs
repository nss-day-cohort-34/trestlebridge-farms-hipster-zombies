namespace Trestlebridge.Interfaces
{
    public interface IHousing
    {
        double FeedPerDay { get; set; }
        void Feed();
    }
}