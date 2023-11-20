namespace LeetCode;

public class UndergroundSystem
{
    private readonly Dictionary<int, (string stationName, int time)> checkIns = [];
    private readonly Dictionary<(string startStation, string endStation), (int totalTime, int count)> routes = [];

    public UndergroundSystem()
    {

    }

    public void CheckIn(int id, string stationName, int t)
    {
        checkIns[id] = (stationName, t);
    }

    public void CheckOut(int id, string stationName, int t)
    {
        if (checkIns.TryGetValue(id, out var checkIn))
        {
            var route = (checkIn.stationName, stationName);
            if (!routes.TryGetValue(route, out var routeInfo))
            {
                routes.Add(route, (t - checkIn.time, 1));
            }
            else
            {
                routes[route] = (routeInfo.totalTime + t - checkIn.time, routeInfo.count + 1);
            }
        }
    }

    public double GetAverageTime(string startStation, string endStation)
    {
        if (routes.TryGetValue((startStation, endStation), out var routeInfo))
        {
            return (double)routeInfo.totalTime / routeInfo.count;
        }
        throw new Exception("Route not found.");
    }
}
