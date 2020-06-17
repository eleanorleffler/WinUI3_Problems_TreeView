using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TreeViewUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            fillTree1();
            fillTree2();
        }

        private void fillTree1()
        {
            TreeViewNode node = new TreeViewNode { Content = "Root", IsExpanded = true };
            treeView1.RootNodes.Add(node);

            TreeViewNode node1 = new TreeViewNode { Content = "Level 1 - A", IsExpanded = true };

            node1.Children.Add(new TreeViewNode { Content = "Level 2 - A" });
            node1.Children.Add(new TreeViewNode { Content = "Level 2 - B" });

            node.Children.Add(node1);
        }

        private void fillTree2()
        {
            TreeViewNode node = new TreeViewNode { Content = "Root", IsExpanded = true };
            treeView2.RootNodes.Add(node);

            TagTreeViewNode node1 = new TagTreeViewNode { Content = "Level 1 - A*", IsExpanded = true };
            node1.Tag = "Node1Tag";

            node1.Children.Add(new TreeViewNode { Content = "Level 2 - A" });
            node1.Children.Add(new TreeViewNode { Content = "Level 2 - B" });

            node.Children.Add(node1);
        }
    }
}
