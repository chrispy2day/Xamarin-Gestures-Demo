using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinFormsGestures.ViewModels;

namespace XamarinFormsGestures.Views
{
    public partial class GesturesPage : ContentPage
    {
        private GestureMessageViewModel _vm;
        public GesturesPage()
        {
            InitializeComponent();

            SetupGestureResponse();

            _vm = new GestureMessageViewModel { Message = "No gestures received." };
            this.BindingContext = _vm;
        }

        private void SetupGestureResponse()
        {
            gestureView.SwipeDown += (sender, e) => { _vm.Message = "Swipe Down received."; };
            gestureView.SwipeLeft += (sender, e) => { _vm.Message = "Swipe Left received."; };
            gestureView.SwipeRight += (sender, e) => { _vm.Message = "Swipe Right received."; };
            gestureView.SwipeUp += (sender, e) => { _vm.Message = "Swipe Up received."; };
        }
    }
}
