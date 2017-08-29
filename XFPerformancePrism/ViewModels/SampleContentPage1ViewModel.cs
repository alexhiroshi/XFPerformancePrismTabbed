using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Windows.Input;

namespace XFPerformancePrism.ViewModels
{
    public class SampleContentPage1ViewModel : BindableBase
    {
        private string _myText;
        public string MyText
        {
            get { return _myText; }
            set { SetProperty(ref _myText, value); }
        }

        public ICommand TestCommand { get; set; }

        public SampleContentPage1ViewModel()
        {
            MyText = "Binding property 1";

            TestCommand = new DelegateCommand(() =>
            {
                MyText = $"Binding Command {DateTime.Now}";
            });
        }
    }
}
