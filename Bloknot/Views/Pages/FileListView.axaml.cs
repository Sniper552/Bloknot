using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using Bloknot.Models;
using Bloknot.ViewModels.Pages;
using System;
using System.Reactive;

namespace Bloknot.Views.Pages
{
    public partial class FileListView : UserControl
    { 

        public FileListView()
        {
            InitializeComponent();
        }

        public void DoubleClickedEvent(object? sender, RoutedEventArgs args)
        {
            if (DataContext is FileLViewModel fileListViewModel)
            {
                fileListViewModel.OpenCommand.Execute().Subscribe();
            }
        }
    }
}
