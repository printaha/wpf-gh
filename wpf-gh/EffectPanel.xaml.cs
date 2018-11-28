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

namespace wpf_gh
{
    /// <summary>
    /// Interaction logic for EffectPanel.xaml
    /// </summary>
    public partial class EffectPanel : UserControl
    {
        public EffectPanel()
        {
            InitializeComponent();
        }

        private void ImageOpacitySwitch(object sender, RoutedEventArgs e)
        {
            Button SenderButton = e.Source as Button;
            if (SenderButton.Opacity < 1) { SenderButton.Opacity = 1; }
            else { SenderButton.Opacity = 0.3; }
        }
    }
}
