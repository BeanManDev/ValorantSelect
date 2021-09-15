using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ValorantSelect
{
    public partial class Weapon : Window
    {
        public Weapon()
        {
            InitializeComponent();
        }
        private void Loadout_Click(object sender, RoutedEventArgs e)
        {
            secondary();
            primary();
            shield();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
        private void Loadout_Secondary_Click(object sender, RoutedEventArgs e)
        {
            secondary();
        }
        private void Loadout_Primary_Click(object sender, RoutedEventArgs e)
        {
            primary();
        }
        private void Loadout_Shields_Click(object sender, RoutedEventArgs e)
        {
            shield();
        }
        private void Button_Click_Clear(object sender, RoutedEventArgs e)
        {
            //secondary
            classic.Opacity = 0;
            frenzy.Opacity = 0;
            ghost.Opacity = 0;
            sheriff.Opacity = 0;
            shorty.Opacity = 0;
            free1.Opacity = 0;

            //primary
            ares.Opacity = 0;
            bucky.Opacity = 0;
            bulldog.Opacity = 0;
            guardian.Opacity = 0;
            judge.Opacity = 0;
            marshal.Opacity = 0;
            odin.Opacity = 0;
            bigBoom.Opacity = 0;
            phantom.Opacity = 0;
            spectre.Opacity = 0;
            stinger.Opacity = 0;
            vandal.Opacity = 0;
            free2.Opacity = 0;

            //shields
            light.Opacity = 0;
            heavy.Opacity = 0;
            free3.Opacity = 0;
        }
        public void secondary()
        {
            string[] pist = new string[7] { "Classic", "Frenzy", "Ghost", "Sheriff", "Shorty", "Free", "" };
            Random randPistol = new Random();
            int val = randPistol.Next(0, pist.Length);

            if(val == 1)
            {
                classic.Opacity = 100;
                frenzy.Opacity = 0;
                ghost.Opacity = 0;
                sheriff.Opacity = 0;
                shorty.Opacity = 0;
                free1.Opacity = 0;
            }
            else if (val == 2)
            {
                classic.Opacity = 0;
                frenzy.Opacity = 100;
                ghost.Opacity = 0;
                sheriff.Opacity = 0;
                shorty.Opacity = 0;
                free1.Opacity = 0;
            }
            else if (val == 3)
            {
                classic.Opacity = 0;
                frenzy.Opacity = 0;
                ghost.Opacity = 100;
                sheriff.Opacity = 0;
                shorty.Opacity = 0;
                free1.Opacity = 0;
            }
            else if (val == 4)
            {
                classic.Opacity = 0;
                frenzy.Opacity = 0;
                ghost.Opacity = 0;
                sheriff.Opacity = 100;
                shorty.Opacity = 0;
                free1.Opacity = 0;
            }
            else if (val == 5)
            {
                classic.Opacity = 0;
                frenzy.Opacity = 0;
                ghost.Opacity = 0;
                sheriff.Opacity = 0;
                shorty.Opacity = 100;
                free1.Opacity = 0;
            }
            else if (val == 6)
            {
                classic.Opacity = 0;
                frenzy.Opacity = 0;
                ghost.Opacity = 0;
                sheriff.Opacity = 0;
                shorty.Opacity = 0;
                free1.Opacity = 100;
            }
            else if (val == 7)
            {
                classic.Opacity = 0;
                frenzy.Opacity = 0;
                ghost.Opacity = 0;
                sheriff.Opacity = 0;
                shorty.Opacity = 0;
                free1.Opacity = 0;
            }
        }
        public void primary()
        {
            string[] gun = new string[14] { "Ares","Bucky","Bulldog","Guardian","Judge","Marshal","Odin","Operator","Phantom","Spectre","Stinger","Vandal","Free","" };
            Random randGun = new Random();
            int val = randGun.Next(0, gun.Length);

            if(val == 1)
            {
                ares.Opacity = 100;
                bucky.Opacity = 0;
                bulldog.Opacity = 0;
                guardian.Opacity = 0;
                judge.Opacity = 0;
                marshal.Opacity = 0;
                odin.Opacity = 0;
                bigBoom.Opacity = 0;
                phantom.Opacity = 0;
                spectre.Opacity = 0;
                stinger.Opacity = 0;
                vandal.Opacity = 0;
                free2.Opacity = 0;
            }
            else if (val == 2)
            {
                ares.Opacity = 0;
                bucky.Opacity = 100;
                bulldog.Opacity = 0;
                guardian.Opacity = 0;
                judge.Opacity = 0;
                marshal.Opacity = 0;
                odin.Opacity = 0;
                bigBoom.Opacity = 0;
                phantom.Opacity = 0;
                spectre.Opacity = 0;
                stinger.Opacity = 0;
                vandal.Opacity = 0;
                free2.Opacity = 0;
            }
            else if (val == 3)
            {
                ares.Opacity = 0;
                bucky.Opacity = 0;
                bulldog.Opacity = 100;
                guardian.Opacity = 0;
                judge.Opacity = 0;
                marshal.Opacity = 0;
                odin.Opacity = 0;
                bigBoom.Opacity = 0;
                phantom.Opacity = 0;
                spectre.Opacity = 0;
                stinger.Opacity = 0;
                vandal.Opacity = 0;
                free2.Opacity = 0;
            }
            else if (val == 4)
            {
                ares.Opacity = 0;
                bucky.Opacity = 0;
                bulldog.Opacity = 0;
                guardian.Opacity = 100;
                judge.Opacity = 0;
                marshal.Opacity = 0;
                odin.Opacity = 0;
                bigBoom.Opacity = 0;
                phantom.Opacity = 0;
                spectre.Opacity = 0;
                stinger.Opacity = 0;
                vandal.Opacity = 0;
                free2.Opacity = 0;
            }
            else if (val == 5)
            {
                ares.Opacity = 0;
                bucky.Opacity = 0;
                bulldog.Opacity = 0;
                guardian.Opacity = 0;
                judge.Opacity = 100;
                marshal.Opacity = 0;
                odin.Opacity = 0;
                bigBoom.Opacity = 0;
                phantom.Opacity = 0;
                spectre.Opacity = 0;
                stinger.Opacity = 0;
                vandal.Opacity = 0;
                free2.Opacity = 0;
            }
            else if (val == 6)
            {
                ares.Opacity = 0;
                bucky.Opacity = 0;
                bulldog.Opacity = 0;
                guardian.Opacity = 0;
                judge.Opacity = 0;
                marshal.Opacity = 100;
                odin.Opacity = 0;
                bigBoom.Opacity = 0;
                phantom.Opacity = 0;
                spectre.Opacity = 0;
                stinger.Opacity = 0;
                vandal.Opacity = 0;
                free2.Opacity = 0;
            }
            else if (val == 7)
            {
                ares.Opacity = 0;
                bucky.Opacity = 0;
                bulldog.Opacity = 0;
                guardian.Opacity = 0;
                judge.Opacity = 0;
                marshal.Opacity = 0;
                odin.Opacity = 100;
                bigBoom.Opacity = 0;
                phantom.Opacity = 0;
                spectre.Opacity = 0;
                stinger.Opacity = 0;
                vandal.Opacity = 0;
                free2.Opacity = 0;
            }
            else if (val == 8)
            {
                ares.Opacity = 0;
                bucky.Opacity = 0;
                bulldog.Opacity = 0;
                guardian.Opacity = 0;
                judge.Opacity = 0;
                marshal.Opacity = 0;
                odin.Opacity = 0;
                bigBoom.Opacity = 100;
                phantom.Opacity = 0;
                spectre.Opacity = 0;
                stinger.Opacity = 0;
                vandal.Opacity = 0;
                free2.Opacity = 0;
            }
            else if (val == 9)
            {
                ares.Opacity = 0;
                bucky.Opacity = 0;
                bulldog.Opacity = 0;
                guardian.Opacity = 0;
                judge.Opacity = 0;
                marshal.Opacity = 0;
                odin.Opacity = 0;
                bigBoom.Opacity = 0;
                phantom.Opacity = 100;
                spectre.Opacity = 0;
                stinger.Opacity = 0;
                vandal.Opacity = 0;
                free2.Opacity = 0;
            }
            else if (val == 10)
            {
                ares.Opacity = 0;
                bucky.Opacity = 0;
                bulldog.Opacity = 0;
                guardian.Opacity = 0;
                judge.Opacity = 0;
                marshal.Opacity = 0;
                odin.Opacity = 0;
                bigBoom.Opacity = 0;
                phantom.Opacity = 0;
                spectre.Opacity = 100;
                stinger.Opacity = 0;
                vandal.Opacity = 0;
                free2.Opacity = 0;
            }
            else if (val == 11)
            {
                ares.Opacity = 0;
                bucky.Opacity = 0;
                bulldog.Opacity = 0;
                guardian.Opacity = 0;
                judge.Opacity = 0;
                marshal.Opacity = 0;
                odin.Opacity = 0;
                bigBoom.Opacity = 0;
                phantom.Opacity = 0;
                spectre.Opacity = 0;
                stinger.Opacity = 100;
                vandal.Opacity = 0;
                free2.Opacity = 0;
            }
            else if (val == 12)
            {
                ares.Opacity = 0;
                bucky.Opacity = 0;
                bulldog.Opacity = 0;
                guardian.Opacity = 0;
                judge.Opacity = 0;
                marshal.Opacity = 0;
                odin.Opacity = 0;
                bigBoom.Opacity = 0;
                phantom.Opacity = 0;
                spectre.Opacity = 0;
                stinger.Opacity = 0;
                vandal.Opacity = 100;
                free2.Opacity = 0;
            }
            else if (val == 13)
            {
                ares.Opacity = 0;
                bucky.Opacity = 0;
                bulldog.Opacity = 0;
                guardian.Opacity = 0;
                judge.Opacity = 0;
                marshal.Opacity = 0;
                odin.Opacity = 0;
                bigBoom.Opacity = 0;
                phantom.Opacity = 0;
                spectre.Opacity = 0;
                stinger.Opacity = 0;
                vandal.Opacity = 0;
                free2.Opacity = 100;
            }
            else if (val == 14)
            {
                ares.Opacity = 0;
                bucky.Opacity = 0;
                bulldog.Opacity = 0;
                guardian.Opacity = 0;
                judge.Opacity = 0;
                marshal.Opacity = 0;
                odin.Opacity = 0;
                bigBoom.Opacity = 0;
                phantom.Opacity = 0;
                spectre.Opacity = 0;
                stinger.Opacity = 0;
                vandal.Opacity = 0;
                free2.Opacity = 0;
            }
        }
        public void shield()
        {
            string[] shield = new string[4] { "Light", "Heavy", "Free", "" };
            Random randShield = new Random();
            int val = randShield.Next(0, shield.Length);

            if(val == 1)
            {
                light.Opacity = 100;
                heavy.Opacity = 0;
                free3.Opacity = 0;
            }
            else if (val == 2)
            {
                light.Opacity = 0;
                heavy.Opacity = 100;
                free3.Opacity = 0;
            }
            else if (val == 3)
            {
                light.Opacity = 0;
                heavy.Opacity = 0;
                free3.Opacity = 100;
            } 
            else if (val == 4)
            {
                light.Opacity = 0;
                heavy.Opacity = 0;
                free3.Opacity = 0;
            }
        }
    }
}
