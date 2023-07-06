
using Application = Microsoft.Maui.Controls.Application;
namespace OpenMaui;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
