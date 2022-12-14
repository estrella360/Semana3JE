using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana3JE
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string user = "jestrella";
            string psw = "12345";
            if (user == txtUser.Text && psw == txtPsw.Text)
            {
                Navigation.PushAsync(new Registro(user));

            }
            else
            {
                DisplayAlert("Alerta", "User/Password Incorrect", "Cerrar");
            }

        }
    }
}