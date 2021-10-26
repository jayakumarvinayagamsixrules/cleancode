using Xunit;
using FluentAssertions;
using Validator;
using System.Threading.Tasks;
namespace ValidatorTest
{
    public class NumericImplementationTest
    {
        /*
        *   
        * Unit of work : what function you going to test
        * State under test : Which condition we going to test
        * Expected behavior : What to be expect
        */
        INumericImplementation _numericimplementation; 
        public NumericImplementationTest()
        {
            _numericimplementation = new NumericImplementation();
        }
        [Fact]
        public async void ArrayOddOrEvenCheckAsync_Empty_shouldReturn_Even()
        {
            //Arrange
            
            //Act
            var actual = await _numericimplementation.ArrayOddOrEvenCheckAsync(new int[]{});
            //Assert
            actual.Should().Be("Even");
        }
        [Fact]
        public async void ArrayOddOrEvenCheckAsync_OddItem_shouldReturn_Even()
        {
            //Arrange
            
            //Act
            var actual = await _numericimplementation.ArrayOddOrEvenCheckAsync(new int[]{1});
            //Assert
            actual.Should().Be("Odd");
        }
        [Fact]
        public async void ArrayOddOrEvenCheckAsync_Zero_shouldReturn_Even()
        {
            //Arrange
            
            //Act
            var actual = await _numericimplementation.ArrayOddOrEvenCheckAsync(new int[]{0});
            //Assert
            actual.Should().Be("Even");
        }
        [Theory]
        [InlineData(new int[]{0, -1,-5}, "Even")]
        [InlineData(new int[]{0, -1,-8}, "Odd")]
        [InlineData(new int[]{342, 9856,48792}, "Even")]
        public async Task ArrayOddOrEvenCheckAsync_With_Edgevalues(int[] values, string expected)
        {
            //Arrange
            
            //Act
            var actual = await _numericimplementation.ArrayOddOrEvenCheckAsync(values);
            //Assert
            actual.Should().Be(expected);
        }

        [Fact]
        public async Task IsPerfectSquareAsync_Notsquare_Negative_1_Shouldreturn_false()
        {
             //Arrange
            
            //Act
             var actual = await _numericimplementation.IsPerfectSquareAsync(-1);
            //Then
            actual.Should().BeFalse();
        }
        [Fact]
        public async Task IsPerfectSquareAsync_Notsquare_Positive_10_Shouldreturn_false()
        {
            //Arrange
            
            //Act
             var actual = await _numericimplementation.IsPerfectSquareAsync(10);
            //Then
            actual.Should().BeFalse();
        }
        [Fact]
        public async Task IsPerfectSquareAsync_Square_Positive_25_Shouldreturn_true()
        {
             //Arrange
            
            //Act
             var actual = await _numericimplementation.IsPerfectSquareAsync(25);
            //Then
            actual.Should().BeTrue();
        }

        [Theory]
        [InlineData(19, false)]
        [InlineData(121, true)]
        [InlineData(144, true)]
        public async Task IsPerfectSquareAsync_EdgeValues(int n, bool expected)
        {
             //Arrange
            
            //Act
             var actual = await _numericimplementation.IsPerfectSquareAsync(n);
            //Then
            actual.Should().Be(expected);
        }
    }
}