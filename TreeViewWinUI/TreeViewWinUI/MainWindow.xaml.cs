using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;

// The Blank Window item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TreeViewWinUI
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
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
