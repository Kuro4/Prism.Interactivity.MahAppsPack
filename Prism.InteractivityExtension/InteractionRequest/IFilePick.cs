using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prism.InteractivityExtension.InteractionRequest
{
    public interface IFilePick
    {
        bool IsMultiSelect { get; set; }
        string Filter { get; set; }
        FileSystemInfo PickedFile { get; }
        FileSystemInfo[] PickedFiles { get; }
    }
}
