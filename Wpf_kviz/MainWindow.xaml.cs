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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_kviz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int lev = 1;

        private string vysledek;
        private string first_value;
        private string second_value;
        private int progress;
        
        private string[,] ot = new string[4, 10] {
            {"10 + 20 =","22 - 11 =","10 * 2 =","150 - 5 =","15 - 15 =","10 + 10 * 0 =","10 * 10 =","96 - 6 =","968 * 5 * 0 =","25 + 25 ="}, // otázka
            {"30","11","20","145","0","10","100","90","0","50"}, //správná odpověď
            {"40","11","20","140","1","0","23","90","0","49"}, //první button
            {"30","28","22","145","0","10","100","25","968","50"} //druhý button

            };
        public MainWindow()
        {  InitializeComponent();



                    Random rnd = new Random(); 
                    int rr = rnd.Next(0, 9);
                    otazka.Content = ot[0, rr];
                    vysledek = ot[1, rr];
                    first_value = ot[2, rr];
                    second_value = ot[3, rr]; 
                    first.Content = first_value;
                    second.Content = second_value;
                    
            
           
          
            prog.Maximum = 10;
            level.Content = 1;
            
            
        }
        private void first_Click(object sender, RoutedEventArgs e)
        {
           if (first_value == vysledek)
            {
                progress++;    
                prog.Value = progress;
                if (progress >= 11)
                {
                    lev++;
                    level.Content = lev;
                    progress = 0;
                    prog.Value = progress;
                }
                
                Random rnd = new Random();
                int rr = rnd.Next(0, 9);
                otazka.Content = ot[0, rr];
                vysledek = ot[1, rr];
                first_value = ot[2, rr];
                second_value = ot[3, rr];
                first.Content = first_value;
                second.Content = second_value;
            }
            else
            {
                if (progress > 0)
                {
                    progress--;
                    prog.Value = progress;
                    Random rnd = new Random();
                    int rr = rnd.Next(0, 9);
                    otazka.Content = ot[0, rr];
                    vysledek = ot[1, rr];
                    first_value = ot[2, rr];
                    second_value = ot[3, rr];
                    first.Content = first_value;
                    second.Content = second_value;
                }
            }  
        }
        private void second_Click(object sender, RoutedEventArgs e)
        {
            if (second_value == vysledek)
            {
                progress++;
                prog.Value = progress;
                if (progress >= 11)
                {
                    lev++;
                    level.Content = lev;
                    progress = 0;
                    prog.Value = progress;
                }
                Random rnd = new Random();
                int rr = rnd.Next(0, 9);
                otazka.Content = ot[0, rr];
                vysledek = ot[1, rr];
                first_value = ot[2, rr];
                second_value = ot[3, rr];
                first.Content = first_value;
                second.Content = second_value;
            }
            else
            {
                if (progress > 0)
                {
                    progress--;
                    prog.Value = progress;
                    Random rnd = new Random();
                    int rr = rnd.Next(0, 9);
                    otazka.Content = ot[0, rr];
                    vysledek = ot[1, rr];
                    first_value = ot[2, rr];
                    second_value = ot[3, rr];
                    first.Content = first_value;
                    second.Content = second_value;
                }
            }
        }

        
    }
}
