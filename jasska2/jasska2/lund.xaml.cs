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
        BoxView lglaz,pglaz,vedro,verh,centr,niz;
        public lund()
        {
            AbsoluteLayout abs = new AbsoluteLayout();
            //ведро на голову
            vedro = new BoxView { Color = Color.DarkGray, CornerRadius = 0 };
            AbsoluteLayout.SetLayoutBounds(vedro, new Rectangle(0.5, 0.05, 60, 60));
            AbsoluteLayout.SetLayoutFlags(vedro, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(vedro);
            //левый глаз
            lglaz = new BoxView { Color = Color.Black, CornerRadius = 60 };
            AbsoluteLayout.SetLayoutBounds(lglaz, new Rectangle(0.5, 0.15, 10, 10));
            AbsoluteLayout.SetLayoutFlags(lglaz, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(lglaz);
            //правый глаз
            pglaz = new BoxView { Color = Color.Black, CornerRadius = 60 };
            AbsoluteLayout.SetLayoutBounds(pglaz, new Rectangle(0.5, 0.15, 10, 10));
            AbsoluteLayout.SetLayoutFlags(pglaz, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(pglaz);
            //верхняя часть
            verh = new BoxView { Color = Color.SkyBlue, CornerRadius = 60 };
            AbsoluteLayout.SetLayoutBounds(verh, new Rectangle(0.5, 0.15, 100, 100));
            AbsoluteLayout.SetLayoutFlags(verh, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(verh);
            //центральная часть
            centr = new BoxView { Color = Color.SkyBlue, CornerRadius = 60 };
            AbsoluteLayout.SetLayoutBounds(centr, new Rectangle(0.5, 0.38, 130, 130));
            AbsoluteLayout.SetLayoutFlags(centr, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(centr);
            //нижняя часть
            niz = new BoxView { Color = Color.SkyBlue, CornerRadius = 60 };
            AbsoluteLayout.SetLayoutBounds(niz, new Rectangle(0.5, 0.67, 140, 140));
            AbsoluteLayout.SetLayoutFlags(niz, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(niz);
            Content = abs;
        }
    }
}