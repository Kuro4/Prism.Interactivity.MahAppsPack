using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prism.InteractivityExtension
{
    public class FilePickerConfirmation : IFilePickerConfirmation
    {
        public IEnumerable<string> DefaultDirectories { get; set; }
        public Models.DirectoryNode SelectedNode { get; set; }
        public string DefaultDirectoryPath { get; set; }
        public bool IsFileSelectMode { get; set; }
        public bool IsMultiSelect { get; set; }
        public string Filter { get; set; }
        public bool Confirmed { get; set; }
        public string Title { get; set; }
        public object Content { get; set; }
    }
}
