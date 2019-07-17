using System;
using Booky.iOS;
using Booky.Services;
using ColorThiefDotNet;
using Xamarin.Forms;

[assembly: Dependency(typeof(ColorHelper))]
namespace Booky.iOS
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
