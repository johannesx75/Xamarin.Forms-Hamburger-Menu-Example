using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace HamburgerMenuExample {
	public class MenuPageViewModel {

		public ICommand GoHomeCommand { get; set; }
		public ICommand GoSecondCommand { get; set; }

		public MenuPageViewModel() {
			GoHomeCommand = new Command(GoHome);
			GoSecondCommand = new Command(GoSecond);
		}

		void GoHome(object obj) {
			App.NavigationPage.Navigation.PopToRootAsync();
			App.MenuIsPresented = false;
		}

		async void GoSecond(object obj) {
			var secondPage = new SecondPage();
			NavigationPage.SetHasBackButton(secondPage, false);
			await App.NavigationPage.Navigation.PushAsync(secondPage);
			App.MenuIsPresented = false;
		}
	}
}

