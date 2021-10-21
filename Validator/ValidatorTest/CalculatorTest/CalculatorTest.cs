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
    * expected behavior : What to be expect
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
            actual.Should().Equals(expected);
        }
        [Fact]
        public async Task AdditionAsync_5_and_negative_8_shouldReturn_3()
        {
            // Arrange
            // Act
            decimal actual = await _citizen.AdditionAsync(5,-8);
            decimal expected = -3;
            // Assert
            actual.Should().Equals(expected);
        }
        [Fact]
        public async Task AdditionAsync_negative_5_and_8_shouldReturn_3()
        {
            // Arrange
            // Act
            decimal actual = await _citizen.AdditionAsync(-5,8);
            decimal expected = 3;
            // Assert
            actual.Should().Equals(expected);
        }
        [Fact]
        public async Task AdditionAsync_negative_5_and_negative_8_shouldReturn_negative_13()
        {
            // Arrange
            // Act
            decimal actual = await _citizen.AdditionAsync(-5,-8);
            decimal expected = -13;
            // Assert
            actual.Should().Equals(expected);
        }
        [Fact]
        public async Task AdditionAsync_negative_5_and_8_shouldNotReturn_13()
        {
            // Arrange
            // Act
            decimal actual = await _citizen.AdditionAsync(-5,8);
            decimal expected = 1113;
            // Assert
            actual.Should().Equals(expected);
        }
    }
}