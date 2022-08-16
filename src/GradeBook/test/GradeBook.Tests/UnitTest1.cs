using Xunit;
namespace GradeBook.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // arrange
        int x = 5;
        int y = 2;
        int expected = 7;

        // act
        int actual = x * y;

        // assert
        Assert.Equal(expected, actual);
    }
}