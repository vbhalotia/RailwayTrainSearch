namespace RailwaySearchservice
{
    public class TrainService : ITrainService
    {
        public IEnumerable<Train> SearchTrains(string origin, string destination)
        {
            // Implement search logic here
            // For now, return a static list for demonstration purposes
            return new List<Train>
        {
            new Train { TrainId = 1, Origin = "CityA", Destination = "CityB", DepartureTime = DateTime.Now },
            // Add more sample data
        }.Where(t => t.Origin == origin && t.Destination == destination);
        }
    }
}
