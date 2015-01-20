using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using XamarinFormsGestures.Controls;
using XamarinFormsGestures.iOS.CustomRenderers;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(GestureView), typeof(GestureViewRenderer))]
namespace XamarinFormsGestures.iOS.CustomRenderers
{
    public class GestureViewRenderer : ViewRenderer
    {
        UISwipeGestureRecognizer _swipeDown;
        UIGestureRecognizer _swipeUp;
        UIGestureRecognizer _swipeLeft;
        UIGestureRecognizer _swipeRight;

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.View> e)
        {
            base.OnElementChanged(e);

            // get the element
            var gestureView = (GestureView)this.Element;

            // setup the swipe actions
            _swipeDown = new UISwipeGestureRecognizer(() =>
            {
                gestureView.OnSwipeDown();
            })
            {
                Direction = UISwipeGestureRecognizerDirection.Down
            };

            _swipeUp = new UISwipeGestureRecognizer(() =>
            {
                gestureView.OnSwipeUp();
            })
            {
                Direction = UISwipeGestureRecognizerDirection.Up
            };

            _swipeLeft = new UISwipeGestureRecognizer(() =>
            {
                gestureView.OnSwipeLeft();
            })
            {
                Direction = UISwipeGestureRecognizerDirection.Left
            };

            _swipeRight = new UISwipeGestureRecognizer(() =>
            {
                gestureView.OnSwipeRight();
            })
            {
                Direction = UISwipeGestureRecognizerDirection.Right
            };

            // remove the gesture when the control is removed
            if (e.NewElement == null)
            {
                if (_swipeDown != null)
                    this.RemoveGestureRecognizer(_swipeDown);
                if (_swipeLeft != null)
                    this.RemoveGestureRecognizer(_swipeLeft);
                if (_swipeRight != null)
                    this.RemoveGestureRecognizer(_swipeRight);
                if (_swipeUp != null)
                    this.RemoveGestureRecognizer(_swipeUp);
            }

            // only add the gesture when the control is not being reused
            if (e.OldElement == null)
            {
                this.AddGestureRecognizer(_swipeDown);
                this.AddGestureRecognizer(_swipeLeft);
                this.AddGestureRecognizer(_swipeRight);
                this.AddGestureRecognizer(_swipeUp);
            }
        }
    }
}