using System.Runtime.InteropServices;

namespace EraseRescycleBin
{
    class Program
    {

        [DllImport("Shell32.dll", CharSet = CharSet.Unicode)]
        static extern uint SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath, uint dwFlags);

        static void Main(string[] args)
        {
            SHEmptyRecycleBin(IntPtr.Zero, null, Constants.SHERB_NOCONFIRMATION 
                | Constants.SHERB_NOPROGRESSUI | Constants.SHERB_NOSOUND);
        }
    }
}