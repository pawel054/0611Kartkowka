using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AplikacjaMobilna.Tabbed_Page
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        int numbersSum = 0;
        int totalSum = 0;
        public HomePage()
        {
            InitializeComponent();
        }

        private void RzutKoscmi(object sender, EventArgs e)
        {
            int[] randomNumbers = new int[5];
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                randomNumbers[i] = random.Next(1, 7);
            }
            image1.Source = ImageSource.FromFile($"liczba{randomNumbers[0]}.png");
            image2.Source = ImageSource.FromFile($"liczba{randomNumbers[1]}.png");
            image3.Source = ImageSource.FromFile($"liczba{randomNumbers[2]}.png");
            image4.Source = ImageSource.FromFile($"liczba{randomNumbers[3]}.png");
            image5.Source = ImageSource.FromFile($"liczba{randomNumbers[4]}.png");


            for (int i = 1; i <= 6; i++)
            {
                int count = 0;
                for (int j = 0; j<randomNumbers.Length; j++)
                    {
                        if (randomNumbers[j] == i)
                        {
                            count++;
                        }
                    }
                if (count > 1)
                {
                    numbersSum += count * i;
                }
            }

            totalSum += numbersSum;

            wynikLabel.Text = $"Wynik tego losowania: {numbersSum.ToString()}";
            wynikLabel2.Text = $"Wynik gry: {totalSum.ToString()}";
            numbersSum = 0 ;
        }

        private void ResetujWynik(object sender, EventArgs e)
        {
            image1.Source = ImageSource.FromFile("question.png");
            image2.Source = ImageSource.FromFile("question.png");
            image3.Source = ImageSource.FromFile("question.png");
            image4.Source = ImageSource.FromFile("question.png");
            image5.Source = ImageSource.FromFile("question.png");

            totalSum = 0;
            numbersSum = 0;

            wynikLabel.Text = $"Wynik tego losowania: {numbersSum.ToString()}";
            wynikLabel2.Text = $"Wynik gry: {totalSum.ToString()}";
        }
    }
}