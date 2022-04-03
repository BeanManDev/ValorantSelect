using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace ValorantSelect
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void CloseWindow_CanExec(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CloseWindow_Exec(object sender, ExecutedRoutedEventArgs e)
        {
            SystemCommands.CloseWindow(this);
        }

        private void AgentRandBtn(object sender, RoutedEventArgs e)
        {
            Main.Content = new AgentRandomizer();
            
        }

        private void WeaponRandBtn(object sender, RoutedEventArgs e)
        {
            Main.Content = new WeaponRandomizer();
        }
    }
}
