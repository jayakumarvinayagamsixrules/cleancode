using System;
using System.Threading.Tasks;

namespace Validator
{
    public interface ICalculator
    {
        Task<decimal> AdditionAsync(decimal x, decimal y);
        Task<decimal> SubtractionAsync(decimal x, decimal y);
        Task<decimal> MultiplicationAsync(decimal x, decimal y);
        Task<decimal> DivisionAsync(decimal x, decimal y);
    }

    public class Calculator : ICalculator
    {
        public async Task<decimal> AdditionAsync(decimal x, decimal y)=> await Task.Run(()=> x + y);

        public async Task<decimal> DivisionAsync(decimal x, decimal y) 
        {
            if(y == 0)
                throw new DivideByZeroException();
            return await Task.Run(()=> x / y);
        }

        public async Task<decimal> MultiplicationAsync(decimal x, decimal y) => await Task.Run(()=> x * y);

        public async Task<decimal> SubtractionAsync(decimal x, decimal y) => await Task.Run(() => x - y);
    }
}