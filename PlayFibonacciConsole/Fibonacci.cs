namespace PlayFibonacciConsole
{
    public class Fibonacci
    {
        private ulong[] All = new ulong[2] { 0, 1 };
        
        private int Index = 0;

        public ulong GetNext()
        {
            if (Index < 2)
            {
                return All[Index++];
            }

            All = new ulong[2] { All[1], All[0] + All[1] };
            Index = 2;

            return All[1];
        }
    }
}
