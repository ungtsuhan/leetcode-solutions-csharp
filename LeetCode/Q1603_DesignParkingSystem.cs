namespace LeetCode
{
    public class ParkingSystem
    {
        // Time Complexity: O(1)
        // Space Complexity: O(1)

        private readonly Dictionary<int, int> availableSlot;
        public ParkingSystem(int big, int medium, int small)
        {
            availableSlot = new Dictionary<int, int>
            {
                { 1, big },
                { 2, medium },
                { 3, small }
            };
        }
    
        public bool AddCar(int carType)
        {
            if (!availableSlot.ContainsKey(carType) || availableSlot[carType] == 0)
                return false;

            availableSlot[carType]--;
            return true;
        }
    }
}
