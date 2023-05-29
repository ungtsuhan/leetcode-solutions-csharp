namespace LeetCode
{
    public class ParkingSystem
    {
        // Time Complexity: O(1)
        // Space Complexity: O(1)

        private readonly Dictionary<int, int> availableSpace;
        public ParkingSystem(int big, int medium, int small)
        {
            availableSpace = new Dictionary<int, int>
            {
                { 1, big },
                { 2, medium },
                { 3, small }
            };
        }
    
        public bool AddCar(int carType)
        {
            if (!availableSpace.ContainsKey(carType) || availableSpace[carType] == 0)
                return false;

            availableSpace[carType]--;
            return true;
        }
    }
}
