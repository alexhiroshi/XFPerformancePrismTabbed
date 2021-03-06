﻿using Prism.Mvvm;
using System;
using Xamarin.Forms;
using XFPerformancePrism.Contents;

namespace XFPerformancePrism.Views
{
    public partial class SampleContentPage2 : ContentPage
    {
        private bool _loadedPage = false;
        private bool _stopTimer = false;

        public SampleContentPage2()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            if (_loadedPage) return;

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                SetContent();
                return false;
            });
        }

        protected override void OnDisappearing()
        {
            _stopTimer = true;
        }

        private void SetContent()
        {
            if (!_stopTimer)
            {
                ViewModelLocator.SetAutowireViewModel(this, true);
                Content = new SampleContent2();

                _loadedPage = true;
            }

            _stopTimer = false;
        }
    }
}
