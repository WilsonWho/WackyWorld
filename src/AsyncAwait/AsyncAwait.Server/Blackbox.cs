using System.Threading.Tasks;

namespace AsyncAwait.Server
{
    public class BlackBox
    {
        public int GetValue(int value)
        {
            return value + value;
        }

        public async Task<int> GetValueAsync(int value)
        {
            return await Task.Run(() => Processor.DoMath(value));
        }
    }
}