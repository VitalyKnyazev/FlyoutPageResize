namespace MauiApp8
{
	public partial class App
	{
		public App()
		{
			InitializeComponent();
		}

		protected override Window CreateWindow(IActivationState? activationState)
		{
			var navigationPage = new NavigationPage(new MainPage());

			var flyoutPage = new FlyoutPage
			{
				Flyout = new FlyoutContentPage { Title = "Foo" },
				FlyoutLayoutBehavior = FlyoutLayoutBehavior.SplitOnLandscape,
				Detail = navigationPage
			};

			return new Window(flyoutPage);
		}
	}
}