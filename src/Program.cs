namespace BitHelp.Core.HandleData
{    static class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new System.ArgumentNullException(nameof(args));
            }
        }
    }
}
