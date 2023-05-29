namespace LeetCode.Tests
{
    public class ParkingSystemTests
    {
        [Theory]
        [InlineData(1, 1, 0, new[] { 1, 2, 3, 1 }, new[] { true, true, false, false })]
        public void AddCar_ValidInput_ReturnsCorrectParkingLotAvailability(int big, int medium, int small, int[] carsToBeAdded, bool[] expectedResult)
        {
            // Arrange
             var parkingSystem = new ParkingSystem(big, medium, small);

            // Act
            var actualResult = new List<bool>();
            foreach (var car in carsToBeAdded)
                actualResult.Add(parkingSystem.AddCar(car));

            // Assert
            Assert.Equal(expectedResult, actualResult.ToArray());
        }
    }
}
