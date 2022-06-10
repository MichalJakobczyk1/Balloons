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
using System.Windows.Threading;

namespace Baloons
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer gameTimer = new DispatcherTimer();

        int speed = 3;
        int intervals = 90;
        Random rand = new Random();

        List<Rectangle> itemRemover = new List<Rectangle>();
        ImageBrush backgroundImage = new ImageBrush();

        int balloonSkins;
        int i;
        int missedBalloons;
        bool gameIsActive;
        int score;

        MediaPlayer player = new MediaPlayer();
        public MainWindow()
        {
            InitializeComponent();

            gameTimer.Tick += GameEngine;
            gameTimer.Interval = TimeSpan.FromMilliseconds(20);

            backgroundImage.ImageSource = new BitmapImage(new Uri("/images/background.png"));
            MyCanvas.Background = backgroundImage;
        }

        private void GameEngine(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void PopBalloons(object sender, MouseButtonEventArgs e)
        { 
        
        }
        private void StartGame()
        { 
        
        }
    }
}
