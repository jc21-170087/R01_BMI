using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace R01_BMI
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        int CM, KG, BMI;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            CM = int.Parse(cm.Text) / 100;
            KG = int.Parse(kg.Text);

            BMI = KG / (CM * CM);

            bmi.Text = BMI.ToString();
            rsl.Text = "計算結果";

        }
    }
}
