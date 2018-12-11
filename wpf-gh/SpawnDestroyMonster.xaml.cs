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
    /// Interaction logic for SpawnDestroyMonster.xaml
    /// </summary>
    public partial class SpawnDestroyMonster : UserControl
    {
        private string LastSpawner = "0";
        public SpawnDestroyMonster()
        {
            InitializeComponent();
        }
        private void SpawnDestroyMonsterClicked(object sender, RoutedEventArgs e)
        {
            if (!SpawnDestroyPopup.IsOpen) { SpawnDestroyPopup.IsOpen = true; }
            else { SpawnDestroyPopup.IsOpen = false; }
            Button source = e.Source as Button;
            int row = 0;
            int column = 0;

            DependencyObject parent = VisualTreeHelper.GetParent(source);
            DependencyObject grandparent = VisualTreeHelper.GetParent(parent);
            DependencyObject grandgrandparent = VisualTreeHelper.GetParent(grandparent);
            DependencyObject grandgrandgrandparent = VisualTreeHelper.GetParent(grandgrandparent);
            string source_name = (string)grandgrandgrandparent.GetValue(NameProperty);
            if (source_name.Last().ToString().Equals("0"))
            {
                row = 10;
                if (Int32.TryParse(source_name[source_name.Length - 3].ToString(), out column))
                {
                    LastSpawner = column.ToString();
                    LastSpawner += row;
                };
            } else
            {
                if (Int32.TryParse(source_name[source_name.Length - 2].ToString(), out column))
                {
                    LastSpawner = column.ToString();
                    if (Int32.TryParse(source_name[source_name.Length - 1].ToString(), out row))
                    {
                        LastSpawner += row;
                    };
                };
            }
            Console.Out.WriteLine(LastSpawner);

        }
        private void ClosePopupClicked(object sender, RoutedEventArgs e)
        {
            if (SpawnDestroyPopup.IsOpen) { SpawnDestroyPopup.IsOpen = false; }
        }
        private void SpawnNormalClicked(object sender, RoutedEventArgs e)
        {
            if (SpawnDestroyPopup.IsOpen) { SpawnDestroyPopup.IsOpen = false; }
            //Button source = e.Source as Button;
            SetHealth(LastSpawner, false, false);
        }
        private void SpawnEliteClicked(object sender, RoutedEventArgs e)
        {
            if (SpawnDestroyPopup.IsOpen) { SpawnDestroyPopup.IsOpen = false; }
            SetHealth(LastSpawner, true, false);
        }

        private void SetHealth(string last_spawner, bool elite, bool removed)
        {
            if (last_spawner.Length >= 2)
            {
                int row = 0;
                int column = 0;
                string health_bar_name = "HealthBar";
                string stat_panel_name = "StatPanel";
                string health = "";

                if (last_spawner.Last().ToString().Equals("0"))
                {
                    row = 10;
                    if (Int32.TryParse(last_spawner.First<char>().ToString(), out column))
                    {
                        health_bar_name += column;
                        health_bar_name += row;
                        stat_panel_name += column;
                        if (elite && !removed)
                        {
                            //health = UITools.FindChild<StatPanel>(root, stat_panel_name).EHealthStat.Text;
                            //UITools.FindChild<HealthBar>(this, health_bar_name).MaxHealth.Text = health;
                            switch (column)
                            {
                                case 1: health = ((MainWindow)System.Windows.Application.Current.MainWindow).StatPanel1.EHealthStat.Text; break;
                                case 2: health = ((MainWindow)System.Windows.Application.Current.MainWindow).StatPanel2.EHealthStat.Text; break;
                                case 3: health = ((MainWindow)System.Windows.Application.Current.MainWindow).StatPanel3.EHealthStat.Text; break;
                                case 4: health = ((MainWindow)System.Windows.Application.Current.MainWindow).StatPanel4.EHealthStat.Text; break;
                                case 5: health = ((MainWindow)System.Windows.Application.Current.MainWindow).StatPanel5.EHealthStat.Text; break;
                                case 6: health = ((MainWindow)System.Windows.Application.Current.MainWindow).StatPanel6.EHealthStat.Text; break;
                                default:
                                    break;
                            }
                        }
                        else if (!elite && !removed)
                        {
                            //health = UITools.FindChild<StatPanel>(root, stat_panel_name).HealthStat.Text;
                            //UITools.FindChild<HealthBar>(this, health_bar_name).MaxHealth.Text = health;
                            switch (column)
                            {
                                case 1: health = ((MainWindow)System.Windows.Application.Current.MainWindow).StatPanel1.HealthStat.Text; break;
                                case 2: health = ((MainWindow)System.Windows.Application.Current.MainWindow).StatPanel2.HealthStat.Text; break;
                                case 3: health = ((MainWindow)System.Windows.Application.Current.MainWindow).StatPanel3.HealthStat.Text; break;
                                case 4: health = ((MainWindow)System.Windows.Application.Current.MainWindow).StatPanel4.HealthStat.Text; break;
                                case 5: health = ((MainWindow)System.Windows.Application.Current.MainWindow).StatPanel5.HealthStat.Text; break;
                                case 6: health = ((MainWindow)System.Windows.Application.Current.MainWindow).StatPanel6.HealthStat.Text; break;
                                default:
                                    break;
                            }
                        }
                    }

                } else
                {
                    if (Int32.TryParse(last_spawner.Last<char>().ToString(), out row))
                    {
                        health_bar_name += row;
                        if (Int32.TryParse(last_spawner.First<char>().ToString(), out column))
                        {
                            health_bar_name += column;
                            stat_panel_name += column;
                            if (elite && !removed)
                            {
                                //health = UITools.FindChild<StatPanel>(root, stat_panel_name).EHealthStat.Text;
                                //UITools.FindChild<HealthBar>(this, health_bar_name).MaxHealth.Text = health;
                                switch (column)
                                {
                                    case 1: health = ((MainWindow)System.Windows.Application.Current.MainWindow).StatPanel1.EHealthStat.Text; break;
                                    case 2: health = ((MainWindow)System.Windows.Application.Current.MainWindow).StatPanel2.EHealthStat.Text; break;
                                    case 3: health = ((MainWindow)System.Windows.Application.Current.MainWindow).StatPanel3.EHealthStat.Text; break;
                                    case 4: health = ((MainWindow)System.Windows.Application.Current.MainWindow).StatPanel4.EHealthStat.Text; break;
                                    case 5: health = ((MainWindow)System.Windows.Application.Current.MainWindow).StatPanel5.EHealthStat.Text; break;
                                    case 6: health = ((MainWindow)System.Windows.Application.Current.MainWindow).StatPanel6.EHealthStat.Text; break;
                                    default:
                                        break;
                                }
                            }
                            else if (!elite && !removed)
                            {
                                //health = UITools.FindChild<StatPanel>(root, stat_panel_name).HealthStat.Text;
                                //UITools.FindChild<HealthBar>(this, health_bar_name).MaxHealth.Text = health;
                                switch (column)
                                {
                                    case 1: health = ((MainWindow)System.Windows.Application.Current.MainWindow).StatPanel1.HealthStat.Text; break;
                                    case 2: health = ((MainWindow)System.Windows.Application.Current.MainWindow).StatPanel2.HealthStat.Text; break;
                                    case 3: health = ((MainWindow)System.Windows.Application.Current.MainWindow).StatPanel3.HealthStat.Text; break;
                                    case 4: health = ((MainWindow)System.Windows.Application.Current.MainWindow).StatPanel4.HealthStat.Text; break;
                                    case 5: health = ((MainWindow)System.Windows.Application.Current.MainWindow).StatPanel5.HealthStat.Text; break;
                                    case 6: health = ((MainWindow)System.Windows.Application.Current.MainWindow).StatPanel6.HealthStat.Text; break;
                                    default:
                                        break;
                                }
                            }
                        };
                    }
                }

                // set main window health controls

                Brush yellow = new SolidColorBrush(Colors.Yellow);
                Brush white = new SolidColorBrush(Colors.White);

                switch (row)
                {
                    case 1:
                        switch (column)
                        {
                            case 1: ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar11.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar11.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster11.SpawnMonster.Background = yellow;
                                } else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster11.SpawnMonster.Background = white;
                                }
                                break;
                            case 2: ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar21.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar21.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster21.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster21.SpawnMonster.Background = white;
                                }
                                break;
                            case 3: ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar31.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar31.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster31.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster31.SpawnMonster.Background = white;
                                }
                                break;
                            case 4: ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar41.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar41.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster41.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster41.SpawnMonster.Background = white;
                                }
                                break;
                            case 5: ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar51.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar51.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster51.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster51.SpawnMonster.Background = white;
                                }
                                break;
                            case 6: ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar61.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar61.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster61.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster61.SpawnMonster.Background = white;
                                }
                                break;
                            default:
                                break;
                        }
                        break;

                    case 2:
                        switch (column)
                        {
                            case 1: ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar12.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar12.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster12.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster12.SpawnMonster.Background = white;
                                }
                                break;
                            case 2: ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar22.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar22.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster22.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster22.SpawnMonster.Background = white;
                                }
                                break;
                            case 3: ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar32.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar32.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster32.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster32.SpawnMonster.Background = white;
                                }
                                break;
                            case 4: ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar42.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar42.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster42.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster42.SpawnMonster.Background = white;
                                }
                                break;
                            case 5: ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar52.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar52.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster52.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster52.SpawnMonster.Background = white;
                                }
                                break;
                            case 6: ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar62.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar62.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster62.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster62.SpawnMonster.Background = white;
                                }
                                break;
                            default:
                                break;
                        }
                        break;
                    case 3:
                        switch (column)
                        {
                            case 1: ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar13.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar13.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster13.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster13.SpawnMonster.Background = white;
                                }
                                break;
                            case 2: ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar23.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar23.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster23.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster23.SpawnMonster.Background = white;
                                }
                                break;
                            case 3: ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar33.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar33.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster33.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster33.SpawnMonster.Background = white;
                                }
                                break;
                            case 4: ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar43.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar43.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster43.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster43.SpawnMonster.Background = white;
                                }
                                break;
                            case 5: ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar53.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar53.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster53.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster53.SpawnMonster.Background = white;
                                }
                                break;
                            case 6: ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar63.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar63.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster63.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster63.SpawnMonster.Background = white;
                                }
                                break;
                            default:
                                break;
                        }
                        break;
                    case 4:
                        switch (column)
                        {
                            case 1: ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar14.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar14.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster14.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster14.SpawnMonster.Background = white;
                                }
                                break;
                            case 2:
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar24.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar24.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster24.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster24.SpawnMonster.Background = white;
                                }
                                break;
                            case 3:
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar34.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar34.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster34.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster34.SpawnMonster.Background = white;
                                }
                                break;
                            case 4:
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar44.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar44.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster44.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster44.SpawnMonster.Background = white;
                                }
                                break;
                            case 5:
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar54.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar54.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster54.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster54.SpawnMonster.Background = white;
                                }
                                break;
                            case 6:
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar64.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar64.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster64.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster64.SpawnMonster.Background = white;
                                }
                                break;
                            default:
                                break;
                        }
                        break;
                    case 5:
                        switch (column)
                        {
                            case 1: ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar15.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar15.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster15.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster15.SpawnMonster.Background = white;
                                }
                                break;
                            case 2:
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar25.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar25.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster25.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster25.SpawnMonster.Background = white;
                                }
                                break;
                            case 3:
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar35.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar35.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster35.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster35.SpawnMonster.Background = white;
                                }
                                break;
                            case 4:
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar45.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar45.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster45.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster45.SpawnMonster.Background = white;
                                }
                                break;
                            case 5:
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar55.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar55.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster55.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster55.SpawnMonster.Background = white;
                                }
                                break;
                            case 6:
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar65.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar65.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster65.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster65.SpawnMonster.Background = white;
                                }
                                break;
                            default:
                                break;
                        }
                        break;
                    case 6:
                        switch (column)
                        {
                            case 1: ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar16.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar16.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster16.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster16.SpawnMonster.Background = white;
                                }
                                break;
                            case 2:
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar26.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar26.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster26.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster26.SpawnMonster.Background = white;
                                }
                                break;
                            case 3:
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar36.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar36.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster36.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster36.SpawnMonster.Background = white;
                                }
                                break;
                            case 4:
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar46.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar46.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster46.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster46.SpawnMonster.Background = white;
                                }
                                break;
                            case 5:
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar56.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar56.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster56.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster56.SpawnMonster.Background = white;
                                }
                                break;
                            case 6:
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar66.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar66.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster66.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster66.SpawnMonster.Background = white;
                                }
                                break;
                            default:
                                break;
                        }
                        break;
                    case 7:
                        switch (column)
                        {
                            case 1: ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar17.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar17.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster17.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster17.SpawnMonster.Background = white;
                                }
                                break;
                            case 2:
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar27.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar27.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster27.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster27.SpawnMonster.Background = white;
                                }
                                break;
                            case 3:
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar37.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar37.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster37.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster37.SpawnMonster.Background = white;
                                }
                                break;
                            case 4:
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar47.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar47.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster47.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster47.SpawnMonster.Background = white;
                                }
                                break;
                            case 5:
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar57.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar57.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster57.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster57.SpawnMonster.Background = white;
                                }
                                break;
                            case 6:
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar67.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar67.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster67.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster67.SpawnMonster.Background = white;
                                }
                                break;
                            default:
                                break;
                        }
                        break;
                    case 8:
                        switch (column)
                        {
                            case 1: ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar18.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar18.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster18.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster18.SpawnMonster.Background = white;
                                }
                                break;
                            case 2:
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar28.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar28.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster28.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster28.SpawnMonster.Background = white;
                                }
                                break;
                            case 3:
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar38.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar38.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster38.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster38.SpawnMonster.Background = white;
                                }
                                break;
                            case 4:
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar48.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar48.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster48.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster48.SpawnMonster.Background = white;
                                }
                                break;
                            case 5:
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar58.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar58.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster58.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster58.SpawnMonster.Background = white;
                                }
                                break;
                            case 6:
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar68.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar68.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster68.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster68.SpawnMonster.Background = white;
                                }
                                break;
                            default:
                                break;
                        }
                        break;
                    case 9:
                        switch (column)
                        {
                            case 1: ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar19.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar19.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster19.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster19.SpawnMonster.Background = white;
                                }
                                break;
                            case 2:
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar29.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar29.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster29.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster29.SpawnMonster.Background = white;
                                }
                                break;
                            case 3:
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar39.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar39.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster39.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster39.SpawnMonster.Background = white;
                                }
                                break;
                            case 4:
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar49.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar49.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster49.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster49.SpawnMonster.Background = white;
                                }
                                break;
                            case 5:
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar59.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar59.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster59.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster59.SpawnMonster.Background = white;
                                }
                                break;
                            case 6:
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar69.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar69.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster69.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster69.SpawnMonster.Background = white;
                                }
                                break;
                            default:
                                break;
                        }
                        break;
                    case 10:
                        switch (column)
                        {
                            case 1: ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar110.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar110.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster110.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster110.SpawnMonster.Background = white;
                                }
                                break;
                            case 2:
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar210.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar210.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster210.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster210.SpawnMonster.Background = white;
                                }
                                break;
                            case 3:
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar310.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar310.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster310.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster310.SpawnMonster.Background = white;
                                }
                                break;
                            case 4:
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar410.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar410.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster410.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster410.SpawnMonster.Background = white;
                                }
                                break;
                            case 5:
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar510.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar510.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster510.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster510.SpawnMonster.Background = white;
                                }
                                break;
                            case 6:
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar610.MaxHealth.Text = health;
                                ((MainWindow)System.Windows.Application.Current.MainWindow).HealthBar610.CurrentHealth.Text = health;
                                if (elite)
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster610.SpawnMonster.Background = yellow;
                                }
                                else
                                {
                                    ((MainWindow)System.Windows.Application.Current.MainWindow).SpawnDestroyMonster610.SpawnMonster.Background = white;
                                }
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }
                
        }

        
        private void RemoveMonsterClicked(object sender, RoutedEventArgs e)
        {
            if (SpawnDestroyPopup.IsOpen) { SpawnDestroyPopup.IsOpen = false; }
            SetHealth(LastSpawner, false, true); // second parameter ("bool elite") effects, e.g., the background color
        }
    }
}
