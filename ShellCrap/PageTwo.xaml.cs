using CommunityToolkit.Mvvm.Input;
using ShellCrap.ViewModels;

namespace ShellCrap;

public partial class PageTwo : ContentPage
{
	public PageTwo(PageTwoVM viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;

        this.Appearing += viewModel.OnAppearing;
        this.Disappearing += viewModel.OnDisappearing;
        this.Loaded += viewModel.OnLoaded;
        this.NavigatedFrom += viewModel.OnNavigatedFrom;
        this.NavigatedTo += viewModel.OnNavigatedTo;
        this.NavigatingFrom += viewModel.OnOnNavigatingFrom;
        this.Unloaded += viewModel.OnUnloaded;
    }
}
