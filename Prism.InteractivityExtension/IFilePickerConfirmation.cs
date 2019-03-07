using Prism.Interactivity.InteractionRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prism.InteractivityExtension
{
    public interface IFilePickerConfirmation : IConfirmation
    {
        IEnumerable<string> DefaultDirectories { get; set; }
        string DefaultDirectoryPath { get; set; }
        bool IsFileSelectMode { get; set; }
        bool IsMultiSelect { get; set;}
        string Filter { get; set; }
    }
}
