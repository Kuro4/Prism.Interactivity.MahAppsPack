using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Prism.InteractivityExtension.Models
{
    public class DirectoryNode
    {
        public DirectoryInfo Directory { get; }
        public ImageSource Image { get; }
        public string Name
        {
            get
            {
                return this.Directory is null ? "NotFound" : this.Directory.Name;
            }
        }
        public bool Exists { get; private set; }

        public List<DirectoryNode> children = new List<DirectoryNode>();
        public ReadOnlyCollection<DirectoryNode> Children { get; }

        public DirectoryNode(string directoryPath) : this(new DirectoryInfo(directoryPath))
        {
        }

        public DirectoryNode(DirectoryInfo directory)
        {
            this.Directory = directory;
            this.Children = new ReadOnlyCollection<DirectoryNode>(this.children);
        }
    }
}
