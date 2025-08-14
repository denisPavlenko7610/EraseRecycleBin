using EraseRecycleBin;

namespace EraseRecycleBin
{
    class Program
    {
        static int Main(string[] args)
        {
            if (!OperatingSystem.IsWindows())
            {
                Console.Error.WriteLine("This tool requires Windows.");
                return 1;
            }

            string? root = args.Length > 0 ? args[0] : null;

            try
            {
                RecycleBin.Empty(root);
                return 0;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                int code = ex.HResult != 0 ? ex.HResult : 1;
                return code;
            }
        }
    }
}