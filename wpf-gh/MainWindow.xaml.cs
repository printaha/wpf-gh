using System;
using System.Collections.Generic;
using System.IO;
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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace wpf_gh
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string GlobalDifficulty = "0";
        private int GlobalRound = 1;
        public MainWindow()
        {
            InitializeComponent();
            SpawnDestroyMonster11.MonsterNumberText.Text = "1";
            SpawnDestroyMonster12.MonsterNumberText.Text = "2";
            SpawnDestroyMonster13.MonsterNumberText.Text = "3";
            SpawnDestroyMonster14.MonsterNumberText.Text = "4";
            SpawnDestroyMonster15.MonsterNumberText.Text = "5";
            SpawnDestroyMonster16.MonsterNumberText.Text = "6";
            SpawnDestroyMonster17.MonsterNumberText.Text = "7";
            SpawnDestroyMonster18.MonsterNumberText.Text = "8";
            SpawnDestroyMonster19.MonsterNumberText.Text = "9";
            SpawnDestroyMonster110.MonsterNumberText.Text = "10";
            SpawnDestroyMonster21.MonsterNumberText.Text = "1";
            SpawnDestroyMonster22.MonsterNumberText.Text = "2";
            SpawnDestroyMonster23.MonsterNumberText.Text = "3";
            SpawnDestroyMonster24.MonsterNumberText.Text = "4";
            SpawnDestroyMonster25.MonsterNumberText.Text = "5";
            SpawnDestroyMonster26.MonsterNumberText.Text = "6";
            SpawnDestroyMonster27.MonsterNumberText.Text = "7";
            SpawnDestroyMonster28.MonsterNumberText.Text = "8";
            SpawnDestroyMonster29.MonsterNumberText.Text = "9";
            SpawnDestroyMonster210.MonsterNumberText.Text = "10";
            SpawnDestroyMonster31.MonsterNumberText.Text = "1";
            SpawnDestroyMonster32.MonsterNumberText.Text = "2";
            SpawnDestroyMonster33.MonsterNumberText.Text = "3";
            SpawnDestroyMonster34.MonsterNumberText.Text = "4";
            SpawnDestroyMonster35.MonsterNumberText.Text = "5";
            SpawnDestroyMonster36.MonsterNumberText.Text = "6";
            SpawnDestroyMonster37.MonsterNumberText.Text = "7";
            SpawnDestroyMonster38.MonsterNumberText.Text = "8";
            SpawnDestroyMonster39.MonsterNumberText.Text = "9";
            SpawnDestroyMonster310.MonsterNumberText.Text = "10";
            SpawnDestroyMonster41.MonsterNumberText.Text = "1";
            SpawnDestroyMonster42.MonsterNumberText.Text = "2";
            SpawnDestroyMonster43.MonsterNumberText.Text = "3";
            SpawnDestroyMonster44.MonsterNumberText.Text = "4";
            SpawnDestroyMonster45.MonsterNumberText.Text = "5";
            SpawnDestroyMonster46.MonsterNumberText.Text = "6";
            SpawnDestroyMonster47.MonsterNumberText.Text = "7";
            SpawnDestroyMonster48.MonsterNumberText.Text = "8";
            SpawnDestroyMonster49.MonsterNumberText.Text = "9";
            SpawnDestroyMonster410.MonsterNumberText.Text = "10";
            SpawnDestroyMonster51.MonsterNumberText.Text = "1";
            SpawnDestroyMonster52.MonsterNumberText.Text = "2";
            SpawnDestroyMonster53.MonsterNumberText.Text = "3";
            SpawnDestroyMonster54.MonsterNumberText.Text = "4";
            SpawnDestroyMonster55.MonsterNumberText.Text = "5";
            SpawnDestroyMonster56.MonsterNumberText.Text = "6";
            SpawnDestroyMonster57.MonsterNumberText.Text = "7";
            SpawnDestroyMonster58.MonsterNumberText.Text = "8";
            SpawnDestroyMonster59.MonsterNumberText.Text = "9";
            SpawnDestroyMonster510.MonsterNumberText.Text = "10";
            SpawnDestroyMonster61.MonsterNumberText.Text = "1";
            SpawnDestroyMonster62.MonsterNumberText.Text = "2";
            SpawnDestroyMonster63.MonsterNumberText.Text = "3";
            SpawnDestroyMonster64.MonsterNumberText.Text = "4";
            SpawnDestroyMonster65.MonsterNumberText.Text = "5";
            SpawnDestroyMonster66.MonsterNumberText.Text = "6";
            SpawnDestroyMonster67.MonsterNumberText.Text = "7";
            SpawnDestroyMonster68.MonsterNumberText.Text = "8";
            SpawnDestroyMonster69.MonsterNumberText.Text = "9";
            SpawnDestroyMonster610.MonsterNumberText.Text = "10";
        }
        /*
        public void SetHealth(Button source, Boolean elite)
        {
            string source_name = source.Name;
            int source_name_length = source_name.Length;
            int row;
            int column;
            string health_bar_name = "HealthBar";
            string stat_panel_name = "StatPanel";
            
            if (source_name.Last().Equals("0"))
            {
                row = 10;
                if (Int32.TryParse(source_name[source_name_length - 3].ToString(), out column))
                {
                    health_bar_name += column;
                    health_bar_name += row;
                    stat_panel_name += column;
                    if (elite)
                    {
                        string elite_health = UITools.FindChild<StatPanel>(this, stat_panel_name).EHealthStat.Text;
                        UITools.FindChild<HealthBar>(this, health_bar_name).MaxHealth.Text = elite_health;
                    } else
                    {
                        string normal_health = UITools.FindChild<StatPanel>(this, stat_panel_name).HealthStat.Text;
                        UITools.FindChild<HealthBar>(this, health_bar_name).MaxHealth.Text = normal_health;
                    }
                }
            }
            else
            {
                if (Int32.TryParse(source_name[source_name_length - 1].ToString(), out row))
                {
                    health_bar_name += row;
                    if (Int32.TryParse(source_name[source_name_length - 2].ToString(), out column))
                    {
                        health_bar_name += column;
                        stat_panel_name += column;
                        if (elite)
                        {
                            string elite_health = UITools.FindChild<StatPanel>(this, stat_panel_name).EHealthStat.Text;
                            UITools.FindChild<HealthBar>(this, health_bar_name).MaxHealth.Text = elite_health;
                        }
                        else
                        {
                            string normal_health = UITools.FindChild<StatPanel>(this, stat_panel_name).HealthStat.Text;
                            UITools.FindChild<HealthBar>(this, health_bar_name).MaxHealth.Text = normal_health;
                        }
                    };
                }
            }
        }
        */

        private void Monster1Locked(object sender, RoutedEventArgs e)
        {
            if (LockMonster1.IsChecked == true & MonsterList1.SelectedIndex != -1) {
                string monster_type = MonsterList1.Text;
                string monster_name = monster_type.Substring(0, monster_type.Length - 4).Trim();
                Monster1.Text = monster_type;
                MonsterList1.IsEnabled = false;
                string monster_stats = File.ReadAllText("monsterstats/monster_stats.json");
                JObject o = JObject.Parse(monster_stats);
                int diff = 0;
                Int32.TryParse(GlobalDifficulty, out diff);
                JToken jmonster = o.SelectToken("$['monsters']['" + monster_name + "']['level'][?(@.level == " + diff + ")]");
                JToken j_normal = jmonster.SelectToken("$.normal");
                JToken j_elite = jmonster.SelectToken("$.elite");
                string testjelite = j_elite.ToString();
                string normal_health = (string)j_normal.SelectToken("health");
                string elite_health = (string)j_elite.SelectToken("health");
                string normal_move = (string)j_normal.SelectToken("move");
                string elite_move = (string)j_elite.SelectToken("move");
                string normal_attack = (string)j_normal.SelectToken("attack");
                string elite_attack = (string)j_elite.SelectToken("attack");
                string normal_range = (string)j_normal.SelectToken("range");
                if (normal_range.Equals("0")) normal_range = "-";
                string elite_range = (string)j_elite.SelectToken("range");
                if (elite_range.Equals("0")) elite_range = "-";

                StatPanel1.HealthStat.Text = normal_health;
                StatPanel1.EHealthStat.Text = elite_health;
                StatPanel1.MoveStat.Text = normal_move;
                StatPanel1.EMoveStat.Text = elite_move;
                StatPanel1.AttackStat.Text = normal_attack;
                StatPanel1.EAttackStat.Text = elite_attack;
                StatPanel1.RangeStat.Text = normal_range;
                StatPanel1.ERangeStat.Text = elite_range;

                JToken j_attributes_normal = j_normal.SelectToken("attributes");
                JToken j_attributes_elite = j_elite.SelectToken("attributes");
                string attributes_normal = j_attributes_normal.ToString().ToLower();
                string attributes_elite = j_attributes_elite.ToString().ToLower();

                if (attributes_normal.Contains("flying")) { StatPanel1.Flying.Opacity = 1; }
                else { StatPanel1.Flying.Opacity = 0.25; }
                if (attributes_elite.Contains("flying")) { StatPanel1.EFlying.Opacity = 1; }
                else { StatPanel1.EFlying.Opacity = 0.25; }
                if (attributes_normal.Contains("curse")) { StatPanel1.Curse.Opacity = 1; }
                else { StatPanel1.Curse.Opacity = 0.25; }
                if (attributes_elite.Contains("curse")) { StatPanel1.ECurse.Opacity = 1; }
                else { StatPanel1.ECurse.Opacity = 0.25; }
                if (attributes_normal.Contains("disarm")) { StatPanel1.Disarm.Opacity = 1; }
                else { StatPanel1.Disarm.Opacity = 0.25; }
                if (attributes_elite.Contains("disarm")) { StatPanel1.EDisarm.Opacity = 1; }
                else { StatPanel1.EDisarm.Opacity = 0.25; }
                if (attributes_normal.Contains("immobilize")) { StatPanel1.Immobilize.Opacity = 1; }
                else { StatPanel1.Immobilize.Opacity = 0.25; }
                if (attributes_elite.Contains("immobilize")) { StatPanel1.EImmobilize.Opacity = 1; }
                else { StatPanel1.EImmobilize.Opacity = 0.25; }
                if (attributes_normal.Contains("muddle")) { StatPanel1.Muddle.Opacity = 1; }
                else { StatPanel1.Muddle.Opacity = 0.25; }
                if (attributes_elite.Contains("muddle")) { StatPanel1.EMuddle.Opacity = 1; }
                else { StatPanel1.EMuddle.Opacity = 0.25; }
                if (attributes_normal.Contains("poison")) { StatPanel1.Poison.Opacity = 1; }
                else { StatPanel1.Poison.Opacity = 0.25; }
                if (attributes_elite.Contains("poison")) { StatPanel1.EPoison.Opacity = 1; }
                else { StatPanel1.EPoison.Opacity = 0.25; }
                if (attributes_normal.Contains("stun")) { StatPanel1.Stun.Opacity = 1; }
                else { StatPanel1.Stun.Opacity = 0.25; }
                if (attributes_elite.Contains("stun")) { StatPanel1.EStun.Opacity = 1; }
                else { StatPanel1.EStun.Opacity = 0.25; }
                if (attributes_normal.Contains("wound")) { StatPanel1.Wound.Opacity = 1; }
                else { StatPanel1.Wound.Opacity = 0.25; }
                if (attributes_elite.Contains("wound")) { StatPanel1.EWound.Opacity = 1; }
                else { StatPanel1.EWound.Opacity = 0.25; }
                //IJEnumerable<JToken> attrs = j_attributes_normal.Values();
                List<string> attr_strings_normal = new List<string>();
                foreach (var value in j_attributes_normal.Children())
                {
                    attr_strings_normal.Add(value.ToString().ToLower());
                }
                string retaliate_value = "-";
                string retaliate_range = "-";
                StatPanel1.RetaliateStat.Text = retaliate_value;
                if (attributes_normal.Contains("retaliate")) // somewhat redundant
                {
                    StatPanel1.Retaliate.Opacity = 1;
                    for (int i = 0; i < attr_strings_normal.Count; i++)
                    {
                        if (attr_strings_normal[i].Contains("retaliate"))
                        {
                            retaliate_value = attr_strings_normal[i].Split(' ')[1][0].ToString();
                            StatPanel1.RetaliateStat.Text = retaliate_value;
                            if (attr_strings_normal[i].Contains("range"))
                            {
                                retaliate_range = attr_strings_normal[i].Split(' ')[3][0].ToString();
                                StatPanel1.RetaliateStat.Text = retaliate_value + ", Range " + retaliate_range;
                            }
                            i = attr_strings_normal.Count;
                        }
                    }
                } else { StatPanel1.Retaliate.Opacity = 0.25; }
                List<string> attr_strings_elite = new List<string>();
                foreach (var value in j_attributes_elite.Children())
                {
                    attr_strings_elite.Add(value.ToString().ToLower());
                }
                retaliate_value = "-";
                retaliate_range = "-";
                StatPanel1.ERetaliateStat.Text = retaliate_value;
                if (attributes_elite.Contains("retaliate"))
                {
                    StatPanel1.Retaliate.Opacity = 1;
                    for (int i = 0; i < attr_strings_elite.Count; i++)
                    {
                        if (attr_strings_elite[i].Contains("retaliate"))
                        {
                            retaliate_value = attr_strings_elite[i].Split(' ')[1][0].ToString();
                            StatPanel1.ERetaliateStat.Text = retaliate_value;
                            if (attr_strings_elite[i].Contains("range"))
                            {
                                retaliate_range = attr_strings_elite[i].Split(' ')[3][0].ToString();
                                StatPanel1.ERetaliateStat.Text = retaliate_value + ", Range " + retaliate_range;
                            }
                            i = attr_strings_elite.Count;
                        }
                    }
                } else { StatPanel1.Retaliate.Opacity = 0.25; }
                
                string pierce_value = "-";
                StatPanel1.PierceStat.Text = pierce_value;
                if (attributes_normal.Contains("pierce")) // somewhat redundant
                {
                    StatPanel1.Pierce.Opacity = 1;
                    for (int i = 0; i < attr_strings_normal.Count; i++)
                    {
                        if (attr_strings_normal[i].Contains("pierce"))
                        {
                            pierce_value = attr_strings_normal[i].Split(' ')[1][0].ToString();
                            StatPanel1.PierceStat.Text = pierce_value;
                            i = attr_strings_normal.Count;
                        }
                    }
                }
                else { StatPanel1.Pierce.Opacity = 0.25; }

                foreach (var value in j_attributes_elite.Children())
                {
                    attr_strings_elite.Add(value.ToString().ToLower());
                }
                pierce_value = "-";
                StatPanel1.EPierceStat.Text = pierce_value;
                if (attributes_elite.Contains("pierce"))
                {
                    StatPanel1.Pierce.Opacity = 1;
                    for (int i = 0; i < attr_strings_elite.Count; i++)
                    {
                        if (attr_strings_elite[i].Contains("pierce"))
                        {
                            pierce_value = attr_strings_elite[i].Split(' ')[1][0].ToString();
                            StatPanel1.EPierceStat.Text = pierce_value;
                            i = attr_strings_elite.Count;
                        }
                    }
                }
                else { StatPanel1.Pierce.Opacity = 0.25; }

                string targets_value = "-";
                StatPanel1.TargetsStat.Text = targets_value;
                if (attributes_normal.Contains("target")) // somewhat redundant
                {
                    StatPanel1.Targets.Opacity = 1;
                    for (int i = 0; i < attr_strings_normal.Count; i++)
                    {
                        if (attr_strings_normal[i].Contains("target"))
                        {
                            targets_value = attr_strings_normal[i].Split(' ')[1][0].ToString();
                            StatPanel1.TargetsStat.Text = targets_value;
                            i = attr_strings_normal.Count;
                        }
                    }
                }
                else { StatPanel1.Targets.Opacity = 0.25; }

                foreach (var value in j_attributes_elite.Children())
                {
                    attr_strings_elite.Add(value.ToString().ToLower());
                }
                targets_value = "-";
                StatPanel1.ETargetsStat.Text = targets_value;
                if (attributes_elite.Contains("target"))
                {
                    StatPanel1.Targets.Opacity = 1;
                    for (int i = 0; i < attr_strings_elite.Count; i++)
                    {
                        if (attr_strings_elite[i].Contains("target"))
                        {
                            targets_value = attr_strings_elite[i].Split(' ')[1][0].ToString();
                            StatPanel1.ETargetsStat.Text = targets_value;
                            i = attr_strings_elite.Count;
                        }
                    }
                }
                else { StatPanel1.Targets.Opacity = 0.25; }

                string shield_value = "-";
                StatPanel1.ShieldStat.Text = shield_value;
                if (attributes_normal.Contains("shield")) // somewhat redundant
                {
                    StatPanel1.Shield.Opacity = 1;
                    for (int i = 0; i < attr_strings_normal.Count; i++)
                    {
                        if (attr_strings_normal[i].Contains("shield"))
                        {
                            shield_value = attr_strings_normal[i].Split(' ')[1][0].ToString();
                            StatPanel1.ShieldStat.Text = shield_value;
                            i = attr_strings_normal.Count;
                        }
                    }
                }
                else { StatPanel1.Shield.Opacity = 0.25; }

                foreach (var value in j_attributes_elite.Children())
                {
                    attr_strings_elite.Add(value.ToString().ToLower());
                }
                shield_value = "-";
                StatPanel1.EShieldStat.Text = shield_value;
                if (attributes_elite.Contains("shield"))
                {
                    StatPanel1.Shield.Opacity = 1;
                    for (int i = 0; i < attr_strings_elite.Count; i++)
                    {
                        if (attr_strings_elite[i].Contains("shield"))
                        {
                            shield_value = attr_strings_elite[i].Split(' ')[1][0].ToString();
                            StatPanel1.EShieldStat.Text = shield_value;
                            i = attr_strings_elite.Count;
                        }
                    }
                }
                else { StatPanel1.Shield.Opacity = 0.25; }

                if (attributes_normal.Contains("disadvantage"))
                {
                    StatPanel1.NormalText.Text = "Normal [Atks. gain Disadv.]";
                } else
                {
                    StatPanel1.NormalText.Text = "Normal";
                }
                if (attributes_elite.Contains("disadvantage"))
                {
                    StatPanel1.EliteText.Text = "Elite [Atks. gain Disadv.]";
                }
                else
                {
                    StatPanel1.EliteText.Text = "Elite";
                }

            } else if (LockMonster1.IsChecked == true)
            {
                MonsterList1.IsEnabled = false;
            }

            if (LockMonster1.IsChecked == false) { MonsterList1.IsEnabled = true; }
        }

        private void Monster2Locked(object sender, RoutedEventArgs e)
        {
            if (LockMonster2.IsChecked == true & MonsterList2.SelectedIndex != -1)
            {
                string monster_type = MonsterList2.Text;
                string monster_name = monster_type.Substring(0, monster_type.Length - 4).Trim();
                Monster2.Text = monster_type;
                MonsterList2.IsEnabled = false;
                string monster_stats = File.ReadAllText("monsterstats/monster_stats.json");
                JObject o = JObject.Parse(monster_stats);
                int diff = 0;
                Int32.TryParse(GlobalDifficulty, out diff);
                JToken jmonster = o.SelectToken("$['monsters']['" + monster_name + "']['level'][?(@.level == " + diff + ")]");
                JToken j_normal = jmonster.SelectToken("$.normal");
                JToken j_elite = jmonster.SelectToken("$.elite");
                string testjelite = j_elite.ToString();
                string normal_health = (string)j_normal.SelectToken("health");
                string elite_health = (string)j_elite.SelectToken("health");
                string normal_move = (string)j_normal.SelectToken("move");
                string elite_move = (string)j_elite.SelectToken("move");
                string normal_attack = (string)j_normal.SelectToken("attack");
                string elite_attack = (string)j_elite.SelectToken("attack");
                string normal_range = (string)j_normal.SelectToken("range");
                if (normal_range.Equals("0")) normal_range = "-";
                string elite_range = (string)j_elite.SelectToken("range");
                if (elite_range.Equals("0")) elite_range = "-";

                StatPanel2.HealthStat.Text = normal_health;
                StatPanel2.EHealthStat.Text = elite_health;
                StatPanel2.MoveStat.Text = normal_move;
                StatPanel2.EMoveStat.Text = elite_move;
                StatPanel2.AttackStat.Text = normal_attack;
                StatPanel2.EAttackStat.Text = elite_attack;
                StatPanel2.RangeStat.Text = normal_range;
                StatPanel2.ERangeStat.Text = elite_range;

                JToken j_attributes_normal = j_normal.SelectToken("attributes");
                JToken j_attributes_elite = j_elite.SelectToken("attributes");
                string attributes_normal = j_attributes_normal.ToString().ToLower();
                string attributes_elite = j_attributes_elite.ToString().ToLower();

                if (attributes_normal.Contains("flying")) { StatPanel2.Flying.Opacity = 1; }
                else { StatPanel2.Flying.Opacity = 0.25; }
                if (attributes_elite.Contains("flying")) { StatPanel2.EFlying.Opacity = 1; }
                else { StatPanel2.EFlying.Opacity = 0.25; }
                if (attributes_normal.Contains("curse")) { StatPanel2.Curse.Opacity = 1; }
                else { StatPanel2.Curse.Opacity = 0.25; }
                if (attributes_elite.Contains("curse")) { StatPanel2.ECurse.Opacity = 1; }
                else { StatPanel2.ECurse.Opacity = 0.25; }
                if (attributes_normal.Contains("disarm")) { StatPanel2.Disarm.Opacity = 1; }
                else { StatPanel2.Disarm.Opacity = 0.25; }
                if (attributes_elite.Contains("disarm")) { StatPanel2.EDisarm.Opacity = 1; }
                else { StatPanel2.EDisarm.Opacity = 0.25; }
                if (attributes_normal.Contains("immobilize")) { StatPanel2.Immobilize.Opacity = 1; }
                else { StatPanel2.Immobilize.Opacity = 0.25; }
                if (attributes_elite.Contains("immobilize")) { StatPanel2.EImmobilize.Opacity = 1; }
                else { StatPanel2.EImmobilize.Opacity = 0.25; }
                if (attributes_normal.Contains("muddle")) { StatPanel2.Muddle.Opacity = 1; }
                else { StatPanel2.Muddle.Opacity = 0.25; }
                if (attributes_elite.Contains("muddle")) { StatPanel2.EMuddle.Opacity = 1; }
                else { StatPanel2.EMuddle.Opacity = 0.25; }
                if (attributes_normal.Contains("poison")) { StatPanel2.Poison.Opacity = 1; }
                else { StatPanel2.Poison.Opacity = 0.25; }
                if (attributes_elite.Contains("poison")) { StatPanel2.EPoison.Opacity = 1; }
                else { StatPanel2.EPoison.Opacity = 0.25; }
                if (attributes_normal.Contains("stun")) { StatPanel2.Stun.Opacity = 1; }
                else { StatPanel2.Stun.Opacity = 0.25; }
                if (attributes_elite.Contains("stun")) { StatPanel2.EStun.Opacity = 1; }
                else { StatPanel2.EStun.Opacity = 0.25; }
                if (attributes_normal.Contains("wound")) { StatPanel2.Wound.Opacity = 1; }
                else { StatPanel2.Wound.Opacity = 0.25; }
                if (attributes_elite.Contains("wound")) { StatPanel2.EWound.Opacity = 1; }
                else { StatPanel2.EWound.Opacity = 0.25; }
                //IJEnumerable<JToken> attrs = j_attributes_normal.Values();
                List<string> attr_strings_normal = new List<string>();
                foreach (var value in j_attributes_normal.Children())
                {
                    attr_strings_normal.Add(value.ToString().ToLower());
                }
                string retaliate_value = "-";
                string retaliate_range = "-";
                StatPanel2.RetaliateStat.Text = retaliate_value;
                if (attributes_normal.Contains("retaliate")) // somewhat redundant
                {
                    StatPanel2.Retaliate.Opacity = 1;
                    for (int i = 0; i < attr_strings_normal.Count; i++)
                    {
                        if (attr_strings_normal[i].Contains("retaliate"))
                        {
                            retaliate_value = attr_strings_normal[i].Split(' ')[1][0].ToString();
                            StatPanel2.RetaliateStat.Text = retaliate_value;
                            if (attr_strings_normal[i].Contains("range"))
                            {
                                retaliate_range = attr_strings_normal[i].Split(' ')[3][0].ToString();
                                StatPanel2.RetaliateStat.Text = retaliate_value + ", Range " + retaliate_range;
                            }
                            i = attr_strings_normal.Count;
                        }
                    }
                }
                else { StatPanel2.Retaliate.Opacity = 0.25; }
                List<string> attr_strings_elite = new List<string>();
                foreach (var value in j_attributes_elite.Children())
                {
                    attr_strings_elite.Add(value.ToString().ToLower());
                }
                retaliate_value = "-";
                retaliate_range = "-";
                StatPanel2.ERetaliateStat.Text = retaliate_value;
                if (attributes_elite.Contains("retaliate"))
                {
                    StatPanel2.Retaliate.Opacity = 1;
                    for (int i = 0; i < attr_strings_elite.Count; i++)
                    {
                        if (attr_strings_elite[i].Contains("retaliate"))
                        {
                            retaliate_value = attr_strings_elite[i].Split(' ')[1][0].ToString();
                            StatPanel2.ERetaliateStat.Text = retaliate_value;
                            if (attr_strings_elite[i].Contains("range"))
                            {
                                retaliate_range = attr_strings_elite[i].Split(' ')[3][0].ToString();
                                StatPanel2.ERetaliateStat.Text = retaliate_value + ", Range " + retaliate_range;
                            }
                            i = attr_strings_elite.Count;
                        }
                    }
                }
                else { StatPanel2.Retaliate.Opacity = 0.25; }

                string pierce_value = "-";
                StatPanel2.PierceStat.Text = pierce_value;
                if (attributes_normal.Contains("pierce")) // somewhat redundant
                {
                    StatPanel2.Pierce.Opacity = 1;
                    for (int i = 0; i < attr_strings_normal.Count; i++)
                    {
                        if (attr_strings_normal[i].Contains("pierce"))
                        {
                            pierce_value = attr_strings_normal[i].Split(' ')[1][0].ToString();
                            StatPanel2.PierceStat.Text = pierce_value;
                            i = attr_strings_normal.Count;
                        }
                    }
                }
                else { StatPanel2.Pierce.Opacity = 0.25; }

                foreach (var value in j_attributes_elite.Children())
                {
                    attr_strings_elite.Add(value.ToString().ToLower());
                }
                pierce_value = "-";
                StatPanel2.EPierceStat.Text = pierce_value;
                if (attributes_elite.Contains("pierce"))
                {
                    StatPanel2.Pierce.Opacity = 1;
                    for (int i = 0; i < attr_strings_elite.Count; i++)
                    {
                        if (attr_strings_elite[i].Contains("pierce"))
                        {
                            pierce_value = attr_strings_elite[i].Split(' ')[1][0].ToString();
                            StatPanel2.EPierceStat.Text = pierce_value;
                            i = attr_strings_elite.Count;
                        }
                    }
                }
                else { StatPanel2.Pierce.Opacity = 0.25; }

                string targets_value = "-";
                StatPanel2.TargetsStat.Text = targets_value;
                if (attributes_normal.Contains("target")) // somewhat redundant
                {
                    StatPanel2.Targets.Opacity = 1;
                    for (int i = 0; i < attr_strings_normal.Count; i++)
                    {
                        if (attr_strings_normal[i].Contains("target"))
                        {
                            targets_value = attr_strings_normal[i].Split(' ')[1][0].ToString();
                            StatPanel2.TargetsStat.Text = targets_value;
                            i = attr_strings_normal.Count;
                        }
                    }
                }
                else { StatPanel2.Targets.Opacity = 0.25; }

                foreach (var value in j_attributes_elite.Children())
                {
                    attr_strings_elite.Add(value.ToString().ToLower());
                }
                targets_value = "-";
                StatPanel2.ETargetsStat.Text = targets_value;
                if (attributes_elite.Contains("target"))
                {
                    StatPanel2.Targets.Opacity = 1;
                    for (int i = 0; i < attr_strings_elite.Count; i++)
                    {
                        if (attr_strings_elite[i].Contains("target"))
                        {
                            targets_value = attr_strings_elite[i].Split(' ')[1][0].ToString();
                            StatPanel2.ETargetsStat.Text = targets_value;
                            i = attr_strings_elite.Count;
                        }
                    }
                }
                else { StatPanel2.Targets.Opacity = 0.25; }

                string shield_value = "-";
                StatPanel2.ShieldStat.Text = shield_value;
                if (attributes_normal.Contains("shield")) // somewhat redundant
                {
                    StatPanel2.Shield.Opacity = 1;
                    for (int i = 0; i < attr_strings_normal.Count; i++)
                    {
                        if (attr_strings_normal[i].Contains("shield"))
                        {
                            shield_value = attr_strings_normal[i].Split(' ')[1][0].ToString();
                            StatPanel2.ShieldStat.Text = shield_value;
                            i = attr_strings_normal.Count;
                        }
                    }
                }
                else { StatPanel2.Shield.Opacity = 0.25; }

                foreach (var value in j_attributes_elite.Children())
                {
                    attr_strings_elite.Add(value.ToString().ToLower());
                }
                shield_value = "-";
                StatPanel2.EShieldStat.Text = shield_value;
                if (attributes_elite.Contains("shield"))
                {
                    StatPanel2.Shield.Opacity = 1;
                    for (int i = 0; i < attr_strings_elite.Count; i++)
                    {
                        if (attr_strings_elite[i].Contains("shield"))
                        {
                            shield_value = attr_strings_elite[i].Split(' ')[1][0].ToString();
                            StatPanel2.EShieldStat.Text = shield_value;
                            i = attr_strings_elite.Count;
                        }
                    }
                }
                else { StatPanel2.Shield.Opacity = 0.25; }

                if (attributes_normal.Contains("disadvantage"))
                {
                    StatPanel2.NormalText.Text = "Normal [Atks. gain Disadv.]";
                }
                else
                {
                    StatPanel2.NormalText.Text = "Normal";
                }
                if (attributes_elite.Contains("disadvantage"))
                {
                    StatPanel2.EliteText.Text = "Elite [Atks. gain Disadv.]";
                }
                else
                {
                    StatPanel2.EliteText.Text = "Elite";
                }

            }
            else if (LockMonster2.IsChecked == true)
            {
                MonsterList2.IsEnabled = false;
            }

            if (LockMonster2.IsChecked == false) { MonsterList2.IsEnabled = true; }
        }

        private void Monster3Locked(object sender, RoutedEventArgs e)
        {
            if (LockMonster3.IsChecked == true & MonsterList3.SelectedIndex != -1)
            {
                string monster_type = MonsterList3.Text;
                string monster_name = monster_type.Substring(0, monster_type.Length - 4).Trim();
                Monster3.Text = monster_type;
                MonsterList3.IsEnabled = false;
                string monster_stats = File.ReadAllText("monsterstats/monster_stats.json");
                JObject o = JObject.Parse(monster_stats);
                int diff = 0;
                Int32.TryParse(GlobalDifficulty, out diff);
                JToken jmonster = o.SelectToken("$['monsters']['" + monster_name + "']['level'][?(@.level == " + diff + ")]");
                JToken j_normal = jmonster.SelectToken("$.normal");
                JToken j_elite = jmonster.SelectToken("$.elite");
                string testjelite = j_elite.ToString();
                string normal_health = (string)j_normal.SelectToken("health");
                string elite_health = (string)j_elite.SelectToken("health");
                string normal_move = (string)j_normal.SelectToken("move");
                string elite_move = (string)j_elite.SelectToken("move");
                string normal_attack = (string)j_normal.SelectToken("attack");
                string elite_attack = (string)j_elite.SelectToken("attack");
                string normal_range = (string)j_normal.SelectToken("range");
                if (normal_range.Equals("0")) normal_range = "-";
                string elite_range = (string)j_elite.SelectToken("range");
                if (elite_range.Equals("0")) elite_range = "-";

                StatPanel3.HealthStat.Text = normal_health;
                StatPanel3.EHealthStat.Text = elite_health;
                StatPanel3.MoveStat.Text = normal_move;
                StatPanel3.EMoveStat.Text = elite_move;
                StatPanel3.AttackStat.Text = normal_attack;
                StatPanel3.EAttackStat.Text = elite_attack;
                StatPanel3.RangeStat.Text = normal_range;
                StatPanel3.ERangeStat.Text = elite_range;

                JToken j_attributes_normal = j_normal.SelectToken("attributes");
                JToken j_attributes_elite = j_elite.SelectToken("attributes");
                string attributes_normal = j_attributes_normal.ToString().ToLower();
                string attributes_elite = j_attributes_elite.ToString().ToLower();

                if (attributes_normal.Contains("flying")) { StatPanel3.Flying.Opacity = 1; }
                else { StatPanel3.Flying.Opacity = 0.25; }
                if (attributes_elite.Contains("flying")) { StatPanel3.EFlying.Opacity = 1; }
                else { StatPanel3.EFlying.Opacity = 0.25; }
                if (attributes_normal.Contains("curse")) { StatPanel3.Curse.Opacity = 1; }
                else { StatPanel3.Curse.Opacity = 0.25; }
                if (attributes_elite.Contains("curse")) { StatPanel3.ECurse.Opacity = 1; }
                else { StatPanel3.ECurse.Opacity = 0.25; }
                if (attributes_normal.Contains("disarm")) { StatPanel3.Disarm.Opacity = 1; }
                else { StatPanel3.Disarm.Opacity = 0.25; }
                if (attributes_elite.Contains("disarm")) { StatPanel3.EDisarm.Opacity = 1; }
                else { StatPanel3.EDisarm.Opacity = 0.25; }
                if (attributes_normal.Contains("immobilize")) { StatPanel3.Immobilize.Opacity = 1; }
                else { StatPanel3.Immobilize.Opacity = 0.25; }
                if (attributes_elite.Contains("immobilize")) { StatPanel3.EImmobilize.Opacity = 1; }
                else { StatPanel3.EImmobilize.Opacity = 0.25; }
                if (attributes_normal.Contains("muddle")) { StatPanel3.Muddle.Opacity = 1; }
                else { StatPanel3.Muddle.Opacity = 0.25; }
                if (attributes_elite.Contains("muddle")) { StatPanel3.EMuddle.Opacity = 1; }
                else { StatPanel3.EMuddle.Opacity = 0.25; }
                if (attributes_normal.Contains("poison")) { StatPanel3.Poison.Opacity = 1; }
                else { StatPanel3.Poison.Opacity = 0.25; }
                if (attributes_elite.Contains("poison")) { StatPanel3.EPoison.Opacity = 1; }
                else { StatPanel3.EPoison.Opacity = 0.25; }
                if (attributes_normal.Contains("stun")) { StatPanel3.Stun.Opacity = 1; }
                else { StatPanel3.Stun.Opacity = 0.25; }
                if (attributes_elite.Contains("stun")) { StatPanel3.EStun.Opacity = 1; }
                else { StatPanel3.EStun.Opacity = 0.25; }
                if (attributes_normal.Contains("wound")) { StatPanel3.Wound.Opacity = 1; }
                else { StatPanel3.Wound.Opacity = 0.25; }
                if (attributes_elite.Contains("wound")) { StatPanel3.EWound.Opacity = 1; }
                else { StatPanel3.EWound.Opacity = 0.25; }
                //IJEnumerable<JToken> attrs = j_attributes_normal.Values();
                List<string> attr_strings_normal = new List<string>();
                foreach (var value in j_attributes_normal.Children())
                {
                    attr_strings_normal.Add(value.ToString().ToLower());
                }
                string retaliate_value = "-";
                string retaliate_range = "-";
                StatPanel3.RetaliateStat.Text = retaliate_value;
                if (attributes_normal.Contains("retaliate")) // somewhat redundant
                {
                    StatPanel3.Retaliate.Opacity = 1;
                    for (int i = 0; i < attr_strings_normal.Count; i++)
                    {
                        if (attr_strings_normal[i].Contains("retaliate"))
                        {
                            retaliate_value = attr_strings_normal[i].Split(' ')[1][0].ToString();
                            StatPanel3.RetaliateStat.Text = retaliate_value;
                            if (attr_strings_normal[i].Contains("range"))
                            {
                                retaliate_range = attr_strings_normal[i].Split(' ')[3][0].ToString();
                                StatPanel3.RetaliateStat.Text = retaliate_value + ", Range " + retaliate_range;
                            }
                            i = attr_strings_normal.Count;
                        }
                    }
                }
                else { StatPanel3.Retaliate.Opacity = 0.25; }
                List<string> attr_strings_elite = new List<string>();
                foreach (var value in j_attributes_elite.Children())
                {
                    attr_strings_elite.Add(value.ToString().ToLower());
                }
                retaliate_value = "-";
                retaliate_range = "-";
                StatPanel3.ERetaliateStat.Text = retaliate_value;
                if (attributes_elite.Contains("retaliate"))
                {
                    StatPanel3.Retaliate.Opacity = 1;
                    for (int i = 0; i < attr_strings_elite.Count; i++)
                    {
                        if (attr_strings_elite[i].Contains("retaliate"))
                        {
                            retaliate_value = attr_strings_elite[i].Split(' ')[1][0].ToString();
                            StatPanel3.ERetaliateStat.Text = retaliate_value;
                            if (attr_strings_elite[i].Contains("range"))
                            {
                                retaliate_range = attr_strings_elite[i].Split(' ')[3][0].ToString();
                                StatPanel3.ERetaliateStat.Text = retaliate_value + ", Range " + retaliate_range;
                            }
                            i = attr_strings_elite.Count;
                        }
                    }
                }
                else { StatPanel3.Retaliate.Opacity = 0.25; }

                string pierce_value = "-";
                StatPanel3.PierceStat.Text = pierce_value;
                if (attributes_normal.Contains("pierce")) // somewhat redundant
                {
                    StatPanel3.Pierce.Opacity = 1;
                    for (int i = 0; i < attr_strings_normal.Count; i++)
                    {
                        if (attr_strings_normal[i].Contains("pierce"))
                        {
                            pierce_value = attr_strings_normal[i].Split(' ')[1][0].ToString();
                            StatPanel3.PierceStat.Text = pierce_value;
                            i = attr_strings_normal.Count;
                        }
                    }
                }
                else { StatPanel3.Pierce.Opacity = 0.25; }

                foreach (var value in j_attributes_elite.Children())
                {
                    attr_strings_elite.Add(value.ToString().ToLower());
                }
                pierce_value = "-";
                StatPanel3.EPierceStat.Text = pierce_value;
                if (attributes_elite.Contains("pierce"))
                {
                    StatPanel3.Pierce.Opacity = 1;
                    for (int i = 0; i < attr_strings_elite.Count; i++)
                    {
                        if (attr_strings_elite[i].Contains("pierce"))
                        {
                            pierce_value = attr_strings_elite[i].Split(' ')[1][0].ToString();
                            StatPanel3.EPierceStat.Text = pierce_value;
                            i = attr_strings_elite.Count;
                        }
                    }
                }
                else { StatPanel3.Pierce.Opacity = 0.25; }

                string targets_value = "-";
                StatPanel3.TargetsStat.Text = targets_value;
                if (attributes_normal.Contains("target")) // somewhat redundant
                {
                    StatPanel3.Targets.Opacity = 1;
                    for (int i = 0; i < attr_strings_normal.Count; i++)
                    {
                        if (attr_strings_normal[i].Contains("target"))
                        {
                            targets_value = attr_strings_normal[i].Split(' ')[1][0].ToString();
                            StatPanel3.TargetsStat.Text = targets_value;
                            i = attr_strings_normal.Count;
                        }
                    }
                }
                else { StatPanel3.Targets.Opacity = 0.25; }

                foreach (var value in j_attributes_elite.Children())
                {
                    attr_strings_elite.Add(value.ToString().ToLower());
                }
                targets_value = "-";
                StatPanel3.ETargetsStat.Text = targets_value;
                if (attributes_elite.Contains("target"))
                {
                    StatPanel3.Targets.Opacity = 1;
                    for (int i = 0; i < attr_strings_elite.Count; i++)
                    {
                        if (attr_strings_elite[i].Contains("target"))
                        {
                            targets_value = attr_strings_elite[i].Split(' ')[1][0].ToString();
                            StatPanel3.ETargetsStat.Text = targets_value;
                            i = attr_strings_elite.Count;
                        }
                    }
                }
                else { StatPanel3.Targets.Opacity = 0.25; }

                string shield_value = "-";
                StatPanel3.ShieldStat.Text = shield_value;
                if (attributes_normal.Contains("shield")) // somewhat redundant
                {
                    StatPanel3.Shield.Opacity = 1;
                    for (int i = 0; i < attr_strings_normal.Count; i++)
                    {
                        if (attr_strings_normal[i].Contains("shield"))
                        {
                            shield_value = attr_strings_normal[i].Split(' ')[1][0].ToString();
                            StatPanel3.ShieldStat.Text = shield_value;
                            i = attr_strings_normal.Count;
                        }
                    }
                }
                else { StatPanel3.Shield.Opacity = 0.25; }

                foreach (var value in j_attributes_elite.Children())
                {
                    attr_strings_elite.Add(value.ToString().ToLower());
                }
                shield_value = "-";
                StatPanel3.EShieldStat.Text = shield_value;
                if (attributes_elite.Contains("shield"))
                {
                    StatPanel3.Shield.Opacity = 1;
                    for (int i = 0; i < attr_strings_elite.Count; i++)
                    {
                        if (attr_strings_elite[i].Contains("shield"))
                        {
                            shield_value = attr_strings_elite[i].Split(' ')[1][0].ToString();
                            StatPanel3.EShieldStat.Text = shield_value;
                            i = attr_strings_elite.Count;
                        }
                    }
                }
                else { StatPanel3.Shield.Opacity = 0.25; }

                if (attributes_normal.Contains("disadvantage"))
                {
                    StatPanel3.NormalText.Text = "Normal [Atks. gain Disadv.]";
                }
                else
                {
                    StatPanel3.NormalText.Text = "Normal";
                }
                if (attributes_elite.Contains("disadvantage"))
                {
                    StatPanel3.EliteText.Text = "Elite [Atks. gain Disadv.]";
                }
                else
                {
                    StatPanel3.EliteText.Text = "Elite";
                }

            }
            else if (LockMonster3.IsChecked == true)
            {
                MonsterList3.IsEnabled = false;
            }

            if (LockMonster3.IsChecked == false) { MonsterList3.IsEnabled = true; }
        }

        private void Monster4Locked(object sender, RoutedEventArgs e)
        {
            if (LockMonster4.IsChecked == true & MonsterList4.SelectedIndex != -1)
            {
                string monster_type = MonsterList4.Text;
                string monster_name = monster_type.Substring(0, monster_type.Length - 4).Trim();
                Monster4.Text = monster_type;
                MonsterList4.IsEnabled = false;
                string monster_stats = File.ReadAllText("monsterstats/monster_stats.json");
                JObject o = JObject.Parse(monster_stats);
                int diff = 0;
                Int32.TryParse(GlobalDifficulty, out diff);
                JToken jmonster = o.SelectToken("$['monsters']['" + monster_name + "']['level'][?(@.level == " + diff + ")]");
                JToken j_normal = jmonster.SelectToken("$.normal");
                JToken j_elite = jmonster.SelectToken("$.elite");
                string testjelite = j_elite.ToString();
                string normal_health = (string)j_normal.SelectToken("health");
                string elite_health = (string)j_elite.SelectToken("health");
                string normal_move = (string)j_normal.SelectToken("move");
                string elite_move = (string)j_elite.SelectToken("move");
                string normal_attack = (string)j_normal.SelectToken("attack");
                string elite_attack = (string)j_elite.SelectToken("attack");
                string normal_range = (string)j_normal.SelectToken("range");
                if (normal_range.Equals("0")) normal_range = "-";
                string elite_range = (string)j_elite.SelectToken("range");
                if (elite_range.Equals("0")) elite_range = "-";

                StatPanel4.HealthStat.Text = normal_health;
                StatPanel4.EHealthStat.Text = elite_health;
                StatPanel4.MoveStat.Text = normal_move;
                StatPanel4.EMoveStat.Text = elite_move;
                StatPanel4.AttackStat.Text = normal_attack;
                StatPanel4.EAttackStat.Text = elite_attack;
                StatPanel4.RangeStat.Text = normal_range;
                StatPanel4.ERangeStat.Text = elite_range;

                JToken j_attributes_normal = j_normal.SelectToken("attributes");
                JToken j_attributes_elite = j_elite.SelectToken("attributes");
                string attributes_normal = j_attributes_normal.ToString().ToLower();
                string attributes_elite = j_attributes_elite.ToString().ToLower();

                if (attributes_normal.Contains("flying")) { StatPanel4.Flying.Opacity = 1; }
                else { StatPanel4.Flying.Opacity = 0.25; }
                if (attributes_elite.Contains("flying")) { StatPanel4.EFlying.Opacity = 1; }
                else { StatPanel4.EFlying.Opacity = 0.25; }
                if (attributes_normal.Contains("curse")) { StatPanel4.Curse.Opacity = 1; }
                else { StatPanel4.Curse.Opacity = 0.25; }
                if (attributes_elite.Contains("curse")) { StatPanel4.ECurse.Opacity = 1; }
                else { StatPanel4.ECurse.Opacity = 0.25; }
                if (attributes_normal.Contains("disarm")) { StatPanel4.Disarm.Opacity = 1; }
                else { StatPanel4.Disarm.Opacity = 0.25; }
                if (attributes_elite.Contains("disarm")) { StatPanel4.EDisarm.Opacity = 1; }
                else { StatPanel4.EDisarm.Opacity = 0.25; }
                if (attributes_normal.Contains("immobilize")) { StatPanel4.Immobilize.Opacity = 1; }
                else { StatPanel4.Immobilize.Opacity = 0.25; }
                if (attributes_elite.Contains("immobilize")) { StatPanel4.EImmobilize.Opacity = 1; }
                else { StatPanel4.EImmobilize.Opacity = 0.25; }
                if (attributes_normal.Contains("muddle")) { StatPanel4.Muddle.Opacity = 1; }
                else { StatPanel4.Muddle.Opacity = 0.25; }
                if (attributes_elite.Contains("muddle")) { StatPanel4.EMuddle.Opacity = 1; }
                else { StatPanel4.EMuddle.Opacity = 0.25; }
                if (attributes_normal.Contains("poison")) { StatPanel4.Poison.Opacity = 1; }
                else { StatPanel4.Poison.Opacity = 0.25; }
                if (attributes_elite.Contains("poison")) { StatPanel4.EPoison.Opacity = 1; }
                else { StatPanel4.EPoison.Opacity = 0.25; }
                if (attributes_normal.Contains("stun")) { StatPanel4.Stun.Opacity = 1; }
                else { StatPanel4.Stun.Opacity = 0.25; }
                if (attributes_elite.Contains("stun")) { StatPanel4.EStun.Opacity = 1; }
                else { StatPanel4.EStun.Opacity = 0.25; }
                if (attributes_normal.Contains("wound")) { StatPanel4.Wound.Opacity = 1; }
                else { StatPanel4.Wound.Opacity = 0.25; }
                if (attributes_elite.Contains("wound")) { StatPanel4.EWound.Opacity = 1; }
                else { StatPanel4.EWound.Opacity = 0.25; }
                //IJEnumerable<JToken> attrs = j_attributes_normal.Values();
                List<string> attr_strings_normal = new List<string>();
                foreach (var value in j_attributes_normal.Children())
                {
                    attr_strings_normal.Add(value.ToString().ToLower());
                }
                string retaliate_value = "-";
                string retaliate_range = "-";
                StatPanel4.RetaliateStat.Text = retaliate_value;
                if (attributes_normal.Contains("retaliate")) // somewhat redundant
                {
                    StatPanel4.Retaliate.Opacity = 1;
                    for (int i = 0; i < attr_strings_normal.Count; i++)
                    {
                        if (attr_strings_normal[i].Contains("retaliate"))
                        {
                            retaliate_value = attr_strings_normal[i].Split(' ')[1][0].ToString();
                            StatPanel4.RetaliateStat.Text = retaliate_value;
                            if (attr_strings_normal[i].Contains("range"))
                            {
                                retaliate_range = attr_strings_normal[i].Split(' ')[3][0].ToString();
                                StatPanel4.RetaliateStat.Text = retaliate_value + ", Range " + retaliate_range;
                            }
                            i = attr_strings_normal.Count;
                        }
                    }
                }
                else { StatPanel4.Retaliate.Opacity = 0.25; }
                List<string> attr_strings_elite = new List<string>();
                foreach (var value in j_attributes_elite.Children())
                {
                    attr_strings_elite.Add(value.ToString().ToLower());
                }
                retaliate_value = "-";
                retaliate_range = "-";
                StatPanel4.ERetaliateStat.Text = retaliate_value;
                if (attributes_elite.Contains("retaliate"))
                {
                    StatPanel4.Retaliate.Opacity = 1;
                    for (int i = 0; i < attr_strings_elite.Count; i++)
                    {
                        if (attr_strings_elite[i].Contains("retaliate"))
                        {
                            retaliate_value = attr_strings_elite[i].Split(' ')[1][0].ToString();
                            StatPanel4.ERetaliateStat.Text = retaliate_value;
                            if (attr_strings_elite[i].Contains("range"))
                            {
                                retaliate_range = attr_strings_elite[i].Split(' ')[3][0].ToString();
                                StatPanel4.ERetaliateStat.Text = retaliate_value + ", Range " + retaliate_range;
                            }
                            i = attr_strings_elite.Count;
                        }
                    }
                }
                else { StatPanel4.Retaliate.Opacity = 0.25; }

                string pierce_value = "-";
                StatPanel4.PierceStat.Text = pierce_value;
                if (attributes_normal.Contains("pierce")) // somewhat redundant
                {
                    StatPanel4.Pierce.Opacity = 1;
                    for (int i = 0; i < attr_strings_normal.Count; i++)
                    {
                        if (attr_strings_normal[i].Contains("pierce"))
                        {
                            pierce_value = attr_strings_normal[i].Split(' ')[1][0].ToString();
                            StatPanel4.PierceStat.Text = pierce_value;
                            i = attr_strings_normal.Count;
                        }
                    }
                }
                else { StatPanel4.Pierce.Opacity = 0.25; }

                foreach (var value in j_attributes_elite.Children())
                {
                    attr_strings_elite.Add(value.ToString().ToLower());
                }
                pierce_value = "-";
                StatPanel4.EPierceStat.Text = pierce_value;
                if (attributes_elite.Contains("pierce"))
                {
                    StatPanel4.Pierce.Opacity = 1;
                    for (int i = 0; i < attr_strings_elite.Count; i++)
                    {
                        if (attr_strings_elite[i].Contains("pierce"))
                        {
                            pierce_value = attr_strings_elite[i].Split(' ')[1][0].ToString();
                            StatPanel4.EPierceStat.Text = pierce_value;
                            i = attr_strings_elite.Count;
                        }
                    }
                }
                else { StatPanel4.Pierce.Opacity = 0.25; }

                string targets_value = "-";
                StatPanel4.TargetsStat.Text = targets_value;
                if (attributes_normal.Contains("target")) // somewhat redundant
                {
                    StatPanel4.Targets.Opacity = 1;
                    for (int i = 0; i < attr_strings_normal.Count; i++)
                    {
                        if (attr_strings_normal[i].Contains("target"))
                        {
                            targets_value = attr_strings_normal[i].Split(' ')[1][0].ToString();
                            StatPanel4.TargetsStat.Text = targets_value;
                            i = attr_strings_normal.Count;
                        }
                    }
                }
                else { StatPanel4.Targets.Opacity = 0.25; }

                foreach (var value in j_attributes_elite.Children())
                {
                    attr_strings_elite.Add(value.ToString().ToLower());
                }
                targets_value = "-";
                StatPanel4.ETargetsStat.Text = targets_value;
                if (attributes_elite.Contains("target"))
                {
                    StatPanel4.Targets.Opacity = 1;
                    for (int i = 0; i < attr_strings_elite.Count; i++)
                    {
                        if (attr_strings_elite[i].Contains("target"))
                        {
                            targets_value = attr_strings_elite[i].Split(' ')[1][0].ToString();
                            StatPanel4.ETargetsStat.Text = targets_value;
                            i = attr_strings_elite.Count;
                        }
                    }
                }
                else { StatPanel4.Targets.Opacity = 0.25; }

                string shield_value = "-";
                StatPanel4.ShieldStat.Text = shield_value;
                if (attributes_normal.Contains("shield")) // somewhat redundant
                {
                    StatPanel4.Shield.Opacity = 1;
                    for (int i = 0; i < attr_strings_normal.Count; i++)
                    {
                        if (attr_strings_normal[i].Contains("shield"))
                        {
                            shield_value = attr_strings_normal[i].Split(' ')[1][0].ToString();
                            StatPanel4.ShieldStat.Text = shield_value;
                            i = attr_strings_normal.Count;
                        }
                    }
                }
                else { StatPanel4.Shield.Opacity = 0.25; }

                foreach (var value in j_attributes_elite.Children())
                {
                    attr_strings_elite.Add(value.ToString().ToLower());
                }
                shield_value = "-";
                StatPanel4.EShieldStat.Text = shield_value;
                if (attributes_elite.Contains("shield"))
                {
                    StatPanel4.Shield.Opacity = 1;
                    for (int i = 0; i < attr_strings_elite.Count; i++)
                    {
                        if (attr_strings_elite[i].Contains("shield"))
                        {
                            shield_value = attr_strings_elite[i].Split(' ')[1][0].ToString();
                            StatPanel4.EShieldStat.Text = shield_value;
                            i = attr_strings_elite.Count;
                        }
                    }
                }
                else { StatPanel4.Shield.Opacity = 0.25; }

                if (attributes_normal.Contains("disadvantage"))
                {
                    StatPanel4.NormalText.Text = "Normal [Atks. gain Disadv.]";
                }
                else
                {
                    StatPanel4.NormalText.Text = "Normal";
                }
                if (attributes_elite.Contains("disadvantage"))
                {
                    StatPanel4.EliteText.Text = "Elite [Atks. gain Disadv.]";
                }
                else
                {
                    StatPanel4.EliteText.Text = "Elite";
                }

            }
            else if (LockMonster4.IsChecked == true)
            {
                MonsterList4.IsEnabled = false;
            }

            if (LockMonster4.IsChecked == false) { MonsterList4.IsEnabled = true; }
        }

        private void Monster5Locked(object sender, RoutedEventArgs e)
        {
            if (LockMonster5.IsChecked == true & MonsterList5.SelectedIndex != -1)
            {
                string monster_type = MonsterList5.Text;
                string monster_name = monster_type.Substring(0, monster_type.Length - 4).Trim();
                Monster5.Text = monster_type;
                MonsterList5.IsEnabled = false;
                string monster_stats = File.ReadAllText("monsterstats/monster_stats.json");
                JObject o = JObject.Parse(monster_stats);
                int diff = 0;
                Int32.TryParse(GlobalDifficulty, out diff);
                JToken jmonster = o.SelectToken("$['monsters']['" + monster_name + "']['level'][?(@.level == " + diff + ")]");
                JToken j_normal = jmonster.SelectToken("$.normal");
                JToken j_elite = jmonster.SelectToken("$.elite");
                string testjelite = j_elite.ToString();
                string normal_health = (string)j_normal.SelectToken("health");
                string elite_health = (string)j_elite.SelectToken("health");
                string normal_move = (string)j_normal.SelectToken("move");
                string elite_move = (string)j_elite.SelectToken("move");
                string normal_attack = (string)j_normal.SelectToken("attack");
                string elite_attack = (string)j_elite.SelectToken("attack");
                string normal_range = (string)j_normal.SelectToken("range");
                if (normal_range.Equals("0")) normal_range = "-";
                string elite_range = (string)j_elite.SelectToken("range");
                if (elite_range.Equals("0")) elite_range = "-";

                StatPanel5.HealthStat.Text = normal_health;
                StatPanel5.EHealthStat.Text = elite_health;
                StatPanel5.MoveStat.Text = normal_move;
                StatPanel5.EMoveStat.Text = elite_move;
                StatPanel5.AttackStat.Text = normal_attack;
                StatPanel5.EAttackStat.Text = elite_attack;
                StatPanel5.RangeStat.Text = normal_range;
                StatPanel5.ERangeStat.Text = elite_range;

                JToken j_attributes_normal = j_normal.SelectToken("attributes");
                JToken j_attributes_elite = j_elite.SelectToken("attributes");
                string attributes_normal = j_attributes_normal.ToString().ToLower();
                string attributes_elite = j_attributes_elite.ToString().ToLower();

                if (attributes_normal.Contains("flying")) { StatPanel5.Flying.Opacity = 1; }
                else { StatPanel5.Flying.Opacity = 0.25; }
                if (attributes_elite.Contains("flying")) { StatPanel5.EFlying.Opacity = 1; }
                else { StatPanel5.EFlying.Opacity = 0.25; }
                if (attributes_normal.Contains("curse")) { StatPanel5.Curse.Opacity = 1; }
                else { StatPanel5.Curse.Opacity = 0.25; }
                if (attributes_elite.Contains("curse")) { StatPanel5.ECurse.Opacity = 1; }
                else { StatPanel5.ECurse.Opacity = 0.25; }
                if (attributes_normal.Contains("disarm")) { StatPanel5.Disarm.Opacity = 1; }
                else { StatPanel5.Disarm.Opacity = 0.25; }
                if (attributes_elite.Contains("disarm")) { StatPanel5.EDisarm.Opacity = 1; }
                else { StatPanel5.EDisarm.Opacity = 0.25; }
                if (attributes_normal.Contains("immobilize")) { StatPanel5.Immobilize.Opacity = 1; }
                else { StatPanel5.Immobilize.Opacity = 0.25; }
                if (attributes_elite.Contains("immobilize")) { StatPanel5.EImmobilize.Opacity = 1; }
                else { StatPanel5.EImmobilize.Opacity = 0.25; }
                if (attributes_normal.Contains("muddle")) { StatPanel5.Muddle.Opacity = 1; }
                else { StatPanel5.Muddle.Opacity = 0.25; }
                if (attributes_elite.Contains("muddle")) { StatPanel5.EMuddle.Opacity = 1; }
                else { StatPanel5.EMuddle.Opacity = 0.25; }
                if (attributes_normal.Contains("poison")) { StatPanel5.Poison.Opacity = 1; }
                else { StatPanel5.Poison.Opacity = 0.25; }
                if (attributes_elite.Contains("poison")) { StatPanel5.EPoison.Opacity = 1; }
                else { StatPanel5.EPoison.Opacity = 0.25; }
                if (attributes_normal.Contains("stun")) { StatPanel5.Stun.Opacity = 1; }
                else { StatPanel5.Stun.Opacity = 0.25; }
                if (attributes_elite.Contains("stun")) { StatPanel5.EStun.Opacity = 1; }
                else { StatPanel5.EStun.Opacity = 0.25; }
                if (attributes_normal.Contains("wound")) { StatPanel5.Wound.Opacity = 1; }
                else { StatPanel5.Wound.Opacity = 0.25; }
                if (attributes_elite.Contains("wound")) { StatPanel5.EWound.Opacity = 1; }
                else { StatPanel5.EWound.Opacity = 0.25; }
                //IJEnumerable<JToken> attrs = j_attributes_normal.Values();
                List<string> attr_strings_normal = new List<string>();
                foreach (var value in j_attributes_normal.Children())
                {
                    attr_strings_normal.Add(value.ToString().ToLower());
                }
                string retaliate_value = "-";
                string retaliate_range = "-";
                StatPanel5.RetaliateStat.Text = retaliate_value;
                if (attributes_normal.Contains("retaliate")) // somewhat redundant
                {
                    StatPanel5.Retaliate.Opacity = 1;
                    for (int i = 0; i < attr_strings_normal.Count; i++)
                    {
                        if (attr_strings_normal[i].Contains("retaliate"))
                        {
                            retaliate_value = attr_strings_normal[i].Split(' ')[1][0].ToString();
                            StatPanel5.RetaliateStat.Text = retaliate_value;
                            if (attr_strings_normal[i].Contains("range"))
                            {
                                retaliate_range = attr_strings_normal[i].Split(' ')[3][0].ToString();
                                StatPanel5.RetaliateStat.Text = retaliate_value + ", Range " + retaliate_range;
                            }
                            i = attr_strings_normal.Count;
                        }
                    }
                }
                else { StatPanel5.Retaliate.Opacity = 0.25; }
                List<string> attr_strings_elite = new List<string>();
                foreach (var value in j_attributes_elite.Children())
                {
                    attr_strings_elite.Add(value.ToString().ToLower());
                }
                retaliate_value = "-";
                retaliate_range = "-";
                StatPanel5.ERetaliateStat.Text = retaliate_value;
                if (attributes_elite.Contains("retaliate"))
                {
                    StatPanel5.Retaliate.Opacity = 1;
                    for (int i = 0; i < attr_strings_elite.Count; i++)
                    {
                        if (attr_strings_elite[i].Contains("retaliate"))
                        {
                            retaliate_value = attr_strings_elite[i].Split(' ')[1][0].ToString();
                            StatPanel5.ERetaliateStat.Text = retaliate_value;
                            if (attr_strings_elite[i].Contains("range"))
                            {
                                retaliate_range = attr_strings_elite[i].Split(' ')[3][0].ToString();
                                StatPanel5.ERetaliateStat.Text = retaliate_value + ", Range " + retaliate_range;
                            }
                            i = attr_strings_elite.Count;
                        }
                    }
                }
                else { StatPanel5.Retaliate.Opacity = 0.25; }

                string pierce_value = "-";
                StatPanel5.PierceStat.Text = pierce_value;
                if (attributes_normal.Contains("pierce")) // somewhat redundant
                {
                    StatPanel5.Pierce.Opacity = 1;
                    for (int i = 0; i < attr_strings_normal.Count; i++)
                    {
                        if (attr_strings_normal[i].Contains("pierce"))
                        {
                            pierce_value = attr_strings_normal[i].Split(' ')[1][0].ToString();
                            StatPanel5.PierceStat.Text = pierce_value;
                            i = attr_strings_normal.Count;
                        }
                    }
                }
                else { StatPanel5.Pierce.Opacity = 0.25; }

                foreach (var value in j_attributes_elite.Children())
                {
                    attr_strings_elite.Add(value.ToString().ToLower());
                }
                pierce_value = "-";
                StatPanel5.EPierceStat.Text = pierce_value;
                if (attributes_elite.Contains("pierce"))
                {
                    StatPanel5.Pierce.Opacity = 1;
                    for (int i = 0; i < attr_strings_elite.Count; i++)
                    {
                        if (attr_strings_elite[i].Contains("pierce"))
                        {
                            pierce_value = attr_strings_elite[i].Split(' ')[1][0].ToString();
                            StatPanel5.EPierceStat.Text = pierce_value;
                            i = attr_strings_elite.Count;
                        }
                    }
                }
                else { StatPanel5.Pierce.Opacity = 0.25; }

                string targets_value = "-";
                StatPanel5.TargetsStat.Text = targets_value;
                if (attributes_normal.Contains("target")) // somewhat redundant
                {
                    StatPanel5.Targets.Opacity = 1;
                    for (int i = 0; i < attr_strings_normal.Count; i++)
                    {
                        if (attr_strings_normal[i].Contains("target"))
                        {
                            targets_value = attr_strings_normal[i].Split(' ')[1][0].ToString();
                            StatPanel5.TargetsStat.Text = targets_value;
                            i = attr_strings_normal.Count;
                        }
                    }
                }
                else { StatPanel5.Targets.Opacity = 0.25; }

                foreach (var value in j_attributes_elite.Children())
                {
                    attr_strings_elite.Add(value.ToString().ToLower());
                }
                targets_value = "-";
                StatPanel5.ETargetsStat.Text = targets_value;
                if (attributes_elite.Contains("target"))
                {
                    StatPanel5.Targets.Opacity = 1;
                    for (int i = 0; i < attr_strings_elite.Count; i++)
                    {
                        if (attr_strings_elite[i].Contains("target"))
                        {
                            targets_value = attr_strings_elite[i].Split(' ')[1][0].ToString();
                            StatPanel5.ETargetsStat.Text = targets_value;
                            i = attr_strings_elite.Count;
                        }
                    }
                }
                else { StatPanel5.Targets.Opacity = 0.25; }

                string shield_value = "-";
                StatPanel5.ShieldStat.Text = shield_value;
                if (attributes_normal.Contains("shield")) // somewhat redundant
                {
                    StatPanel5.Shield.Opacity = 1;
                    for (int i = 0; i < attr_strings_normal.Count; i++)
                    {
                        if (attr_strings_normal[i].Contains("shield"))
                        {
                            shield_value = attr_strings_normal[i].Split(' ')[1][0].ToString();
                            StatPanel5.ShieldStat.Text = shield_value;
                            i = attr_strings_normal.Count;
                        }
                    }
                }
                else { StatPanel5.Shield.Opacity = 0.25; }

                foreach (var value in j_attributes_elite.Children())
                {
                    attr_strings_elite.Add(value.ToString().ToLower());
                }
                shield_value = "-";
                StatPanel5.EShieldStat.Text = shield_value;
                if (attributes_elite.Contains("shield"))
                {
                    StatPanel5.Shield.Opacity = 1;
                    for (int i = 0; i < attr_strings_elite.Count; i++)
                    {
                        if (attr_strings_elite[i].Contains("shield"))
                        {
                            shield_value = attr_strings_elite[i].Split(' ')[1][0].ToString();
                            StatPanel5.EShieldStat.Text = shield_value;
                            i = attr_strings_elite.Count;
                        }
                    }
                }
                else { StatPanel5.Shield.Opacity = 0.25; }

                if (attributes_normal.Contains("disadvantage"))
                {
                    StatPanel5.NormalText.Text = "Normal [Atks. gain Disadv.]";
                }
                else
                {
                    StatPanel5.NormalText.Text = "Normal";
                }
                if (attributes_elite.Contains("disadvantage"))
                {
                    StatPanel5.EliteText.Text = "Elite [Atks. gain Disadv.]";
                }
                else
                {
                    StatPanel5.EliteText.Text = "Elite";
                }

            }
            else if (LockMonster5.IsChecked == true)
            {
                MonsterList5.IsEnabled = false;
            }

            if (LockMonster5.IsChecked == false) { MonsterList5.IsEnabled = true; }
        }

        private void Monster6Locked(object sender, RoutedEventArgs e)
        {
            if (LockMonster6.IsChecked == true & MonsterList6.SelectedIndex != -1)
            {
                string monster_type = MonsterList6.Text;
                string monster_name = monster_type.Substring(0, monster_type.Length - 4).Trim();
                Monster6.Text = monster_type;
                MonsterList6.IsEnabled = false;
                string monster_stats = File.ReadAllText("monsterstats/monster_stats.json");
                JObject o = JObject.Parse(monster_stats);
                int diff = 0;
                Int32.TryParse(GlobalDifficulty, out diff);
                JToken jmonster = o.SelectToken("$['monsters']['" + monster_name + "']['level'][?(@.level == " + diff + ")]");
                JToken j_normal = jmonster.SelectToken("$.normal");
                JToken j_elite = jmonster.SelectToken("$.elite");
                string testjelite = j_elite.ToString();
                string normal_health = (string)j_normal.SelectToken("health");
                string elite_health = (string)j_elite.SelectToken("health");
                string normal_move = (string)j_normal.SelectToken("move");
                string elite_move = (string)j_elite.SelectToken("move");
                string normal_attack = (string)j_normal.SelectToken("attack");
                string elite_attack = (string)j_elite.SelectToken("attack");
                string normal_range = (string)j_normal.SelectToken("range");
                if (normal_range.Equals("0")) normal_range = "-";
                string elite_range = (string)j_elite.SelectToken("range");
                if (elite_range.Equals("0")) elite_range = "-";

                StatPanel6.HealthStat.Text = normal_health;
                StatPanel6.EHealthStat.Text = elite_health;
                StatPanel6.MoveStat.Text = normal_move;
                StatPanel6.EMoveStat.Text = elite_move;
                StatPanel6.AttackStat.Text = normal_attack;
                StatPanel6.EAttackStat.Text = elite_attack;
                StatPanel6.RangeStat.Text = normal_range;
                StatPanel6.ERangeStat.Text = elite_range;

                JToken j_attributes_normal = j_normal.SelectToken("attributes");
                JToken j_attributes_elite = j_elite.SelectToken("attributes");
                string attributes_normal = j_attributes_normal.ToString().ToLower();
                string attributes_elite = j_attributes_elite.ToString().ToLower();

                if (attributes_normal.Contains("flying")) { StatPanel6.Flying.Opacity = 1; }
                else { StatPanel6.Flying.Opacity = 0.25; }
                if (attributes_elite.Contains("flying")) { StatPanel6.EFlying.Opacity = 1; }
                else { StatPanel6.EFlying.Opacity = 0.25; }
                if (attributes_normal.Contains("curse")) { StatPanel6.Curse.Opacity = 1; }
                else { StatPanel6.Curse.Opacity = 0.25; }
                if (attributes_elite.Contains("curse")) { StatPanel6.ECurse.Opacity = 1; }
                else { StatPanel6.ECurse.Opacity = 0.25; }
                if (attributes_normal.Contains("disarm")) { StatPanel6.Disarm.Opacity = 1; }
                else { StatPanel6.Disarm.Opacity = 0.25; }
                if (attributes_elite.Contains("disarm")) { StatPanel6.EDisarm.Opacity = 1; }
                else { StatPanel6.EDisarm.Opacity = 0.25; }
                if (attributes_normal.Contains("immobilize")) { StatPanel6.Immobilize.Opacity = 1; }
                else { StatPanel6.Immobilize.Opacity = 0.25; }
                if (attributes_elite.Contains("immobilize")) { StatPanel6.EImmobilize.Opacity = 1; }
                else { StatPanel6.EImmobilize.Opacity = 0.25; }
                if (attributes_normal.Contains("muddle")) { StatPanel6.Muddle.Opacity = 1; }
                else { StatPanel6.Muddle.Opacity = 0.25; }
                if (attributes_elite.Contains("muddle")) { StatPanel6.EMuddle.Opacity = 1; }
                else { StatPanel6.EMuddle.Opacity = 0.25; }
                if (attributes_normal.Contains("poison")) { StatPanel6.Poison.Opacity = 1; }
                else { StatPanel6.Poison.Opacity = 0.25; }
                if (attributes_elite.Contains("poison")) { StatPanel6.EPoison.Opacity = 1; }
                else { StatPanel6.EPoison.Opacity = 0.25; }
                if (attributes_normal.Contains("stun")) { StatPanel6.Stun.Opacity = 1; }
                else { StatPanel6.Stun.Opacity = 0.25; }
                if (attributes_elite.Contains("stun")) { StatPanel6.EStun.Opacity = 1; }
                else { StatPanel6.EStun.Opacity = 0.25; }
                if (attributes_normal.Contains("wound")) { StatPanel6.Wound.Opacity = 1; }
                else { StatPanel6.Wound.Opacity = 0.25; }
                if (attributes_elite.Contains("wound")) { StatPanel6.EWound.Opacity = 1; }
                else { StatPanel6.EWound.Opacity = 0.25; }
                //IJEnumerable<JToken> attrs = j_attributes_normal.Values();
                List<string> attr_strings_normal = new List<string>();
                foreach (var value in j_attributes_normal.Children())
                {
                    attr_strings_normal.Add(value.ToString().ToLower());
                }
                string retaliate_value = "-";
                string retaliate_range = "-";
                StatPanel6.RetaliateStat.Text = retaliate_value;
                if (attributes_normal.Contains("retaliate")) // somewhat redundant
                {
                    StatPanel6.Retaliate.Opacity = 1;
                    for (int i = 0; i < attr_strings_normal.Count; i++)
                    {
                        if (attr_strings_normal[i].Contains("retaliate"))
                        {
                            retaliate_value = attr_strings_normal[i].Split(' ')[1][0].ToString();
                            StatPanel6.RetaliateStat.Text = retaliate_value;
                            if (attr_strings_normal[i].Contains("range"))
                            {
                                retaliate_range = attr_strings_normal[i].Split(' ')[3][0].ToString();
                                StatPanel6.RetaliateStat.Text = retaliate_value + ", Range " + retaliate_range;
                            }
                            i = attr_strings_normal.Count;
                        }
                    }
                }
                else { StatPanel6.Retaliate.Opacity = 0.25; }
                List<string> attr_strings_elite = new List<string>();
                foreach (var value in j_attributes_elite.Children())
                {
                    attr_strings_elite.Add(value.ToString().ToLower());
                }
                retaliate_value = "-";
                retaliate_range = "-";
                StatPanel6.ERetaliateStat.Text = retaliate_value;
                if (attributes_elite.Contains("retaliate"))
                {
                    StatPanel6.Retaliate.Opacity = 1;
                    for (int i = 0; i < attr_strings_elite.Count; i++)
                    {
                        if (attr_strings_elite[i].Contains("retaliate"))
                        {
                            retaliate_value = attr_strings_elite[i].Split(' ')[1][0].ToString();
                            StatPanel6.ERetaliateStat.Text = retaliate_value;
                            if (attr_strings_elite[i].Contains("range"))
                            {
                                retaliate_range = attr_strings_elite[i].Split(' ')[3][0].ToString();
                                StatPanel6.ERetaliateStat.Text = retaliate_value + ", Range " + retaliate_range;
                            }
                            i = attr_strings_elite.Count;
                        }
                    }
                }
                else { StatPanel6.Retaliate.Opacity = 0.25; }

                string pierce_value = "-";
                StatPanel6.PierceStat.Text = pierce_value;
                if (attributes_normal.Contains("pierce")) // somewhat redundant
                {
                    StatPanel6.Pierce.Opacity = 1;
                    for (int i = 0; i < attr_strings_normal.Count; i++)
                    {
                        if (attr_strings_normal[i].Contains("pierce"))
                        {
                            pierce_value = attr_strings_normal[i].Split(' ')[1][0].ToString();
                            StatPanel6.PierceStat.Text = pierce_value;
                            i = attr_strings_normal.Count;
                        }
                    }
                }
                else { StatPanel6.Pierce.Opacity = 0.25; }

                foreach (var value in j_attributes_elite.Children())
                {
                    attr_strings_elite.Add(value.ToString().ToLower());
                }
                pierce_value = "-";
                StatPanel6.EPierceStat.Text = pierce_value;
                if (attributes_elite.Contains("pierce"))
                {
                    StatPanel6.Pierce.Opacity = 1;
                    for (int i = 0; i < attr_strings_elite.Count; i++)
                    {
                        if (attr_strings_elite[i].Contains("pierce"))
                        {
                            pierce_value = attr_strings_elite[i].Split(' ')[1][0].ToString();
                            StatPanel6.EPierceStat.Text = pierce_value;
                            i = attr_strings_elite.Count;
                        }
                    }
                }
                else { StatPanel6.Pierce.Opacity = 0.25; }

                string targets_value = "-";
                StatPanel6.TargetsStat.Text = targets_value;
                if (attributes_normal.Contains("target")) // somewhat redundant
                {
                    StatPanel6.Targets.Opacity = 1;
                    for (int i = 0; i < attr_strings_normal.Count; i++)
                    {
                        if (attr_strings_normal[i].Contains("target"))
                        {
                            targets_value = attr_strings_normal[i].Split(' ')[1][0].ToString();
                            StatPanel6.TargetsStat.Text = targets_value;
                            i = attr_strings_normal.Count;
                        }
                    }
                }
                else { StatPanel6.Targets.Opacity = 0.25; }

                foreach (var value in j_attributes_elite.Children())
                {
                    attr_strings_elite.Add(value.ToString().ToLower());
                }
                targets_value = "-";
                StatPanel6.ETargetsStat.Text = targets_value;
                if (attributes_elite.Contains("target"))
                {
                    StatPanel6.Targets.Opacity = 1;
                    for (int i = 0; i < attr_strings_elite.Count; i++)
                    {
                        if (attr_strings_elite[i].Contains("target"))
                        {
                            targets_value = attr_strings_elite[i].Split(' ')[1][0].ToString();
                            StatPanel6.ETargetsStat.Text = targets_value;
                            i = attr_strings_elite.Count;
                        }
                    }
                }
                else { StatPanel6.Targets.Opacity = 0.25; }

                string shield_value = "-";
                StatPanel6.ShieldStat.Text = shield_value;
                if (attributes_normal.Contains("shield")) // somewhat redundant
                {
                    StatPanel6.Shield.Opacity = 1;
                    for (int i = 0; i < attr_strings_normal.Count; i++)
                    {
                        if (attr_strings_normal[i].Contains("shield"))
                        {
                            shield_value = attr_strings_normal[i].Split(' ')[1][0].ToString();
                            StatPanel6.ShieldStat.Text = shield_value;
                            i = attr_strings_normal.Count;
                        }
                    }
                }
                else { StatPanel6.Shield.Opacity = 0.25; }

                foreach (var value in j_attributes_elite.Children())
                {
                    attr_strings_elite.Add(value.ToString().ToLower());
                }
                shield_value = "-";
                StatPanel6.EShieldStat.Text = shield_value;
                if (attributes_elite.Contains("shield"))
                {
                    StatPanel6.Shield.Opacity = 1;
                    for (int i = 0; i < attr_strings_elite.Count; i++)
                    {
                        if (attr_strings_elite[i].Contains("shield"))
                        {
                            shield_value = attr_strings_elite[i].Split(' ')[1][0].ToString();
                            StatPanel6.EShieldStat.Text = shield_value;
                            i = attr_strings_elite.Count;
                        }
                    }
                }
                else { StatPanel6.Shield.Opacity = 0.25; }

                if (attributes_normal.Contains("disadvantage"))
                {
                    StatPanel6.NormalText.Text = "Normal [Atks. gain Disadv.]";
                }
                else
                {
                    StatPanel6.NormalText.Text = "Normal";
                }
                if (attributes_elite.Contains("disadvantage"))
                {
                    StatPanel6.EliteText.Text = "Elite [Atks. gain Disadv.]";
                }
                else
                {
                    StatPanel6.EliteText.Text = "Elite";
                }

            }
            else if (LockMonster6.IsChecked == true)
            {
                MonsterList6.IsEnabled = false;
            }

            if (LockMonster6.IsChecked == false) { MonsterList6.IsEnabled = true; }
        }

        private void DifficultyLocked(object sender, RoutedEventArgs e)
        {
            if (LockDifficulty.IsChecked == true) { DungeonLevel.IsEnabled = false; }
            if (LockDifficulty.IsChecked == false) { DungeonLevel.IsEnabled = true; }
        }


        private void SpawnDestroyMonsterClicked(object sender, RoutedEventArgs e)

        {
            if (LockDifficulty.IsChecked == true) { DungeonLevel.IsEnabled = false; }
            if (LockDifficulty.IsChecked == false) { DungeonLevel.IsEnabled = true; }
        }

        private void ImageOpacitySwitch(object sender, RoutedEventArgs e)
        {
            Button SenderButton = e.Source as Button;
            if (SenderButton.Opacity < 1) { SenderButton.Opacity = 1; }
            else { SenderButton.Opacity = 0.3; }
        }
            

        private void LevelChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            ComboBox Difficulty = e.Source as ComboBox;
            ComboBoxItem SelectedLevel = Difficulty.SelectedItem as ComboBoxItem;
            var diff_value = SelectedLevel.Content;
            GlobalDifficulty = (string)diff_value;
        }

        private void PrevRoundClicked(object sender, RoutedEventArgs e)
        {
            if (GlobalRound > 1) GlobalRound -= 1;
            RoundCount.Text = "Round " + GlobalRound;
        }

        private void NextRoundClicked(object sender, RoutedEventArgs e)
        {
            if (GlobalRound < 100) GlobalRound += 1;
            RoundCount.Text = "Round " + GlobalRound;
        }

        ///        private void Monster1Changed(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        ///        {
        ///        Monster1.Text = MonsterList1.Text;
        ///        }
    }
}
