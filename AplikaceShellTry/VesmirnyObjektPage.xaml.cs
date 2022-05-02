using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AplikaceShellTry
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VesmirnyObjektPage : ContentPage
    {
        public static VesmirnyObjekt vesmirnyObjektNow;
        public VesmirnyObjektPage()
        {
            BindingContext = vesmirnyObjektNow;
            InitializeComponent();
        }
    }
}