using System;
using XamBookLibrary.iOS;
using XamBookLibrary.Services;
using ColorThiefDotNet;
using Xamarin.Forms;

[assembly: Dependency(typeof(ColorHelper))]
namespace XamBookLibrary.iOS
{
    public class ColorHelper : IColorHelper
    {
        public ColorHelper() { }

        public string GetColor(string fileName)
        {
            var colorThief = new ColorThief();
            var theifColor = colorThief.GetColor(new UIKit.UIImage(fileName), 1).Color;
            return theifColor.ToHexString();
        }
    }
}
