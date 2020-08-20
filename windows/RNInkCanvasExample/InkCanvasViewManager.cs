using Microsoft.ReactNative;
using Microsoft.ReactNative.Managed;
using Windows.UI;
using Windows.UI.Input.Inking;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace RNInkCanvasExample
{
    class InkCanvasViewManager : IViewManager
    {
        private InkCanvas inkCanvas;

        public string Name => "InkCanvasCS";

        public FrameworkElement CreateView()
        {
            inkCanvas = new InkCanvas();

            inkCanvas.InkPresenter.InputDeviceTypes = Windows.UI.Core.CoreInputDeviceTypes.Mouse | Windows.UI.Core.CoreInputDeviceTypes.Pen | Windows.UI.Core.CoreInputDeviceTypes.Touch;

            return inkCanvas;
        }

    }
}
