
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamCoder.Droid;
using XamCoder.Helpers;

[assembly: ExportRenderer(typeof(ShapeView), typeof(ShapeRenderer))]
namespace XamCoder.Droid
{
    public class ShapeRenderer : ViewRenderer<ShapeView, Shape>
    {
        public ShapeRenderer()
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<ShapeView> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null || this.Element == null)
                return;

            SetNativeControl(new Shape(Resources.DisplayMetrics.Density, Context)
            {
                ShapeView = Element
            });
        }
    }
}