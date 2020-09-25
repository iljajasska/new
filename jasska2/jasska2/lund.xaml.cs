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
        BoxView lglaz,pglaz,vedro,vedro2,verh,centr,niz;
        public lund()
        {
            AbsoluteLayout abs = new AbsoluteLayout();
            //верхняя часть
            verh = new BoxView { Color = Color.SkyBlue, CornerRadius = 60 };
            AbsoluteLayout.SetLayoutBounds(verh, new Rectangle(0.5, 0.15, 100, 100));
            AbsoluteLayout.SetLayoutFlags(verh, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(verh);
            //ведро на голову
            vedro = new BoxView { Color = Color.Black, CornerRadius = 0 };
            AbsoluteLayout.SetLayoutBounds(vedro, new Rectangle(0.5, 0.043, 60, 60));
            AbsoluteLayout.SetLayoutFlags(vedro, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(vedro);
            //ведро2
            vedro2 = new BoxView { Color = Color.Black, CornerRadius = 0 };
            AbsoluteLayout.SetLayoutBounds(vedro2, new Rectangle(0.5, 0.13, 120, 10));
            AbsoluteLayout.SetLayoutFlags(vedro2, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(vedro2);
            //левый глаз
            lglaz = new BoxView { Color = Color.Black, CornerRadius = 60 };
            AbsoluteLayout.SetLayoutBounds(lglaz, new Rectangle(0.45, 0.17, 10, 10));
            AbsoluteLayout.SetLayoutFlags(lglaz, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(lglaz);
            //правый глаз
            pglaz = new BoxView { Color = Color.Black, CornerRadius = 60 };
            AbsoluteLayout.SetLayoutBounds(pglaz, new Rectangle(0.55, 0.17, 10, 10));
            AbsoluteLayout.SetLayoutFlags(pglaz, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(pglaz);
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