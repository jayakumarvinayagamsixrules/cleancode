using System.Threading.Tasks;

namespace Validator
{
    public interface ICalculator
    {
        Task<decimal> AdditionAsync(decimal x, decimal y);
    }

    public class Calculator : ICalculator
    {
        public async Task<decimal> AdditionAsync(decimal x, decimal y)=> await Task.Run(()=> x + y);
    }
}