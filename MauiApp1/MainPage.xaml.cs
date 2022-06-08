namespace MauiApp1;

public partial class MainPage : ContentPage
{
	int count = 0;

	MainPageViewModel _vm;
	public MainPage()
	{
		InitializeComponent();
		_vm = new MainPageViewModel();
		BindingContext = _vm;
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
		_vm.Init();
    }
}

