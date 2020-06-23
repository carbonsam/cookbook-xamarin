using CustomRendererContracts;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace FormsCustomRendererImplementationsAndroid
{
    public class ViewPositionLocator : IViewPositionLocator
    {
        public Rectangle GetCoordinates(VisualElement view)
        {
            var nativeView = Platform.GetRenderer(view).View;
            var screenDensity = nativeView.Context.Resources.DisplayMetrics.Density;
            var locationPoints = new int[2];

            nativeView.GetLocationOnScreen(locationPoints);

            int absX = (int)Math.Round(locationPoints[0] / screenDensity);
            int absY = (int)Math.Round(locationPoints[1] / screenDensity);

            return new Rectangle(absX, absY, view.Width, view.Height);
        }
    }
}
