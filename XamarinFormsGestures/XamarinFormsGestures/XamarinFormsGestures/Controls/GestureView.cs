using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinFormsGestures.Controls
{
    public class GestureView : ContentView
    {
        public event EventHandler SwipeDown;
        public event EventHandler SwipeUp;
        public event EventHandler SwipeLeft;
        public event EventHandler SwipeRight;

        public void OnSwipeDown()
        {
            EventHandler handler = SwipeDown;
            if (handler != null)
                SwipeDown(this, null);
        }

        public void OnSwipeUp()
        {
            EventHandler handler = SwipeUp;
            if (handler != null)
                SwipeUp(this, null);
        }

        public void OnSwipeLeft()
        {
            EventHandler handler = SwipeLeft;
            if (handler != null)
                SwipeLeft(this, null);
        }

        public void OnSwipeRight()
        {
            EventHandler handler = SwipeRight;
            if (handler != null)
                SwipeRight(this, null);
        }
    }
}
