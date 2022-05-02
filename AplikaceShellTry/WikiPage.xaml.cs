using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace AplikaceShellTry
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WikiPage : ContentPage
    {
        public static ObservableCollection<VesmirnyObjekt> VesmirnaCollection { get; set; }
        public WikiPage()
        {
            InitializeComponent();
            VesmirnaCollection = new ObservableCollection<VesmirnyObjekt>(
                new VesmirnyObjekt[]
                    {
                    new VesmirnyObjekt {Nazev="Země", Popis="Země je třetí planeta sluneční soustavy se střední vzdáleností od Slunce asi 1 AU, zároveň největší terestrická planeta v soustavě a jediné planetární těleso, na němž je dle současných vědeckých poznatků potvrzen život.", VzdalenostOdSlunce=149.6 },
                    new VesmirnyObjekt {Nazev="Mars", Popis="Mars je čtvrtá planeta sluneční soustavy, druhá nejmenší planeta soustavy po Merkuru. Byla pojmenována po římském bohu války Martovi. Jedná se o planetu terestrického typu, tj. s pevným horninovým povrchem pokrytým impaktními krátery, vysokými sopkami, hlubokými kaňony a dalšími útvary. Má dva měsíce nepravidelného tvaru nazvané Phobos a Deimos.", VzdalenostOdSlunce=227.9 },
                    }); ;
            VesmirneObjListView.ItemsSource = VesmirnaCollection;
        }

        private void DeleteButton_Clicked(object sender, EventArgs e)
        {
            ImageButton b = sender as ImageButton;
            VesmirnaCollection.Remove(b.CommandParameter as VesmirnyObjekt);

        }

        private void AddButton_Clicked(object sender, EventArgs e)
        {
            AddLayout.IsVisible = true;
        }

        private void ButADDConfirm_Clicked(object sender, EventArgs e)
        {
            VesmirnaCollection.Add(new VesmirnyObjekt { Nazev = NameEntry.Text, Popis = PopisEntry.Text, VzdalenostOdSlunce = Convert.ToDouble(VzdalenostEntry.Text) });
            AddLayout.IsVisible = false;
        }
      
        private void InfoButton_Clicked(object sender, EventArgs e)
        {
            ImageButton b = sender as ImageButton;
            VesmirnyObjektPage.vesmirnyObjektNow = b.CommandParameter as VesmirnyObjekt;
            Navigation.PushAsync(new VesmirnyObjektPage());
        }
    }

    public class VesmirnyObjekt
    {
        public string Nazev { get; set; }
        public string Popis { get; set; }
        public double VzdalenostOdSlunce { get; set; }
    }
}