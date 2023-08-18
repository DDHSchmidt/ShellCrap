using System.Reflection;
using CommunityToolkit.Mvvm.Input;

namespace ShellCrap;

public partial class AppShell : Shell
{
	public DateTime StartTime
	{
		get => DateTime.UtcNow;
	}

	public string MauiAssemblyVersion { get; set; }


    public AppShell()
	{
		InitializeComponent();
		MauiAssemblyVersion = Environment.GetEnvironmentVariable("RuntimeMauiVersion", EnvironmentVariableTarget.Process);
        BindingContext = this;
	}
}

