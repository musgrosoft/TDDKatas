using Xunit;
using FluentAssertions;

namespace FizzBuzz.Tests;

public class FooTests
{
    [Fact]
    public void ShouldBar()
    {
        //Given 
        var input = 123;
        var foo = new Foo.Foo();

        //When
        var result = foo.Bar(input);

        //Then
        Assert.Equal("bar", result);

        //Given
        //When
        //Then

        //Arrange
        //Act
        //Assert
    }


    [Theory]
    [InlineData(123, "bar")]
    [InlineData(456, "bar")]
    [InlineData(789, "bar")]
    public void ShouldBar2(int input, string expected)
    {
        //Given 
        var foo = new Foo.Foo();

        //When
        var result = foo.Bar(input);

        //Then
        //Assert.Equal(expected, result);
        result.Should().Be(expected, "because all inputs result in 'bar'");
    }

}