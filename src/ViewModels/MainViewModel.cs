using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace HelloMauiMarkup;

partial class MainViewModel : BaseViewModel
{
	[ObservableProperty]
	public partial int ClickCount { get; set; } = 0;

	[RelayCommand]
	void IncrementClickMeButton() => ClickCount++;
}