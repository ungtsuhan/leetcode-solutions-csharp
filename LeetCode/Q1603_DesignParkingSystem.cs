namespace LeetCode;

public class ParkingSystem
{
    // Time Complexity: O(1)
    // Space Complexity: O(1)

    private readonly int[] space;
    public ParkingSystem(int big, int medium, int small)
    {
        space = new int[] { big, medium, small };
    }

    public bool AddCar(int carType)
    {
        if (space[carType - 1] == 0)
            return false;

        space[carType - 1]--;
        return true;
    }
}
