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

namespace ValorantSelect
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          if (agents.IsChecked == true)
          {
                Agent agentWin = new Agent();
                agentWin.Show();
                this.Close();
          }
          else if (weapons.IsChecked == true)
          {
                Weapon weaponWin = new Weapon();
                weaponWin.Show();
                this.Close();
          }
        }
    }
}
