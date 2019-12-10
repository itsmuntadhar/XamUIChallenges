using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamUIChallenges.Interfaces;

[assembly: Dependency(typeof(XamUIChallenges.iOS.Services.StatusBarStyleManager))]
namespace XamUIChallenges.iOS.Services
{
    public class StatusBarStyleManager : IStatusBarStyleManager
    {
        public void SetStatusBarColor(Color color)
        {
            if (UIDevice.CurrentDevice.CheckSystemVersion(13, 0))
            {
                foreach (var window in UIApplication.SharedApplication.Windows)
                {
                    const int statusBarTag = 38482;
                    var statusBar = new UIView(UIApplication.SharedApplication.StatusBarFrame)
                    {
                        Tag = 38482,
                        BackgroundColor = color.ToUIColor()
                    };

                    if (window.ViewWithTag(statusBarTag) != null)
                    {
                        window.WillRemoveSubview(statusBar);
                    }
                    window.AddSubview(statusBar);
                }
            }
            else
            {
                var statusBar = UIApplication.SharedApplication.ValueForKey(new NSString("statusBarWindow")).ValueForKey(new NSString("statusBar")) as UIView;
                statusBar.BackgroundColor = color.ToUIColor();
                statusBar.TintColor = UIColor.White;
            }
        }
    }
}