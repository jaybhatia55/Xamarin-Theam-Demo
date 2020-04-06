using System;

using Xamarin.Forms;
using TheamDemo.iOS.Renders;
using Xamarin.Forms.Platform.iOS;
using UIKit;

[assembly :ExportRenderer (typeof(ContentPage),typeof(PageRender))]
namespace TheamDemo.iOS.Renders
{
    public class PageRender : Xamarin.Forms.Platform.iOS.PageRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);
            if (e.OldElement != null || Element == null)
                return;

            try
            {
                SetTheme();
            }
            catch (Exception ex)
            {

            }
                    
        }
        public override void TraitCollectionDidChange(UITraitCollection previousTraitCollection)
        {
            base.TraitCollectionDidChange(previousTraitCollection);
            if (TraitCollection.UserInterfaceStyle != previousTraitCollection.UserInterfaceStyle)
                SetTheme();

        }
        private void SetTheme()
        {
            App.ApplyTheme();

        }
    }
}

