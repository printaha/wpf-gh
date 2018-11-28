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
    /// Interaction logic for HealthBar.xaml
    /// </summary>
    public partial class HealthBar : UserControl
    {
        public HealthBar()
        {
            InitializeComponent();
        }
        private void MinusButtonClicked(object sender, RoutedEventArgs e)
        {
            string health = CurrentHealth.Text;

            int current = 0;

            if (Int32.TryParse(health, out current)) { if (current>0) CurrentHealth.Text = (current-1).ToString(); }
        }

        private void PlusButtonClicked(object sender, RoutedEventArgs e)
        {
            string health = CurrentHealth.Text;
            string max_health = MaxHealth.Text;

            int max = 0;
            int current = 0;

            if (Int32.TryParse(max_health, out max)) {
                if (Int32.TryParse(health, out current)) { if (current < max) CurrentHealth.Text = (current + 1).ToString(); }
            }
            
        }
    }
}
