using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppJogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";
        int jogadas = 0;
        bool ganhou = false;

        public MainPage()
        {
            InitializeComponent();
        }

        public void zerar()
        {
            ganhou = false;
            jogadas = 0;
            btn10.Text = null;
            btn11.Text = null;
            btn12.Text = null;

            btn20.Text = null;
            btn21.Text = null;
            btn22.Text = null;

            btn30.Text = null;
            btn31.Text = null;
            btn32.Text = null;

            btn10.IsEnabled = true;
            btn11.IsEnabled = true;
            btn12.IsEnabled = true;

            btn20.IsEnabled = true;
            btn21.IsEnabled = true;
            btn22.IsEnabled = true;

            btn30.IsEnabled = true;
            btn31.IsEnabled = true;
            btn32.IsEnabled = true;

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.IsEnabled = false;

            if (vez == "X")
            {
                btn.Text = "X";
                vez = "O";
            }
            else
            {
                btn.Text = "O";
                vez = "X";
            }

            jogadas++;

            if (btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X")
            {
                DisplayAlert("Parabéns", "O X Ganhou!", "Ok");
                ganhou = true;
                zerar();
            }

            if (btn20.Text == "X" && btn21.Text == "X" && btn22.Text == "X")
            {
                DisplayAlert("Parabéns", "O X Ganhou!", "Ok");
                ganhou = true;
                zerar();
            }

            if (btn30.Text == "X" && btn31.Text == "X" && btn32.Text == "X")
            {
                DisplayAlert("Parabéns", "O X Ganhou!", "Ok");
                ganhou = true;
                zerar();
            }

            

            if (jogadas == 9 && ganhou == false)
            {
                DisplayAlert(":(", "Deu velha", "Ok");
            }



        }
    }
}
