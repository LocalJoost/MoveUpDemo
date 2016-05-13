using Windows.UI.Xaml.Controls;

namespace MoveUpDemo
{
  public sealed partial class Default : Page
  {
    public Default()
    {
      this.InitializeComponent();
    }

    public DemoViewModel ViewModel => DemoViewModel.Instance;

  }
}
