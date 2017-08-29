using Prism.Unity;
using Xamarin.Forms;
using XFPerformancePrism.Views;

namespace XFPerformancePrism
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("MainPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<SampleContentPage1>();
            Container.RegisterTypeForNavigation<SampleContentPage2>();
        }
    }
}
