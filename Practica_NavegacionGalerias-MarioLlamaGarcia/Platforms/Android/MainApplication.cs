using Android.App;
using Android.App;
using Android.Runtime;

namespace Practica_NavegacionGalerias_MarioLlamaGarcia
{
    [Application]
    public class MainApplication : MauiApplication
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownership)
            : base(handle, ownership)
        {
        }

        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}
