using System.Threading.Tasks;
using System.Linq;
using System;

namespace Validator
{
    public interface INumericImplementation
    {
        Task<string> ArrayOddOrEvenCheckAsync(int[] values);
        Task<bool> IsPerfectSquareAsync(int n);
    }

    public class NumericImplementation : INumericImplementation
    {

        public async Task<string> ArrayOddOrEvenCheckAsync(int[] values)=> await Task.Run(() => (values.Sum() % 2 == 0)? NumericLevel.Even.ToString()  :NumericLevel.Odd.ToString());

        public async Task<bool> IsPerfectSquareAsync(int n) => await Task.Run(()=> Math.Sqrt(n)%1==0);
    }
    public enum NumericLevel
    {
        Odd,
        Even
       
    }
}