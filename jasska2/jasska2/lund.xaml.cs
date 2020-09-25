using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace jasska2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class lund : ContentPage
    {
        BoxView golova, vedro, telo;
        public lund()
        {
            AbsoluteLayout abs = new AbsoluteLayout();
            golova = new BoxView { Color = Color.LightBlue, CornerRadius = 50 };
            AbsoluteLayout.SetLayoutBounds(golova, new Rectangle(0.1, 0.2, 300, 300));
            AbsoluteLayout.SetLayoutFlags(golova, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(golova);
            Content = abs;
        }
    }
}