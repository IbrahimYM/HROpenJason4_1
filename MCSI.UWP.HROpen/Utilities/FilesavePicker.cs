using System;
using Windows.Storage.Pickers;

namespace MCSI.UWP.HROpen.Utilities
{
    internal class FilesavePicker
    {
        public static implicit operator FilesavePicker(FileOpenPicker v)
        {
            throw new NotImplementedException();
        }
    }
}