using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GeneratorFałszywejTożsamości_Warczak_Kamil
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Generowanie_PESELU_Click(object sender, RoutedEventArgs e)
        {
            int[] mnozniki = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            var fullYear = DateBornPicker.SelectedDate.Value.Year.ToString();
            var halfYear = fullYear.Substring(2, 2);
            var month = DateBornPicker.SelectedDate.Value.Month.ToString();
            var day = DateBornPicker.SelectedDate.Value.Day.ToString();

            int sum = 0;
            for (int i = 0; i < 2; i++)
            {
                sum += mnozniki[i] * int.Parse(halfYear[i].ToString());
            }
            if(month.Length == 2)
            {
                sum += mnozniki[2] * int.Parse(month[0].ToString());
                sum += mnozniki[3] * int.Parse(month[1].ToString());
            }
            else if(month.Length == 1)
            {
                sum += mnozniki[3] * int.Parse(month[0].ToString());
            }

            if(day.Length == 2)
            {
                sum += mnozniki[4] * int.Parse(day[0].ToString());
                sum += mnozniki[5] * int.Parse(day[1].ToString());
            }
            else if(day.Length == 1)
            {
                sum += mnozniki[5] * int.Parse(day[0].ToString());
            }

            var randNumbers = randomNumbers();

            sum += mnozniki[6] * int.Parse(randNumbers[0].ToString());
            sum += mnozniki[7] * int.Parse(randNumbers[1].ToString());
            sum += mnozniki[8] * int.Parse(randNumbers[2].ToString());

            int random = 0;

            if(ComboBox_Płci.SelectedIndex == 0)
            {
                Random r = new Random();
                int[] SexNumberArray = new int[] { 1, 3, 5, 7, 9 };
                int randomIndex = r.Next(SexNumberArray.Length);
                random = SexNumberArray[randomIndex];
                sum += mnozniki[9] * int.Parse(random.ToString());
            }
            else if (ComboBox_Płci.SelectedIndex == 1)
            {
                Random r = new Random();
                int[] SexNumberArray = new int[] { 0, 2, 4, 6, 8 };
                int randomIndex = r.Next(SexNumberArray.Length);
                random = SexNumberArray[randomIndex];
                sum += mnozniki[9] * int.Parse(random.ToString());
            }

            int reszta = sum % 10;
            int liczbaKontrolna = 10 - reszta;


            if (liczbaKontrolna.ToString().Length == 2)
            {
                var resztaString = liczbaKontrolna.ToString()[1];

                if(month.Length == 1)
                {
                    month = "0" + DateBornPicker.SelectedDate.Value.Month.ToString();
                }

                if(day.Length == 1)
                {
                    day = "0" + DateBornPicker.SelectedDate.Value.Day.ToString();
                }
                var pesel = halfYear + month + day + randNumbers + random + resztaString;

                TextBlock_Wygenerowanego_PESELU.Text = $"{pesel}";
                TextBlock_Wygenerowanego_PESELU.Foreground = new SolidColorBrush(Colors.Green);
            }
            else
            {

                if (month.Length == 1)
                {
                    month = "0" + DateBornPicker.SelectedDate.Value.Month.ToString();
                }

                if (day.Length == 1)
                {
                    day = "0" + DateBornPicker.SelectedDate.Value.Day.ToString();
                }

                var pesel = halfYear + month + day + randNumbers + random + liczbaKontrolna;

                TextBlock_Wygenerowanego_PESELU.Text = $"{pesel}";
                TextBlock_Wygenerowanego_PESELU.Foreground = new SolidColorBrush(Colors.Green);
            }

        }

        public static String randomNumbers()
        {
            Random rand = new Random();
            int a = rand.Next(1000);
            String liczba = a.ToString();
            int b = liczba.Length;
            if (b == 1)
            {
                liczba = "00" + liczba;
            }
            else if (b == 2)
            {
                liczba = "0" + liczba;
            }
            else if (b == 3)
            {
                liczba = "" + liczba;
            }
            return (liczba);
        }

        private void MenuItemCreator_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The Creator of this programm is Kamil Warczak.");
        }

        private void ExitToolMenu_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
}
