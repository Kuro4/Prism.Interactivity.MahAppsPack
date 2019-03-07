using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Prism.InteractivityExtension.DefaultPopupWindows
{
    /// <summary>
    /// DefaultFilePickerWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class DefaultFilePickerWindow : Window
    {
        public DefaultFilePickerWindow()
        {
            InitializeComponent();
        }

        public IFilePickerConfirmation FilePickerConfirmation
        {
            get
            {
                return this.DataContext as IFilePickerConfirmation;
            }
            set
            {
                this.DataContext = value;
                this.TreeExplorer.ItemsSource = value.DefaultDirectories.Select(x => new Models.DirectoryNode(x));
            }
        }
    }
}
