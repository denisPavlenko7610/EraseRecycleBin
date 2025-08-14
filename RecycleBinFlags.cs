namespace EraseRecycleBin;

[Flags]
internal enum RecycleBinFlags : uint
{
    NoConfirmation = 0x00000001, // SHERB_NOCONFIRMATION
    NoProgressUi   = 0x00000002, // SHERB_NOPROGRESSUI
    NoSound        = 0x00000004, // SHERB_NOSOUND
}