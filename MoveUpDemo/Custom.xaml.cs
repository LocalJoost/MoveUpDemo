using Windows.UI.Xaml.Controls;

namespace MoveUpDemo
{
  public sealed partial class Custom : Page
  {
    public Custom()
    {
      this.InitializeComponent();
    }

    public DemoViewModel ViewModel => DemoViewModel.Instance;
  }
}
