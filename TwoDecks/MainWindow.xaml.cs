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

namespace TwoDecks
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            if (Resources["rightDeck"] is Deck rightDeck)
            {
                rightDeck.Clear();
            }
        }

        private void MoveCard(bool leftToRight)
        {
            if ((Resources["rightDeck"] is Deck rightDeck) && (Resources["leftDeck"] is Deck leftDeck))
            {
                if (leftToRight)
                {
                    if (leftDeckListBox.SelectedItem is Card cardL)
                    {
                        leftDeck.Remove(cardL);
                        rightDeck.Add(cardL);
                    } else
                    {
                        if (rightDeckListBox.SelectedItem is Card cardR)
                        {
                            rightDeck.Remove(cardR);
                            leftDeck.Add(cardR);
                        }
                    }
                }
            }
        }

        private void shuffleLeftDeck_Click(object sender, RoutedEventArgs e)
        {

        }

        private void resetLeftDeck_Click(object sender, RoutedEventArgs e)
        {

        }

        private void clearRightDeck_Click(object sender, RoutedEventArgs e)
        {

        }

        private void sortRightDeck_Click(object sender, RoutedEventArgs e)
        {

        }

        private void leftDeckListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                MoveCard(true);
            }
        }

        private void leftDeckListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MoveCard(true);
        }

        private void rightDeckListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MoveCard(false);
        }

        private void rightDeckListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                MoveCard(false);
            }
        }
    }
}
