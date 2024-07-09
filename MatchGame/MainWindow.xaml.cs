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

namespace MatchGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SetUpGame();
        }

        private void SetUpGame()
        {
            List<string> animalEmoji = new List<string>()
            {
                "🦁","🐋",
                "🦑","🦢",
                "🐶","🦭",
                "🦋","🦘",
                "🦭","🐋",
                "🦢","🦁",
                "🐶","🦑",
                "🦘","🦋",
                "🦢","🦁",
                "🐶","🦑",
                "🦘","🦋"


            };
            Random random = new Random();

            List<TextBlock> textBlocks = mainGrid.Children.OfType<TextBlock>().ToList();

            foreach (TextBlock textBlock in textBlocks)
            {
                if (animalEmoji.Count == 0)
                    break;

                int index = random.Next(animalEmoji.Count);
                string nextEmoji = animalEmoji[index];
                textBlock.Text = nextEmoji;
                animalEmoji.RemoveAt(index);
            }
        }
    }
}
