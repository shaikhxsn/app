using Xunit;

public class MathUtilsTests
{
    [Fact]
    public void Add_TwoNumbers_ReturnsCorrectSum()
    {
        // Arrange
        var mathUtils = new MathUtils();

        // Act
        int result = mathUtils.Add(2, 3);

        // Assert
        Assert.Equal(5, result);
    }
}
