namespace LeetCode.Tests;

public class Q0705Tests
{
    [Fact]
    public void TestHashSetOperations()
    {
        // Arrange
        var myHashSet = new MyHashSet();

        // Act
        myHashSet.Add(1);
        myHashSet.Add(2);
        bool contains1 = myHashSet.Contains(1);
        bool contains3 = myHashSet.Contains(3);
        myHashSet.Add(2);
        bool contains2 = myHashSet.Contains(2);
        myHashSet.Remove(2);
        bool contains2AfterRemove = myHashSet.Contains(2);

        // Assert
        Assert.True(contains1);
        Assert.False(contains3);
        Assert.True(contains2);
        Assert.False(contains2AfterRemove);
    }
}
