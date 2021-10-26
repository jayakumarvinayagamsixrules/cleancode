using System;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using Validator;
namespace ValidatorTest
{
    /*
    *   
    * Unit of work : what function you going to test
    * State under test : Which condition we going to test
    * Expected behavior : What to be expect
    */
    public class CalculatorTest
    {
        private readonly ICalculator _citizen;
        public CalculatorTest()
        {
            _citizen = new Calculator();
        }
        [Fact]
        public async Task AdditionAsync_5_and_8_shouldReturn_13()
        {
            // Arrange
            // Act
            decimal actual = await _citizen.AdditionAsync(5,8);
            decimal expected = 13;
            // Assert
            actual.Should().Be(expected);
        }
        [Fact]
        public async Task AdditionAsync_5_and_negative_8_shouldReturn_3()
        {
            // Arrange
            // Act
            decimal actual = await _citizen.AdditionAsync(5,-8);
            decimal expected = -3;
            // Assert
            actual.Should().Be(expected);
        }
        [Fact]
        public async Task AdditionAsync_negative_5_and_8_shouldReturn_3()
        {
            // Arrange
            // Act
            decimal actual = await _citizen.AdditionAsync(-5,8);
            decimal expected = 3;
            // Assert
            actual.Should().Be(expected);
        }
        [Fact]
        public async Task AdditionAsync_negative_5_and_negative_8_shouldReturn_negative_13()
        {
            // Arrange
            // Act
            decimal actual = await _citizen.AdditionAsync(-5,-8);
            decimal expected = -13;
            // Assert
            actual.Should().Be(expected);
        }
        [Fact]
        public async Task AdditionAsync_negative_5_and_8_shouldNotReturn_13()    
        {
            // Arrange
            // Act
            decimal actual = await _citizen.AdditionAsync(-5,8);
            decimal expected = 3;
            // Assert
            actual.Should().Be(expected);
        }
        [Fact]
        public async Task SubtractionAsync_5_and_8_ShouldReturn_negative_3()
        {
            // Arrange
            // Act
            decimal actual = await _citizen.SubtractionAsync(5,8);
            decimal expected = -3;
            // Assert
            actual.Should().Be(expected);
        }
        [Fact]
        public async Task SubtractionAsync_5_and_negative_8_ShouldReturn_negative_13()
        {
            // Arrange
            // Act
            decimal actual = await _citizen.SubtractionAsync(5,-8);
            decimal expected = 13;
            // Assert
            actual.Should().Be(expected);
        }
        [Fact]
        public async Task SubtractionAsync_negative_5_and_8_ShouldReturn_negative_13()
        {
            // Arrange
            // Act
            decimal actual = await _citizen.SubtractionAsync(-5,8);
            decimal expected = -13;
            // Assert
            actual.Should().Be(expected);
        }
        [Fact]
        public async Task SubtractionAsync__negative_5_and_negative_8_ShouldReturn_3()
        {
            // Arrange
            // Act
            decimal actual = await _citizen.SubtractionAsync(-5,-8);
            decimal expected = 3;
            // Assert
            actual.Should().Be(expected);
        }
        [Fact]
        public async Task MultiplicationAsync_5_and_8_shouldreturn_40()
        {
            // Arrange
            // Act
            decimal actual = await _citizen.MultiplicationAsync(5,8);
            decimal expected = 40;
            // Assert
            actual.Should().Be(expected);
        }
        [Fact]
        public async Task MultiplicationAsync_5_and_negative_8_shouldreturn_negative_40()
        {
            // Arrange
            // Act
            decimal actual = await _citizen.MultiplicationAsync(5,-8);
            decimal expected = -40;
            // Assert
            actual.Should().Be(expected);
        }
        [Fact]
        public async Task MultiplicationAsync_negative_5_and_8_shouldreturn_negative_40()
        {
            // Arrange
            // Act
            decimal actual = await _citizen.MultiplicationAsync(-5,8);
            decimal expected = -40;
            // Assert
            actual.Should().Be(expected);
        }
        [Fact]
        public async Task MultiplicationAsync_negative_5_and_negative_8_shouldreturn_40()
        {
            // Arrange
            // Act
            decimal actual = await _citizen.MultiplicationAsync(-5,-8);
            decimal expected = 40;
            // Assert
            actual.Should().Be(expected);
        }
        [Fact]
        public async Task MultiplicationAsync_5_and_0_shouldreturn_0()
        {
            // Arrange
            // Act
            decimal actual = await _citizen.MultiplicationAsync(-5,0);
            decimal expected = 0;
            // Assert
            actual.Should().Be(expected);
        }
        [Fact]
        public async Task DivisionAsync_8_and_2_shouldreturn_4()
        {
            // Arrange
            // Act
            decimal actual = await _citizen.DivisionAsync(8,2);
            decimal expected = 4;
            // Assert
            actual.Should().Be(expected);
        }
        [Fact]
        public async Task DivisionAsync_8_and_negative_2_shouldreturn_negative_4()
        {
            // Arrange
            // Act
            decimal actual = await _citizen.DivisionAsync(8,-2);
            decimal expected = -4;
            // Assert
            actual.Should().Be(expected);
        }
        [Fact]
        public async Task DivisionAsync_negative_8_and_2_shouldreturn_negative_4()
        {
            // Arrange
            // Act
            decimal actual = await _citizen.DivisionAsync(-8,2);
            decimal expected = -4;
            // Assert
            actual.Should().Be(expected);
        }
        [Fact]
        public async Task DivisionAsync_negative_8_and_0_shouldreturn_exception()
        {
            // Arrange
            // Act
            // Assert
            Assert.ThrowsAsync<DivideByZeroException>(()=> _citizen.DivisionAsync(8,0));
        }
    }
}



