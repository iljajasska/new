using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace jasska2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class lund : ContentPage
    {
        BoxView lglaz,pglaz,vedro,vedro2,verh,centr,niz,pugovica1,pugovica2,pugovica3,rot;
        Button knopka1, knopka2, knopka3, knopka4;
        public lund()
        {
            AbsoluteLayout abs = new AbsoluteLayout();
            //верхняя часть
            verh = new BoxView { Color = Color.SkyBlue, CornerRadius = 60 };
            AbsoluteLayout.SetLayoutBounds(verh, new Rectangle(0.5, 0.15, 100, 100));
            AbsoluteLayout.SetLayoutFlags(verh, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(verh);
            //рот
            rot = new BoxView { Color = Color.Black, CornerRadius = 60 };
            AbsoluteLayout.SetLayoutBounds(rot, new Rectangle(0.5, 0.24, 30, 10));
            AbsoluteLayout.SetLayoutFlags(rot, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(rot);
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
            //пуговица1
            pugovica1 = new BoxView { Color = Color.Black, CornerRadius = 60 };
            AbsoluteLayout.SetLayoutBounds(pugovica1, new Rectangle(0.5, 0.34, 13, 13));
            AbsoluteLayout.SetLayoutFlags(pugovica1, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(pugovica1);
            //пуговица2
            pugovica2 = new BoxView { Color = Color.Black, CornerRadius = 60 };
            AbsoluteLayout.SetLayoutBounds(pugovica2, new Rectangle(0.5, 0.40, 13, 13));
            AbsoluteLayout.SetLayoutFlags(pugovica2, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(pugovica2);
            //пуговица3
            pugovica3 = new BoxView { Color = Color.Black, CornerRadius = 60 };
            AbsoluteLayout.SetLayoutBounds(pugovica3, new Rectangle(0.5, 0.46, 13, 13));
            AbsoluteLayout.SetLayoutFlags(pugovica3, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(pugovica3);
            //нижняя часть
            niz = new BoxView { Color = Color.SkyBlue, CornerRadius = 60 };
            AbsoluteLayout.SetLayoutBounds(niz, new Rectangle(0.5, 0.67, 140, 140));
            AbsoluteLayout.SetLayoutFlags(niz, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(niz);
            //убрать голову
            knopka1 = new Button { Text = "голова" };
            knopka1.Clicked += Knopka1_Clicked;
            AbsoluteLayout.SetLayoutBounds(knopka1, new Rectangle(0.02, 0.9, 110, 55));
            AbsoluteLayout.SetLayoutFlags(knopka1, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(knopka1);
            //смена цвета пуговиц
            knopka2 = new Button { Text = "пуговицы" };
            knopka2.Clicked += Knopka2_Clicked;
            AbsoluteLayout.SetLayoutBounds(knopka2, new Rectangle(0.5, 0.9, 110, 55));
            AbsoluteLayout.SetLayoutFlags(knopka2, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(knopka2);
            //злой снеговик
            knopka3 = new Button { Text = "злой снеговик" };
            knopka3.Clicked += Knopka3_Clicked;
            AbsoluteLayout.SetLayoutBounds(knopka3, new Rectangle(0.95, 0.9, 110, 55));
            AbsoluteLayout.SetLayoutFlags(knopka3, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(knopka3);
            //сдвинуть слево
            knopka4 = new Button { Text = "сдвинуть" };
            knopka4.Clicked += Knopka4_Clicked;
            AbsoluteLayout.SetLayoutBounds(knopka4, new Rectangle(0.5, 1, 110, 55));
            AbsoluteLayout.SetLayoutFlags(knopka4, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(knopka4);
            Content = abs;

        }

        private void Knopka4_Clicked(object sender, EventArgs e)
        {
            if (flag)
            {
                AbsoluteLayout.SetLayoutBounds(verh, new Rectangle(0.13, 0.15, 100, 100));
                AbsoluteLayout.SetLayoutFlags(verh, AbsoluteLayoutFlags.PositionProportional);
                AbsoluteLayout.SetLayoutBounds(rot, new Rectangle(0.20, 0.24, 30, 10));
                AbsoluteLayout.SetLayoutFlags(rot, AbsoluteLayoutFlags.PositionProportional);
                AbsoluteLayout.SetLayoutBounds(vedro, new Rectangle(0.17, 0.043, 60, 60));
                AbsoluteLayout.SetLayoutFlags(vedro, AbsoluteLayoutFlags.PositionProportional);
                AbsoluteLayout.SetLayoutBounds(vedro2, new Rectangle(0.1, 0.13, 120, 10));
                AbsoluteLayout.SetLayoutFlags(vedro2, AbsoluteLayoutFlags.PositionProportional);
                AbsoluteLayout.SetLayoutBounds(lglaz, new Rectangle(0.17, 0.17, 10, 10));
                AbsoluteLayout.SetLayoutFlags(lglaz, AbsoluteLayoutFlags.PositionProportional);
                AbsoluteLayout.SetLayoutBounds(pglaz, new Rectangle(0.27, 0.17, 10, 10));
                AbsoluteLayout.SetLayoutFlags(pglaz, AbsoluteLayoutFlags.PositionProportional);
                AbsoluteLayout.SetLayoutBounds(centr, new Rectangle(0.1, 0.38, 130, 130));
                AbsoluteLayout.SetLayoutFlags(centr, AbsoluteLayoutFlags.PositionProportional);
                AbsoluteLayout.SetLayoutBounds(pugovica1, new Rectangle(0.23, 0.34, 13, 13));
                AbsoluteLayout.SetLayoutFlags(pugovica1, AbsoluteLayoutFlags.PositionProportional);
                AbsoluteLayout.SetLayoutBounds(pugovica2, new Rectangle(0.23, 0.40, 13, 13));
                AbsoluteLayout.SetLayoutFlags(pugovica2, AbsoluteLayoutFlags.PositionProportional);
                AbsoluteLayout.SetLayoutBounds(pugovica3, new Rectangle(0.23, 0.46, 13, 13));
                AbsoluteLayout.SetLayoutFlags(pugovica3, AbsoluteLayoutFlags.PositionProportional);
                AbsoluteLayout.SetLayoutBounds(niz, new Rectangle(0.1, 0.67, 140, 140));
                AbsoluteLayout.SetLayoutFlags(niz, AbsoluteLayoutFlags.PositionProportional);
                flag = false;
            }
            else
            {
                AbsoluteLayout.SetLayoutBounds(verh, new Rectangle(0.5, 0.15, 100, 100));
                AbsoluteLayout.SetLayoutFlags(verh, AbsoluteLayoutFlags.PositionProportional);
                AbsoluteLayout.SetLayoutBounds(rot, new Rectangle(0.5, 0.24, 30, 10));
                AbsoluteLayout.SetLayoutFlags(rot, AbsoluteLayoutFlags.PositionProportional);
                AbsoluteLayout.SetLayoutBounds(vedro, new Rectangle(0.5, 0.043, 60, 60));
                AbsoluteLayout.SetLayoutFlags(vedro, AbsoluteLayoutFlags.PositionProportional);
                AbsoluteLayout.SetLayoutBounds(vedro2, new Rectangle(0.5, 0.13, 120, 10));
                AbsoluteLayout.SetLayoutFlags(vedro2, AbsoluteLayoutFlags.PositionProportional);
                AbsoluteLayout.SetLayoutBounds(lglaz, new Rectangle(0.45, 0.17, 10, 10));
                AbsoluteLayout.SetLayoutFlags(lglaz, AbsoluteLayoutFlags.PositionProportional);
                AbsoluteLayout.SetLayoutBounds(pglaz, new Rectangle(0.55, 0.17, 10, 10));
                AbsoluteLayout.SetLayoutFlags(pglaz, AbsoluteLayoutFlags.PositionProportional);
                AbsoluteLayout.SetLayoutBounds(centr, new Rectangle(0.5, 0.38, 130, 130));
                AbsoluteLayout.SetLayoutFlags(centr, AbsoluteLayoutFlags.PositionProportional);
                AbsoluteLayout.SetLayoutBounds(pugovica1, new Rectangle(0.5, 0.34, 13, 13));
                AbsoluteLayout.SetLayoutFlags(pugovica1, AbsoluteLayoutFlags.PositionProportional);
                AbsoluteLayout.SetLayoutBounds(pugovica2, new Rectangle(0.5, 0.40, 13, 13));
                AbsoluteLayout.SetLayoutFlags(pugovica2, AbsoluteLayoutFlags.PositionProportional);
                AbsoluteLayout.SetLayoutBounds(pugovica3, new Rectangle(0.5, 0.46, 13, 13));
                AbsoluteLayout.SetLayoutFlags(pugovica3, AbsoluteLayoutFlags.PositionProportional);
                AbsoluteLayout.SetLayoutBounds(niz, new Rectangle(0.5, 0.67, 140, 140));
                AbsoluteLayout.SetLayoutFlags(niz, AbsoluteLayoutFlags.PositionProportional);
                flag = true;
            }
        }
        private void Knopka3_Clicked(object sender, EventArgs e)
        {
            if (flag)
            {
                verh.Color = Color.DarkGray;
                centr.Color = Color.DarkGray;
                niz.Color = Color.DarkGray;
                lglaz.Color = Color.Red;
                pglaz.Color = Color.Red;
                rot.Color = Color.Red;
                pugovica1.CornerRadius = 0;
                pugovica2.CornerRadius = 0;
                pugovica3.CornerRadius = 0;
                vedro.Opacity = 0;
                vedro2.Opacity = 0;
                flag = false;
            }
            else
            {
                verh.Color = Color.SkyBlue;
                centr.Color = Color.SkyBlue;
                niz.Color = Color.SkyBlue;
                lglaz.Color = Color.Black;
                pglaz.Color = Color.Black;
                rot.Color = Color.Black;
                pugovica1.CornerRadius = 60;
                pugovica2.CornerRadius = 60;
                pugovica3.CornerRadius = 60;
                vedro.Opacity = 1;
                vedro2.Opacity = 1;
                flag = true;
            }
        }
        private void Knopka2_Clicked(object sender, EventArgs e)
        {
            if (flag)
            {
                pugovica1.Color = Color.Red;
                pugovica2.Color = Color.Red;
                pugovica3.Color = Color.Red;
                flag = false;
            }
            else
            {
                pugovica1.Color = Color.Black;
                pugovica2.Color = Color.Black;
                pugovica3.Color = Color.Black;
                flag = true;
            }
        }
        bool flag = true;
        private void Knopka1_Clicked(object sender, EventArgs e)
        {
            if (flag)
            {
                verh.Opacity = 0;
                lglaz.Opacity = 0;
                pglaz.Opacity = 0;
                rot.Opacity = 0;
                vedro.Opacity = 0;
                vedro2.Opacity = 0;
                flag = false;
            }
            else
            {
                verh.Opacity = 1;
                lglaz.Opacity = 1;
                pglaz.Opacity = 1;
                rot.Opacity = 1;
                vedro.Opacity = 1;
                vedro2.Opacity = 1;
                flag = true;
            }
        }
    }
}