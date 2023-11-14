namespace RailwaySearchservice
{
    public interface ITrainService
    {
        IEnumerable<Train> SearchTrains(string origin, string destination);
    }
}
