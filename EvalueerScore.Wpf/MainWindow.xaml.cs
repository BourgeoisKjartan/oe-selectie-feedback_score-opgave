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

namespace EvalueerScore.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        // constanten (altijd met hoofdletter beginnen
        // altijd globaal declareren

        const int OkOfNietOk = 1;
        const int OkGoedNietOk = 2;
        const int Gedetailleerd = 3;
        const int GedetailleerdSwitch = 4;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            VulScores();
        }

        void VulScores()
        {
            lstScores.Items.Add(1);
            lstScores.Items.Add(2);
            lstScores.Items.Add(3);
            lstScores.Items.Add(4);
            lstScores.Items.Add(5);
        }


        //Een score minder dan 3 is 'Niet OK', vanaf 3 'OK'

        string GeefScoreFeedBackOkNietOk(int score)
        {

            string feedback;
            if (score < 3)
            {
                feedback = "Niet Ok";
            }
            else
            {
                feedback = "OK";
            }
            return feedback;
        }

        private void btnOkOfNiet_Click(object sender, RoutedEventArgs e)
        {
            EvalueerScore(OkOfNietOk);

        }

        private void EvalueerScore(int methodeNummer)
        {   
            string feedback;
            int score;
            score = (int)lstScores.SelectedItem;
            if (methodeNummer == OkOfNietOk) feedback = GeefScoreFeedBackOkNietOk(score);
            else if (methodeNummer == OkGoedNietOk) feedback = GeefScoreFeedBackOkGoedNietOk(score);
            else if (methodeNummer == Gedetailleerd) feedback = GeefGedetailleerdeFeedback(score);
            else if (methodeNummer == GedetailleerdSwitch) feedback = GeefGedetailleerdeFeedbackMetSwitch(score);
            else feedback = "Geef een geldig nummer";
            //feedback = GeefScoreFeedBackOkNietOk(score);
            lblFeedback.Content = feedback;
        }

        //btnOkGoedNietOk
        //minder dan 3: 'Niet OK'
        //3: 'OK'
        //meer dan 3: 'Goed'

        string GeefScoreFeedBackOkGoedNietOk(int score)
        {
            string feedback;
            if (score < 3)
            {
                feedback = "Niet Ok";
            }
            else if (score == 3)
            {
                feedback = "Ok";
            }
            else
            {
                feedback = "Goed";
            }
            return feedback;
        }

        private void btnOkGoedNietOk_Click(object sender, RoutedEventArgs e)
        {
            EvalueerScore(OkGoedNietOk);
        }

        //btnGedetailleerdeFeedback
            //1: Zwak
            //2: Kan beter
            //3: Goed
            //4: Zeer goed
            //5: Uitstekend Mocht er een andere score gekozen zijn, dan is de feedback: 'Kies een score'

        string GeefGedetailleerdeFeedback(int score)
        {
            string feedback;

            if (score == 1) feedback = "Zwak";
            else if (score == 2) feedback = "Kan beter";
            else if (score == 3) feedback = "Goed";
            else if (score == 4) feedback = "Zeer goed";
            else if (score == 5) feedback = "Uitstekend";
            else feedback = "Kies een score";
            return feedback;
        }

        private void btnGedetailleerdeFeedback_Click(object sender, RoutedEventArgs e)
        {
            //string feedback;
            //int score;
            //score = (int)lstScores.SelectedItem;
            //feedback = GeefGedetailleerdeFeedback(score);
            //lblFeedback.Content = feedback;

            EvalueerScore(Gedetailleerd);
        }

        string GeefGedetailleerdeFeedbackMetSwitch(int score)
        {
            string feedback;

            switch (score)
            {
                case 1:
                    feedback = "Zwak";
                    break;
                case 2:
                    feedback = "Kan beter";
                    break;
                case 3:
                    feedback = "Goed";
                    break;
                case 4:
                    feedback = "Zeer goed";
                    break;
                case 5:
                    feedback = "Uitstekend";
                    break;
                default:
                    feedback = "Kies een score";
                    break;
            }



            //Was met IF & ELSE

            //if (score == 1)
            //{
            //    feedback = "Zwak";
            //}
            //else if (score == 2)
            //{
            //    feedback = "Kan beter";
            //}
            //else if (score == 3) feedback = "Goed";
            //else if (score == 4) feedback = "Zeer goed";
            //else if (score == 5) feedback = "Uitstekend";
            //else feedback = "Kies een score";
            return feedback;
        }

        private void btnOkGoedNietOkSwitch_Click(object sender, RoutedEventArgs e)
        {
            EvalueerScore(GedetailleerdSwitch);
        }
    }
}
