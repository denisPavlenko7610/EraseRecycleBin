using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace EraseRecycleBin;

internal static class RecycleBin
{
    private const RecycleBinFlags DefaultFlags =
        RecycleBinFlags.NoConfirmation | RecycleBinFlags.NoProgressUi | RecycleBinFlags.NoSound;

    [SupportedOSPlatform("windows")]
    public static void Empty(string? rootPath = null, RecycleBinFlags flags = DefaultFlags)
    {
        // hwnd = 0 (IntPtr.Zero): without ui owner
        int hr = NativeMethods.SHEmptyRecycleBin(0, rootPath, flags);
        if (hr < 0) // FAILED(hr)
        {
            Marshal.ThrowExceptionForHR(hr);
        }
    }
}