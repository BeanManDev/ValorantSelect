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

        List<string> agentArray = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
        }

        //Agent Randomizer Code
        private void All_Click(object sender, RoutedEventArgs e)
        {
            boxSelect();
        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            agentArray.Clear();
            boxReset();
        }
        private void Astra_Check_Click(object sender, RoutedEventArgs e)
        {
            if (agentArray.Contains("Astra") == true)
            {
                if (astra.IsChecked == true)
                {
                    return;
                }
                else
                {
                    agentArray.Remove("Astra");

                }
            }
            else
            {
                if (astra.IsChecked == true)
                {
                    agentArray.Add("Astra");
                }
                else
                {
                    return;
                }
            }
        }
        private void Breach_Check_Click(object sender, RoutedEventArgs e)
        {
            if (agentArray.Contains("Breach") == true)
            {
                if (breach.IsChecked == true)
                {
                    return;
                }
                else
                {
                    agentArray.Remove("Breach");

                }
            }
            else
            {
                if (breach.IsChecked == true)
                {
                    agentArray.Add("Breach");
                }
                else
                {
                    return;
                }
            }
        }
        private void Brim_Check_Click(object sender, RoutedEventArgs e)
        {
            if (agentArray.Contains("Brimstone") == true)
            {
                if (brimstone.IsChecked == true)
                {
                    return;
                }
                else
                {
                    agentArray.Remove("Brimstone");

                }
            }
            else
            {
                if (brimstone.IsChecked == true)
                {
                    agentArray.Add("Brimstone");
                }
                else
                {
                    return;
                }
            }
        }
        private void Chamber_Check_Click(object sender, RoutedEventArgs e)
        {
            if (agentArray.Contains("Chamber") == true)
            {
                if (chamber.IsChecked == true)
                {
                    return;
                }
                else
                {
                    agentArray.Remove("Chamber");

                }
            }
            else
            {
                if (chamber.IsChecked == true)
                {
                    agentArray.Add("Chamber");
                }
                else
                {
                    return;
                }
            }
        }
        private void Cypher_Check_Click(object sender, RoutedEventArgs e)
        {
            if (agentArray.Contains("Cypher") == true)
            {
                if (cypher.IsChecked == true)
                {
                    return;
                }
                else
                {
                    agentArray.Remove("Cypher");

                }
            }
            else
            {
                if (cypher.IsChecked == true)
                {
                    agentArray.Add("Cypher");
                }
                else
                {
                    return;
                }
            }
        }
        private void Jett_Check_Click(object sender, RoutedEventArgs e)
        {
            if (agentArray.Contains("Jett") == true)
            {
                if (jett.IsChecked == true)
                {
                    return;
                }
                else
                {
                    agentArray.Remove("Jett");

                }
            }
            else
            {
                if (jett.IsChecked == true)
                {
                    agentArray.Add("Jett");
                }
                else
                {
                    return;
                }
            }
        }
        private void Kayo_Check_Click(object sender, RoutedEventArgs e)
        {
            if (agentArray.Contains("Kayo") == true)
            {
                if (kayo.IsChecked == true)
                {
                    return;
                }
                else
                {
                    agentArray.Remove("Kayo");

                }
            }
            else
            {
                if (kayo.IsChecked == true)
                {
                    agentArray.Add("Kayo");
                }
                else
                {
                    return;
                }
            }
        }
        private void Killjoy_Check_Click(object sender, RoutedEventArgs e)
        {
            if (agentArray.Contains("Killjoy") == true)
            {
                if (killjoy.IsChecked == true)
                {
                    return;
                }
                else
                {
                    agentArray.Remove("Killjoy");

                }
            }
            else
            {
                if (killjoy.IsChecked == true)
                {
                    agentArray.Add("Killjoy");
                }
                else
                {
                    return;
                }
            }
        }
        private void Neon_Check_Click(object sender, RoutedEventArgs e)
        {
            if (agentArray.Contains("Neon") == true)
            {
                if (neon.IsChecked == true)
                {
                    return;
                }
                else
                {
                    agentArray.Remove("Neon");

                }
            }
            else
            {
                if (neon.IsChecked == true)
                {
                    agentArray.Add("Neon");
                }
                else
                {
                    return;
                }
            }
        }
        private void Omen_Check_Click(object sender, RoutedEventArgs e)
        {
            if (agentArray.Contains("Omen") == true)
            {
                if (omen.IsChecked == true)
                {
                    return;
                }
                else
                {
                    agentArray.Remove("Omen");

                }
            }
            else
            {
                if (omen.IsChecked == true)
                {
                    agentArray.Add("Omen");
                }
                else
                {
                    return;
                }
            }
        }
        private void Phoenix_Check_Click(object sender, RoutedEventArgs e)
        {
            if (agentArray.Contains("Phoenix") == true)
            {
                if (phoenix.IsChecked == true)
                {
                    return;
                }
                else
                {
                    agentArray.Remove("Phoenix");

                }
            }
            else
            {
                if (phoenix.IsChecked == true)
                {
                    agentArray.Add("Phoenix");
                }
                else
                {
                    return;
                }
            }
        }
        private void Raze_Check_Click(object sender, RoutedEventArgs e)
        {
            if (agentArray.Contains("Raze") == true)
            {
                if (raze.IsChecked == true)
                {
                    return;
                }
                else
                {
                    agentArray.Remove("Raze");

                }
            }
            else
            {
                if (raze.IsChecked == true)
                {
                    agentArray.Add("Raze");
                }
                else
                {
                    return;
                }
            }
        }
        private void Reyna_Check_Click(object sender, RoutedEventArgs e)
        {
            if (agentArray.Contains("Reyna") == true)
            {
                if (reyna.IsChecked == true)
                {
                    return;
                }
                else
                {
                    agentArray.Remove("Reyna");

                }
            }
            else
            {
                if (reyna.IsChecked == true)
                {
                    agentArray.Add("Reyna");
                }
                else
                {
                    return;
                }
            }
        }
        private void Sage_Check_Click(object sender, RoutedEventArgs e)
        {
            if (agentArray.Contains("Sage") == true)
            {
                if (sage.IsChecked == true)
                {
                    return;
                }
                else
                {
                    agentArray.Remove("Sage");

                }
            }
            else
            {
                if (sage.IsChecked == true)
                {
                    agentArray.Add("Sage");
                }
                else
                {
                    return;
                }
            }
        }
        private void Skye_Check_Click(object sender, RoutedEventArgs e)
        {
            if (agentArray.Contains("Skye") == true)
            {
                if (skye.IsChecked == true)
                {
                    return;
                }
                else
                {
                    agentArray.Remove("Skye");

                }
            }
            else
            {
                if (skye.IsChecked == true)
                {
                    agentArray.Add("Skye");
                }
                else
                {
                    return;
                }
            }
        }
        private void Sova_Check_Click(object sender, RoutedEventArgs e)
        {
            if (agentArray.Contains("Sova") == true)
            {
                if (sova.IsChecked == true)
                {
                    return;
                }
                else
                {
                    agentArray.Remove("Sova");

                }
            }
            else
            {
                if (sova.IsChecked == true)
                {
                    agentArray.Add("Sova");
                }
                else
                {
                    return;
                }
            }
        }
        private void Viper_Check_Click(object sender, RoutedEventArgs e)
        {
            if (agentArray.Contains("Viper") == true)
            {
                if (viper.IsChecked == true)
                {
                    return;
                }
                else
                {
                    agentArray.Remove("Viper");

                }
            }
            else
            {
                if (viper.IsChecked == true)
                {
                    agentArray.Add("Viper");
                }
                else
                {
                    return;
                }
            }
        }
        private void Yoru_Check_Click(object sender, RoutedEventArgs e)
        {
            if (agentArray.Contains("Yoru") == true)
            {
                if (yoru.IsChecked == true)
                {
                    return;
                }
                else
                {
                    agentArray.Remove("Yoru");

                }
            }
            else
            {
                if (yoru.IsChecked == true)
                {
                    agentArray.Add("Yoru");
                }
                else
                {
                    return;
                }
            }
        }
        private void Button_Choose_Click(object sender, RoutedEventArgs e)
        {
            if (cover.Opacity == 100)
            {
                string[] agentString = agentArray.ToArray();
                Random rand = new Random();
                int val = rand.Next(0, agentString.Length);

                if (!(agentArray.Count == 0))
                {
                    if (agentArray[val] == "Astra")
                    {
                        cover.Opacity = 0;
                        astraImage.Opacity = 100;
                    }
                    else if (agentArray[val] == "Breach")
                    {
                        cover.Opacity = 0;
                        breachImage.Opacity = 100;
                    }
                    else if (agentArray[val] == "Brimstone")
                    {
                        cover.Opacity = 0;
                        brimstoneImage.Opacity = 100;
                    }
                    else if (agentArray[val] == "Chamber")
                    {
                        cover.Opacity = 0;
                        chamberImage.Opacity = 100;
                    }
                    else if (agentArray[val] == "Cypher")
                    {
                        cover.Opacity = 0;
                        cypherImage.Opacity = 100;
                    }
                    else if (agentArray[val] == "Jett")
                    {
                        cover.Opacity = 0;
                        jettImage.Opacity = 100;
                    }
                    else if (agentArray[val] == "Kayo")
                    {
                        cover.Opacity = 0;
                        kayoImage.Opacity = 100;
                    }
                    else if (agentArray[val] == "Killjoy")
                    {
                        cover.Opacity = 0;
                        killjoyImage.Opacity = 100;
                    }
                    else if (agentArray[val] == "Neon")
                    {
                        cover.Opacity = 0;
                        neonImage.Opacity = 100;
                    }
                    else if (agentArray[val] == "Omen")
                    {
                        cover.Opacity = 0;
                        omenImage.Opacity = 100;
                    }
                    else if (agentArray[val] == "Phoenix")
                    {
                        cover.Opacity = 0;
                        phoenixImage.Opacity = 100;
                    }
                    else if (agentArray[val] == "Raze")
                    {
                        cover.Opacity = 0;
                        razeImage.Opacity = 100;
                    }
                    else if (agentArray[val] == "Reyna")
                    {
                        cover.Opacity = 0;
                        reynaImage.Opacity = 100;
                    }
                    else if (agentArray[val] == "Sage")
                    {
                        cover.Opacity = 0;
                        sageImage.Opacity = 100;
                    }
                    else if (agentArray[val] == "Skye")
                    {
                        cover.Opacity = 0;
                        skyeImage.Opacity = 100;
                    }
                    else if (agentArray[val] == "Sova")
                    {
                        cover.Opacity = 0;
                        sovaImage.Opacity = 100;
                    }
                    else if (agentArray[val] == "Viper")
                    {
                        cover.Opacity = 0;
                        viperImage.Opacity = 100;
                    }
                    else if (agentArray[val] == "Yoru")
                    {
                        cover.Opacity = 0;
                        yoruImage.Opacity = 100;
                    }
                }
            }
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            winReset();
        }
        private void Respin_Click(object sender, RoutedEventArgs e)
        {
            if (cover.Opacity == 0)
            {
                if (agentArray.Count == 0)
                {
                    imageReset();
                }
                else
                {
                    string[] agentString = agentArray.ToArray();
                    Random rand = new Random();
                    int val = rand.Next(0, agentString.Length);
                    if (!(agentArray.Count == 0))
                    {
                        if (agentArray[val] == "Astra")
                        {
                            breachImage.Opacity = 0;
                            brimstoneImage.Opacity = 0;
                            chamberImage.Opacity = 0;
                            cypherImage.Opacity = 0;
                            jettImage.Opacity = 0;
                            kayoImage.Opacity = 0;
                            killjoyImage.Opacity = 0;
                            neonImage.Opacity = 0;
                            omenImage.Opacity = 0;
                            phoenixImage.Opacity = 0;
                            razeImage.Opacity = 0;
                            reynaImage.Opacity = 0;
                            sageImage.Opacity = 0;
                            skyeImage.Opacity = 0;
                            sovaImage.Opacity = 0;
                            viperImage.Opacity = 0;
                            yoruImage.Opacity = 0;
                            astraImage.Opacity = 100;
                        }
                        else if (agentArray[val] == "Breach")
                        {
                            astraImage.Opacity = 0;
                            brimstoneImage.Opacity = 0;
                            chamberImage.Opacity = 0;
                            cypherImage.Opacity = 0;
                            jettImage.Opacity = 0;
                            kayoImage.Opacity = 0;
                            killjoyImage.Opacity = 0;
                            neonImage.Opacity = 0;
                            omenImage.Opacity = 0;
                            phoenixImage.Opacity = 0;
                            razeImage.Opacity = 0;
                            reynaImage.Opacity = 0;
                            sageImage.Opacity = 0;
                            skyeImage.Opacity = 0;
                            sovaImage.Opacity = 0;
                            viperImage.Opacity = 0;
                            yoruImage.Opacity = 0;
                            breachImage.Opacity = 100;
                        }
                        else if (agentArray[val] == "Brimstone")
                        {
                            astraImage.Opacity = 0;
                            breachImage.Opacity = 0;
                            chamberImage.Opacity = 0;
                            cypherImage.Opacity = 0;
                            jettImage.Opacity = 0;
                            kayoImage.Opacity = 0;
                            killjoyImage.Opacity = 0;
                            neonImage.Opacity = 0;
                            omenImage.Opacity = 0;
                            phoenixImage.Opacity = 0;
                            razeImage.Opacity = 0;
                            reynaImage.Opacity = 0;
                            sageImage.Opacity = 0;
                            skyeImage.Opacity = 0;
                            sovaImage.Opacity = 0;
                            viperImage.Opacity = 0;
                            yoruImage.Opacity = 0;
                            brimstoneImage.Opacity = 100;
                        }
                        else if (agentArray[val] == "Chamber")
                        {
                            astraImage.Opacity = 0;
                            breachImage.Opacity = 0;
                            brimstoneImage.Opacity = 0;
                            cypherImage.Opacity = 0;
                            jettImage.Opacity = 0;
                            kayoImage.Opacity = 0;
                            killjoyImage.Opacity = 0;
                            neonImage.Opacity = 0;
                            omenImage.Opacity = 0;
                            phoenixImage.Opacity = 0;
                            razeImage.Opacity = 0;
                            reynaImage.Opacity = 0;
                            sageImage.Opacity = 0;
                            skyeImage.Opacity = 0;
                            sovaImage.Opacity = 0;
                            viperImage.Opacity = 0;
                            yoruImage.Opacity = 0;
                            chamberImage.Opacity = 100;
                        }
                        else if (agentArray[val] == "Cypher")
                        {
                            astraImage.Opacity = 0;
                            breachImage.Opacity = 0;
                            brimstoneImage.Opacity = 0;
                            chamberImage.Opacity = 0;
                            jettImage.Opacity = 0;
                            kayoImage.Opacity = 0;
                            killjoyImage.Opacity = 0;
                            neonImage.Opacity = 0;
                            omenImage.Opacity = 0;
                            phoenixImage.Opacity = 0;
                            razeImage.Opacity = 0;
                            reynaImage.Opacity = 0;
                            sageImage.Opacity = 0;
                            skyeImage.Opacity = 0;
                            sovaImage.Opacity = 0;
                            viperImage.Opacity = 0;
                            yoruImage.Opacity = 0;
                            cypherImage.Opacity = 100;
                        }
                        else if (agentArray[val] == "Jett")
                        {
                            astraImage.Opacity = 0;
                            breachImage.Opacity = 0;
                            brimstoneImage.Opacity = 0;
                            chamberImage.Opacity = 0;
                            cypherImage.Opacity = 0;
                            jettImage.Opacity = 100;
                            kayoImage.Opacity = 0;
                            killjoyImage.Opacity = 0;
                            neonImage.Opacity = 0;
                            omenImage.Opacity = 0;
                            phoenixImage.Opacity = 0;
                            razeImage.Opacity = 0;
                            reynaImage.Opacity = 0;
                            sageImage.Opacity = 0;
                            skyeImage.Opacity = 0;
                            sovaImage.Opacity = 0;
                            viperImage.Opacity = 0;
                            yoruImage.Opacity = 0;
                        }
                        else if (agentArray[val] == "Kayo")
                        {
                            astraImage.Opacity = 0;
                            breachImage.Opacity = 0;
                            brimstoneImage.Opacity = 0;
                            chamberImage.Opacity = 0;
                            cypherImage.Opacity = 0;
                            jettImage.Opacity = 0;
                            killjoyImage.Opacity = 0;
                            neonImage.Opacity = 0;
                            omenImage.Opacity = 0;
                            phoenixImage.Opacity = 0;
                            razeImage.Opacity = 0;
                            reynaImage.Opacity = 0;
                            sageImage.Opacity = 0;
                            skyeImage.Opacity = 0;
                            sovaImage.Opacity = 0;
                            viperImage.Opacity = 0;
                            yoruImage.Opacity = 0;
                            kayoImage.Opacity = 100;
                        }
                        else if (agentArray[val] == "Killjoy")
                        {
                            astraImage.Opacity = 0;
                            breachImage.Opacity = 0;
                            brimstoneImage.Opacity = 0;
                            chamberImage.Opacity = 0;
                            cypherImage.Opacity = 0;
                            jettImage.Opacity = 0;
                            kayoImage.Opacity = 0;
                            neonImage.Opacity = 0;
                            omenImage.Opacity = 0;
                            phoenixImage.Opacity = 0;
                            razeImage.Opacity = 0;
                            reynaImage.Opacity = 0;
                            sageImage.Opacity = 0;
                            skyeImage.Opacity = 0;
                            sovaImage.Opacity = 0;
                            viperImage.Opacity = 0;
                            yoruImage.Opacity = 0;
                            killjoyImage.Opacity = 100;
                        }
                        else if (agentArray[val] == "Neon")
                        {
                            astraImage.Opacity = 0;
                            breachImage.Opacity = 0;
                            brimstoneImage.Opacity = 0;
                            chamberImage.Opacity = 0;
                            cypherImage.Opacity = 0;
                            jettImage.Opacity = 0;
                            kayoImage.Opacity = 0;
                            killjoyImage.Opacity = 0;
                            omenImage.Opacity = 0;
                            phoenixImage.Opacity = 0;
                            razeImage.Opacity = 0;
                            reynaImage.Opacity = 0;
                            sageImage.Opacity = 0;
                            skyeImage.Opacity = 0;
                            sovaImage.Opacity = 0;
                            viperImage.Opacity = 0;
                            yoruImage.Opacity = 0;
                            neonImage.Opacity = 100;
                        }
                        else if (agentArray[val] == "Omen")
                        {
                            astraImage.Opacity = 0;
                            breachImage.Opacity = 0;
                            brimstoneImage.Opacity = 0;
                            chamberImage.Opacity = 0;
                            cypherImage.Opacity = 0;
                            jettImage.Opacity = 0;
                            kayoImage.Opacity = 0;
                            killjoyImage.Opacity = 0;
                            neonImage.Opacity = 0;
                            phoenixImage.Opacity = 0;
                            razeImage.Opacity = 0;
                            reynaImage.Opacity = 0;
                            sageImage.Opacity = 0;
                            skyeImage.Opacity = 0;
                            sovaImage.Opacity = 0;
                            viperImage.Opacity = 0;
                            yoruImage.Opacity = 0;
                            omenImage.Opacity = 100;
                        }
                        else if (agentArray[val] == "Phoenix")
                        {
                            astraImage.Opacity = 0;
                            breachImage.Opacity = 0;
                            brimstoneImage.Opacity = 0;
                            chamberImage.Opacity = 0;
                            cypherImage.Opacity = 0;
                            jettImage.Opacity = 0;
                            kayoImage.Opacity = 0;
                            killjoyImage.Opacity = 0;
                            neonImage.Opacity = 0;
                            omenImage.Opacity = 0;
                            razeImage.Opacity = 0;
                            reynaImage.Opacity = 0;
                            sageImage.Opacity = 0;
                            skyeImage.Opacity = 0;
                            sovaImage.Opacity = 0;
                            viperImage.Opacity = 0;
                            yoruImage.Opacity = 0;
                            phoenixImage.Opacity = 100;
                        }
                        else if (agentArray[val] == "Raze")
                        {
                            astraImage.Opacity = 0;
                            breachImage.Opacity = 0;
                            brimstoneImage.Opacity = 0;
                            chamberImage.Opacity = 0;
                            cypherImage.Opacity = 0;
                            jettImage.Opacity = 0;
                            kayoImage.Opacity = 0;
                            killjoyImage.Opacity = 0;
                            neonImage.Opacity = 0;
                            omenImage.Opacity = 0;
                            phoenixImage.Opacity = 0;
                            reynaImage.Opacity = 0;
                            sageImage.Opacity = 0;
                            skyeImage.Opacity = 0;
                            sovaImage.Opacity = 0;
                            viperImage.Opacity = 0;
                            yoruImage.Opacity = 0;
                            razeImage.Opacity = 100;
                        }
                        else if (agentArray[val] == "Reyna")
                        {
                            astraImage.Opacity = 0;
                            breachImage.Opacity = 0;
                            brimstoneImage.Opacity = 0;
                            chamberImage.Opacity = 0;
                            cypherImage.Opacity = 0;
                            jettImage.Opacity = 0;
                            kayoImage.Opacity = 0;
                            killjoyImage.Opacity = 0;
                            neonImage.Opacity = 0;
                            omenImage.Opacity = 0;
                            phoenixImage.Opacity = 0;
                            razeImage.Opacity = 0;
                            reynaImage.Opacity = 100;
                            sageImage.Opacity = 0;
                            skyeImage.Opacity = 0;
                            sovaImage.Opacity = 0;
                            viperImage.Opacity = 0;
                            yoruImage.Opacity = 0;
                        }
                        else if (agentArray[val] == "Sage")
                        {
                            astraImage.Opacity = 0;
                            breachImage.Opacity = 0;
                            brimstoneImage.Opacity = 0;
                            chamberImage.Opacity = 0;
                            cypherImage.Opacity = 0;
                            jettImage.Opacity = 0;
                            kayoImage.Opacity = 0;
                            killjoyImage.Opacity = 0;
                            neonImage.Opacity = 0;
                            omenImage.Opacity = 0;
                            phoenixImage.Opacity = 0;
                            razeImage.Opacity = 0;
                            reynaImage.Opacity = 0;
                            skyeImage.Opacity = 0;
                            sovaImage.Opacity = 0;
                            viperImage.Opacity = 0;
                            yoruImage.Opacity = 0;
                            sageImage.Opacity = 100;
                        }
                        else if (agentArray[val] == "Skye")
                        {
                            astraImage.Opacity = 0;
                            breachImage.Opacity = 0;
                            brimstoneImage.Opacity = 0;
                            chamberImage.Opacity = 0;
                            cypherImage.Opacity = 0;
                            jettImage.Opacity = 0;
                            kayoImage.Opacity = 0;
                            killjoyImage.Opacity = 0;
                            neonImage.Opacity = 0;
                            omenImage.Opacity = 0;
                            phoenixImage.Opacity = 0;
                            razeImage.Opacity = 0;
                            reynaImage.Opacity = 0;
                            sageImage.Opacity = 0;
                            sovaImage.Opacity = 0;
                            viperImage.Opacity = 0;
                            yoruImage.Opacity = 0;
                            skyeImage.Opacity = 100;
                        }
                        else if (agentArray[val] == "Sova")
                        {
                            astraImage.Opacity = 0;
                            breachImage.Opacity = 0;
                            brimstoneImage.Opacity = 0;
                            chamberImage.Opacity = 0;
                            cypherImage.Opacity = 0;
                            jettImage.Opacity = 0;
                            kayoImage.Opacity = 0;
                            killjoyImage.Opacity = 0;
                            neonImage.Opacity = 0;
                            omenImage.Opacity = 0;
                            phoenixImage.Opacity = 0;
                            razeImage.Opacity = 0;
                            reynaImage.Opacity = 0;
                            sageImage.Opacity = 0;
                            skyeImage.Opacity = 0;
                            viperImage.Opacity = 0;
                            yoruImage.Opacity = 0;
                            sovaImage.Opacity = 100;
                        }
                        else if (agentArray[val] == "Viper")
                        {
                            astraImage.Opacity = 0;
                            breachImage.Opacity = 0;
                            brimstoneImage.Opacity = 0;
                            chamberImage.Opacity = 0;
                            cypherImage.Opacity = 0;
                            jettImage.Opacity = 0;
                            kayoImage.Opacity = 0;
                            killjoyImage.Opacity = 0;
                            neonImage.Opacity = 0;
                            omenImage.Opacity = 0;
                            phoenixImage.Opacity = 0;
                            razeImage.Opacity = 0;
                            reynaImage.Opacity = 0;
                            sageImage.Opacity = 0;
                            skyeImage.Opacity = 0;
                            sovaImage.Opacity = 0;
                            yoruImage.Opacity = 0;
                            viperImage.Opacity = 100;
                        }
                        else if (agentArray[val] == "Yoru")
                        {
                            astraImage.Opacity = 0;
                            breachImage.Opacity = 0;
                            brimstoneImage.Opacity = 0;
                            chamberImage.Opacity = 0;
                            cypherImage.Opacity = 0;
                            jettImage.Opacity = 0;
                            kayoImage.Opacity = 0;
                            killjoyImage.Opacity = 0;
                            neonImage.Opacity = 0;
                            omenImage.Opacity = 0;
                            phoenixImage.Opacity = 0;
                            razeImage.Opacity = 0;
                            reynaImage.Opacity = 0;
                            sageImage.Opacity = 0;
                            skyeImage.Opacity = 0;
                            sovaImage.Opacity = 0;
                            viperImage.Opacity = 0;
                            yoruImage.Opacity = 100;
                        }
                    }
                }

            }
        }
        public void winReset()
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
        public void boxReset()
        {
            imageReset();
            astra.IsChecked = false;
            breach.IsChecked = false;
            brimstone.IsChecked = false;
            chamber.IsChecked = false;
            cypher.IsChecked = false;
            jett.IsChecked = false;
            kayo.IsChecked = false;
            killjoy.IsChecked = false;
            neon.IsChecked = false;
            omen.IsChecked = false;
            phoenix.IsChecked = false;
            raze.IsChecked = false;
            reyna.IsChecked = false;
            sage.IsChecked = false;
            skye.IsChecked = false;
            sova.IsChecked = false;
            viper.IsChecked = false;
            yoru.IsChecked = false;
        }
        public void boxSelect()
        {
            agentArray.Clear();

            astra.IsChecked = true;
            breach.IsChecked = true;
            brimstone.IsChecked = true;
            chamber.IsChecked = true;
            cypher.IsChecked = true;
            jett.IsChecked = true;
            kayo.IsChecked = true;
            killjoy.IsChecked = true;
            neon.IsChecked = true;
            omen.IsChecked = true;
            phoenix.IsChecked = true;
            raze.IsChecked = true;
            reyna.IsChecked = true;
            sage.IsChecked = true;
            skye.IsChecked = true;
            sova.IsChecked = true;
            viper.IsChecked = true;
            yoru.IsChecked = true;

            agentArray.Add("Astra");
            agentArray.Add("Breach");
            agentArray.Add("Brimstone");
            agentArray.Add("Chamber");
            agentArray.Add("Cypher");
            agentArray.Add("Jett");
            agentArray.Add("Kayo");
            agentArray.Add("Killjoy");
            agentArray.Add("Neon");
            agentArray.Add("Omen");
            agentArray.Add("Phoenix");
            agentArray.Add("Raze");
            agentArray.Add("Reyna");
            agentArray.Add("Sage");
            agentArray.Add("Skye");
            agentArray.Add("Sova");
            agentArray.Add("Viper");
            agentArray.Add("Yoru");
        }
        public void imageReset()
        {
            cover.Opacity = 100;
            astraImage.Opacity = 0;
            breachImage.Opacity = 0;
            brimstoneImage.Opacity = 0;
            cypherImage.Opacity = 0;
            jettImage.Opacity = 0;
            kayoImage.Opacity = 0;
            killjoyImage.Opacity = 0;
            neonImage.Opacity = 0;
            omenImage.Opacity = 0;
            phoenixImage.Opacity = 0;
            razeImage.Opacity = 0;
            reynaImage.Opacity = 0;
            sageImage.Opacity = 0;
            sovaImage.Opacity = 0;
            skyeImage.Opacity = 0;
            viperImage.Opacity = 0;
            yoruImage.Opacity = 0;
        }
        public void cbClear()
        {
            astra.IsChecked = false;
            breach.IsChecked = false;
            brimstone.IsChecked = false;
            cypher.IsChecked = false;
            jett.IsChecked = false;
            kayo.IsChecked = false;
            killjoy.IsChecked = false;
            neon.IsChecked = false;
            omen.IsChecked = false;
            phoenix.IsChecked = false;
            raze.IsChecked = false;
            reyna.IsChecked = false;
            sage.IsChecked = false;
            skye.IsChecked = false;
            sova.IsChecked = false;
            viper.IsChecked = false;
            yoru.IsChecked = false;
        }

        //Weapons Randomizer Code
        private void Loadout_Click(object sender, RoutedEventArgs e)
        {
            secondary();
            primary();
            shield();
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

            if (val == 1)
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
            string[] gun = new string[14] { "Ares", "Bucky", "Bulldog", "Guardian", "Judge", "Marshal", "Odin", "Operator", "Phantom", "Spectre", "Stinger", "Vandal", "Free", "" };
            Random randGun = new Random();
            int val = randGun.Next(0, gun.Length);

            if (val == 1)
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

            if (val == 1)
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
