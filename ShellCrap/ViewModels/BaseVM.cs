using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ShellCrap.ViewModels
{
	public abstract partial class BaseVM : ObservableObject
	{
        [ObservableProperty]
        private bool isBusy;

        [ObservableProperty]
        private string title;

		public BaseVM()
		{
		}

		public virtual async Task OnAnything(object sender, EventArgs args)
		{
			await Task.CompletedTask;
		}

		public virtual async void OnAppearing(object sender, EventArgs args)
		{
			await OnAnything(sender, args);
		}

        public virtual async void OnDisappearing(object sender, EventArgs args)
        {
            await OnAnything(sender, args);
        }

        public virtual async void OnLoaded(object sender, EventArgs args)
        {
            await OnAnything(sender, args);
        }

        public virtual async void OnNavigatedFrom(object sender, EventArgs args)
        {
            await OnAnything(sender, args);
        }

        public virtual async void OnNavigatedTo(object sender, EventArgs args)
        {
            await OnAnything(sender, args);
        }

        public virtual async void OnOnNavigatingFrom(object sender, EventArgs args)
        {
            await OnAnything(sender, args);
        }

        public virtual async void OnUnloaded(object sender, EventArgs args)
        {
            await OnAnything(sender, args);
        }
    }
}

