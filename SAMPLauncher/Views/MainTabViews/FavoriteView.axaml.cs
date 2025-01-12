using Avalonia.Controls;
using Avalonia.Interactivity;

namespace SAMPLauncher.Views.MainTabViews;

public partial class FavoriteView : UserControl
{
    public FavoriteView()
    {
        InitializeComponent();
    }

    private void FilterButtonToggle_Click(object? sender, RoutedEventArgs e)
    {
        FilterBorder.IsVisible = !FilterBorder.IsVisible;
    }
}