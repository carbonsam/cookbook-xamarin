using CustomRendererContracts;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

namespace FormsCustomRendererImplementationsIOS
{
    public class ViewPositionLocator : IViewPositionLocator
    {
        public Rectangle GetCoordinates(VisualElement view)
        {
            var nativeView = Platform.GetRenderer(view).NativeView;
            var absPoints = nativeView.Superview.ConvertPointToView(nativeView.Frame.Location, null);

            int absX = (int)Math.Round(absPoints.X);
            int absY = (int)Math.Round(absPoints.Y); // TODO: Account for iOS safe area

            return new Rectangle(absX, absY, (int)view.Width, (int)view.Height);
        }
    }
}
