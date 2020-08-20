using Microsoft.ReactNative;
using Microsoft.ReactNative.Managed;

namespace RNInkCanvasExample
{
    public partial class ReactPackageProvider : IReactPackageProvider
    {

        public void CreatePackage(IReactPackageBuilder packageBuilder)
        {
            packageBuilder.AddViewManagers();
        }
    }
}
