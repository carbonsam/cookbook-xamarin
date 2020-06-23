using Xamarin.Forms;

namespace CustomRendererContracts
{
    public interface IViewPositionLocator
    {
        Rectangle GetCoordinates(VisualElement view);
    }
}
