using GalaSoft.MvvmLight;

namespace MoveUpDemo
{
  public class DemoViewModel : ViewModelBase
  {
    private DemoViewModel()
    {
    }

    public  void ToggleDisplay()
    {
      TabDisplay = !TabDisplay;
    }

    private bool _tabDisplay;
    public bool TabDisplay
    {
      get { return _tabDisplay; }
      set { Set(() => TabDisplay, ref _tabDisplay, value); }
    }

    private static DemoViewModel _demoViewModel;

    public static DemoViewModel Instance
    {
      get { return _demoViewModel ?? (_demoViewModel = new DemoViewModel()); }
    }
  }
}
