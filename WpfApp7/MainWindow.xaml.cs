using System.Text;
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

namespace WpfApp7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            StartPulsingAnimation();
        }
        private void StartPulsingAnimation()
        {

            DoubleAnimation innerAnimation = new DoubleAnimation
            {
                From = 0.0,
                To = 0.5,
                Duration = TimeSpan.FromSeconds(1),
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };


            DoubleAnimation outerAnimation = new DoubleAnimation
            {
                From = 0.5,
                To = 1,
                Duration = TimeSpan.FromSeconds(1),
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };


            InnerStop.BeginAnimation(GradientStop.OffsetProperty, innerAnimation);
            OuterStop.BeginAnimation(GradientStop.OffsetProperty, outerAnimation);
        }
    }
}