using System.Runtime.InteropServices;

namespace EraseRecycleBin;

internal static partial class NativeMethods
{
    // SHSTDAPI SHEmptyRecycleBinW(HWND hwnd, LPCWSTR pszRootPath, DWORD dwFlags);
    [LibraryImport("shell32.dll", EntryPoint = "SHEmptyRecycleBinW", StringMarshalling = StringMarshalling.Utf16)]
    [DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
    internal static partial int SHEmptyRecycleBin(nint hwnd, string? pszRootPath, RecycleBinFlags dwFlags);
}