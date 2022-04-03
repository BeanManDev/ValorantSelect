using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace ValorantSelect
{
    public partial class WeaponRandomizer : Page
    {
        List<string> classicArray = new List<string>();
        List<string> frenzyArray = new List<string>();
        List<string> ghostArray = new List<string>();
        List<string> sheriffArray = new List<string>();
        List<string> shortyArray = new List<string>();

        List<string> spectreArray = new List<string>();
        List<string> stingerArray = new List<string>();
        List<string> buckyArray = new List<string>();
        List<string> judgeArray = new List<string>();
        List<string> bulldogArray = new List<string>();
        List<string> guardianArray = new List<string>();
        List<string> phantomArray = new List<string>();
        List<string> vandalArray = new List<string>();
        List<string> marshalArray = new List<string>();
        List<string> operatorArray = new List<string>();
        List<string> aresArray = new List<string>();
        List<string> odinArray = new List<string>();

        public WeaponRandomizer()
        {
            InitializeComponent();
            InitializeSkins();
        }


        private void InitializeSkins()
        {
            classicArray.Add(Properties.Settings.Default.Classic);
            frenzyArray.Add(Properties.Settings.Default.Frenzy);
            ghostArray.Add(Properties.Settings.Default.Ghost);
            sheriffArray.Add(Properties.Settings.Default.Sheriff);
            shortyArray.Add(Properties.Settings.Default.Shorty);

            spectreArray.Add(Properties.Settings.Default.Spectre);
            stingerArray.Add(Properties.Settings.Default.Stinger);
            buckyArray.Add(Properties.Settings.Default.Bucky);
            judgeArray.Add(Properties.Settings.Default.Judge);
            bulldogArray.Add(Properties.Settings.Default.Bulldog);
            guardianArray.Add(Properties.Settings.Default.Guardian);
            phantomArray.Add(Properties.Settings.Default.Phantom);
            vandalArray.Add(Properties.Settings.Default.Vandal);
            marshalArray.Add(Properties.Settings.Default.Marshal);
            operatorArray.Add(Properties.Settings.Default.Op);
            aresArray.Add(Properties.Settings.Default.Ares);
            odinArray.Add(Properties.Settings.Default.Odin);
        }







        //classic skins
        private void ClassicDefault(object sender, RoutedEventArgs e)
        {
            if (classicArray.Contains("default"))
            {
                return;
            }
            else
            {
                classicArray.Clear();
                classicArray.Add("default");
                Properties.Settings.Default.Classic = "default";
                Properties.Settings.Default.Save();
            }
        }
        private void ClassicAvalanche(object sender, RoutedEventArgs e)
        {
            if (classicArray.Contains("avalanche"))
            {
                return;
            }
            else
            {
                classicArray.Clear();
                classicArray.Add("avalanche");
                Properties.Settings.Default.Classic = "avalanche";
                Properties.Settings.Default.Save();
            }
        }
        private void ClassicFinal(object sender, RoutedEventArgs e)
        {
            if (classicArray.Contains("final"))
            {
                return;
            }
            else
            {
                classicArray.Clear();
                classicArray.Add("final");
                Properties.Settings.Default.Classic = "final";
                Properties.Settings.Default.Save();
            }
        }
        private void ClassicFinesse(object sender, RoutedEventArgs e)
        {
            if (classicArray.Contains("finesse"))
            {
                return;
            }
            else
            {
                classicArray.Clear();
                classicArray.Add("finesse");
                Properties.Settings.Default.Classic = "finesse";
                Properties.Settings.Default.Save();
            }
        }
        private void ClassicFireArm(object sender, RoutedEventArgs e)
        {
            if (classicArray.Contains("firearm"))
            {
                return;
            }
            else
            {
                classicArray.Clear();
                classicArray.Add("firearm");
                Properties.Settings.Default.Classic = "firearm";
                Properties.Settings.Default.Save();
            }
        }
        private void ClassicForsaken(object sender, RoutedEventArgs e)
        {
            if (classicArray.Contains("forsaken"))
            {
                return;
            }
            else
            {
                classicArray.Clear();
                classicArray.Add("forsaken");
                Properties.Settings.Default.Classic = "forsaken";
                Properties.Settings.Default.Save();
            }
        }
        private void ClassicGalleria(object sender, RoutedEventArgs e)
        {
            if (classicArray.Contains("galleria"))
            {
                return;
            }
            else
            {
                classicArray.Clear();
                classicArray.Add("galleria");
                Properties.Settings.Default.Classic = "galleria";
                Properties.Settings.Default.Save();
            }
        }
        private void ClassicGlitchpop(object sender, RoutedEventArgs e)
        {
            if (classicArray.Contains("glitchpop"))
            {
                return;
            }
            else
            {
                classicArray.Clear();
                classicArray.Add("glitchpop");
                Properties.Settings.Default.Classic = "glitchpop";
                Properties.Settings.Default.Save();
            }
        }
        private void ClassicGoldwing(object sender, RoutedEventArgs e)
        {
            if (classicArray.Contains("goldwing"))
            {
                return;
            }
            else
            {
                classicArray.Clear();
                classicArray.Add("goldwing");
                Properties.Settings.Default.Classic = "goldwing";
                Properties.Settings.Default.Save();
            }
        }
        private void ClassicNeuroblaster(object sender, RoutedEventArgs e)
        {
            if (classicArray.Contains("neuroblaster"))
            {
                return;
            }
            else
            {
                classicArray.Clear();
                classicArray.Add("neuroblaster");
                Properties.Settings.Default.Classic = "neuroblaster";
                Properties.Settings.Default.Save();
            }
        }
        private void ClassicInfinity(object sender, RoutedEventArgs e)
        {
            if (classicArray.Contains("infinity"))
            {
                return;
            }
            else
            {
                classicArray.Clear();
                classicArray.Add("infinity");
                Properties.Settings.Default.Classic = "infinity";
                Properties.Settings.Default.Save();
            }
        }
        private void ClassicKingdom(object sender, RoutedEventArgs e)
        {
            if (classicArray.Contains("kingdom"))
            {
                return;
            }
            else
            {
                classicArray.Clear();
                classicArray.Add("kingdom");
                Properties.Settings.Default.Classic = "kingdom";
                Properties.Settings.Default.Save();
            }
        }
        private void ClassicPistolinha(object sender, RoutedEventArgs e)
        {
            if (classicArray.Contains("pistolinha"))
            {
                return;
            }
            else
            {
                classicArray.Clear();
                classicArray.Add("pistolinha");
                Properties.Settings.Default.Classic = "pistolinha";
                Properties.Settings.Default.Save();
            }
        }
        private void ClassicPrime(object sender, RoutedEventArgs e)
        {
            if (classicArray.Contains("prime"))
            {
                return;
            }
            else
            {
                classicArray.Clear();
                classicArray.Add("prime");
                Properties.Settings.Default.Classic = "prime";
                Properties.Settings.Default.Save();
            }
        }
        private void ClassicPrism(object sender, RoutedEventArgs e)
        {
            if (classicArray.Contains("prism"))
            {
                return;
            }
            else
            {
                classicArray.Clear();
                classicArray.Add("prism");
                Properties.Settings.Default.Classic = "prism";
                Properties.Settings.Default.Save();
            }
        }
        private void ClassicCrisis(object sender, RoutedEventArgs e)
        {
            if (classicArray.Contains("crisis"))
            {
                return;
            }
            else
            {
                classicArray.Clear();
                classicArray.Add("crisis");
                Properties.Settings.Default.Classic = "crisis";
                Properties.Settings.Default.Save();
            }
        }
        private void ClassicRedAlert(object sender, RoutedEventArgs e)
        {
            if (classicArray.Contains("redalert"))
            {
                return;
            }
            else
            {
                classicArray.Clear();
                classicArray.Add("redalert");
                Properties.Settings.Default.Classic = "redalert";
                Properties.Settings.Default.Save();
            }
        }
        private void ClassicSakura(object sender, RoutedEventArgs e)
        {
            if (classicArray.Contains("sakura"))
            {
                return;
            }
            else
            {
                classicArray.Clear();
                classicArray.Add("sakura");
                Properties.Settings.Default.Classic = "sakura";
                Properties.Settings.Default.Save();
            }
        }
        private void ClassicSmite(object sender, RoutedEventArgs e)
        {
            if (classicArray.Contains("smite"))
            {
                return;
            }
            else
            {
                classicArray.Clear();
                classicArray.Add("smite");
                Properties.Settings.Default.Classic = "smite";
                Properties.Settings.Default.Save();
            }
        }
        private void ClassicSnowfall(object sender, RoutedEventArgs e)
        {
            if (classicArray.Contains("snowfall"))
            {
                return;
            }
            else
            {
                classicArray.Clear();
                classicArray.Add("snowfall");
                Properties.Settings.Default.Classic = "snowfall";
                Properties.Settings.Default.Save();
            }
        }
        private void ClassicSongsteel(object sender, RoutedEventArgs e)
        {
            if (classicArray.Contains("songsteel"))
            {
                return;
            }
            else
            {
                classicArray.Clear();
                classicArray.Add("songsteel");
                Properties.Settings.Default.Classic = "songsteel";
                Properties.Settings.Default.Save();
            }
        }
        private void ClassicSpectrum(object sender, RoutedEventArgs e)
        {
            if (classicArray.Contains("spectrum"))
            {
                return;
            }
            else
            {
                classicArray.Clear();
                classicArray.Add("spectrum");
                Properties.Settings.Default.Classic = "spectrum";
                Properties.Settings.Default.Save();
            }
        }
        private void ClassicSpline(object sender, RoutedEventArgs e)
        {
            if (classicArray.Contains("spline"))
            {
                return;
            }
            else
            {
                classicArray.Clear();
                classicArray.Add("spline");
                Properties.Settings.Default.Classic = "spline";
                Properties.Settings.Default.Save();
            }
        }
        private void ClassicStriker(object sender, RoutedEventArgs e)
        {
            if (classicArray.Contains("striker"))
            {
                return;
            }
            else
            {
                classicArray.Clear();
                classicArray.Add("striker");
                Properties.Settings.Default.Classic = "striker";
                Properties.Settings.Default.Save();
            }
        }
        private void ClassicSurge(object sender, RoutedEventArgs e)
        {
            if (classicArray.Contains("surge"))
            {
                return;
            }
            else
            {
                classicArray.Clear();
                classicArray.Add("surge");
                Properties.Settings.Default.Classic = "surge";
                Properties.Settings.Default.Save();
            }
        }
        private void ClassicUndercity(object sender, RoutedEventArgs e)
        {
            if (classicArray.Contains("undercity"))
            {
                return;
            }
            else
            {
                classicArray.Clear();
                classicArray.Add("undercity");
                Properties.Settings.Default.Classic = "undercity";
                Properties.Settings.Default.Save();
            }
        }
        private void ClassicValorantGo(object sender, RoutedEventArgs e)
        {
            if (classicArray.Contains("valgo"))
            {
                return;
            }
            else
            {
                classicArray.Clear();
                classicArray.Add("valgo");
                Properties.Settings.Default.Classic = "valgo";
                Properties.Settings.Default.Save();
            }
        }

        //frenzy skins
        private void FrenzyDefault(object sender, RoutedEventArgs e)
        {
            if (frenzyArray.Contains("default"))
            {
                return;
            }
            else
            {
                frenzyArray.Clear();
                frenzyArray.Add("default");
                Properties.Settings.Default.Frenzy = "default";
                Properties.Settings.Default.Save();
            }
        }
        private void FrenzyAero(object sender, RoutedEventArgs e)
        {
            if (frenzyArray.Contains("aero"))
            {
                return;
            }
            else
            {
                frenzyArray.Clear();
                frenzyArray.Add("aero");
                Properties.Settings.Default.Frenzy = "aero";
                Properties.Settings.Default.Save();
            }
        }
        private void FrenzyBlastx(object sender, RoutedEventArgs e)
        {
            if (frenzyArray.Contains("blastx"))
            {
                return;
            }
            else
            {
                frenzyArray.Clear();
                frenzyArray.Add("blastx");
                Properties.Settings.Default.Frenzy = "blastx";
                Properties.Settings.Default.Save();
            }
        }
        private void FrenzyCelestial(object sender, RoutedEventArgs e)
        {
            if (frenzyArray.Contains("celestial"))
            {
                return;
            }
            else
            {
                frenzyArray.Clear();
                frenzyArray.Add("celestial");
                Properties.Settings.Default.Frenzy = "celestial";
                Properties.Settings.Default.Save();
            }
        }
        private void FrenzyCouture(object sender, RoutedEventArgs e)
        {
            if (frenzyArray.Contains("couture"))
            {
                return;
            }
            else
            {
                frenzyArray.Clear();
                frenzyArray.Add("couture");
                Properties.Settings.Default.Frenzy = "couture";
                Properties.Settings.Default.Save();
            }
        }
        private void FrenzyDivine(object sender, RoutedEventArgs e)
        {
            if (frenzyArray.Contains("divine"))
            {
                return;
            }
            else
            {
                frenzyArray.Clear();
                frenzyArray.Add("divine");
                Properties.Settings.Default.Frenzy = "divine";
                Properties.Settings.Default.Save();
            }
        }
        private void FrenzyElderflame(object sender, RoutedEventArgs e)
        {
            if (frenzyArray.Contains("elderflame"))
            {
                return;
            }
            else
            {
                frenzyArray.Clear();
                frenzyArray.Add("elderflame");
                Properties.Settings.Default.Frenzy = "elderflame";
                Properties.Settings.Default.Save();
            }
        }
        private void FrenzyGlitchpop(object sender, RoutedEventArgs e)
        {
            if (frenzyArray.Contains("glitchpop"))
            {
                return;
            }
            else
            {
                frenzyArray.Clear();
                frenzyArray.Add("glitchpop");
                Properties.Settings.Default.Frenzy = "glitchpop";
                Properties.Settings.Default.Save();
            }
        }
        private void FrenzyHorizon(object sender, RoutedEventArgs e)
        {
            if (frenzyArray.Contains("horizon"))
            {
                return;
            }
            else
            {
                frenzyArray.Clear();
                frenzyArray.Add("horizon");
                Properties.Settings.Default.Frenzy = "horizon";
                Properties.Settings.Default.Save();
            }
        }
        private void FrenzyHydrodip(object sender, RoutedEventArgs e)
        {
            if (frenzyArray.Contains("hydrodip"))
            {
                return;
            }
            else
            {
                frenzyArray.Clear();
                frenzyArray.Add("hydrodip");
                Properties.Settings.Default.Frenzy = "hydrodip";
                Properties.Settings.Default.Save();
            }
        }
        private void FrenzyLightwave(object sender, RoutedEventArgs e)
        {
            if (frenzyArray.Contains("lightwave"))
            {
                return;
            }
            else
            {
                frenzyArray.Clear();
                frenzyArray.Add("lightwave");
                Properties.Settings.Default.Frenzy = "lightwave";
                Properties.Settings.Default.Save();
            }
        }
        private void FrenzyLiveWire(object sender, RoutedEventArgs e)
        {
            if (frenzyArray.Contains("livewire"))
            {
                return;
            }
            else
            {
                frenzyArray.Clear();
                frenzyArray.Add("livewire");
                Properties.Settings.Default.Frenzy = "livewire";
                Properties.Settings.Default.Save();
            }
        }
        private void FrenzyMonarch(object sender, RoutedEventArgs e)
        {
            if (frenzyArray.Contains("monarch"))
            {
                return;
            }
            else
            {
                frenzyArray.Clear();
                frenzyArray.Add("monarch");
                Properties.Settings.Default.Frenzy = "monarch";
                Properties.Settings.Default.Save();
            }
        }
        private void FrenzyOlvidados(object sender, RoutedEventArgs e)
        {
            if (frenzyArray.Contains("olvidados"))
            {
                return;
            }
            else
            {
                frenzyArray.Clear();
                frenzyArray.Add("olvidados");
                Properties.Settings.Default.Frenzy = "olvidados";
                Properties.Settings.Default.Save();
            }
        }
        private void FrenzyOrigin(object sender, RoutedEventArgs e)
        {
            if (frenzyArray.Contains("origin"))
            {
                return;
            }
            else
            {
                frenzyArray.Clear();
                frenzyArray.Add("origin");
                Properties.Settings.Default.Frenzy = "origin";
                Properties.Settings.Default.Save();
            }
        }
        private void FrenzyPrime(object sender, RoutedEventArgs e)
        {
            if (frenzyArray.Contains("prime"))
            {
                return;
            }
            else
            {
                frenzyArray.Clear();
                frenzyArray.Add("prime");
                Properties.Settings.Default.Frenzy = "prime";
                Properties.Settings.Default.Save();
            }
        }
        private void FrenzyRagnarocker(object sender, RoutedEventArgs e)
        {
            if (frenzyArray.Contains("ragnarocker"))
            {
                return;
            }
            else
            {
                frenzyArray.Clear();
                frenzyArray.Add("ragnarocker");
                Properties.Settings.Default.Frenzy = "ragnarocker";
                Properties.Settings.Default.Save();
            }
        }
        private void FrenzyRGX11(object sender, RoutedEventArgs e)
        {
            if (frenzyArray.Contains("rgx11"))
            {
                return;
            }
            else
            {
                frenzyArray.Clear();
                frenzyArray.Add("rgx11");
                Properties.Settings.Default.Frenzy = "rgx11";
                Properties.Settings.Default.Save();
            }
        }
        private void FrenzyRush(object sender, RoutedEventArgs e)
        {
            if (frenzyArray.Contains("rush"))
            {
                return;
            }
            else
            {
                frenzyArray.Clear();
                frenzyArray.Add("rush");
                Properties.Settings.Default.Frenzy = "rush";
                Properties.Settings.Default.Save();
            }
        }
        private void FrenzySensation(object sender, RoutedEventArgs e)
        {
            if (frenzyArray.Contains("sensation"))
            {
                return;
            }
            else
            {
                frenzyArray.Clear();
                frenzyArray.Add("sensation");
                Properties.Settings.Default.Frenzy = "sensation";
                Properties.Settings.Default.Save();
            }
        }
        private void FrenzySpitfire(object sender, RoutedEventArgs e)
        {
            if (frenzyArray.Contains("spitfire"))
            {
                return;
            }
            else
            {
                frenzyArray.Clear();
                frenzyArray.Add("spitfire");
                Properties.Settings.Default.Frenzy = "spitfire";
                Properties.Settings.Default.Save();
            }
        }
        private void FrenzySwooping(object sender, RoutedEventArgs e)
        {
            if (frenzyArray.Contains("swooping"))
            {
                return;
            }
            else
            {
                frenzyArray.Clear();
                frenzyArray.Add("swooping");
                Properties.Settings.Default.Frenzy = "swooping";
                Properties.Settings.Default.Save();
            }
        }

        //ghost skins
        private void GhostDefault(object sender, RoutedEventArgs e)
        {
            if (ghostArray.Contains("default"))
            {
                return;
            }
            else
            {
                ghostArray.Clear();
                ghostArray.Add("default");
                Properties.Settings.Default.Ghost = "default";
                Properties.Settings.Default.Save();
            }
        }
        private void GhostArtisan(object sender, RoutedEventArgs e)
        {
            if (ghostArray.Contains("artisan"))
            {
                return;
            }
            else
            {
                ghostArray.Clear();
                ghostArray.Add("artisan");
                Properties.Settings.Default.Ghost = "artisan";
                Properties.Settings.Default.Save();
            }
        }
        private void GhostCavalier(object sender, RoutedEventArgs e)
        {
            if (ghostArray.Contains("cavalier"))
            {
                return;
            }
            else
            {
                ghostArray.Clear();
                ghostArray.Add("cavalier");
                Properties.Settings.Default.Ghost = "cavalier";
                Properties.Settings.Default.Save();
            }
        }
        private void GhostDepths(object sender, RoutedEventArgs e)
        {
            if (ghostArray.Contains("depths"))
            {
                return;
            }
            else
            {
                ghostArray.Clear();
                ghostArray.Add("depths");
                Properties.Settings.Default.Ghost = "depths";
                Properties.Settings.Default.Save();
            }
        }
        private void GhostDotExe(object sender, RoutedEventArgs e)
        {
            if (ghostArray.Contains("dotexe"))
            {
                return;
            }
            else
            {
                ghostArray.Clear();
                ghostArray.Add("dotexe");
                Properties.Settings.Default.Ghost = "dotexe";
                Properties.Settings.Default.Save();
            }
        }
        private void GhostEclipse(object sender, RoutedEventArgs e)
        {
            if (ghostArray.Contains("eclipse"))
            {
                return;
            }
            else
            {
                ghostArray.Clear();
                ghostArray.Add("eclipse");
                Properties.Settings.Default.Ghost = "eclipse";
                Properties.Settings.Default.Save();
            }
        }
        private void GhostEgo(object sender, RoutedEventArgs e)
        {
            if (ghostArray.Contains("ego"))
            {
                return;
            }
            else
            {
                ghostArray.Clear();
                ghostArray.Add("ego");
                Properties.Settings.Default.Ghost = "ego";
                Properties.Settings.Default.Save();
            }
        }
        private void GhostGaias(object sender, RoutedEventArgs e)
        {
            if (ghostArray.Contains("gaias"))
            {
                return;
            }
            else
            {
                ghostArray.Clear();
                ghostArray.Add("gaias");
                Properties.Settings.Default.Ghost = "gaias";
                Properties.Settings.Default.Save();
            }
        }
        private void GhostGoldwing(object sender, RoutedEventArgs e)
        {
            if (ghostArray.Contains("goldwing"))
            {
                return;
            }
            else
            {
                ghostArray.Clear();
                ghostArray.Add("goldwing");
                Properties.Settings.Default.Ghost = "goldwing";
                Properties.Settings.Default.Save();
            }
        }
        private void GhostHush(object sender, RoutedEventArgs e)
        {
            if (ghostArray.Contains("hush"))
            {
                return;
            }
            else
            {
                ghostArray.Clear();
                ghostArray.Add("hush");
                Properties.Settings.Default.Ghost = "hush";
                Properties.Settings.Default.Save();
            }
        }
        private void GhostInfantry(object sender, RoutedEventArgs e)
        {
            if (ghostArray.Contains("infantry"))
            {
                return;
            }
            else
            {
                ghostArray.Clear();
                ghostArray.Add("infantry");
                Properties.Settings.Default.Ghost = "infantry";
                Properties.Settings.Default.Save();
            }
        }
        private void GhostJigsaw(object sender, RoutedEventArgs e)
        {
            if (ghostArray.Contains("jigsaw"))
            {
                return;
            }
            else
            {
                ghostArray.Clear();
                ghostArray.Add("jigsaw");
                Properties.Settings.Default.Ghost = "jigsaw";
                Properties.Settings.Default.Save();
            }
        }
        private void GhostLuxe(object sender, RoutedEventArgs e)
        {
            if (ghostArray.Contains("luxe"))
            {
                return;
            }
            else
            {
                ghostArray.Clear();
                ghostArray.Add("luxe");
                Properties.Settings.Default.Ghost = "luxe";
                Properties.Settings.Default.Save();
            }
        }
        private void GhostLycan(object sender, RoutedEventArgs e)
        {
            if (ghostArray.Contains("lycan"))
            {
                return;
            }
            else
            {
                ghostArray.Clear();
                ghostArray.Add("lycan");
                Properties.Settings.Default.Ghost = "lycan";
                Properties.Settings.Default.Save();
            }
        }
        private void GhostMagepunk(object sender, RoutedEventArgs e)
        {
            if (ghostArray.Contains("magepunk"))
            {
                return;
            }
            else
            {
                ghostArray.Clear();
                ghostArray.Add("magepunk");
                Properties.Settings.Default.Ghost = "magepunk";
                Properties.Settings.Default.Save();
            }
        }
        private void GhostOutpost(object sender, RoutedEventArgs e)
        {
            if (ghostArray.Contains("outpost"))
            {
                return;
            }
            else
            {
                ghostArray.Clear();
                ghostArray.Add("outpost");
                Properties.Settings.Default.Ghost = "outpost";
                Properties.Settings.Default.Save();
            }
        }
        private void GhostPrism(object sender, RoutedEventArgs e)
        {
            if (ghostArray.Contains("prism"))
            {
                return;
            }
            else
            {
                ghostArray.Clear();
                ghostArray.Add("prism");
                Properties.Settings.Default.Ghost = "prism";
                Properties.Settings.Default.Save();
            }
        }
        private void GhostRecon(object sender, RoutedEventArgs e)
        {
            if (ghostArray.Contains("recon"))
            {
                return;
            }
            else
            {
                ghostArray.Clear();
                ghostArray.Add("recon");
                Properties.Settings.Default.Ghost = "recon";
                Properties.Settings.Default.Save();
            }
        }
        private void GhostRuination(object sender, RoutedEventArgs e)
        {
            if (ghostArray.Contains("ruination"))
            {
                return;
            }
            else
            {
                ghostArray.Clear();
                ghostArray.Add("ruination");
                Properties.Settings.Default.Ghost = "ruination";
                Properties.Settings.Default.Save();
            }
        }
        private void GhostSerenity(object sender, RoutedEventArgs e)
        {
            if (ghostArray.Contains("serenity"))
            {
                return;
            }
            else
            {
                ghostArray.Clear();
                ghostArray.Add("serenity");
                Properties.Settings.Default.Ghost = "serenity";
                Properties.Settings.Default.Save();
            }
        }
        private void GhostSoulSilencer(object sender, RoutedEventArgs e)
        {
            if (ghostArray.Contains("soul"))
            {
                return;
            }
            else
            {
                ghostArray.Clear();
                ghostArray.Add("soul");
                Properties.Settings.Default.Ghost = "soul";
                Properties.Settings.Default.Save();
            }
        }
        private void GhostSovereign(object sender, RoutedEventArgs e)
        {
            if (ghostArray.Contains("sovereign"))
            {
                return;
            }
            else
            {
                ghostArray.Clear();
                ghostArray.Add("sovereign");
                Properties.Settings.Default.Ghost = "sovereign";
                Properties.Settings.Default.Save();
            }
        }
        private void GhostTethered(object sender, RoutedEventArgs e)
        {
            if (ghostArray.Contains("tethered"))
            {
                return;
            }
            else
            {
                ghostArray.Clear();
                ghostArray.Add("tethered");
                Properties.Settings.Default.Ghost = "tethered";
                Properties.Settings.Default.Save();
            }
        }
        private void GhostValGo(object sender, RoutedEventArgs e)
        {
            if (ghostArray.Contains("valgo"))
            {
                return;
            }
            else
            {
                ghostArray.Clear();
                ghostArray.Add("valgo");
                Properties.Settings.Default.Ghost = "valgo";
                Properties.Settings.Default.Save();
            }
        }
        private void GhostVendetta(object sender, RoutedEventArgs e)
        {
            if (ghostArray.Contains("vendetta"))
            {
                return;
            }
            else
            {
                ghostArray.Clear();
                ghostArray.Add("vendetta");
                Properties.Settings.Default.Ghost = "vendetta";
                Properties.Settings.Default.Save();
            }
        }
        private void GhostWunderland(object sender, RoutedEventArgs e)
        {
            if (ghostArray.Contains("wunderland"))
            {
                return;
            }
            else
            {
                ghostArray.Clear();
                ghostArray.Add("wunderland");
                Properties.Settings.Default.Ghost = "wunderland";
                Properties.Settings.Default.Save();
            }
        }

        //sheriff skins
        private void SheriffDefault(object sender, RoutedEventArgs e)
        {
            if (sheriffArray.Contains("default"))
            {
                return;
            }
            else
            {
                sheriffArray.Clear();
                sheriffArray.Add("default");
                Properties.Settings.Default.Sheriff = "default";
                Properties.Settings.Default.Save();
            }
        }
        private void SheriffArcane(object sender, RoutedEventArgs e)
        {
            if (sheriffArray.Contains("arcane"))
            {
                return;
            }
            else
            {
                sheriffArray.Clear();
                sheriffArray.Add("arcane");
                Properties.Settings.Default.Sheriff = "arcane";
                Properties.Settings.Default.Save();
            }
        }
        private void SheriffAristocrat(object sender, RoutedEventArgs e)
        {
            if (sheriffArray.Contains("aristocrat"))
            {
                return;
            }
            else
            {
                sheriffArray.Clear();
                sheriffArray.Add("aristocrat");
                Properties.Settings.Default.Sheriff = "aristocrat";
                Properties.Settings.Default.Save();
            }
        }
        private void SheriffConvex(object sender, RoutedEventArgs e)
        {
            if (sheriffArray.Contains("convex"))
            {
                return;
            }
            else
            {
                sheriffArray.Clear();
                sheriffArray.Add("convex");
                Properties.Settings.Default.Sheriff = "convex";
                Properties.Settings.Default.Save();
            }
        }
        private void SheriffDeathWish(object sender, RoutedEventArgs e)
        {
            if (sheriffArray.Contains("deathwish"))
            {
                return;
            }
            else
            {
                sheriffArray.Clear();
                sheriffArray.Add("deathwish");
                Properties.Settings.Default.Sheriff = "deathwish";
                Properties.Settings.Default.Save();
            }
        }
        private void SheriffGameOver(object sender, RoutedEventArgs e)
        {
            if (sheriffArray.Contains("gameover"))
            {
                return;
            }
            else
            {
                sheriffArray.Clear();
                sheriffArray.Add("gameover");
                Properties.Settings.Default.Sheriff = "gameover";
                Properties.Settings.Default.Save();
            }
        }
        private void SheriffIon(object sender, RoutedEventArgs e)
        {
            if (sheriffArray.Contains("ion"))
            {
                return;
            }
            else
            {
                sheriffArray.Clear();
                sheriffArray.Add("ion");
                Properties.Settings.Default.Sheriff = "ion";
                Properties.Settings.Default.Save();
            }
        }
        private void SheriffKTAC(object sender, RoutedEventArgs e)
        {
            if (sheriffArray.Contains("ktac"))
            {
                return;
            }
            else
            {
                sheriffArray.Clear();
                sheriffArray.Add("ktac");
                Properties.Settings.Default.Sheriff = "ktac";
                Properties.Settings.Default.Save();
            }
        }
        private void SheriffLightwave(object sender, RoutedEventArgs e)
        {
            if (sheriffArray.Contains("lightwave"))
            {
                return;
            }
            else
            {
                sheriffArray.Clear();
                sheriffArray.Add("lightwave");
                Properties.Settings.Default.Sheriff = "lightwave";
                Properties.Settings.Default.Save();
            }
        }
        private void SheriffMagepunk(object sender, RoutedEventArgs e)
        {
            if (sheriffArray.Contains("magepunk"))
            {
                return;
            }
            else
            {
                sheriffArray.Clear();
                sheriffArray.Add("magepunk");
                Properties.Settings.Default.Sheriff = "magepunk";
                Properties.Settings.Default.Save();
            }
        }
        private void SheriffMinima(object sender, RoutedEventArgs e)
        {
            if (sheriffArray.Contains("minima"))
            {
                return;
            }
            else
            {
                sheriffArray.Clear();
                sheriffArray.Add("minima");
                Properties.Settings.Default.Sheriff = "minima";
                Properties.Settings.Default.Save();
            }
        }
        private void SheriffNebula(object sender, RoutedEventArgs e)
        {
            if (sheriffArray.Contains("nebula"))
            {
                return;
            }
            else
            {
                sheriffArray.Clear();
                sheriffArray.Add("nebula");
                Properties.Settings.Default.Sheriff = "nebula";
                Properties.Settings.Default.Save();
            }
        }
        private void SheriffPeacekeeper(object sender, RoutedEventArgs e)
        {
            if (sheriffArray.Contains("peacekeeper"))
            {
                return;
            }
            else
            {
                sheriffArray.Clear();
                sheriffArray.Add("peacekeeper");
                Properties.Settings.Default.Sheriff = "peacekeeper";
                Properties.Settings.Default.Save();
            }
        }
        private void SheriffPolyfox(object sender, RoutedEventArgs e)
        {
            if (sheriffArray.Contains("polyfox"))
            {
                return;
            }
            else
            {
                sheriffArray.Clear();
                sheriffArray.Add("polyfox");
                Properties.Settings.Default.Sheriff = "polyfox";
                Properties.Settings.Default.Save();
            }
        }
        private void SheriffPolyfrog(object sender, RoutedEventArgs e)
        {
            if (sheriffArray.Contains("polyfrog"))
            {
                return;
            }
            else
            {
                sheriffArray.Clear();
                sheriffArray.Add("polyfrog");
                Properties.Settings.Default.Sheriff = "polyfrog";
                Properties.Settings.Default.Save();
            }
        }
        private void SheriffPrism(object sender, RoutedEventArgs e)
        {
            if (sheriffArray.Contains("prism"))
            {
                return;
            }
            else
            {
                sheriffArray.Clear();
                sheriffArray.Add("prism");
                Properties.Settings.Default.Sheriff = "prism";
                Properties.Settings.Default.Save();
            }
        }
        private void SheriffProtektor(object sender, RoutedEventArgs e)
        {
            if (sheriffArray.Contains("protektor"))
            {
                return;
            }
            else
            {
                sheriffArray.Clear();
                sheriffArray.Add("protektor");
                Properties.Settings.Default.Sheriff = "protektor";
                Properties.Settings.Default.Save();
            }
        }
        private void SheriffProtocol(object sender, RoutedEventArgs e)
        {
            if (sheriffArray.Contains("protocol"))
            {
                return;
            }
            else
            {
                sheriffArray.Clear();
                sheriffArray.Add("protocol");
                Properties.Settings.Default.Sheriff = "protocol";
                Properties.Settings.Default.Save();
            }
        }
        private void SheriffReaver(object sender, RoutedEventArgs e)
        {
            if (sheriffArray.Contains("reaver"))
            {
                return;
            }
            else
            {
                sheriffArray.Clear();
                sheriffArray.Add("reaver");
                Properties.Settings.Default.Sheriff = "reaver";
                Properties.Settings.Default.Save();
            }
        }
        private void SheriffSakura(object sender, RoutedEventArgs e)
        {
            if (sheriffArray.Contains("sakura"))
            {
                return;
            }
            else
            {
                sheriffArray.Clear();
                sheriffArray.Add("sakura");
                Properties.Settings.Default.Sheriff = "sakura";
                Properties.Settings.Default.Save();
            }
        }
        private void SheriffSchema(object sender, RoutedEventArgs e)
        {
            if (sheriffArray.Contains("schema"))
            {
                return;
            }
            else
            {
                sheriffArray.Clear();
                sheriffArray.Add("schema");
                Properties.Settings.Default.Sheriff = "schema";
                Properties.Settings.Default.Save();
            }
        }
        private void SheriffSentinels(object sender, RoutedEventArgs e)
        {
            if (sheriffArray.Contains("sentinels"))
            {
                return;
            }
            else
            {
                sheriffArray.Clear();
                sheriffArray.Add("sentinels");
                Properties.Settings.Default.Sheriff = "sentinels";
                Properties.Settings.Default.Save();
            }
        }
        private void SheriffSilvanus(object sender, RoutedEventArgs e)
        {
            if (sheriffArray.Contains("silvanus"))
            {
                return;
            }
            else
            {
                sheriffArray.Clear();
                sheriffArray.Add("silvanus");
                Properties.Settings.Default.Sheriff = "silvanus";
                Properties.Settings.Default.Save();
            }
        }
        private void SheriffSingularity(object sender, RoutedEventArgs e)
        {
            if (sheriffArray.Contains("singularity"))
            {
                return;
            }
            else
            {
                sheriffArray.Clear();
                sheriffArray.Add("singularity");
                Properties.Settings.Default.Sheriff = "singularity";
                Properties.Settings.Default.Save();
            }
        }
        private void SheriffSurge(object sender, RoutedEventArgs e)
        {
            if (sheriffArray.Contains("surge"))
            {
                return;
            }
            else
            {
                sheriffArray.Clear();
                sheriffArray.Add("surge");
                Properties.Settings.Default.Sheriff = "surge";
                Properties.Settings.Default.Save();
            }
        }
        private void SheriffVarnish(object sender, RoutedEventArgs e)
        {
            if (sheriffArray.Contains("varnish"))
            {
                return;
            }
            else
            {
                sheriffArray.Clear();
                sheriffArray.Add("varnish");
                Properties.Settings.Default.Sheriff = "varnish";
                Properties.Settings.Default.Save();
            }
        }
        private void SheriffWasteland(object sender, RoutedEventArgs e)
        {
            if (sheriffArray.Contains("wasteland"))
            {
                return;
            }
            else
            {
                sheriffArray.Clear();
                sheriffArray.Add("wasteland");
                Properties.Settings.Default.Sheriff = "wasteland";
                Properties.Settings.Default.Save();
            }
        }

        //shorty skins
        private void ShortyDefault(object sender, RoutedEventArgs e)
        {
            if (shortyArray.Contains("default"))
            {
                return;
            }
            else
            {
                shortyArray.Clear();
                shortyArray.Add("default");
                Properties.Settings.Default.Shorty = "default";
                Properties.Settings.Default.Save();
            }
        }
        private void ShortyAerosol(object sender, RoutedEventArgs e)
        {
            if (shortyArray.Contains("aerosol"))
            {
                return;
            }
            else
            {
                shortyArray.Clear();
                shortyArray.Add("aerosol");
                Properties.Settings.Default.Shorty = "aerosol";
                Properties.Settings.Default.Save();
            }
        }
        private void ShortyGenesis(object sender, RoutedEventArgs e)
        {
            if (shortyArray.Contains("genesis"))
            {
                return;
            }
            else
            {
                shortyArray.Clear();
                shortyArray.Add("genesis");
                Properties.Settings.Default.Shorty = "genesis";
                Properties.Settings.Default.Save();
            }
        }
        private void ShortyHivemind(object sender, RoutedEventArgs e)
        {
            if (shortyArray.Contains("hivemind"))
            {
                return;
            }
            else
            {
                shortyArray.Clear();
                shortyArray.Add("hivemind");
                Properties.Settings.Default.Shorty = "hivemind";
                Properties.Settings.Default.Save();
            }
        }
        private void ShortyMonarch(object sender, RoutedEventArgs e)
        {
            if (shortyArray.Contains("monarch"))
            {
                return;
            }
            else
            {
                shortyArray.Clear();
                shortyArray.Add("monarch");
                Properties.Settings.Default.Shorty = "monarch";
                Properties.Settings.Default.Save();
            }
        }
        private void ShortyOni(object sender, RoutedEventArgs e)
        {
            if (shortyArray.Contains("oni"))
            {
                return;
            }
            else
            {
                shortyArray.Clear();
                shortyArray.Add("oni");
                Properties.Settings.Default.Shorty = "oni";
                Properties.Settings.Default.Save();
            }
        }
        private void ShortyPrism(object sender, RoutedEventArgs e)
        {
            if (shortyArray.Contains("prism"))
            {
                return;
            }
            else
            {
                shortyArray.Clear();
                shortyArray.Add("prism");
                Properties.Settings.Default.Shorty = "prism";
                Properties.Settings.Default.Save();
            }
        }
        private void ShortyRuin(object sender, RoutedEventArgs e)
        {
            if (shortyArray.Contains("ruin"))
            {
                return;
            }
            else
            {
                shortyArray.Clear();
                shortyArray.Add("ruin");
                Properties.Settings.Default.Shorty = "ruin";
                Properties.Settings.Default.Save();
            }
        }
        private void ShortySnakebite(object sender, RoutedEventArgs e)
        {
            if (shortyArray.Contains("snakebite"))
            {
                return;
            }
            else
            {
                shortyArray.Clear();
                shortyArray.Add("snakebite");
                Properties.Settings.Default.Shorty = "snakebite";
                Properties.Settings.Default.Save();
            }
        }
        private void ShortyTigris(object sender, RoutedEventArgs e)
        {
            if (shortyArray.Contains("tigris"))
            {
                return;
            }
            else
            {
                shortyArray.Clear();
                shortyArray.Add("tigris");
                Properties.Settings.Default.Shorty = "tigris";
                Properties.Settings.Default.Save();
            }
        }
        private void ShortyVelocity(object sender, RoutedEventArgs e)
        {
            if (shortyArray.Contains("velocity"))
            {
                return;
            }
            else
            {
                shortyArray.Clear();
                shortyArray.Add("velocity");
                Properties.Settings.Default.Shorty = "velocity";
                Properties.Settings.Default.Save();
            }
        }
        private void ShortyWasteland(object sender, RoutedEventArgs e)
        {
            if (shortyArray.Contains("wasteland"))
            {
                return;
            }
            else
            {
                shortyArray.Clear();
                shortyArray.Add("wasteland");
                Properties.Settings.Default.Shorty = "wasteland";
                Properties.Settings.Default.Save();
            }
        }
        private void ShortyWayfinder(object sender, RoutedEventArgs e)
        {
            if (shortyArray.Contains("wayfinder"))
            {
                return;
            }
            else
            {
                shortyArray.Clear();
                shortyArray.Add("wayfinder");
                Properties.Settings.Default.Shorty = "wayfinder";
                Properties.Settings.Default.Save();
            }
        }
        private void ShortyWunderkind(object sender, RoutedEventArgs e)
        {
            if (shortyArray.Contains("wunderkind"))
            {
                return;
            }
            else
            {
                shortyArray.Clear();
                shortyArray.Add("wunderkind");
                Properties.Settings.Default.Shorty = "wunderkind";
                Properties.Settings.Default.Save();
            }
        }

        //ares skins
        private void aresDefault(object sender, RoutedEventArgs e)
        {
            if (aresArray.Contains("default"))
            {
                return;
            }
            else
            {
                aresArray.Clear();
                aresArray.Add("default");
                Properties.Settings.Default.Ares = "default";
                Properties.Settings.Default.Save();
            }
        }
        private void aresAristocrat(object sender, RoutedEventArgs e)
        {
            if (aresArray.Contains("aristocrat"))
            {
                return;
            }
            else
            {
                aresArray.Clear();
                aresArray.Add("aristocrat");
                Properties.Settings.Default.Ares = "aristocrat";
                Properties.Settings.Default.Save();
            }
        }
        private void aresCelestial(object sender, RoutedEventArgs e)
        {
            if (aresArray.Contains("celestial"))
            {
                return;
            }
            else
            {
                aresArray.Clear();
                aresArray.Add("celestial");
                Properties.Settings.Default.Ares = "celestial";
                Properties.Settings.Default.Save();
            }
        }
        private void aresDivine(object sender, RoutedEventArgs e)
        {
            if (aresArray.Contains("divine"))
            {
                return;
            }
            else
            {
                aresArray.Clear();
                aresArray.Add("divine");
                Properties.Settings.Default.Ares = "divine";
                Properties.Settings.Default.Save();
            }
        }
        private void aresGoldwing(object sender, RoutedEventArgs e)
        {
            if (aresArray.Contains("goldwing"))
            {
                return;
            }
            else
            {
                aresArray.Clear();
                aresArray.Add("goldwing");
                Properties.Settings.Default.Ares = "goldwing";
                Properties.Settings.Default.Save();
            }
        }
        private void aresHivemind(object sender, RoutedEventArgs e)
        {
            if (aresArray.Contains("hivemind"))
            {
                return;
            }
            else
            {
                aresArray.Clear();
                aresArray.Add("hivemind");
                Properties.Settings.Default.Ares = "hivemind";
                Properties.Settings.Default.Save();
            }
        }
        private void aresInfantry(object sender, RoutedEventArgs e)
        {
            if (aresArray.Contains("infantry"))
            {
                return;
            }
            else
            {
                aresArray.Clear();
                aresArray.Add("infantry");
                Properties.Settings.Default.Ares = "infantry";
                Properties.Settings.Default.Save();
            }
        }
        private void aresJigsaw(object sender, RoutedEventArgs e)
        {
            if (aresArray.Contains("jigsaw"))
            {
                return;
            }
            else
            {
                aresArray.Clear();
                aresArray.Add("jigsaw");
                Properties.Settings.Default.Ares = "jigsaw";
                Properties.Settings.Default.Save();
            }
        }
        private void aresMagepunk(object sender, RoutedEventArgs e)
        {
            if (aresArray.Contains("magepunk"))
            {
                return;
            }
            else
            {
                aresArray.Clear();
                aresArray.Add("magepunk");
                Properties.Settings.Default.Ares = "magepunk";
                Properties.Settings.Default.Save();
            }
        }
        private void aresMinima(object sender, RoutedEventArgs e)
        {
            if (aresArray.Contains("minima"))
            {
                return;
            }
            else
            {
                aresArray.Clear();
                aresArray.Add("minima");
                Properties.Settings.Default.Ares = "minima";
                Properties.Settings.Default.Save();
            }
        }
        private void aresNebula(object sender, RoutedEventArgs e)
        {
            if (aresArray.Contains("nebula"))
            {
                return;
            }
            else
            {
                aresArray.Clear();
                aresArray.Add("nebula");
                Properties.Settings.Default.Ares = "nebula";
                Properties.Settings.Default.Save();
            }
        }
        private void aresOlvidados(object sender, RoutedEventArgs e)
        {
            if (aresArray.Contains("olvidados"))
            {
                return;
            }
            else
            {
                aresArray.Clear();
                aresArray.Add("olvidados");
                Properties.Settings.Default.Ares = "olvidados";
                Properties.Settings.Default.Save();
            }
        }
        private void aresOutpost(object sender, RoutedEventArgs e)
        {
            if (aresArray.Contains("outpost"))
            {
                return;
            }
            else
            {
                aresArray.Clear();
                aresArray.Add("outpost");
                Properties.Settings.Default.Ares = "outpost";
                Properties.Settings.Default.Save();
            }
        }
        private void aresPolyfrog(object sender, RoutedEventArgs e)
        {
            if (aresArray.Contains("polyfrog"))
            {
                return;
            }
            else
            {
                aresArray.Clear();
                aresArray.Add("polyfrog");
                Properties.Settings.Default.Ares = "polyfrog";
                Properties.Settings.Default.Save();
            }
        }
        private void aresPrism(object sender, RoutedEventArgs e)
        {
            if (aresArray.Contains("prism"))
            {
                return;
            }
            else
            {
                aresArray.Clear();
                aresArray.Add("prism");
                Properties.Settings.Default.Ares = "prism";
                Properties.Settings.Default.Save();
            }
        }
        private void aresRush(object sender, RoutedEventArgs e)
        {
            if (aresArray.Contains("rush"))
            {
                return;
            }
            else
            {
                aresArray.Clear();
                aresArray.Add("rush");
                Properties.Settings.Default.Ares = "rush";
                Properties.Settings.Default.Save();
            }
        }
        private void aresSakura(object sender, RoutedEventArgs e)
        {
            if (aresArray.Contains("sakura"))
            {
                return;
            }
            else
            {
                aresArray.Clear();
                aresArray.Add("sakura");
                Properties.Settings.Default.Ares = "sakura";
                Properties.Settings.Default.Save();
            }
        }
        private void aresSentinels(object sender, RoutedEventArgs e)
        {
            if (aresArray.Contains("sentinels"))
            {
                return;
            }
            else
            {
                aresArray.Clear();
                aresArray.Add("sentinels");
                Properties.Settings.Default.Ares = "sentinels";
                Properties.Settings.Default.Save();
            }
        }
        private void aresSingularity(object sender, RoutedEventArgs e)
        {
            if (aresArray.Contains("singularity"))
            {
                return;
            }
            else
            {
                aresArray.Clear();
                aresArray.Add("singularity");
                Properties.Settings.Default.Ares = "singularity";
                Properties.Settings.Default.Save();
            }
        }
        private void aresSnowfall(object sender, RoutedEventArgs e)
        {
            if (aresArray.Contains("snowfall"))
            {
                return;
            }
            else
            {
                aresArray.Clear();
                aresArray.Add("snowfall");
                Properties.Settings.Default.Ares = "snowfall";
                Properties.Settings.Default.Save();
            }
        }
        private void aresValgo(object sender, RoutedEventArgs e)
        {
            if (aresArray.Contains("valgo"))
            {
                return;
            }
            else
            {
                aresArray.Clear();
                aresArray.Add("valgo");
                Properties.Settings.Default.Ares = "valgo";
                Properties.Settings.Default.Save();
            }
        }

        //bucky skins
        private void buckyDefault(object sender, RoutedEventArgs e)
        {
            if (buckyArray.Contains("default"))
            {
                return;
            }
            else
            {
                buckyArray.Clear();
                buckyArray.Add("default");
                Properties.Settings.Default.Bucky = "default";
                Properties.Settings.Default.Save();
            }
        }
        private void buckyAerosol(object sender, RoutedEventArgs e)
        {
            if (buckyArray.Contains("aerosol"))
            {
                return;
            }
            else
            {
                buckyArray.Clear();
                buckyArray.Add("aerosol");
                Properties.Settings.Default.Bucky = "aerosol";
                Properties.Settings.Default.Save();
            }
        }
        private void buckyArtisan(object sender, RoutedEventArgs e)
        {
            if (buckyArray.Contains("artisan"))
            {
                return;
            }
            else
            {
                buckyArray.Clear();
                buckyArray.Add("artisan");
                Properties.Settings.Default.Bucky = "artisan";
                Properties.Settings.Default.Save();
            }
        }
        private void buckyCavalier(object sender, RoutedEventArgs e)
        {
            if (buckyArray.Contains("cavalier"))
            {
                return;
            }
            else
            {
                buckyArray.Clear();
                buckyArray.Add("cavalier");
                Properties.Settings.Default.Bucky = "cavalier";
                Properties.Settings.Default.Save();
            }
        }
        private void buckyGalleria(object sender, RoutedEventArgs e)
        {
            if (buckyArray.Contains("galleria"))
            {
                return;
            }
            else
            {
                buckyArray.Clear();
                buckyArray.Add("galleria");
                Properties.Settings.Default.Bucky = "galleria";
                Properties.Settings.Default.Save();
            }
        }
        private void buckyGenesis(object sender, RoutedEventArgs e)
        {
            if (buckyArray.Contains("genesis"))
            {
                return;
            }
            else
            {
                buckyArray.Clear();
                buckyArray.Add("genesis");
                Properties.Settings.Default.Bucky = "genesis";
                Properties.Settings.Default.Save();
            }
        }
        private void buckyNeuroblaster(object sender, RoutedEventArgs e)
        {
            if (buckyArray.Contains("neuroblaster"))
            {
                return;
            }
            else
            {
                buckyArray.Clear();
                buckyArray.Add("neuroblaster");
                Properties.Settings.Default.Bucky = "neuroblaster";
                Properties.Settings.Default.Save();
            }
        }
        private void buckyHorizon(object sender, RoutedEventArgs e)
        {
            if (buckyArray.Contains("horizon"))
            {
                return;
            }
            else
            {
                buckyArray.Clear();
                buckyArray.Add("horizon");
                Properties.Settings.Default.Bucky = "horizon";
                Properties.Settings.Default.Save();
            }
        }
        private void buckyHydrodip(object sender, RoutedEventArgs e)
        {
            if (buckyArray.Contains("hydrodip"))
            {
                return;
            }
            else
            {
                buckyArray.Clear();
                buckyArray.Add("hydrodip");
                Properties.Settings.Default.Bucky = "hydrodip";
                Properties.Settings.Default.Save();
            }
        }
        private void buckyIon(object sender, RoutedEventArgs e)
        {
            if (buckyArray.Contains("ion"))
            {
                return;
            }
            else
            {
                buckyArray.Clear();
                buckyArray.Add("ion");
                Properties.Settings.Default.Bucky = "ion";
                Properties.Settings.Default.Save();
            }
        }
        private void buckyKingdom(object sender, RoutedEventArgs e)
        {
            if (buckyArray.Contains("kingdom"))
            {
                return;
            }
            else
            {
                buckyArray.Clear();
                buckyArray.Add("kingdom");
                Properties.Settings.Default.Bucky = "kingdom";
                Properties.Settings.Default.Save();
            }
        }
        private void buckyLightwave(object sender, RoutedEventArgs e)
        {
            if (buckyArray.Contains("lightwave"))
            {
                return;
            }
            else
            {
                buckyArray.Clear();
                buckyArray.Add("lightwave");
                Properties.Settings.Default.Bucky = "lightwave";
                Properties.Settings.Default.Save();
            }
        }
        private void buckyMagepunk(object sender, RoutedEventArgs e)
        {
            if (buckyArray.Contains("magepunk"))
            {
                return;
            }
            else
            {
                buckyArray.Clear();
                buckyArray.Add("magepunk");
                Properties.Settings.Default.Bucky = "magepunk";
                Properties.Settings.Default.Save();
            }
        }
        private void buckyMonarch(object sender, RoutedEventArgs e)
        {
            if (buckyArray.Contains("monarch"))
            {
                return;
            }
            else
            {
                buckyArray.Clear();
                buckyArray.Add("monarch");
                Properties.Settings.Default.Bucky = "monarch";
                Properties.Settings.Default.Save();
            }
        }
        private void buckyOni(object sender, RoutedEventArgs e)
        {
            if (buckyArray.Contains("oni"))
            {
                return;
            }
            else
            {
                buckyArray.Clear();
                buckyArray.Add("oni");
                Properties.Settings.Default.Bucky = "oni";
                Properties.Settings.Default.Save();
            }
        }
        private void buckyOrigin(object sender, RoutedEventArgs e)
        {
            if (buckyArray.Contains("origin"))
            {
                return;
            }
            else
            {
                buckyArray.Clear();
                buckyArray.Add("origin");
                Properties.Settings.Default.Bucky = "origin";
                Properties.Settings.Default.Save();
            }
        }
        private void buckyPrime(object sender, RoutedEventArgs e)
        {
            if (buckyArray.Contains("prime"))
            {
                return;
            }
            else
            {
                buckyArray.Clear();
                buckyArray.Add("prime");
                Properties.Settings.Default.Bucky = "prime";
                Properties.Settings.Default.Save();
            }
        }
        private void buckyPrism(object sender, RoutedEventArgs e)
        {
            if (buckyArray.Contains("prism"))
            {
                return;
            }
            else
            {
                buckyArray.Clear();
                buckyArray.Add("prism");
                Properties.Settings.Default.Bucky = "prism";
                Properties.Settings.Default.Save();
            }
        }
        private void buckyCrisis(object sender, RoutedEventArgs e)
        {
            if (buckyArray.Contains("crisis"))
            {
                return;
            }
            else
            {
                buckyArray.Clear();
                buckyArray.Add("crisis");
                Properties.Settings.Default.Bucky = "crisis";
                Properties.Settings.Default.Save();
            }
        }
        private void buckyRedalert(object sender, RoutedEventArgs e)
        {
            if (buckyArray.Contains("redalert"))
            {
                return;
            }
            else
            {
                buckyArray.Clear();
                buckyArray.Add("redalert");
                Properties.Settings.Default.Bucky = "redalert";
                Properties.Settings.Default.Save();
            }
        }
        private void buckySurge(object sender, RoutedEventArgs e)
        {
            if (buckyArray.Contains("surge"))
            {
                return;
            }
            else
            {
                buckyArray.Clear();
                buckyArray.Add("surge");
                Properties.Settings.Default.Bucky = "surge";
                Properties.Settings.Default.Save();
            }
        }

        //bulldog skins
        private void bulldogDefault(object sender, RoutedEventArgs e)
        {
            if (bulldogArray.Contains("default"))
            {
                return;
            }
            else
            {
                bulldogArray.Clear();
                bulldogArray.Add("default");
                Properties.Settings.Default.Bulldog = "default";
                Properties.Settings.Default.Save();
            }
        }
        private void bulldogAristocrat(object sender, RoutedEventArgs e)
        {
            if (bulldogArray.Contains("aristocrat"))
            {
                return;
            }
            else
            {
                bulldogArray.Clear();
                bulldogArray.Add("aristocrat");
                Properties.Settings.Default.Bulldog = "aristocrat";
                Properties.Settings.Default.Save();
            }
        }
        private void bulldogConvex(object sender, RoutedEventArgs e)
        {
            if (bulldogArray.Contains("convex"))
            {
                return;
            }
            else
            {
                bulldogArray.Clear();
                bulldogArray.Add("convex");
                Properties.Settings.Default.Bulldog = "convex";
                Properties.Settings.Default.Save();
            }
        }
        private void bulldogCouture(object sender, RoutedEventArgs e)
        {
            if (bulldogArray.Contains("couture"))
            {
                return;
            }
            else
            {
                bulldogArray.Clear();
                bulldogArray.Add("couture");
                Properties.Settings.Default.Bulldog = "couture";
                Properties.Settings.Default.Save();
            }
        }
        private void bulldogDepths(object sender, RoutedEventArgs e)
        {
            if (bulldogArray.Contains("depths"))
            {
                return;
            }
            else
            {
                bulldogArray.Clear();
                bulldogArray.Add("depths");
                Properties.Settings.Default.Bulldog = "depths";
                Properties.Settings.Default.Save();
            }
        }
        private void bulldogGenesis(object sender, RoutedEventArgs e)
        {
            if (bulldogArray.Contains("genesis"))
            {
                return;
            }
            else
            {
                bulldogArray.Clear();
                bulldogArray.Add("genesis");
                Properties.Settings.Default.Bulldog = "genesis";
                Properties.Settings.Default.Save();
            }
        }
        private void bulldogGlitchpop(object sender, RoutedEventArgs e)
        {
            if (bulldogArray.Contains("glitchpop"))
            {
                return;
            }
            else
            {
                bulldogArray.Clear();
                bulldogArray.Add("glitchpop");
                Properties.Settings.Default.Bulldog = "glitchpop";
                Properties.Settings.Default.Save();
            }
        }
        private void bulldogHorizon(object sender, RoutedEventArgs e)
        {
            if (bulldogArray.Contains("horizon"))
            {
                return;
            }
            else
            {
                bulldogArray.Clear();
                bulldogArray.Add("horizon");
                Properties.Settings.Default.Bulldog = "horizon";
                Properties.Settings.Default.Save();
            }
        }
        private void bulldogInfinity(object sender, RoutedEventArgs e)
        {
            if (bulldogArray.Contains("infinity"))
            {
                return;
            }
            else
            {
                bulldogArray.Clear();
                bulldogArray.Add("infinity");
                Properties.Settings.Default.Bulldog = "infinity";
                Properties.Settings.Default.Save();
            }
        }
        private void bulldogKTAC(object sender, RoutedEventArgs e)
        {
            if (bulldogArray.Contains("ktac"))
            {
                return;
            }
            else
            {
                bulldogArray.Clear();
                bulldogArray.Add("ktac");
                Properties.Settings.Default.Bulldog = "ktac";
                Properties.Settings.Default.Save();
            }
        }
        private void bulldogOlvidados(object sender, RoutedEventArgs e)
        {
            if (bulldogArray.Contains("olvidados"))
            {
                return;
            }
            else
            {
                bulldogArray.Clear();
                bulldogArray.Add("olvidados");
                Properties.Settings.Default.Bulldog = "olvidados";
                Properties.Settings.Default.Save();
            }
        }
        private void bulldogPolyfox(object sender, RoutedEventArgs e)
        {
            if (bulldogArray.Contains("polyfox"))
            {
                return;
            }
            else
            {
                bulldogArray.Clear();
                bulldogArray.Add("polyfox");
                Properties.Settings.Default.Bulldog = "polyfox";
                Properties.Settings.Default.Save();
            }
        }
        private void bulldogProtocol(object sender, RoutedEventArgs e)
        {
            if (bulldogArray.Contains("protocol"))
            {
                return;
            }
            else
            {
                bulldogArray.Clear();
                bulldogArray.Add("protocol");
                Properties.Settings.Default.Bulldog = "protocol";
                Properties.Settings.Default.Save();
            }
        }
        private void bulldogRush(object sender, RoutedEventArgs e)
        {
            if (bulldogArray.Contains("rush"))
            {
                return;
            }
            else
            {
                bulldogArray.Clear();
                bulldogArray.Add("rush");
                Properties.Settings.Default.Bulldog = "rush";
                Properties.Settings.Default.Save();
            }
        }
        private void bulldogSpectrum(object sender, RoutedEventArgs e)
        {
            if (bulldogArray.Contains("spectrum"))
            {
                return;
            }
            else
            {
                bulldogArray.Clear();
                bulldogArray.Add("spectrum");
                Properties.Settings.Default.Bulldog = "spectrum";
                Properties.Settings.Default.Save();
            }
        }
        private void bulldogStriker(object sender, RoutedEventArgs e)
        {
            if (bulldogArray.Contains("striker"))
            {
                return;
            }
            else
            {
                bulldogArray.Clear();
                bulldogArray.Add("striker");
                Properties.Settings.Default.Bulldog = "striker";
                Properties.Settings.Default.Save();
            }
        }
        private void bulldogUndercity(object sender, RoutedEventArgs e)
        {
            if (bulldogArray.Contains("undercity"))
            {
                return;
            }
            else
            {
                bulldogArray.Clear();
                bulldogArray.Add("undercity");
                Properties.Settings.Default.Bulldog = "undercity";
                Properties.Settings.Default.Save();
            }
        }
        private void bulldogVarnish(object sender, RoutedEventArgs e)
        {
            if (bulldogArray.Contains("varnish"))
            {
                return;
            }
            else
            {
                bulldogArray.Clear();
                bulldogArray.Add("varnish");
                Properties.Settings.Default.Bulldog = "varnish";
                Properties.Settings.Default.Save();
            }
        }
        private void bulldogVelocity(object sender, RoutedEventArgs e)
        {
            if (bulldogArray.Contains("velocity"))
            {
                return;
            }
            else
            {
                bulldogArray.Clear();
                bulldogArray.Add("velocity");
                Properties.Settings.Default.Bulldog = "velocity";
                Properties.Settings.Default.Save();
            }
        }

        //guardian skins
        private void guardianDefault(object sender, RoutedEventArgs e)
        {
            if (guardianArray.Contains("default"))
            {
                return;
            }
            else
            {
                guardianArray.Clear();
                guardianArray.Add("default");
                Properties.Settings.Default.Guardian = "default";
                Properties.Settings.Default.Save();
            }
        }
        private void guardianAero(object sender, RoutedEventArgs e)
        {
            if (guardianArray.Contains("aero"))
            {
                return;
            }
            else
            {
                guardianArray.Clear();
                guardianArray.Add("aero");
                Properties.Settings.Default.Guardian = "aero";
                Properties.Settings.Default.Save();
            }
        }
        private void guardianEgo(object sender, RoutedEventArgs e)
        {
            if (guardianArray.Contains("ego"))
            {
                return;
            }
            else
            {
                guardianArray.Clear();
                guardianArray.Add("ego");
                Properties.Settings.Default.Guardian = "ego";
                Properties.Settings.Default.Save();
            }
        }
        private void guardianGaias(object sender, RoutedEventArgs e)
        {
            if (guardianArray.Contains("gaias"))
            {
                return;
            }
            else
            {
                guardianArray.Clear();
                guardianArray.Add("gaias");
                Properties.Settings.Default.Guardian = "gaias";
                Properties.Settings.Default.Save();
            }
        }
        private void guardianGalleria(object sender, RoutedEventArgs e)
        {
            if (guardianArray.Contains("galleria"))
            {
                return;
            }
            else
            {
                guardianArray.Clear();
                guardianArray.Add("galleria");
                Properties.Settings.Default.Guardian = "galleria";
                Properties.Settings.Default.Save();
            }
        }
        private void guardianHydrodip(object sender, RoutedEventArgs e)
        {
            if (guardianArray.Contains("hydrodip"))
            {
                return;
            }
            else
            {
                guardianArray.Clear();
                guardianArray.Add("hydrodip");
                Properties.Settings.Default.Guardian = "hydrodip";
                Properties.Settings.Default.Save();
            }
        }
        private void guardianInfantry(object sender, RoutedEventArgs e)
        {
            if (guardianArray.Contains("infantry"))
            {
                return;
            }
            else
            {
                guardianArray.Clear();
                guardianArray.Add("infantry");
                Properties.Settings.Default.Guardian = "infantry";
                Properties.Settings.Default.Save();
            }
        }
        private void guardianInfinity(object sender, RoutedEventArgs e)
        {
            if (guardianArray.Contains("infinity"))
            {
                return;
            }
            else
            {
                guardianArray.Clear();
                guardianArray.Add("infinity");
                Properties.Settings.Default.Guardian = "infinity";
                Properties.Settings.Default.Save();
            }
        }
        private void guardianJigsaw(object sender, RoutedEventArgs e)
        {
            if (guardianArray.Contains("jigsaw"))
            {
                return;
            }
            else
            {
                guardianArray.Clear();
                guardianArray.Add("jigsaw");
                Properties.Settings.Default.Guardian = "jigsaw";
                Properties.Settings.Default.Save();
            }
        }
        private void guardianMagepunk(object sender, RoutedEventArgs e)
        {
            if (guardianArray.Contains("magepunk"))
            {
                return;
            }
            else
            {
                guardianArray.Clear();
                guardianArray.Add("magepunk");
                Properties.Settings.Default.Guardian = "magepunk";
                Properties.Settings.Default.Save();
            }
        }
        private void guardianNebula(object sender, RoutedEventArgs e)
        {
            if (guardianArray.Contains("nebula"))
            {
                return;
            }
            else
            {
                guardianArray.Clear();
                guardianArray.Add("nebula");
                Properties.Settings.Default.Guardian = "nebula";
                Properties.Settings.Default.Save();
            }
        }
        private void guardianNitro(object sender, RoutedEventArgs e)
        {
            if (guardianArray.Contains("nitro"))
            {
                return;
            }
            else
            {
                guardianArray.Clear();
                guardianArray.Add("nitro");
                Properties.Settings.Default.Guardian = "nitro";
                Properties.Settings.Default.Save();
            }
        }
        private void guardianOni(object sender, RoutedEventArgs e)
        {
            if (guardianArray.Contains("oni"))
            {
                return;
            }
            else
            {
                guardianArray.Clear();
                guardianArray.Add("oni");
                Properties.Settings.Default.Guardian = "oni";
                Properties.Settings.Default.Save();
            }
        }
        private void guardianPolyfox(object sender, RoutedEventArgs e)
        {
            if (guardianArray.Contains("polyfox"))
            {
                return;
            }
            else
            {
                guardianArray.Clear();
                guardianArray.Add("polyfox");
                Properties.Settings.Default.Guardian = "polyfox";
                Properties.Settings.Default.Save();
            }
        }
        private void guardianPrime(object sender, RoutedEventArgs e)
        {
            if (guardianArray.Contains("prime"))
            {
                return;
            }
            else
            {
                guardianArray.Clear();
                guardianArray.Add("prime");
                Properties.Settings.Default.Guardian = "prime";
                Properties.Settings.Default.Save();
            }
        }
        private void guardianReaver(object sender, RoutedEventArgs e)
        {
            if (guardianArray.Contains("reaver"))
            {
                return;
            }
            else
            {
                guardianArray.Clear();
                guardianArray.Add("reaver");
                Properties.Settings.Default.Guardian = "reaver";
                Properties.Settings.Default.Save();
            }
        }
        private void guardianRecon(object sender, RoutedEventArgs e)
        {
            if (guardianArray.Contains("recon"))
            {
                return;
            }
            else
            {
                guardianArray.Clear();
                guardianArray.Add("recon");
                Properties.Settings.Default.Guardian = "recon";
                Properties.Settings.Default.Save();
            }
        }
        private void guardianRgx11(object sender, RoutedEventArgs e)
        {
            if (guardianArray.Contains("rgx11"))
            {
                return;
            }
            else
            {
                guardianArray.Clear();
                guardianArray.Add("rgx11");
                Properties.Settings.Default.Guardian = "rgx11";
                Properties.Settings.Default.Save();
            }
        }
        private void guardianRuin(object sender, RoutedEventArgs e)
        {
            if (guardianArray.Contains("ruin"))
            {
                return;
            }
            else
            {
                guardianArray.Clear();
                guardianArray.Add("ruin");
                Properties.Settings.Default.Guardian = "ruin";
                Properties.Settings.Default.Save();
            }
        }
        private void guardianRuination(object sender, RoutedEventArgs e)
        {
            if (guardianArray.Contains("ruination"))
            {
                return;
            }
            else
            {
                guardianArray.Clear();
                guardianArray.Add("ruination");
                Properties.Settings.Default.Guardian = "ruination";
                Properties.Settings.Default.Save();
            }
        }
        private void guardianSongsteel(object sender, RoutedEventArgs e)
        {
            if (guardianArray.Contains("songsteel"))
            {
                return;
            }
            else
            {
                guardianArray.Clear();
                guardianArray.Add("songsteel");
                Properties.Settings.Default.Guardian = "songsteel";
                Properties.Settings.Default.Save();
            }
        }
        private void guardianSovereign(object sender, RoutedEventArgs e)
        {
            if (guardianArray.Contains("sovereign"))
            {
                return;
            }
            else
            {
                guardianArray.Clear();
                guardianArray.Add("sovereign");
                Properties.Settings.Default.Guardian = "sovereign";
                Properties.Settings.Default.Save();
            }
        }
        private void guardianSpectrum(object sender, RoutedEventArgs e)
        {
            if (guardianArray.Contains("spectrum"))
            {
                return;
            }
            else
            {
                guardianArray.Clear();
                guardianArray.Add("spectrum");
                Properties.Settings.Default.Guardian = "spectrum";
                Properties.Settings.Default.Save();
            }
        }
        private void guardianTethered(object sender, RoutedEventArgs e)
        {
            if (guardianArray.Contains("tethered"))
            {
                return;
            }
            else
            {
                guardianArray.Clear();
                guardianArray.Add("tethered");
                Properties.Settings.Default.Guardian = "tethered";
                Properties.Settings.Default.Save();
            }
        }
        private void guardianValgo(object sender, RoutedEventArgs e)
        {
            if (guardianArray.Contains("valgo"))
            {
                return;
            }
            else
            {
                guardianArray.Clear();
                guardianArray.Add("valgo");
                Properties.Settings.Default.Guardian = "valgo";
                Properties.Settings.Default.Save();
            }
        }

        //judge skins
        private void judgeDefault(object sender, RoutedEventArgs e)
        {
            if (judgeArray.Contains("default"))
            {
                return;
            }
            else
            {
                judgeArray.Clear();
                judgeArray.Add("default");
                Properties.Settings.Default.Judge = "default";
                Properties.Settings.Default.Save();
            }
        }
        private void judgeCelestial(object sender, RoutedEventArgs e)
        {
            if (judgeArray.Contains("celestial"))
            {
                return;
            }
            else
            {
                judgeArray.Clear();
                judgeArray.Add("celestial");
                Properties.Settings.Default.Judge = "celestial";
                Properties.Settings.Default.Save();
            }
        }
        private void judgeConvex(object sender, RoutedEventArgs e)
        {
            if (judgeArray.Contains("convex"))
            {
                return;
            }
            else
            {
                judgeArray.Clear();
                judgeArray.Add("convex");
                Properties.Settings.Default.Judge = "convex";
                Properties.Settings.Default.Save();
            }
        }
        private void judgeDivine(object sender, RoutedEventArgs e)
        {
            if (judgeArray.Contains("divine"))
            {
                return;
            }
            else
            {
                judgeArray.Clear();
                judgeArray.Add("divine");
                Properties.Settings.Default.Judge = "divine";
                Properties.Settings.Default.Save();
            }
        }
        private void judgeDotexe(object sender, RoutedEventArgs e)
        {
            if (judgeArray.Contains("dotexe"))
            {
                return;
            }
            else
            {
                judgeArray.Clear();
                judgeArray.Add("dotexe");
                Properties.Settings.Default.Judge = "dotexe";
                Properties.Settings.Default.Save();
            }
        }
        private void judgeElderflame(object sender, RoutedEventArgs e)
        {
            if (judgeArray.Contains("elderflame"))
            {
                return;
            }
            else
            {
                judgeArray.Clear();
                judgeArray.Add("elderflame");
                Properties.Settings.Default.Judge = "elderflame";
                Properties.Settings.Default.Save();
            }
        }
        private void judgeGlitchpop(object sender, RoutedEventArgs e)
        {
            if (judgeArray.Contains("glitchpop"))
            {
                return;
            }
            else
            {
                judgeArray.Clear();
                judgeArray.Add("glitchpop");
                Properties.Settings.Default.Judge = "glitchpop";
                Properties.Settings.Default.Save();
            }
        }
        private void judgeGoldwing(object sender, RoutedEventArgs e)
        {
            if (judgeArray.Contains("goldwing"))
            {
                return;
            }
            else
            {
                judgeArray.Clear();
                judgeArray.Add("goldwing");
                Properties.Settings.Default.Judge = "goldwing";
                Properties.Settings.Default.Save();
            }
        }
        private void judgeHydrodip(object sender, RoutedEventArgs e)
        {
            if (judgeArray.Contains("hydrodip"))
            {
                return;
            }
            else
            {
                judgeArray.Clear();
                judgeArray.Add("hydrodip");
                Properties.Settings.Default.Judge = "hydrodip";
                Properties.Settings.Default.Save();
            }
        }
        private void judgeJigsaw(object sender, RoutedEventArgs e)
        {
            if (judgeArray.Contains("jigsaw"))
            {
                return;
            }
            else
            {
                judgeArray.Clear();
                judgeArray.Add("jigsaw");
                Properties.Settings.Default.Judge = "jigsaw";
                Properties.Settings.Default.Save();
            }
        }
        private void judgeLuxe(object sender, RoutedEventArgs e)
        {
            if (judgeArray.Contains("luxe"))
            {
                return;
            }
            else
            {
                judgeArray.Clear();
                judgeArray.Add("luxe");
                Properties.Settings.Default.Judge = "luxe";
                Properties.Settings.Default.Save();
            }
        }
        private void judgeOutpost(object sender, RoutedEventArgs e)
        {
            if (judgeArray.Contains("outpost"))
            {
                return;
            }
            else
            {
                judgeArray.Clear();
                judgeArray.Add("outpost");
                Properties.Settings.Default.Judge = "outpost";
                Properties.Settings.Default.Save();
            }
        }
        private void judgePolyfox(object sender, RoutedEventArgs e)
        {
            if (judgeArray.Contains("polyfox"))
            {
                return;
            }
            else
            {
                judgeArray.Clear();
                judgeArray.Add("polyfox");
                Properties.Settings.Default.Judge = "polyfox";
                Properties.Settings.Default.Save();
            }
        }
        private void judgePrism(object sender, RoutedEventArgs e)
        {
            if (judgeArray.Contains("prism"))
            {
                return;
            }
            else
            {
                judgeArray.Clear();
                judgeArray.Add("prism");
                Properties.Settings.Default.Judge = "prism";
                Properties.Settings.Default.Save();
            }
        }
        private void judgeRush(object sender, RoutedEventArgs e)
        {
            if (judgeArray.Contains("rush"))
            {
                return;
            }
            else
            {
                judgeArray.Clear();
                judgeArray.Add("rush");
                Properties.Settings.Default.Judge = "rush";
                Properties.Settings.Default.Save();
            }
        }
        private void judgeSensation(object sender, RoutedEventArgs e)
        {
            if (judgeArray.Contains("sensation"))
            {
                return;
            }
            else
            {
                judgeArray.Clear();
                judgeArray.Add("sensation");
                Properties.Settings.Default.Judge = "sensation";
                Properties.Settings.Default.Save();
            }
        }
        private void judgeSerenity(object sender, RoutedEventArgs e)
        {
            if (judgeArray.Contains("serenity"))
            {
                return;
            }
            else
            {
                judgeArray.Clear();
                judgeArray.Add("serenity");
                Properties.Settings.Default.Judge = "serenity";
                Properties.Settings.Default.Save();
            }
        }
        private void judgeSmite(object sender, RoutedEventArgs e)
        {
            if (judgeArray.Contains("smite"))
            {
                return;
            }
            else
            {
                judgeArray.Clear();
                judgeArray.Add("smite");
                Properties.Settings.Default.Judge = "smite";
                Properties.Settings.Default.Save();
            }
        }
        private void judgeSnowfall(object sender, RoutedEventArgs e)
        {
            if (judgeArray.Contains("snowfall"))
            {
                return;
            }
            else
            {
                judgeArray.Clear();
                judgeArray.Add("snowfall");
                Properties.Settings.Default.Judge = "snowfall";
                Properties.Settings.Default.Save();
            }
        }
        private void judgeUndercity(object sender, RoutedEventArgs e)
        {
            if (judgeArray.Contains("undercity"))
            {
                return;
            }
            else
            {
                judgeArray.Clear();
                judgeArray.Add("undercity");
                Properties.Settings.Default.Judge = "undercity";
                Properties.Settings.Default.Save();
            }
        }
        private void judgeVarnish(object sender, RoutedEventArgs e)
        {
            if (judgeArray.Contains("varnish"))
            {
                return;
            }
            else
            {
                judgeArray.Clear();
                judgeArray.Add("varnish");
                Properties.Settings.Default.Judge = "varnish";
                Properties.Settings.Default.Save();
            }
        }

        //marshal skins
        private void marshalDefault(object sender, RoutedEventArgs e)
        {
            if (marshalArray.Contains("default"))
            {
                return;
            }
            else
            {
                marshalArray.Clear();
                marshalArray.Add("default");
                Properties.Settings.Default.Marshal = "default";
                Properties.Settings.Default.Save();
            }
        }
        private void marshalArtisan(object sender, RoutedEventArgs e)
        {
            if (marshalArray.Contains("artisan"))
            {
                return;
            }
            else
            {
                marshalArray.Clear();
                marshalArray.Add("artisan");
                Properties.Settings.Default.Marshal = "artisan";
                Properties.Settings.Default.Save();
            }
        }
        private void marshalAvalanche(object sender, RoutedEventArgs e)
        {
            if (marshalArray.Contains("avalanche"))
            {
                return;
            }
            else
            {
                marshalArray.Clear();
                marshalArray.Add("avalanche");
                Properties.Settings.Default.Marshal = "avalanche";
                Properties.Settings.Default.Save();
            }
        }
        private void marshalCouture(object sender, RoutedEventArgs e)
        {
            if (marshalArray.Contains("couture"))
            {
                return;
            }
            else
            {
                marshalArray.Clear();
                marshalArray.Add("couture");
                Properties.Settings.Default.Marshal = "couture";
                Properties.Settings.Default.Save();
            }
        }
        private void marshalDivine(object sender, RoutedEventArgs e)
        {
            if (marshalArray.Contains("divine"))
            {
                return;
            }
            else
            {
                marshalArray.Clear();
                marshalArray.Add("divine");
                Properties.Settings.Default.Marshal = "divine";
                Properties.Settings.Default.Save();
            }
        }
        private void marshalGaias(object sender, RoutedEventArgs e)
        {
            if (marshalArray.Contains("gaias"))
            {
                return;
            }
            else
            {
                marshalArray.Clear();
                marshalArray.Add("gaias");
                Properties.Settings.Default.Marshal = "gaias";
                Properties.Settings.Default.Save();
            }
        }
        private void marshalGalleria(object sender, RoutedEventArgs e)
        {
            if (marshalArray.Contains("galleria"))
            {
                return;
            }
            else
            {
                marshalArray.Clear();
                marshalArray.Add("galleria");
                Properties.Settings.Default.Marshal = "galleria";
                Properties.Settings.Default.Save();
            }
        }
        private void marshalMagepunk(object sender, RoutedEventArgs e)
        {
            if (marshalArray.Contains("magepunk"))
            {
                return;
            }
            else
            {
                marshalArray.Clear();
                marshalArray.Add("magepunk");
                Properties.Settings.Default.Marshal = "magepunk";
                Properties.Settings.Default.Save();
            }
        }
        private void marshalMonarch(object sender, RoutedEventArgs e)
        {
            if (marshalArray.Contains("monarch"))
            {
                return;
            }
            else
            {
                marshalArray.Clear();
                marshalArray.Add("monarch");
                Properties.Settings.Default.Marshal = "monarch";
                Properties.Settings.Default.Save();
            }
        }
        private void marshalPolyfrog(object sender, RoutedEventArgs e)
        {
            if (marshalArray.Contains("polyfrog"))
            {
                return;
            }
            else
            {
                marshalArray.Clear();
                marshalArray.Add("polyfrog");
                Properties.Settings.Default.Marshal = "polyfrog";
                Properties.Settings.Default.Save();
            }
        }
        private void marshalRuin(object sender, RoutedEventArgs e)
        {
            if (marshalArray.Contains("ruin"))
            {
                return;
            }
            else
            {
                marshalArray.Clear();
                marshalArray.Add("ruin");
                Properties.Settings.Default.Marshal = "ruin";
                Properties.Settings.Default.Save();
            }
        }
        private void marshalSongsteel(object sender, RoutedEventArgs e)
        {
            if (marshalArray.Contains("songsteel"))
            {
                return;
            }
            else
            {
                marshalArray.Clear();
                marshalArray.Add("songsteel");
                Properties.Settings.Default.Marshal = "songsteel";
                Properties.Settings.Default.Save();
            }
        }
        private void marshalSovereign(object sender, RoutedEventArgs e)
        {
            if (marshalArray.Contains("sovereign"))
            {
                return;
            }
            else
            {
                marshalArray.Clear();
                marshalArray.Add("sovereign");
                Properties.Settings.Default.Marshal = "sovereign";
                Properties.Settings.Default.Save();
            }
        }
        private void marshalWasteland(object sender, RoutedEventArgs e)
        {
            if (marshalArray.Contains("wasteland"))
            {
                return;
            }
            else
            {
                marshalArray.Clear();
                marshalArray.Add("wasteland");
                Properties.Settings.Default.Marshal = "wasteland";
                Properties.Settings.Default.Save();
            }
        }
        private void marshalWunderland(object sender, RoutedEventArgs e)
        {
            if (marshalArray.Contains("wunderland"))
            {
                return;
            }
            else
            {
                marshalArray.Clear();
                marshalArray.Add("wunderland");
                Properties.Settings.Default.Marshal = "wunderland";
                Properties.Settings.Default.Save();
            }
        }

        //odin skins
        private void odinDefault(object sender, RoutedEventArgs e)
        {
            if (odinArray.Contains("default"))
            {
                return;
            }
            else
            {
                odinArray.Clear();
                odinArray.Add("default");
                Properties.Settings.Default.Odin = "default";
                Properties.Settings.Default.Save();
            }
        }
        private void odinAerosol(object sender, RoutedEventArgs e)
        {
            if (odinArray.Contains("aerosol"))
            {
                return;
            }
            else
            {
                odinArray.Clear();
                odinArray.Add("aerosol");
                Properties.Settings.Default.Odin = "aerosol";
                Properties.Settings.Default.Save();
            }
        }
        private void odinBlastx(object sender, RoutedEventArgs e)
        {
            if (odinArray.Contains("blastx"))
            {
                return;
            }
            else
            {
                odinArray.Clear();
                odinArray.Add("blastx");
                Properties.Settings.Default.Odin = "blastx";
                Properties.Settings.Default.Save();
            }
        }
        private void odinDotexe(object sender, RoutedEventArgs e)
        {
            if (odinArray.Contains("dotexe"))
            {
                return;
            }
            else
            {
                odinArray.Clear();
                odinArray.Add("dotexe");
                Properties.Settings.Default.Odin = "dotexe";
                Properties.Settings.Default.Save();
            }
        }
        private void odinGlitchpop(object sender, RoutedEventArgs e)
        {
            if (odinArray.Contains("glitchpop"))
            {
                return;
            }
            else
            {
                odinArray.Clear();
                odinArray.Add("glitchpop");
                Properties.Settings.Default.Odin = "glitchpop";
                Properties.Settings.Default.Save();
            }
        }
        private void odinLightwave(object sender, RoutedEventArgs e)
        {
            if (odinArray.Contains("lightwave"))
            {
                return;
            }
            else
            {
                odinArray.Clear();
                odinArray.Add("lightwave");
                Properties.Settings.Default.Odin = "lightwave";
                Properties.Settings.Default.Save();
            }
        }
        private void odinLycan(object sender, RoutedEventArgs e)
        {
            if (odinArray.Contains("lycan"))
            {
                return;
            }
            else
            {
                odinArray.Clear();
                odinArray.Add("lycan");
                Properties.Settings.Default.Odin = "lycan";
                Properties.Settings.Default.Save();
            }
        }
        private void odinNitro(object sender, RoutedEventArgs e)
        {
            if (odinArray.Contains("nitro"))
            {
                return;
            }
            else
            {
                odinArray.Clear();
                odinArray.Add("nitro");
                Properties.Settings.Default.Odin = "nitro";
                Properties.Settings.Default.Save();
            }
        }
        private void odinPrime(object sender, RoutedEventArgs e)
        {
            if (odinArray.Contains("prime"))
            {
                return;
            }
            else
            {
                odinArray.Clear();
                odinArray.Add("prime");
                Properties.Settings.Default.Odin = "prime";
                Properties.Settings.Default.Save();
            }
        }
        private void odinPrism(object sender, RoutedEventArgs e)
        {
            if (odinArray.Contains("prism"))
            {
                return;
            }
            else
            {
                odinArray.Clear();
                odinArray.Add("prism");
                Properties.Settings.Default.Odin = "prism";
                Properties.Settings.Default.Save();
            }
        }
        private void odinSchema(object sender, RoutedEventArgs e)
        {
            if (odinArray.Contains("schema"))
            {
                return;
            }
            else
            {
                odinArray.Clear();
                odinArray.Add("schema");
                Properties.Settings.Default.Odin = "schema";
                Properties.Settings.Default.Save();
            }
        }
        private void odinSensation(object sender, RoutedEventArgs e)
        {
            if (odinArray.Contains("sensation"))
            {
                return;
            }
            else
            {
                odinArray.Clear();
                odinArray.Add("sensation");
                Properties.Settings.Default.Odin = "sensation";
                Properties.Settings.Default.Save();
            }
        }
        private void odinSmite(object sender, RoutedEventArgs e)
        {
            if (odinArray.Contains("smite"))
            {
                return;
            }
            else
            {
                odinArray.Clear();
                odinArray.Add("smite");
                Properties.Settings.Default.Odin = "smite";
                Properties.Settings.Default.Save();
            }
        }

        //operator skins
        private void operatorDefault(object sender, RoutedEventArgs e)
        {
            if (operatorArray.Contains("default"))
            {
                return;
            }
            else
            {
                operatorArray.Clear();
                operatorArray.Add("default");
                Properties.Settings.Default.Op = "default";
                Properties.Settings.Default.Save();
            }
        }
        private void operatorAerosol(object sender, RoutedEventArgs e)
        {
            if (operatorArray.Contains("aerosol"))
            {
                return;
            }
            else
            {
                operatorArray.Clear();
                operatorArray.Add("aerosol");
                Properties.Settings.Default.Op = "aerosol";
                Properties.Settings.Default.Save();
            }
        }
        private void operatorCavalier(object sender, RoutedEventArgs e)
        {
            if (operatorArray.Contains("cavalier"))
            {
                return;
            }
            else
            {
                operatorArray.Clear();
                operatorArray.Add("cavalier");
                Properties.Settings.Default.Op = "cavalier";
                Properties.Settings.Default.Save();
            }
        }
        private void operatorConvex(object sender, RoutedEventArgs e)
        {
            if (operatorArray.Contains("convex"))
            {
                return;
            }
            else
            {
                operatorArray.Clear();
                operatorArray.Add("convex");
                Properties.Settings.Default.Op = "convex";
                Properties.Settings.Default.Save();
            }
        }
        private void operatorElderflame(object sender, RoutedEventArgs e)
        {
            if (operatorArray.Contains("elderflame"))
            {
                return;
            }
            else
            {
                operatorArray.Clear();
                operatorArray.Add("elderflame");
                Properties.Settings.Default.Op = "elderflame";
                Properties.Settings.Default.Save();
            }
        }
        private void operatorForsaken(object sender, RoutedEventArgs e)
        {
            if (operatorArray.Contains("forsaken"))
            {
                return;
            }
            else
            {
                operatorArray.Clear();
                operatorArray.Add("forsaken");
                Properties.Settings.Default.Op = "forsaken";
                Properties.Settings.Default.Save();
            }
        }
        private void operatorGenesis(object sender, RoutedEventArgs e)
        {
            if (operatorArray.Contains("genesis"))
            {
                return;
            }
            else
            {
                operatorArray.Clear();
                operatorArray.Add("genesis");
                Properties.Settings.Default.Op = "genesis";
                Properties.Settings.Default.Save();
            }
        }
        private void operatorGlitchpop(object sender, RoutedEventArgs e)
        {
            if (operatorArray.Contains("glitchpop"))
            {
                return;
            }
            else
            {
                operatorArray.Clear();
                operatorArray.Add("glitchpop");
                Properties.Settings.Default.Op = "glitchpop";
                Properties.Settings.Default.Save();
            }
        }
        private void operatorNeuroblaster(object sender, RoutedEventArgs e)
        {
            if (operatorArray.Contains("neuroblaster"))
            {
                return;
            }
            else
            {
                operatorArray.Clear();
                operatorArray.Add("neuroblaster");
                Properties.Settings.Default.Op = "neuroblaster";
                Properties.Settings.Default.Save();
            }
        }
        private void operatorInfantry(object sender, RoutedEventArgs e)
        {
            if (operatorArray.Contains("infantry"))
            {
                return;
            }
            else
            {
                operatorArray.Clear();
                operatorArray.Add("infantry");
                Properties.Settings.Default.Op = "infantry";
                Properties.Settings.Default.Save();
            }
        }
        private void operatorIon(object sender, RoutedEventArgs e)
        {
            if (operatorArray.Contains("ion"))
            {
                return;
            }
            else
            {
                operatorArray.Clear();
                operatorArray.Add("ion");
                Properties.Settings.Default.Op = "ion";
                Properties.Settings.Default.Save();
            }
        }
        private void operatorKtac(object sender, RoutedEventArgs e)
        {
            if (operatorArray.Contains("ktac"))
            {
                return;
            }
            else
            {
                operatorArray.Clear();
                operatorArray.Add("ktac");
                Properties.Settings.Default.Op = "ktac";
                Properties.Settings.Default.Save();
            }
        }
        private void operatorLuxe(object sender, RoutedEventArgs e)
        {
            if (operatorArray.Contains("luxe"))
            {
                return;
            }
            else
            {
                operatorArray.Clear();
                operatorArray.Add("luxe");
                Properties.Settings.Default.Op = "luxe";
                Properties.Settings.Default.Save();
            }
        }
        private void operatorMagepunk(object sender, RoutedEventArgs e)
        {
            if (operatorArray.Contains("magepunk"))
            {
                return;
            }
            else
            {
                operatorArray.Clear();
                operatorArray.Add("magepunk");
                Properties.Settings.Default.Op = "magepunk";
                Properties.Settings.Default.Save();
            }
        }
        private void operatorMinima(object sender, RoutedEventArgs e)
        {
            if (operatorArray.Contains("minima"))
            {
                return;
            }
            else
            {
                operatorArray.Clear();
                operatorArray.Add("minima");
                Properties.Settings.Default.Op = "minima";
                Properties.Settings.Default.Save();
            }
        }
        private void operatorNitro(object sender, RoutedEventArgs e)
        {
            if (operatorArray.Contains("nitro"))
            {
                return;
            }
            else
            {
                operatorArray.Clear();
                operatorArray.Add("nitro");
                Properties.Settings.Default.Op = "nitro";
                Properties.Settings.Default.Save();
            }
        }
        private void operatorOrigin(object sender, RoutedEventArgs e)
        {
            if (operatorArray.Contains("origin"))
            {
                return;
            }
            else
            {
                operatorArray.Clear();
                operatorArray.Add("origin");
                Properties.Settings.Default.Op = "origin";
                Properties.Settings.Default.Save();
            }
        }
        private void operatorPrism(object sender, RoutedEventArgs e)
        {
            if (operatorArray.Contains("prism"))
            {
                return;
            }
            else
            {
                operatorArray.Clear();
                operatorArray.Add("prism");
                Properties.Settings.Default.Op = "prism";
                Properties.Settings.Default.Save();
            }
        }
        private void operatorReaver(object sender, RoutedEventArgs e)
        {
            if (operatorArray.Contains("reaver"))
            {
                return;
            }
            else
            {
                operatorArray.Clear();
                operatorArray.Add("reaver");
                Properties.Settings.Default.Op = "reaver";
                Properties.Settings.Default.Save();
            }
        }
        private void operatorRedalert(object sender, RoutedEventArgs e)
        {
            if (operatorArray.Contains("redalert"))
            {
                return;
            }
            else
            {
                operatorArray.Clear();
                operatorArray.Add("redalert");
                Properties.Settings.Default.Op = "redalert";
                Properties.Settings.Default.Save();
            }
        }
        private void operatorSentinels(object sender, RoutedEventArgs e)
        {
            if (operatorArray.Contains("sentinels"))
            {
                return;
            }
            else
            {
                operatorArray.Clear();
                operatorArray.Add("sentinels");
                Properties.Settings.Default.Op = "sentinels";
                Properties.Settings.Default.Save();
            }
        }
        private void operatorSilvanus(object sender, RoutedEventArgs e)
        {
            if (operatorArray.Contains("silvanus"))
            {
                return;
            }
            else
            {
                operatorArray.Clear();
                operatorArray.Add("silvanus");
                Properties.Settings.Default.Op = "silvanus";
                Properties.Settings.Default.Save();
            }
        }
        private void operatorSpline(object sender, RoutedEventArgs e)
        {
            if (operatorArray.Contains("spline"))
            {
                return;
            }
            else
            {
                operatorArray.Clear();
                operatorArray.Add("spline");
                Properties.Settings.Default.Op = "spline";
                Properties.Settings.Default.Save();
            }
        }
        private void operatorStriker(object sender, RoutedEventArgs e)
        {
            if (operatorArray.Contains("striker"))
            {
                return;
            }
            else
            {
                operatorArray.Clear();
                operatorArray.Add("striker");
                Properties.Settings.Default.Op = "striker";
                Properties.Settings.Default.Save();
            }
        }
        private void operatorTethered(object sender, RoutedEventArgs e)
        {
            if (operatorArray.Contains("tethered"))
            {
                return;
            }
            else
            {
                operatorArray.Clear();
                operatorArray.Add("tethered");
                Properties.Settings.Default.Op = "tethered";
                Properties.Settings.Default.Save();
            }
        }
        private void operatorTigris(object sender, RoutedEventArgs e)
        {
            if (operatorArray.Contains("tigris"))
            {
                return;
            }
            else
            {
                operatorArray.Clear();
                operatorArray.Add("tigris");
                Properties.Settings.Default.Op = "tigris";
                Properties.Settings.Default.Save();
            }
        }
        private void operatorValgo(object sender, RoutedEventArgs e)
        {
            if (operatorArray.Contains("valgo"))
            {
                return;
            }
            else
            {
                operatorArray.Clear();
                operatorArray.Add("valgo");
                Properties.Settings.Default.Op = "valgo";
                Properties.Settings.Default.Save();
            }
        }

        //phantom skins
        private void phantomDefault(object sender, RoutedEventArgs e)
        {
            if (phantomArray.Contains("default"))
            {
                return;
            }
            else
            {
                phantomArray.Clear();
                phantomArray.Add("default");
                Properties.Settings.Default.Phantom = "default";
                Properties.Settings.Default.Save();
            }
        }
        private void phantomAero(object sender, RoutedEventArgs e)
        {
            if (phantomArray.Contains("aero"))
            {
                return;
            }
            else
            {
                phantomArray.Clear();
                phantomArray.Add("aero");
                Properties.Settings.Default.Phantom = "aero";
                Properties.Settings.Default.Save();
            }
        }
        private void phantomArtisan(object sender, RoutedEventArgs e)
        {
            if (phantomArray.Contains("artisan"))
            {
                return;
            }
            else
            {
                phantomArray.Clear();
                phantomArray.Add("artisan");
                Properties.Settings.Default.Phantom = "artisan";
                Properties.Settings.Default.Save();
            }
        }
        private void phantomAvalanche(object sender, RoutedEventArgs e)
        {
            if (phantomArray.Contains("avalanche"))
            {
                return;
            }
            else
            {
                phantomArray.Clear();
                phantomArray.Add("avalanche");
                Properties.Settings.Default.Phantom = "avalanche";
                Properties.Settings.Default.Save();
            }
        }
        private void phantomBlastx(object sender, RoutedEventArgs e)
        {
            if (phantomArray.Contains("blastx"))
            {
                return;
            }
            else
            {
                phantomArray.Clear();
                phantomArray.Add("blastx");
                Properties.Settings.Default.Phantom = "blastx";
                Properties.Settings.Default.Save();
            }
        }
        private void phantomCelestial(object sender, RoutedEventArgs e)
        {
            if (phantomArray.Contains("celestial"))
            {
                return;
            }
            else
            {
                phantomArray.Clear();
                phantomArray.Add("celestial");
                Properties.Settings.Default.Phantom = "celestial";
                Properties.Settings.Default.Save();
            }
        }
        private void phantomGalleria(object sender, RoutedEventArgs e)
        {
            if (phantomArray.Contains("galleria"))
            {
                return;
            }
            else
            {
                phantomArray.Clear();
                phantomArray.Add("galleria");
                Properties.Settings.Default.Phantom = "galleria";
                Properties.Settings.Default.Save();
            }
        }
        private void phantomGlitchpop(object sender, RoutedEventArgs e)
        {
            if (phantomArray.Contains("glitchpop"))
            {
                return;
            }
            else
            {
                phantomArray.Clear();
                phantomArray.Add("glitchpop");
                Properties.Settings.Default.Phantom = "glitchpop";
                Properties.Settings.Default.Save();
            }
        }
        private void phantomInfinity(object sender, RoutedEventArgs e)
        {
            if (phantomArray.Contains("infinity"))
            {
                return;
            }
            else
            {
                phantomArray.Clear();
                phantomArray.Add("infinity");
                Properties.Settings.Default.Phantom = "infinity";
                Properties.Settings.Default.Save();
            }
        }
        private void phantomIon(object sender, RoutedEventArgs e)
        {
            if (phantomArray.Contains("ion"))
            {
                return;
            }
            else
            {
                phantomArray.Clear();
                phantomArray.Add("ion");
                Properties.Settings.Default.Phantom = "ion";
                Properties.Settings.Default.Save();
            }
        }
        private void phantomKingdom(object sender, RoutedEventArgs e)
        {
            if (phantomArray.Contains("kingdom"))
            {
                return;
            }
            else
            {
                phantomArray.Clear();
                phantomArray.Add("kingdom");
                Properties.Settings.Default.Phantom = "kingdom";
                Properties.Settings.Default.Save();
            }
        }
        private void phantomLightwave(object sender, RoutedEventArgs e)
        {
            if (phantomArray.Contains("lightwave"))
            {
                return;
            }
            else
            {
                phantomArray.Clear();
                phantomArray.Add("lightwave");
                Properties.Settings.Default.Phantom = "lightwave";
                Properties.Settings.Default.Save();
            }
        }
        private void phantomMinima(object sender, RoutedEventArgs e)
        {
            if (phantomArray.Contains("minima"))
            {
                return;
            }
            else
            {
                phantomArray.Clear();
                phantomArray.Add("minima");
                Properties.Settings.Default.Phantom = "minima";
                Properties.Settings.Default.Save();
            }
        }
        private void phantomNebula(object sender, RoutedEventArgs e)
        {
            if (phantomArray.Contains("nebula"))
            {
                return;
            }
            else
            {
                phantomArray.Clear();
                phantomArray.Add("nebula");
                Properties.Settings.Default.Phantom = "nebula";
                Properties.Settings.Default.Save();
            }
        }
        private void phantomOni(object sender, RoutedEventArgs e)
        {
            if (phantomArray.Contains("oni"))
            {
                return;
            }
            else
            {
                phantomArray.Clear();
                phantomArray.Add("oni");
                Properties.Settings.Default.Phantom = "oni";
                Properties.Settings.Default.Save();
            }
        }
        private void phantomPrime(object sender, RoutedEventArgs e)
        {
            if (phantomArray.Contains("prime"))
            {
                return;
            }
            else
            {
                phantomArray.Clear();
                phantomArray.Add("prime");
                Properties.Settings.Default.Phantom = "prime";
                Properties.Settings.Default.Save();
            }
        }
        private void phantomPrism(object sender, RoutedEventArgs e)
        {
            if (phantomArray.Contains("prism"))
            {
                return;
            }
            else
            {
                phantomArray.Clear();
                phantomArray.Add("prism");
                Properties.Settings.Default.Phantom = "prism";
                Properties.Settings.Default.Save();
            }
        }
        private void phantomProtocol(object sender, RoutedEventArgs e)
        {
            if (phantomArray.Contains("protocol"))
            {
                return;
            }
            else
            {
                phantomArray.Clear();
                phantomArray.Add("protocol");
                Properties.Settings.Default.Phantom = "protocol";
                Properties.Settings.Default.Save();
            }
        }
        private void phantomCrisis(object sender, RoutedEventArgs e)
        {
            if (phantomArray.Contains("crisis"))
            {
                return;
            }
            else
            {
                phantomArray.Clear();
                phantomArray.Add("crisis");
                Properties.Settings.Default.Phantom = "crisis";
                Properties.Settings.Default.Save();
            }
        }
        private void phantomRecon(object sender, RoutedEventArgs e)
        {
            if (phantomArray.Contains("recon"))
            {
                return;
            }
            else
            {
                phantomArray.Clear();
                phantomArray.Add("recon");
                Properties.Settings.Default.Phantom = "recon";
                Properties.Settings.Default.Save();
            }
        }
        private void phantomRuination(object sender, RoutedEventArgs e)
        {
            if (phantomArray.Contains("ruination"))
            {
                return;
            }
            else
            {
                phantomArray.Clear();
                phantomArray.Add("ruination");
                Properties.Settings.Default.Phantom = "ruination";
                Properties.Settings.Default.Save();
            }
        }
        private void phantomRush(object sender, RoutedEventArgs e)
        {
            if (phantomArray.Contains("rush"))
            {
                return;
            }
            else
            {
                phantomArray.Clear();
                phantomArray.Add("rush");
                Properties.Settings.Default.Phantom = "rush";
                Properties.Settings.Default.Save();
            }
        }
        private void phantomSerenity(object sender, RoutedEventArgs e)
        {
            if (phantomArray.Contains("serenity"))
            {
                return;
            }
            else
            {
                phantomArray.Clear();
                phantomArray.Add("serenity");
                Properties.Settings.Default.Phantom = "serenity";
                Properties.Settings.Default.Save();
            }
        }
        private void phantomSilvanus(object sender, RoutedEventArgs e)
        {
            if (phantomArray.Contains("silvanus"))
            {
                return;
            }
            else
            {
                phantomArray.Clear();
                phantomArray.Add("silvanus");
                Properties.Settings.Default.Phantom = "silvanus";
                Properties.Settings.Default.Save();
            }
        }
        private void phantomSingularity(object sender, RoutedEventArgs e)
        {
            if (phantomArray.Contains("singularity"))
            {
                return;
            }
            else
            {
                phantomArray.Clear();
                phantomArray.Add("singularity");
                Properties.Settings.Default.Phantom = "singularity";
                Properties.Settings.Default.Save();
            }
        }
        private void phantomSmite(object sender, RoutedEventArgs e)
        {
            if (phantomArray.Contains("smite"))
            {
                return;
            }
            else
            {
                phantomArray.Clear();
                phantomArray.Add("smite");
                Properties.Settings.Default.Phantom = "smite";
                Properties.Settings.Default.Save();
            }
        }
        private void phantomSnowfall(object sender, RoutedEventArgs e)
        {
            if (phantomArray.Contains("snowfall"))
            {
                return;
            }
            else
            {
                phantomArray.Clear();
                phantomArray.Add("snowfall");
                Properties.Settings.Default.Phantom = "snowfall";
                Properties.Settings.Default.Save();
            }
        }
        private void phantomSpectrum(object sender, RoutedEventArgs e)
        {
            if (phantomArray.Contains("spectrum"))
            {
                return;
            }
            else
            {
                phantomArray.Clear();
                phantomArray.Add("spectrum");
                Properties.Settings.Default.Phantom = "spectrum";
                Properties.Settings.Default.Save();
            }
        }
        private void phantomSpline(object sender, RoutedEventArgs e)
        {
            if (phantomArray.Contains("spline"))
            {
                return;
            }
            else
            {
                phantomArray.Clear();
                phantomArray.Add("spline");
                Properties.Settings.Default.Phantom = "spline";
                Properties.Settings.Default.Save();
            }
        }
        private void phantomTigris(object sender, RoutedEventArgs e)
        {
            if (phantomArray.Contains("tigris"))
            {
                return;
            }
            else
            {
                phantomArray.Clear();
                phantomArray.Add("tigris");
                Properties.Settings.Default.Phantom = "tigris";
                Properties.Settings.Default.Save();
            }
        }
        private void phantomUndercity(object sender, RoutedEventArgs e)
        {
            if (phantomArray.Contains("undercity"))
            {
                return;
            }
            else
            {
                phantomArray.Clear();
                phantomArray.Add("undercity");
                Properties.Settings.Default.Phantom = "undercity";
                Properties.Settings.Default.Save();
            }
        }
        private void phantomValgo(object sender, RoutedEventArgs e)
        {
            if (phantomArray.Contains("valgo"))
            {
                return;
            }
            else
            {
                phantomArray.Clear();
                phantomArray.Add("valgo");
                Properties.Settings.Default.Phantom = "valgo";
                Properties.Settings.Default.Save();
            }
        }
        private void phantomVelocity(object sender, RoutedEventArgs e)
        {
            if (phantomArray.Contains("velocity"))
            {
                return;
            }
            else
            {
                phantomArray.Clear();
                phantomArray.Add("velocity");
                Properties.Settings.Default.Phantom = "velocity";
                Properties.Settings.Default.Save();
            }
        }
        private void phantomWunderland(object sender, RoutedEventArgs e)
        {
            if (phantomArray.Contains("wunderland"))
            {
                return;
            }
            else
            {
                phantomArray.Clear();
                phantomArray.Add("wunderland");
                Properties.Settings.Default.Phantom = "wunderland";
                Properties.Settings.Default.Save();
            }
        }

        //spectre skins
        private void spectreDefault(object sender, RoutedEventArgs e)
        {
            if (spectreArray.Contains("default"))
            {
                return;
            }
            else
            {
                spectreArray.Clear();
                spectreArray.Add("default");
                Properties.Settings.Default.Spectre = "default";
                Properties.Settings.Default.Save();
            }
        }
        private void spectreAero(object sender, RoutedEventArgs e)
        {
            if (spectreArray.Contains("aero"))
            {
                return;
            }
            else
            {
                spectreArray.Clear();
                spectreArray.Add("aero");
                Properties.Settings.Default.Spectre = "aero";
                Properties.Settings.Default.Save();
            }
        }
        private void spectreAvalanche(object sender, RoutedEventArgs e)
        {
            if (spectreArray.Contains("avalanche"))
            {
                return;
            }
            else
            {
                spectreArray.Clear();
                spectreArray.Add("avalanche");
                Properties.Settings.Default.Spectre = "avalanche";
                Properties.Settings.Default.Save();
            }
        }
        private void spectreBlastx(object sender, RoutedEventArgs e)
        {
            if (spectreArray.Contains("blastx"))
            {
                return;
            }
            else
            {
                spectreArray.Clear();
                spectreArray.Add("blastx");
                Properties.Settings.Default.Spectre = "blastx";
                Properties.Settings.Default.Save();
            }
        }
        private void spectreConvex(object sender, RoutedEventArgs e)
        {
            if (spectreArray.Contains("convex"))
            {
                return;
            }
            else
            {
                spectreArray.Clear();
                spectreArray.Add("convex");
                Properties.Settings.Default.Spectre = "convex";
                Properties.Settings.Default.Save();
            }
        }
        private void spectreForsaken(object sender, RoutedEventArgs e)
        {
            if (spectreArray.Contains("forsaken"))
            {
                return;
            }
            else
            {
                spectreArray.Clear();
                spectreArray.Add("forsaken");
                Properties.Settings.Default.Spectre = "forsaken";
                Properties.Settings.Default.Save();
            }
        }
        private void spectreNeuroblaster(object sender, RoutedEventArgs e)
        {
            if (spectreArray.Contains("neuroblaster"))
            {
                return;
            }
            else
            {
                spectreArray.Clear();
                spectreArray.Add("neuroblaster");
                Properties.Settings.Default.Spectre = "neuroblaster";
                Properties.Settings.Default.Save();
            }
        }
        private void spectreHivemind(object sender, RoutedEventArgs e)
        {
            if (spectreArray.Contains("hivemind"))
            {
                return;
            }
            else
            {
                spectreArray.Clear();
                spectreArray.Add("hivemind");
                Properties.Settings.Default.Spectre = "hivemind";
                Properties.Settings.Default.Save();
            }
        }
        private void spectreHorizon(object sender, RoutedEventArgs e)
        {
            if (spectreArray.Contains("horizon"))
            {
                return;
            }
            else
            {
                spectreArray.Clear();
                spectreArray.Add("horizon");
                Properties.Settings.Default.Spectre = "horizon";
                Properties.Settings.Default.Save();
            }
        }
        private void spectreInfantry(object sender, RoutedEventArgs e)
        {
            if (spectreArray.Contains("infantry"))
            {
                return;
            }
            else
            {
                spectreArray.Clear();
                spectreArray.Add("infantry");
                Properties.Settings.Default.Spectre = "infantry";
                Properties.Settings.Default.Save();
            }
        }
        private void spectreInfinity(object sender, RoutedEventArgs e)
        {
            if (spectreArray.Contains("infinity"))
            {
                return;
            }
            else
            {
                spectreArray.Clear();
                spectreArray.Add("infinity");
                Properties.Settings.Default.Spectre = "infinity";
                Properties.Settings.Default.Save();
            }
        }
        private void spectreKingdom(object sender, RoutedEventArgs e)
        {
            if (spectreArray.Contains("kingdom"))
            {
                return;
            }
            else
            {
                spectreArray.Clear();
                spectreArray.Add("kingdom");
                Properties.Settings.Default.Spectre = "kingdom";
                Properties.Settings.Default.Save();
            }
        }
        private void spectreLuxe(object sender, RoutedEventArgs e)
        {
            if (spectreArray.Contains("luxe"))
            {
                return;
            }
            else
            {
                spectreArray.Clear();
                spectreArray.Add("luxe");
                Properties.Settings.Default.Spectre = "luxe";
                Properties.Settings.Default.Save();
            }
        }
        private void spectreMagepunk(object sender, RoutedEventArgs e)
        {
            if (spectreArray.Contains("magepunk"))
            {
                return;
            }
            else
            {
                spectreArray.Clear();
                spectreArray.Add("magepunk");
                Properties.Settings.Default.Spectre = "magepunk";
                Properties.Settings.Default.Save();
            }
        }
        private void spectreMinima(object sender, RoutedEventArgs e)
        {
            if (spectreArray.Contains("minima"))
            {
                return;
            }
            else
            {
                spectreArray.Clear();
                spectreArray.Add("minima");
                Properties.Settings.Default.Spectre = "minima";
                Properties.Settings.Default.Save();
            }
        }
        private void spectrePolyfrog(object sender, RoutedEventArgs e)
        {
            if (spectreArray.Contains("polyfrog"))
            {
                return;
            }
            else
            {
                spectreArray.Clear();
                spectreArray.Add("polyfrog");
                Properties.Settings.Default.Spectre = "polyfrog";
                Properties.Settings.Default.Save();
            }
        }
        private void spectrePrime(object sender, RoutedEventArgs e)
        {
            if (spectreArray.Contains("prime"))
            {
                return;
            }
            else
            {
                spectreArray.Clear();
                spectreArray.Add("prime");
                Properties.Settings.Default.Spectre = "prime";
                Properties.Settings.Default.Save();
            }
        }
        private void spectrePrism(object sender, RoutedEventArgs e)
        {
            if (spectreArray.Contains("prism"))
            {
                return;
            }
            else
            {
                spectreArray.Clear();
                spectreArray.Add("prism");
                Properties.Settings.Default.Spectre = "prism";
                Properties.Settings.Default.Save();
            }
        }
        private void spectreProtocol(object sender, RoutedEventArgs e)
        {
            if (spectreArray.Contains("protocol"))
            {
                return;
            }
            else
            {
                spectreArray.Clear();
                spectreArray.Add("protocol");
                Properties.Settings.Default.Spectre = "protocol";
                Properties.Settings.Default.Save();
            }
        }
        private void spectreCrisis(object sender, RoutedEventArgs e)
        {
            if (spectreArray.Contains("crisis"))
            {
                return;
            }
            else
            {
                spectreArray.Clear();
                spectreArray.Add("crisis");
                Properties.Settings.Default.Spectre = "crisis";
                Properties.Settings.Default.Save();
            }
        }
        private void spectreRecon(object sender, RoutedEventArgs e)
        {
            if (spectreArray.Contains("recon"))
            {
                return;
            }
            else
            {
                spectreArray.Clear();
                spectreArray.Add("recon");
                Properties.Settings.Default.Spectre = "recon";
                Properties.Settings.Default.Save();
            }
        }
        private void spectreRuination(object sender, RoutedEventArgs e)
        {
            if (spectreArray.Contains("ruination"))
            {
                return;
            }
            else
            {
                spectreArray.Clear();
                spectreArray.Add("ruination");
                Properties.Settings.Default.Spectre = "ruination";
                Properties.Settings.Default.Save();
            }
        }
        private void spectreSerenity(object sender, RoutedEventArgs e)
        {
            if (spectreArray.Contains("serenity"))
            {
                return;
            }
            else
            {
                spectreArray.Clear();
                spectreArray.Add("serenity");
                Properties.Settings.Default.Spectre = "serenity";
                Properties.Settings.Default.Save();
            }
        }
        private void spectreSingularity(object sender, RoutedEventArgs e)
        {
            if (spectreArray.Contains("singularity"))
            {
                return;
            }
            else
            {
                spectreArray.Clear();
                spectreArray.Add("singularity");
                Properties.Settings.Default.Spectre = "singularity";
                Properties.Settings.Default.Save();
            }
        }
        private void spectreSpline(object sender, RoutedEventArgs e)
        {
            if (spectreArray.Contains("spline"))
            {
                return;
            }
            else
            {
                spectreArray.Clear();
                spectreArray.Add("spline");
                Properties.Settings.Default.Spectre = "spline";
                Properties.Settings.Default.Save();
            }
        }
        private void spectreStriker(object sender, RoutedEventArgs e)
        {
            if (spectreArray.Contains("striker"))
            {
                return;
            }
            else
            {
                spectreArray.Clear();
                spectreArray.Add("striker");
                Properties.Settings.Default.Spectre = "striker";
                Properties.Settings.Default.Save();
            }
        }
        private void spectreTigris(object sender, RoutedEventArgs e)
        {
            if (spectreArray.Contains("tigris"))
            {
                return;
            }
            else
            {
                spectreArray.Clear();
                spectreArray.Add("tigris");
                Properties.Settings.Default.Spectre = "tigris";
                Properties.Settings.Default.Save();
            }
        }
        private void spectreValgo(object sender, RoutedEventArgs e)
        {
            if (spectreArray.Contains("valgo"))
            {
                return;
            }
            else
            {
                spectreArray.Clear();
                spectreArray.Add("valgo");
                Properties.Settings.Default.Spectre = "valgo";
                Properties.Settings.Default.Save();
            }
        }
        private void spectreVelocity(object sender, RoutedEventArgs e)
        {
            if (spectreArray.Contains("velocity"))
            {
                return;
            }
            else
            {
                spectreArray.Clear();
                spectreArray.Add("velocity");
                Properties.Settings.Default.Spectre = "velocity";
                Properties.Settings.Default.Save();
            }
        }
        private void spectreWasteland(object sender, RoutedEventArgs e)
        {
            if (spectreArray.Contains("wasteland"))
            {
                return;
            }
            else
            {
                spectreArray.Clear();
                spectreArray.Add("wasteland");
                Properties.Settings.Default.Spectre = "wasteland";
                Properties.Settings.Default.Save();
            }
        }

        //stinger skins
        private void stingerDefault(object sender, RoutedEventArgs e)
        {
            if (stingerArray.Contains("default"))
            {
                return;
            }
            else
            {
                stingerArray.Clear();
                stingerArray.Add("default");
                Properties.Settings.Default.Stinger = "default";
                Properties.Settings.Default.Save();
            }
        }
        private void stingerAristocrat(object sender, RoutedEventArgs e)
        {
            if (stingerArray.Contains("aristocrat"))
            {
                return;
            }
            else
            {
                stingerArray.Clear();
                stingerArray.Add("aristocrat");
                Properties.Settings.Default.Stinger = "aristocrat";
                Properties.Settings.Default.Save();
            }
        }
        private void stingerCavalier(object sender, RoutedEventArgs e)
        {
            if (stingerArray.Contains("cavalier"))
            {
                return;
            }
            else
            {
                stingerArray.Clear();
                stingerArray.Add("cavalier");
                Properties.Settings.Default.Stinger = "cavalier";
                Properties.Settings.Default.Save();
            }
        }
        private void stingerCouture(object sender, RoutedEventArgs e)
        {
            if (stingerArray.Contains("couture"))
            {
                return;
            }
            else
            {
                stingerArray.Clear();
                stingerArray.Add("couture");
                Properties.Settings.Default.Stinger = "couture";
                Properties.Settings.Default.Save();
            }
        }
        private void stingerDepths(object sender, RoutedEventArgs e)
        {
            if (stingerArray.Contains("depths"))
            {
                return;
            }
            else
            {
                stingerArray.Clear();
                stingerArray.Add("depths");
                Properties.Settings.Default.Stinger = "depths";
                Properties.Settings.Default.Save();
            }
        }
        private void stingerEgo(object sender, RoutedEventArgs e)
        {
            if (stingerArray.Contains("ego"))
            {
                return;
            }
            else
            {
                stingerArray.Clear();
                stingerArray.Add("ego");
                Properties.Settings.Default.Stinger = "ego";
                Properties.Settings.Default.Save();
            }
        }
        private void stingerLycan(object sender, RoutedEventArgs e)
        {
            if (stingerArray.Contains("lycan"))
            {
                return;
            }
            else
            {
                stingerArray.Clear();
                stingerArray.Add("lycan");
                Properties.Settings.Default.Stinger = "lycan";
                Properties.Settings.Default.Save();
            }
        }
        private void stingerPrism(object sender, RoutedEventArgs e)
        {
            if (stingerArray.Contains("prism"))
            {
                return;
            }
            else
            {
                stingerArray.Clear();
                stingerArray.Add("prism");
                Properties.Settings.Default.Stinger = "prism";
                Properties.Settings.Default.Save();
            }
        }
        private void stingerRedalert(object sender, RoutedEventArgs e)
        {
            if (stingerArray.Contains("redalert"))
            {
                return;
            }
            else
            {
                stingerArray.Clear();
                stingerArray.Add("redalert");
                Properties.Settings.Default.Stinger = "redalert";
                Properties.Settings.Default.Save();
            }
        }
        private void stingerRgx11(object sender, RoutedEventArgs e)
        {
            if (stingerArray.Contains("rgx11"))
            {
                return;
            }
            else
            {
                stingerArray.Clear();
                stingerArray.Add("rgx11");
                Properties.Settings.Default.Stinger = "rgx11";
                Properties.Settings.Default.Save();
            }
        }
        private void stingerSakura(object sender, RoutedEventArgs e)
        {
            if (stingerArray.Contains("sakura"))
            {
                return;
            }
            else
            {
                stingerArray.Clear();
                stingerArray.Add("sakura");
                Properties.Settings.Default.Stinger = "sakura";
                Properties.Settings.Default.Save();
            }
        }
        private void stingerSchema(object sender, RoutedEventArgs e)
        {
            if (stingerArray.Contains("schema"))
            {
                return;
            }
            else
            {
                stingerArray.Clear();
                stingerArray.Add("schema");
                Properties.Settings.Default.Stinger = "schema";
                Properties.Settings.Default.Save();
            }
        }
        private void stingerSensation(object sender, RoutedEventArgs e)
        {
            if (stingerArray.Contains("sensation"))
            {
                return;
            }
            else
            {
                stingerArray.Clear();
                stingerArray.Add("sensation");
                Properties.Settings.Default.Stinger = "sensation";
                Properties.Settings.Default.Save();
            }
        }
        private void stingerSilvanus(object sender, RoutedEventArgs e)
        {
            if (stingerArray.Contains("silvanus"))
            {
                return;
            }
            else
            {
                stingerArray.Clear();
                stingerArray.Add("silvanus");
                Properties.Settings.Default.Stinger = "silvanus";
                Properties.Settings.Default.Save();
            }
        }
        private void stingerSovereign(object sender, RoutedEventArgs e)
        {
            if (stingerArray.Contains("sovereign"))
            {
                return;
            }
            else
            {
                stingerArray.Clear();
                stingerArray.Add("sovereign");
                Properties.Settings.Default.Stinger = "sovereign";
                Properties.Settings.Default.Save();
            }
        }
        private void stingerSurge(object sender, RoutedEventArgs e)
        {
            if (stingerArray.Contains("surge"))
            {
                return;
            }
            else
            {
                stingerArray.Clear();
                stingerArray.Add("surge");
                Properties.Settings.Default.Stinger = "surge";
                Properties.Settings.Default.Save();
            }
        }
        private void stingerVarnish(object sender, RoutedEventArgs e)
        {
            if (stingerArray.Contains("varnish"))
            {
                return;
            }
            else
            {
                stingerArray.Clear();
                stingerArray.Add("varnish");
                Properties.Settings.Default.Stinger = "varnish";
                Properties.Settings.Default.Save();
            }
        }

        //vandal skins
        private void vandalDefault(object sender, RoutedEventArgs e)
        {
            if (vandalArray.Contains("default"))
            {
                return;
            }
            else
            {
                vandalArray.Clear();
                vandalArray.Add("default");
                Properties.Settings.Default.Vandal = "default";
                Properties.Settings.Default.Save();
            }
        }
        private void vandalAristocrat(object sender, RoutedEventArgs e)
        {
            if (vandalArray.Contains("aristocrat"))
            {
                return;
            }
            else
            {
                vandalArray.Clear();
                vandalArray.Add("aristocrat");
                Properties.Settings.Default.Vandal = "aristocrat";
                Properties.Settings.Default.Save();
            }
        }
        private void vandalAvalanche(object sender, RoutedEventArgs e)
        {
            if (vandalArray.Contains("avalanche"))
            {
                return;
            }
            else
            {
                vandalArray.Clear();
                vandalArray.Add("avalanche");
                Properties.Settings.Default.Vandal = "avalanche";
                Properties.Settings.Default.Save();
            }
        }
        private void vandalCavalier(object sender, RoutedEventArgs e)
        {
            if (vandalArray.Contains("cavalier"))
            {
                return;
            }
            else
            {
                vandalArray.Clear();
                vandalArray.Add("cavalier");
                Properties.Settings.Default.Vandal = "cavalier";
                Properties.Settings.Default.Save();
            }
        }
        private void vandalChampions(object sender, RoutedEventArgs e)
        {
            if (vandalArray.Contains("champions"))
            {
                return;
            }
            else
            {
                vandalArray.Clear();
                vandalArray.Add("champions");
                Properties.Settings.Default.Vandal = "champions";
                Properties.Settings.Default.Save();
            }
        }
        private void vandalDepths(object sender, RoutedEventArgs e)
        {
            if (vandalArray.Contains("depths"))
            {
                return;
            }
            else
            {
                vandalArray.Clear();
                vandalArray.Add("depths");
                Properties.Settings.Default.Vandal = "depths";
                Properties.Settings.Default.Save();
            }
        }
        private void vandalDotexe(object sender, RoutedEventArgs e)
        {
            if (vandalArray.Contains("dotexe"))
            {
                return;
            }
            else
            {
                vandalArray.Clear();
                vandalArray.Add("dotexe");
                Properties.Settings.Default.Vandal = "dotexe";
                Properties.Settings.Default.Save();
            }
        }
        private void vandalEgo(object sender, RoutedEventArgs e)
        {
            if (vandalArray.Contains("ego"))
            {
                return;
            }
            else
            {
                vandalArray.Clear();
                vandalArray.Add("ego");
                Properties.Settings.Default.Vandal = "ego";
                Properties.Settings.Default.Save();
            }
        }
        private void vandalElderflame(object sender, RoutedEventArgs e)
        {
            if (vandalArray.Contains("elderflame"))
            {
                return;
            }
            else
            {
                vandalArray.Clear();
                vandalArray.Add("elderflame");
                Properties.Settings.Default.Vandal = "elderflame";
                Properties.Settings.Default.Save();
            }
        }
        private void vandalForsaken(object sender, RoutedEventArgs e)
        {
            if (vandalArray.Contains("forsaken"))
            {
                return;
            }
            else
            {
                vandalArray.Clear();
                vandalArray.Add("forsaken");
                Properties.Settings.Default.Vandal = "forsaken";
                Properties.Settings.Default.Save();
            }
        }
        private void vandalGaias(object sender, RoutedEventArgs e)
        {
            if (vandalArray.Contains("gaias"))
            {
                return;
            }
            else
            {
                vandalArray.Clear();
                vandalArray.Add("gaias");
                Properties.Settings.Default.Vandal = "gaias";
                Properties.Settings.Default.Save();
            }
        }
        private void vandalGlitchpop(object sender, RoutedEventArgs e)
        {
            if (vandalArray.Contains("glitchpop"))
            {
                return;
            }
            else
            {
                vandalArray.Clear();
                vandalArray.Add("glitchpop");
                Properties.Settings.Default.Vandal = "glitchpop";
                Properties.Settings.Default.Save();
            }
        }
        private void vandalHivemind(object sender, RoutedEventArgs e)
        {
            if (vandalArray.Contains("hivemind"))
            {
                return;
            }
            else
            {
                vandalArray.Clear();
                vandalArray.Add("hivemind");
                Properties.Settings.Default.Vandal = "hivemind";
                Properties.Settings.Default.Save();
            }
        }
        private void vandalHorizon(object sender, RoutedEventArgs e)
        {
            if (vandalArray.Contains("horizon"))
            {
                return;
            }
            else
            {
                vandalArray.Clear();
                vandalArray.Add("horizon");
                Properties.Settings.Default.Vandal = "horizon";
                Properties.Settings.Default.Save();
            }
        }
        private void vandalKtac(object sender, RoutedEventArgs e)
        {
            if (vandalArray.Contains("ktac"))
            {
                return;
            }
            else
            {
                vandalArray.Clear();
                vandalArray.Add("ktac");
                Properties.Settings.Default.Vandal = "ktac";
                Properties.Settings.Default.Save();
            }
        }
        private void vandalLuxe(object sender, RoutedEventArgs e)
        {
            if (vandalArray.Contains("luxe"))
            {
                return;
            }
            else
            {
                vandalArray.Clear();
                vandalArray.Add("luxe");
                Properties.Settings.Default.Vandal = "luxe";
                Properties.Settings.Default.Save();
            }
        }
        private void vandalLycan(object sender, RoutedEventArgs e)
        {
            if (vandalArray.Contains("lycan"))
            {
                return;
            }
            else
            {
                vandalArray.Clear();
                vandalArray.Add("lycan");
                Properties.Settings.Default.Vandal = "lycan";
                Properties.Settings.Default.Save();
            }
        }
        private void vandalNitro(object sender, RoutedEventArgs e)
        {
            if (vandalArray.Contains("nitro"))
            {
                return;
            }
            else
            {
                vandalArray.Clear();
                vandalArray.Add("nitro");
                Properties.Settings.Default.Vandal = "nitro";
                Properties.Settings.Default.Save();
            }
        }
        private void vandalOlvidados(object sender, RoutedEventArgs e)
        {
            if (vandalArray.Contains("olvidados"))
            {
                return;
            }
            else
            {
                vandalArray.Clear();
                vandalArray.Add("olvidados");
                Properties.Settings.Default.Vandal = "olvidados";
                Properties.Settings.Default.Save();
            }
        }
        private void vandalOrigin(object sender, RoutedEventArgs e)
        {
            if (vandalArray.Contains("origin"))
            {
                return;
            }
            else
            {
                vandalArray.Clear();
                vandalArray.Add("origin");
                Properties.Settings.Default.Vandal = "origin";
                Properties.Settings.Default.Save();
            }
        }
        private void vandalPrime(object sender, RoutedEventArgs e)
        {
            if (vandalArray.Contains("prime"))
            {
                return;
            }
            else
            {
                vandalArray.Clear();
                vandalArray.Add("prime");
                Properties.Settings.Default.Vandal = "prime";
                Properties.Settings.Default.Save();
            }
        }
        private void vandalPrism(object sender, RoutedEventArgs e)
        {
            if (vandalArray.Contains("prism"))
            {
                return;
            }
            else
            {
                vandalArray.Clear();
                vandalArray.Add("prism");
                Properties.Settings.Default.Vandal = "prism";
                Properties.Settings.Default.Save();
            }
        }
        private void vandalReaver(object sender, RoutedEventArgs e)
        {
            if (vandalArray.Contains("reaver"))
            {
                return;
            }
            else
            {
                vandalArray.Clear();
                vandalArray.Add("reaver");
                Properties.Settings.Default.Vandal = "reaver";
                Properties.Settings.Default.Save();
            }
        }
        private void vandalRgx11(object sender, RoutedEventArgs e)
        {
            if (vandalArray.Contains("rgx11"))
            {
                return;
            }
            else
            {
                vandalArray.Clear();
                vandalArray.Add("rgx11");
                Properties.Settings.Default.Vandal = "rgx11";
                Properties.Settings.Default.Save();
            }
        }
        private void vandalRuin(object sender, RoutedEventArgs e)
        {
            if (vandalArray.Contains("ruin"))
            {
                return;
            }
            else
            {
                vandalArray.Clear();
                vandalArray.Add("ruin");
                Properties.Settings.Default.Vandal = "ruin";
                Properties.Settings.Default.Save();
            }
        }
        private void vandalSakura(object sender, RoutedEventArgs e)
        {
            if (vandalArray.Contains("sakura"))
            {
                return;
            }
            else
            {
                vandalArray.Clear();
                vandalArray.Add("sakura");
                Properties.Settings.Default.Vandal = "sakura";
                Properties.Settings.Default.Save();
            }
        }
        private void vandalSchema(object sender, RoutedEventArgs e)
        {
            if (vandalArray.Contains("schema"))
            {
                return;
            }
            else
            {
                vandalArray.Clear();
                vandalArray.Add("schema");
                Properties.Settings.Default.Vandal = "schema";
                Properties.Settings.Default.Save();
            }
        }
        private void vandalSensation(object sender, RoutedEventArgs e)
        {
            if (vandalArray.Contains("sensation"))
            {
                return;
            }
            else
            {
                vandalArray.Clear();
                vandalArray.Add("sensation");
                Properties.Settings.Default.Vandal = "sensation";
                Properties.Settings.Default.Save();
            }
        }
        private void vandalSentinels(object sender, RoutedEventArgs e)
        {
            if (vandalArray.Contains("sentinels"))
            {
                return;
            }
            else
            {
                vandalArray.Clear();
                vandalArray.Add("sentinels");
                Properties.Settings.Default.Vandal = "sentinels";
                Properties.Settings.Default.Save();
            }
        }
        private void vandalSilvanus(object sender, RoutedEventArgs e)
        {
            if (vandalArray.Contains("silvanus"))
            {
                return;
            }
            else
            {
                vandalArray.Clear();
                vandalArray.Add("silvanus");
                Properties.Settings.Default.Vandal = "silvanus";
                Properties.Settings.Default.Save();
            }
        }
        private void vandalTethered(object sender, RoutedEventArgs e)
        {
            if (vandalArray.Contains("tethered"))
            {
                return;
            }
            else
            {
                vandalArray.Clear();
                vandalArray.Add("tethered");
                Properties.Settings.Default.Vandal = "tethered";
                Properties.Settings.Default.Save();
            }
        }
        private void vandalValgo(object sender, RoutedEventArgs e)
        {
            if (vandalArray.Contains("valgo"))
            {
                return;
            }
            else
            {
                vandalArray.Clear();
                vandalArray.Add("valgo");
                Properties.Settings.Default.Vandal = "valgo";
                Properties.Settings.Default.Save();
            }
        }
        private void vandalWasteland(object sender, RoutedEventArgs e)
        {
            if (vandalArray.Contains("wasteland"))
            {
                return;
            }
            else
            {
                vandalArray.Clear();
                vandalArray.Add("wasteland");
                Properties.Settings.Default.Vandal = "wasteland";
                Properties.Settings.Default.Save();
            }
        }
        private void vandalWunderland(object sender, RoutedEventArgs e)
        {
            if (vandalArray.Contains("wunderland"))
            {
                return;
            }
            else
            {
                vandalArray.Clear();
                vandalArray.Add("wunderland");
                Properties.Settings.Default.Vandal = "wunderland";
                Properties.Settings.Default.Save();
            }
        }


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
            classicResets();
            frenzyResets();
            ghostResets();
            sheriffResets();
            shortyResets();
            free1.Opacity = 0;
            blank1.Opacity = 0;
            pistolGiven.Text = "";

            //primary
            aresResets();
            buckyResets();
            bulldogResets();
            guardianResets();
            judgeResets();
            marshalResets();
            odinResets();
            operatorResets();
            phantomResets();
            spectreResets();
            stingerResets();
            vandalResets();
            free2.Opacity = 0;
            blank2.Opacity = 0;
            mainGiven.Text = "";

            //shields
            light.Opacity = 0;
            heavy.Opacity = 0;
            free3.Opacity = 0;
            blank3.Opacity = 0;
            shieldGiven.Text = "";
        }

        public void secondary()
        {
            string[] pist = new string[7] { "Classic", "Frenzy", "Ghost", "Sheriff", "Shorty", "Free", "Blank" };
            Random randPistol = new Random();
            int val = randPistol.Next(0, pist.Length + 1);

            if (val == 1)
            {
                pistolGiven.Text = "Classic";
                classicResets();
                frenzyResets();
                ghostResets();
                sheriffResets();
                shortyResets();
                free1.Opacity = 0;
                blank1.Opacity = 0;
                if (classicArray.Contains("default"))
                {
                    classic.Opacity = 100;
                }
                else if (classicArray.Contains("avalanche"))
                {
                    avalancheclassic.Opacity = 100;
                }
                else if (classicArray.Contains("final"))
                {
                    finalclassic.Opacity = 100;
                }
                else if (classicArray.Contains("finesse"))
                {
                    finesseclassic.Opacity = 100;
                }
                else if (classicArray.Contains("firearm"))
                {
                    firearmclassic.Opacity = 100;
                }
                else if (classicArray.Contains("forsaken"))
                {
                    forsakenclassic.Opacity = 100;
                }
                else if (classicArray.Contains("galleria"))
                {
                    galleriaclassic.Opacity = 100;
                }
                else if (classicArray.Contains("glitchpop"))
                {
                    glitchpopclassic.Opacity = 100;
                }
                else if (classicArray.Contains("goldwing"))
                {
                    goldwingclassic.Opacity = 100;
                }
                else if (classicArray.Contains("neuroblaster"))
                {
                    neuroblasterclassic.Opacity = 100;
                }
                else if (classicArray.Contains("infinity"))
                {
                    infinityclassic.Opacity = 100;
                }
                else if (classicArray.Contains("kingdom"))
                {
                    kingdomclassic.Opacity = 100;
                }
                else if (classicArray.Contains("pistolinha"))
                {
                    pistolinhaclassic.Opacity = 100;
                }
                else if (classicArray.Contains("prime"))
                {
                    primeclassic.Opacity = 100;
                }
                else if (classicArray.Contains("prism"))
                {
                    prismclassic.Opacity = 100;
                }
                else if (classicArray.Contains("crisis"))
                {
                    crisisclassic.Opacity = 100;
                }
                else if (classicArray.Contains("redalert"))
                {
                    redalertclassic.Opacity = 100;
                }
                else if (classicArray.Contains("sakura"))
                {
                    sakuraclassic.Opacity = 100;
                }
                else if (classicArray.Contains("smite"))
                {
                    smiteclassic.Opacity = 100;
                }
                else if (classicArray.Contains("snowfall"))
                {
                    snowfallclassic.Opacity = 100;
                }
                else if (classicArray.Contains("songsteel"))
                {
                    songsteelclassic.Opacity = 100;
                }
                else if (classicArray.Contains("spectrum"))
                {
                    specrtumclassic.Opacity = 100;
                }
                else if (classicArray.Contains("spline"))
                {
                    splineclassic.Opacity = 100;
                }
                else if (classicArray.Contains("striker"))
                {
                    strikerclassic.Opacity = 100;
                }
                else if (classicArray.Contains("surge"))
                {
                    surgeclassic.Opacity = 100;
                }
                else if (classicArray.Contains("undercity"))
                {
                    undercityclassic.Opacity = 100;
                }
                else if (classicArray.Contains("valgo"))
                {
                    valgoclassic.Opacity = 100;
                }
            }
            else if (val == 2)
            {
                pistolGiven.Text = "Frenzy";
                classicResets();
                frenzyResets();
                ghostResets();
                sheriffResets();
                shortyResets();
                free1.Opacity = 0;
                blank1.Opacity = 0;
                if (frenzyArray.Contains("default"))
                {
                    frenzy.Opacity = 100;
                }
                else if (frenzyArray.Contains("aero"))
                {
                    aerofrenzy.Opacity = 100;
                }
                else if (frenzyArray.Contains("blastx"))
                {
                    blastxfrenzy.Opacity = 100;
                }
                else if (frenzyArray.Contains("celestial"))
                {
                    celestialfrenzy.Opacity = 100;
                }
                else if (frenzyArray.Contains("couture"))
                {
                    couturefrenzy.Opacity = 100;
                }
                else if (frenzyArray.Contains("divine"))
                {
                    divinefrenzy.Opacity = 100;
                }
                else if (frenzyArray.Contains("elderflame"))
                {
                    elderflamefrenzy.Opacity = 100;
                }
                else if (frenzyArray.Contains("glitchpop"))
                {
                    glitchpopfrenzy.Opacity = 100;
                }
                else if (frenzyArray.Contains("horizon"))
                {
                    horizonfrenzy.Opacity = 100;
                }
                else if (frenzyArray.Contains("hydrodip"))
                {
                    hydrodipfrenzy.Opacity = 100;
                }
                else if (frenzyArray.Contains("lightwave"))
                {
                    lightwavefrenzy.Opacity = 100;
                }
                else if (frenzyArray.Contains("livewire"))
                {
                    livewirefrenzy.Opacity = 100;
                }
                else if (frenzyArray.Contains("monarch"))
                {
                    monarchfrenzy.Opacity = 100;
                }
                else if (frenzyArray.Contains("olvidados"))
                {
                    olvidadosfrenzy.Opacity = 100;
                }
                else if (frenzyArray.Contains("origin"))
                {
                    originfrenzy.Opacity = 100;
                }
                else if (frenzyArray.Contains("prime"))
                {
                    primefrenzy.Opacity = 100;
                }
                else if (frenzyArray.Contains("ragnarocker"))
                {
                    ragnarockerfrenzy.Opacity = 100;
                }
                else if (frenzyArray.Contains("rgx11"))
                {
                    rgx11frenzy.Opacity = 100;
                }
                else if (frenzyArray.Contains("rush"))
                {
                    rushfrenzy.Opacity = 100;
                }
                else if (frenzyArray.Contains("sensation"))
                {
                    sensationfrenzy.Opacity = 100;
                }
                else if (frenzyArray.Contains("spitfire"))
                {
                    spitfirefrenzy.Opacity = 100;
                }
                else if (frenzyArray.Contains("swooping"))
                {
                    swoopingfrenzy.Opacity = 100;
                }
            }
            else if (val == 3)
            {
                pistolGiven.Text = "Ghost";
                classicResets();
                frenzyResets();
                ghostResets();
                sheriffResets();
                shortyResets();
                free1.Opacity = 0;
                blank1.Opacity = 0;
                if (ghostArray.Contains("default"))
                {
                    ghost.Opacity = 100;
                }
                else if (ghostArray.Contains("artisan"))
                {
                    artisanghost.Opacity = 100;
                }
                else if (ghostArray.Contains("cavalier"))
                {
                    cavalierghost.Opacity = 100;
                }
                else if (ghostArray.Contains("depths"))
                {
                    depthsghost.Opacity = 100;
                }
                else if (ghostArray.Contains("dotexe"))
                {
                    dotexeghost.Opacity = 100;
                }
                else if (ghostArray.Contains("eclipse"))
                {
                    eclipseghost.Opacity = 100;
                }
                else if (ghostArray.Contains("ego"))
                {
                    egoghost.Opacity = 100;
                }
                else if (ghostArray.Contains("gaias"))
                {
                    gaiasghost.Opacity = 100;
                }
                else if (ghostArray.Contains("goldwing"))
                {
                    goldwingghost.Opacity = 100;
                }
                else if (ghostArray.Contains("hush"))
                {
                    hushghost.Opacity = 100;
                }
                else if (ghostArray.Contains("infantry"))
                {
                    infantryghost.Opacity = 100;
                }
                else if (ghostArray.Contains("jigsaw"))
                {
                    jigsawghost.Opacity = 100;
                }
                else if (ghostArray.Contains("luxe"))
                {
                    luxeghost.Opacity = 100;
                }
                else if (ghostArray.Contains("lycan"))
                {
                    lycanghost.Opacity = 100;
                }
                else if (ghostArray.Contains("magepunk"))
                {
                    magepunkghost.Opacity = 100;
                }
                else if (ghostArray.Contains("outpost"))
                {
                    outpostghost.Opacity = 100;
                }
                else if (ghostArray.Contains("prism"))
                {
                    prismghost.Opacity = 100;
                }
                else if (ghostArray.Contains("recon"))
                {
                    reconghost.Opacity = 100;
                }
                else if (ghostArray.Contains("ruination"))
                {
                    ruinationghost.Opacity = 100;
                }
                else if (ghostArray.Contains("serenity"))
                {
                    serenityghost.Opacity = 100;
                }
                else if (ghostArray.Contains("soul"))
                {
                    soulsilencerghost.Opacity = 100;
                }
                else if (ghostArray.Contains("sovereign"))
                {
                    sovereignghost.Opacity = 100;
                }
                else if (ghostArray.Contains("tethered"))
                {
                    tetheredghost.Opacity = 100;
                }
                else if (ghostArray.Contains("valgo"))
                {
                    valgoghost.Opacity = 100;
                }
                else if (ghostArray.Contains("vendetta"))
                {
                    vendettaghost.Opacity = 100;
                }
                else if (ghostArray.Contains("wunderland"))
                {
                    winterwunderlandghost.Opacity = 100;
                }
            }
            else if (val == 4)
            {
                pistolGiven.Text = "Sheriff";
                classicResets();
                frenzyResets();
                ghostResets();
                sheriffResets();
                shortyResets();
                free1.Opacity = 0;
                blank1.Opacity = 0;
                if (sheriffArray.Contains("default"))
                {
                    sheriff.Opacity = 100;
                }
                else if (sheriffArray.Contains("arcane"))
                {
                    arcanesheriff.Opacity = 100;
                }
                else if (sheriffArray.Contains("aristocrat"))
                {
                    aristocratsheriff.Opacity = 100;
                }
                else if (sheriffArray.Contains("convex"))
                {
                    convexsheriff.Opacity = 100;
                }
                else if (sheriffArray.Contains("deathwish"))
                {
                    deathwishsheriff.Opacity = 100;
                }
                else if (sheriffArray.Contains("gameover"))
                {
                    gameoversheriff.Opacity = 100;
                }
                else if (sheriffArray.Contains("ion"))
                {
                    ionsheriff.Opacity = 100;
                }
                else if (sheriffArray.Contains("ktac"))
                {
                    ktacsheriff.Opacity = 100;
                }
                else if (sheriffArray.Contains("lightwave"))
                {
                    lightwavesheriff.Opacity = 100;
                }
                else if (sheriffArray.Contains("magepunk"))
                {
                    magepunksheriff.Opacity = 100;
                }
                else if (sheriffArray.Contains("minima"))
                {
                    minimasheriff.Opacity = 100;
                }
                else if (sheriffArray.Contains("nebula"))
                {
                    nebulasheriff.Opacity = 100;
                }
                else if (sheriffArray.Contains("peacekeeper"))
                {
                    peacekeepersheriff.Opacity = 100;
                }
                else if (sheriffArray.Contains("polyfox"))
                {
                    polyfoxsheriff.Opacity = 100;
                }
                else if (sheriffArray.Contains("polyfrog"))
                {
                    polyfrogsheriff.Opacity = 100;
                }
                else if (sheriffArray.Contains("prism"))
                {
                    prismsheriff.Opacity = 100;
                }
                else if (sheriffArray.Contains("protektor"))
                {
                    protektorsheriff.Opacity = 100;
                }
                else if (sheriffArray.Contains("protocol"))
                {
                    protocolsheriff.Opacity = 100;
                }
                else if (sheriffArray.Contains("reaver"))
                {
                    reaversheriff.Opacity = 100;
                }
                else if (sheriffArray.Contains("sakura"))
                {
                    sakurasheriff.Opacity = 100;
                }
                else if (sheriffArray.Contains("schema"))
                {
                    schemasheriff.Opacity = 100;
                }
                else if (sheriffArray.Contains("sentinels"))
                {
                    sentinelssheriff.Opacity = 100;
                }
                else if (sheriffArray.Contains("silvanus"))
                {
                    silvanussheriff.Opacity = 100;
                }
                else if (sheriffArray.Contains("singularity"))
                {
                    singularitysheriff.Opacity = 100;
                }
                else if (sheriffArray.Contains("surge"))
                {
                    surgesheriff.Opacity = 100;
                }
                else if (sheriffArray.Contains("varnish"))
                {
                    varnishsheriff.Opacity = 100;
                }
                else if (sheriffArray.Contains("wasteland"))
                {
                    wastelandsheriff.Opacity = 100;
                }
            }
            else if (val == 5)
            {
                pistolGiven.Text = "Shorty";
                classicResets();
                frenzyResets();
                ghostResets();
                sheriffResets();
                shortyResets();
                free1.Opacity = 0;
                blank1.Opacity = 0;
                if (shortyArray.Contains("default"))
                {
                    shorty.Opacity = 100;
                }
                else if (shortyArray.Contains("aerosol"))
                {
                    aerosolshorty.Opacity = 100;
                }
                else if (shortyArray.Contains("genesis"))
                {
                    genesisshorty.Opacity = 100;
                }
                else if (shortyArray.Contains("hivemind"))
                {
                    hivemindshorty.Opacity = 100;
                }
                else if (shortyArray.Contains("monarch"))
                {
                    monarchshorty.Opacity = 100;
                }
                else if (shortyArray.Contains("oni"))
                {
                    onishorty.Opacity = 100;
                }
                else if (shortyArray.Contains("prism"))
                {
                    prismshorty.Opacity = 100;
                }
                else if (shortyArray.Contains("ruin"))
                {
                    ruinshorty.Opacity = 100;
                }
                else if (shortyArray.Contains("snakebite"))
                {
                    snakebiteshorty.Opacity = 100;
                }
                else if (shortyArray.Contains("tigris"))
                {
                    tigrisshorty.Opacity = 100;
                }
                else if (shortyArray.Contains("velocity"))
                {
                    velocityshorty.Opacity = 100;
                }
                else if (shortyArray.Contains("wasteland"))
                {
                    wastelandshorty.Opacity = 100;
                }
                else if (shortyArray.Contains("wayfinder"))
                {
                    wayfindershorty.Opacity = 100;
                }
                else if (shortyArray.Contains("wunderkind"))
                {
                    wunderkindshorty.Opacity = 100;
                }
            }
            else if (val == 6)
            {
                classicResets();
                frenzyResets();
                ghostResets();
                sheriffResets();
                shortyResets();
                free1.Opacity = 100;
                blank1.Opacity = 0;
                pistolGiven.Text = "Your Pick";
            }
            else if (val == 7)
            {
                classicResets();
                frenzyResets();
                ghostResets();
                sheriffResets();
                shortyResets();
                free1.Opacity = 0;
                blank1.Opacity = 100;
                pistolGiven.Text = "No Pistol";
            }
        }
        public void primary()
        {
            string[] gun = new string[14] { "Ares", "Bucky", "Bulldog", "Guardian", "Judge", "Marshal", "Odin", "Operator", "Phantom", "Spectre", "Stinger", "Vandal", "Free", "Blank" };
            Random randGun = new Random();
            int val = randGun.Next(0, gun.Length + 1);

            if (val == 1)
            {
                mainGiven.Text = "Ares";
                blank2.Opacity = 0;
                free2.Opacity = 0;
                aresResets();
                buckyResets();
                bulldogResets();
                guardianResets();
                judgeResets();
                marshalResets();
                odinResets();
                operatorResets();
                phantomResets();
                spectreResets();
                stingerResets();
                vandalResets();
                if (aresArray.Contains("default"))
                {
                    ares.Opacity = 100;
                }
                else if (aresArray.Contains("aristocrat"))
                {
                    aristocratares.Opacity = 100;
                }
                else if (aresArray.Contains("celestial"))
                {
                    celestialares.Opacity = 100;
                }
                else if (aresArray.Contains("divine"))
                {
                    divinares.Opacity = 100;
                }
                else if (aresArray.Contains("goldwing"))
                {
                    goldwingares.Opacity = 100;
                }
                else if (aresArray.Contains("hivemind"))
                {
                    hivemindares.Opacity = 100;
                }
                else if (aresArray.Contains("infantry"))
                {
                    infantryares.Opacity = 100;
                }
                else if (aresArray.Contains("jigsaw"))
                {
                    jigsawares.Opacity = 100;
                }
                else if (aresArray.Contains("magepunk"))
                {
                    magepunkares.Opacity = 100;
                }
                else if (aresArray.Contains("minima"))
                {
                    minimaares.Opacity = 100;
                }
                else if (aresArray.Contains("nebula"))
                {
                    nebulaares.Opacity = 100;
                }
                else if (aresArray.Contains("olvidados"))
                {
                    olvidadosares.Opacity = 100;
                }
                else if (aresArray.Contains("outpost"))
                {
                    outpostares.Opacity = 100;
                }
                else if (aresArray.Contains("polyfrog"))
                {
                    polyfrogares.Opacity = 100;
                }
                else if (aresArray.Contains("prism"))
                {
                    prismares.Opacity = 100;
                }
                else if (aresArray.Contains("rush"))
                {
                    rushares.Opacity = 100;
                }
                else if (aresArray.Contains("sakura"))
                {
                    sakuraares.Opacity = 100;
                }
                else if (aresArray.Contains("sentinels"))
                {
                    sentinelsares.Opacity = 100;
                }
                else if (aresArray.Contains("singularity"))
                {
                    singularityares.Opacity = 100;
                }
                else if (aresArray.Contains("snowfall"))
                {
                    snowfallares.Opacity = 100;
                }
                else if (aresArray.Contains("valgo"))
                {
                    valgoares.Opacity = 100;
                }
            }
            else if (val == 2)
            {
                mainGiven.Text = "Bucky";
                blank2.Opacity = 0;
                free2.Opacity = 0;
                aresResets();
                buckyResets();
                bulldogResets();
                guardianResets();
                judgeResets();
                marshalResets();
                odinResets();
                operatorResets();
                phantomResets();
                spectreResets();
                stingerResets();
                vandalResets();
                if (buckyArray.Contains("default"))
                {
                    bucky.Opacity = 100;
                }
                else if (buckyArray.Contains("aerosol"))
                {
                    aerosolbucky.Opacity = 100;
                }
                else if (buckyArray.Contains("artisan"))
                {
                    artisanbucky.Opacity = 100;
                }
                else if (buckyArray.Contains("cavalier"))
                {
                    cavalierbucky.Opacity = 100;
                }
                else if (buckyArray.Contains("galleria"))
                {
                    galleriabucky.Opacity = 100;
                }
                else if (buckyArray.Contains("genesis"))
                {
                    genesisbucky.Opacity = 100;
                }
                else if (buckyArray.Contains("neuroblaster"))
                {
                    neuroblasterbucky.Opacity = 100;
                }
                else if (buckyArray.Contains("horizon"))
                {
                    horizonbucky.Opacity = 100;
                }
                else if (buckyArray.Contains("hydrodip"))
                {
                    hydrodipbucky.Opacity = 100;
                }
                else if (buckyArray.Contains("ion"))
                {
                    ionbucky.Opacity = 100;
                }
                else if (buckyArray.Contains("kingdom"))
                {
                    kingdombucky.Opacity = 100;
                }
                else if (buckyArray.Contains("lightwave"))
                {
                    lightwavebucky.Opacity = 100;
                }
                else if (buckyArray.Contains("magepunk"))
                {
                    magepunkbucky.Opacity = 100;
                }
                else if (buckyArray.Contains("monarch"))
                {
                    monarchbucky.Opacity = 100;
                }
                else if (buckyArray.Contains("oni"))
                {
                    onibucky.Opacity = 100;
                }
                else if (buckyArray.Contains("origin"))
                {
                    originbucky.Opacity = 100;
                }
                else if (buckyArray.Contains("prime"))
                {
                    primebucky.Opacity = 100;
                }
                else if (buckyArray.Contains("prism"))
                {
                    prismbucky.Opacity = 100;
                }
                else if (buckyArray.Contains("crisis"))
                {
                    crisisbucky.Opacity = 100;
                }
                else if (buckyArray.Contains("redalert"))
                {
                    redalertbucky.Opacity = 100;
                }
                else if (buckyArray.Contains("surge"))
                {
                    surgebucky.Opacity = 100;
                }
            }
            else if (val == 3)
            {
                mainGiven.Text = "Bulldog";
                blank2.Opacity = 0;
                free2.Opacity = 0;
                aresResets();
                buckyResets();
                bulldogResets();
                guardianResets();
                judgeResets();
                marshalResets();
                odinResets();
                operatorResets();
                phantomResets();
                spectreResets();
                stingerResets();
                vandalResets();
                if (bulldogArray.Contains("default"))
                {
                    bulldog.Opacity = 100;
                }
                else if (bulldogArray.Contains("aristocrat"))
                {
                    aristocratbulldog.Opacity = 100;
                }
                else if (bulldogArray.Contains("convex"))
                {
                    convexbulldog.Opacity = 100;
                }
                else if (bulldogArray.Contains("couture"))
                {
                    couturebulldog.Opacity = 100;
                }
                else if (bulldogArray.Contains("depths"))
                {
                    depthsbulldog.Opacity = 100;
                }
                else if (bulldogArray.Contains("genesis"))
                {
                    genesisbulldog.Opacity = 100;
                }
                else if (bulldogArray.Contains("glitchpop"))
                {
                    glitchpopbulldog.Opacity = 100;
                }
                else if (bulldogArray.Contains("horizon"))
                {
                    horizonbulldog.Opacity = 100;
                }
                else if (bulldogArray.Contains("infinity"))
                {
                    infinitybulldog.Opacity = 100;
                }
                else if (bulldogArray.Contains("ktac"))
                {
                    ktacbulldog.Opacity = 100;
                }
                else if (bulldogArray.Contains("olvidados"))
                {
                    olvidadosbulldog.Opacity = 100;
                }
                else if (bulldogArray.Contains("polyfox"))
                {
                    polyfoxbulldog.Opacity = 100;
                }
                else if (bulldogArray.Contains("protocol"))
                {
                    protocolbulldog.Opacity = 100;
                }
                else if (bulldogArray.Contains("rush"))
                {
                    rushbulldog.Opacity = 100;
                }
                else if (bulldogArray.Contains("spectrum"))
                {
                    spectrumbulldog.Opacity = 100;
                }
                else if (bulldogArray.Contains("striker"))
                {
                    strikerbulldog.Opacity = 100;
                }
                else if (bulldogArray.Contains("undercity"))
                {
                    undercitybulldog.Opacity = 100;
                }
                else if (bulldogArray.Contains("varnish"))
                {
                    varnishbulldog.Opacity = 100;
                }
                else if (bulldogArray.Contains("velocity"))
                {
                    velocitybulldog.Opacity = 100;
                }
            }
            else if (val == 4)
            {
                mainGiven.Text = "Guardian";
                blank2.Opacity = 0;
                free2.Opacity = 0;
                aresResets();
                buckyResets();
                bulldogResets();
                guardianResets();
                judgeResets();
                marshalResets();
                odinResets();
                operatorResets();
                phantomResets();
                spectreResets();
                stingerResets();
                vandalResets();
                if (guardianArray.Contains("default"))
                {
                    guardian.Opacity = 100;
                }
                else if (guardianArray.Contains("aero"))
                {
                    aeroguardian.Opacity = 100;
                }
                else if (guardianArray.Contains("ego"))
                {
                    egoguardian.Opacity = 100;
                }
                else if (guardianArray.Contains("gaias"))
                {
                    gaiasguardian.Opacity = 100;
                }
                else if (guardianArray.Contains("galleria"))
                {
                    galleriaguardian.Opacity = 100;
                }
                else if (guardianArray.Contains("hydrodip"))
                {
                    hydrodipguardian.Opacity = 100;
                }
                else if (guardianArray.Contains("infantry"))
                {
                    infantryguardian.Opacity = 100;
                }
                else if (guardianArray.Contains("infinity"))
                {
                    infinityguardian.Opacity = 100;
                }
                else if (guardianArray.Contains("jigsaw"))
                {
                    jigsawguardian.Opacity = 100;
                }
                else if (guardianArray.Contains("magepunk"))
                {
                    magepunkguardian.Opacity = 100;
                }
                else if (guardianArray.Contains("nebula"))
                {
                    nebulaguardian.Opacity = 100;
                }
                else if (guardianArray.Contains("nitro"))
                {
                    nitroguardian.Opacity = 100;
                }
                else if (guardianArray.Contains("oni"))
                {
                    oniguardian.Opacity = 100;
                }
                else if (guardianArray.Contains("polyfox"))
                {
                    polyfoxguardian.Opacity = 100;
                }
                else if (guardianArray.Contains("prime"))
                {
                    primeguardian.Opacity = 100;
                }
                else if (guardianArray.Contains("reaver"))
                {
                    reaverguardian.Opacity = 100;
                }
                else if (guardianArray.Contains("recon"))
                {
                    reconguardian.Opacity = 100;
                }
                else if (guardianArray.Contains("rgx11"))
                {
                    rgx11guardian.Opacity = 100;
                }
                else if (guardianArray.Contains("ruin"))
                {
                    ruinguardian.Opacity = 100;
                }
                else if (guardianArray.Contains("ruination"))
                {
                    ruinationguardian.Opacity = 100;
                }
                else if (guardianArray.Contains("songsteel"))
                {
                    songsteelguardian.Opacity = 100;
                }
                else if (guardianArray.Contains("sovereign"))
                {
                    sovereignguardian.Opacity = 100;
                }
                else if (guardianArray.Contains("spectrum"))
                {
                    spectrumguardian.Opacity = 100;
                }
                else if (guardianArray.Contains("tethered"))
                {
                    tetheredguardian.Opacity = 100;
                }
                else if (guardianArray.Contains("valgo"))
                {
                    valgoguardian.Opacity = 100;
                }
            }
            else if (val == 5)
            {
                mainGiven.Text = "Judge";
                blank2.Opacity = 0;
                free2.Opacity = 0;
                aresResets();
                buckyResets();
                bulldogResets();
                guardianResets();
                judgeResets();
                marshalResets();
                odinResets();
                operatorResets();
                phantomResets();
                spectreResets();
                stingerResets();
                vandalResets();
                if (judgeArray.Contains("default"))
                {
                    judge.Opacity = 100;
                }
                else if (judgeArray.Contains("celestial"))
                {
                    celestialjudge.Opacity = 100;
                }
                else if (judgeArray.Contains("convex"))
                {
                    convexjudge.Opacity = 100;
                }
                else if (judgeArray.Contains("divine"))
                {
                    divinejudge.Opacity = 100;
                }
                else if (judgeArray.Contains("dotexe"))
                {
                    dotexejudge.Opacity = 100;
                }
                else if (judgeArray.Contains("elderflame"))
                {
                    elderflamejudge.Opacity = 100;
                }
                else if (judgeArray.Contains("glitchpop"))
                {
                    glitchpopjudge.Opacity = 100;
                }
                else if (judgeArray.Contains("goldwing"))
                {
                    goldwingjudge.Opacity = 100;
                }
                else if (judgeArray.Contains("hydrodip"))
                {
                    hydrodipjudge.Opacity = 100;
                }
                else if (judgeArray.Contains("jigsaw"))
                {
                    jigsawjudge.Opacity = 100;
                }
                else if (judgeArray.Contains("luxe"))
                {
                    luxejudge.Opacity = 100;
                }
                else if (judgeArray.Contains("outpost"))
                {
                    outpostjudge.Opacity = 100;
                }
                else if (judgeArray.Contains("polyfox"))
                {
                    polyfoxjudge.Opacity = 100;
                }
                else if (judgeArray.Contains("prism"))
                {
                    prismjudge.Opacity = 100;
                }
                else if (judgeArray.Contains("rush"))
                {
                    rushjudge.Opacity = 100;
                }
                else if (judgeArray.Contains("sensation"))
                {
                    sensationjudge.Opacity = 100;
                }
                else if (judgeArray.Contains("serenity"))
                {
                    serenityjudge.Opacity = 100;
                }
                else if (judgeArray.Contains("smite"))
                {
                    smitejudge.Opacity = 100;
                }
                else if (judgeArray.Contains("snowfall"))
                {
                    snowfalljudge.Opacity = 100;
                }
                else if (judgeArray.Contains("undercity"))
                {
                    undercityjudge.Opacity = 100;
                }
                else if (judgeArray.Contains("varnish"))
                {
                    varnishjudge.Opacity = 100;
                }
            }
            else if (val == 6)
            {
                mainGiven.Text = "Marshal";
                blank2.Opacity = 0;
                free2.Opacity = 0;
                aresResets();
                buckyResets();
                bulldogResets();
                guardianResets();
                judgeResets();
                marshalResets();
                odinResets();
                operatorResets();
                phantomResets();
                spectreResets();
                stingerResets();
                vandalResets();
                if (marshalArray.Contains("default"))
                {
                    marshal.Opacity = 100;
                }
                else if (marshalArray.Contains("artisan"))
                {
                    artisanmarshal.Opacity = 100;
                }
                else if (marshalArray.Contains("avalanche"))
                {
                    avalanchemarshal.Opacity = 100;
                }
                else if (marshalArray.Contains("couture"))
                {
                    couturemarshal.Opacity = 100;
                }
                else if (marshalArray.Contains("divine"))
                {
                    divinemarshal.Opacity = 100;
                }
                else if (marshalArray.Contains("gaias"))
                {
                    gaiasmarshal.Opacity = 100;
                }
                else if (marshalArray.Contains("galleria"))
                {
                    galleriamarshal.Opacity = 100;
                }
                else if (marshalArray.Contains("magepunk"))
                {
                    magepunkmarshal.Opacity = 100;
                }
                else if (marshalArray.Contains("monarch"))
                {
                    monarchmarshal.Opacity = 100;
                }
                else if (marshalArray.Contains("polyfrog"))
                {
                    polyfrogmarshal.Opacity = 100;
                }
                else if (marshalArray.Contains("ruin"))
                {
                    ruinmarshal.Opacity = 100;
                }
                else if (marshalArray.Contains("songsteel"))
                {
                    songsteelmarshal.Opacity = 100;
                }
                else if (marshalArray.Contains("sovereign"))
                {
                    sovereignmarshal.Opacity = 100;
                }
                else if (marshalArray.Contains("wasteland"))
                {
                    wastelandmarshal.Opacity = 100;
                }
                else if (marshalArray.Contains("wunderland"))
                {
                    wunderlandmarshal.Opacity = 100;
                }
            }
            else if (val == 7)
            {
                mainGiven.Text = "Odin";
                blank2.Opacity = 0;
                free2.Opacity = 0;
                aresResets();
                buckyResets();
                bulldogResets();
                guardianResets();
                judgeResets();
                marshalResets();
                odinResets();
                operatorResets();
                phantomResets();
                spectreResets();
                stingerResets();
                vandalResets();
                if (odinArray.Contains("default"))
                {
                    odin.Opacity = 100;
                }
                else if (odinArray.Contains("aerosol"))
                {
                    aerosolodin.Opacity = 100;
                }
                else if (odinArray.Contains("blastx"))
                {
                    blastxodin.Opacity = 100;
                }
                else if (odinArray.Contains("dotexe"))
                {
                    dotexeodin.Opacity = 100;
                }
                else if (odinArray.Contains("glitchpop"))
                {
                    glitchpopodin.Opacity = 100;
                }
                else if (odinArray.Contains("lightwave"))
                {
                    lightwaveodin.Opacity = 100;
                }
                else if (odinArray.Contains("lycan"))
                {
                    lycanodin.Opacity = 100;
                }
                else if (odinArray.Contains("nitro"))
                {
                    nitroodin.Opacity = 100;
                }
                else if (odinArray.Contains("prime"))
                {
                    primeodin.Opacity = 100;
                }
                else if (odinArray.Contains("prism"))
                {
                    prismodin.Opacity = 100;
                }
                else if (odinArray.Contains("schema"))
                {
                    schemaodin.Opacity = 100;
                }
                else if (odinArray.Contains("sensation"))
                {
                    sensationodin.Opacity = 100;
                }
                else if (odinArray.Contains("smite"))
                {
                    smiteodin.Opacity = 100;
                }
            }
            else if (val == 8)
            {
                mainGiven.Text = "Operator";
                blank2.Opacity = 0;
                free2.Opacity = 0;
                aresResets();
                buckyResets();
                bulldogResets();
                guardianResets();
                judgeResets();
                marshalResets();
                odinResets();
                operatorResets();
                phantomResets();
                spectreResets();
                stingerResets();
                vandalResets();
                if (operatorArray.Contains("default"))
                {
                    bigBoom.Opacity = 100;
                }
                else if (operatorArray.Contains("aerosol"))
                {
                    aerosolbigBoom.Opacity = 100;
                }
                else if (operatorArray.Contains("cavalier"))
                {
                    cavalierbigBoom.Opacity = 100;
                }
                else if (operatorArray.Contains("convex"))
                {
                    convexbigBoom.Opacity = 100;
                }
                else if (operatorArray.Contains("elderflame"))
                {
                    elderflamebigBoom.Opacity = 100;
                }
                else if (operatorArray.Contains("forsaken"))
                {
                    forsakenbigBoom.Opacity = 100;
                }
                else if (operatorArray.Contains("genesis"))
                {
                    genesisbigBoom.Opacity = 100;
                }
                else if (operatorArray.Contains("glitchpop"))
                {
                    glitchpopbigBoom.Opacity = 100;
                }
                else if (operatorArray.Contains("neuroblaster"))
                {
                    neuroblasterbigBoom.Opacity = 100;
                }
                else if (operatorArray.Contains("infantry"))
                {
                    infantrybigBoom.Opacity = 100;
                }
                else if (operatorArray.Contains("ion"))
                {
                    ionbigBoom.Opacity = 100;
                }
                else if (operatorArray.Contains("ktac"))
                {
                    ktacbigBoom.Opacity = 100;
                }
                else if (operatorArray.Contains("luxe"))
                {
                    luxebigBoom.Opacity = 100;
                }
                else if (operatorArray.Contains("magepunk"))
                {
                    magepunkbigBoom.Opacity = 100;
                }
                else if (operatorArray.Contains("minima"))
                {
                    minimabigBoom.Opacity = 100;
                }
                else if (operatorArray.Contains("nitro"))
                {
                    nitrobigBoom.Opacity = 100;
                }
                else if (operatorArray.Contains("origin"))
                {
                    originbigBoom.Opacity = 100;
                }
                else if (operatorArray.Contains("prism"))
                {
                    prismbigBoom.Opacity = 100;
                }
                else if (operatorArray.Contains("reaver"))
                {
                    reaverbigBoom.Opacity = 100;
                }
                else if (operatorArray.Contains("redalert"))
                {
                    redalertbigBoom.Opacity = 100;
                }
                else if (operatorArray.Contains("sentinels"))
                {
                    sentinelsbigBoom.Opacity = 100;
                }
                else if (operatorArray.Contains("silvanus"))
                {
                    silcanusbigBoom.Opacity = 100;
                }
                else if (operatorArray.Contains("spline"))
                {
                    splinebigBoom.Opacity = 100;
                }
                else if (operatorArray.Contains("striker"))
                {
                    strikerbigBoom.Opacity = 100;
                }
                else if (operatorArray.Contains("tethered"))
                {
                    tetheredbigBoom.Opacity = 100;
                }
                else if (operatorArray.Contains("tigris"))
                {
                    tigrisbigBoom.Opacity = 100;
                }
                else if (operatorArray.Contains("valgo"))
                {
                    valgobigBoom.Opacity = 100;
                }
            }
            else if (val == 9)
            {
                mainGiven.Text = "Phantom";
                blank2.Opacity = 0;
                free2.Opacity = 0;
                aresResets();
                buckyResets();
                bulldogResets();
                guardianResets();
                judgeResets();
                marshalResets();
                odinResets();
                operatorResets();
                phantomResets();
                spectreResets();
                stingerResets();
                vandalResets();
                if (phantomArray.Contains("default"))
                {
                    phantom.Opacity = 100;
                }
                else if (phantomArray.Contains("aero"))
                {
                    aerophantom.Opacity = 100;
                }
                else if (phantomArray.Contains("artisan"))
                {
                    artisanphantom.Opacity = 100;
                }
                else if (phantomArray.Contains("avalanche"))
                {
                    avalanchephantom.Opacity = 100;
                }
                else if (phantomArray.Contains("blastx"))
                {
                    blastxphantom.Opacity = 100;
                }
                else if (phantomArray.Contains("celestial"))
                {
                    celestialphantom.Opacity = 100;
                }
                else if (phantomArray.Contains("galleria"))
                {
                    galleriaphantom.Opacity = 100;
                }
                else if (phantomArray.Contains("glitchpop"))
                {
                    glitchpopphantom.Opacity = 100;
                }
                else if (phantomArray.Contains("infinity"))
                {
                    infinityphantom.Opacity = 100;
                }
                else if (phantomArray.Contains("ion"))
                {
                    ionphantom.Opacity = 100;
                }
                else if (phantomArray.Contains("kingdom"))
                {
                    kingdomphantom.Opacity = 100;
                }
                else if (phantomArray.Contains("lightwave"))
                {
                    lightwavephantom.Opacity = 100;
                }
                else if (phantomArray.Contains("minima"))
                {
                    minimaphantom.Opacity = 100;
                }
                else if (phantomArray.Contains("nebula"))
                {
                    nebulaphantom.Opacity = 100;
                }
                else if (phantomArray.Contains("oni"))
                {
                    oniphantom.Opacity = 100;
                }
                else if (phantomArray.Contains("prime"))
                {
                    primephantom.Opacity = 100;
                }
                else if (phantomArray.Contains("prism"))
                {
                    prismphantom.Opacity = 100;
                }
                else if (phantomArray.Contains("protocol"))
                {
                    protocolphantom.Opacity = 100;
                }
                else if (phantomArray.Contains("crisis"))
                {
                    crisisphantom.Opacity = 100;
                }
                else if (phantomArray.Contains("recon"))
                {
                    reconphantom.Opacity = 100;
                }
                else if (phantomArray.Contains("ruination"))
                {
                    ruinationphantom.Opacity = 100;
                }
                else if (phantomArray.Contains("rush"))
                {
                    rushphantom.Opacity = 100;
                }
                else if (phantomArray.Contains("serenity"))
                {
                    serenityphantom.Opacity = 100;
                }
                else if (phantomArray.Contains("silvanus"))
                {
                    silvanusphantom.Opacity = 100;
                }
                else if (phantomArray.Contains("singularity"))
                {
                    singularityphantom.Opacity = 100;
                }
                else if (phantomArray.Contains("smite"))
                {
                    smitephantom.Opacity = 100;
                }
                else if (phantomArray.Contains("snowfall"))
                {
                    snowfallphantom.Opacity = 100;
                }
                else if (phantomArray.Contains("spectrum"))
                {
                    spectrumphantom.Opacity = 100;
                }
                else if (phantomArray.Contains("spline"))
                {
                    splinephantom.Opacity = 100;
                }
                else if (phantomArray.Contains("tigris"))
                {
                    tigrisphantom.Opacity = 100;
                }
                else if (phantomArray.Contains("undercity"))
                {
                    undercityphantom.Opacity = 100;
                }
                else if (phantomArray.Contains("valgo"))
                {
                    valgophantom.Opacity = 100;
                }
                else if (phantomArray.Contains("velocity"))
                {
                    velocityphantom.Opacity = 100;
                }
                else if (phantomArray.Contains("wunderland"))
                {
                    wunderlandphantom.Opacity = 100;
                }
            }
            else if (val == 10)
            {
                mainGiven.Text = "Spectre";
                blank2.Opacity = 0;
                free2.Opacity = 0;
                aresResets();
                buckyResets();
                bulldogResets();
                guardianResets();
                judgeResets();
                marshalResets();
                odinResets();
                operatorResets();
                phantomResets();
                spectreResets();
                stingerResets();
                vandalResets();
                if (spectreArray.Contains("default"))
                {
                    spectre.Opacity = 100;
                }
                else if (spectreArray.Contains("aero"))
                {
                    aerospectre.Opacity = 100;
                }
                else if (spectreArray.Contains("avalanche"))
                {
                    avalanchespectre.Opacity = 100;
                }
                else if (spectreArray.Contains("blastx"))
                {
                    blastxspectre.Opacity = 100;
                }
                else if (spectreArray.Contains("convex"))
                {
                    convexspectre.Opacity = 100;
                }
                else if (spectreArray.Contains("forsaken"))
                {
                    forsakenspectre.Opacity = 100;
                }
                else if (spectreArray.Contains("neuroblaster"))
                {
                    neuroblasterspectre.Opacity = 100;
                }
                else if (spectreArray.Contains("hivemind"))
                {
                    hivemindspectre.Opacity = 100;
                }
                else if (spectreArray.Contains("horizon"))
                {
                    horizonspectre.Opacity = 100;
                }
                else if (spectreArray.Contains("infantry"))
                {
                    infantryspectre.Opacity = 100;
                }
                else if (spectreArray.Contains("infinity"))
                {
                    infinityspectre.Opacity = 100;
                }
                else if (spectreArray.Contains("kingdom"))
                {
                    kingdomspectre.Opacity = 100;
                }
                else if (spectreArray.Contains("luxe"))
                {
                    luxespectre.Opacity = 100;
                }
                else if (spectreArray.Contains("magepunk"))
                {
                    magepunkspectre.Opacity = 100;
                }
                else if (spectreArray.Contains("minima"))
                {
                    minimaspectre.Opacity = 100;
                }
                else if (spectreArray.Contains("polyfrog"))
                {
                    polyfrogspectre.Opacity = 100;
                }
                else if (spectreArray.Contains("prime"))
                {
                    primespectre.Opacity = 100;
                }
                else if (spectreArray.Contains("prism"))
                {
                    prismspectre.Opacity = 100;
                }
                else if (spectreArray.Contains("protocol"))
                {
                    protocolspectre.Opacity = 100;
                }
                else if (spectreArray.Contains("crisis"))
                {
                    crisisspectre.Opacity = 100;
                }
                else if (spectreArray.Contains("recon"))
                {
                    reconspectre.Opacity = 100;
                }
                else if (spectreArray.Contains("ruination"))
                {
                    ruinationspectre.Opacity = 100;
                }
                else if (spectreArray.Contains("serenity"))
                {
                    serenityspectre.Opacity = 100;
                }
                else if (spectreArray.Contains("singularity"))
                {
                    singularityspectre.Opacity = 100;
                }
                else if (spectreArray.Contains("spline"))
                {
                    splinespectre.Opacity = 100;
                }
                else if (spectreArray.Contains("striker"))
                {
                    strikerspectre.Opacity = 100;
                }
                else if (spectreArray.Contains("tigris"))
                {
                    tigrisspectre.Opacity = 100;
                }
                else if (spectreArray.Contains("valgo"))
                {
                    valgospectre.Opacity = 100;
                }
                else if (spectreArray.Contains("velocity"))
                {
                    velocityspectre.Opacity = 100;
                }
                else if (spectreArray.Contains("wasteland"))
                {
                    wastelandspectre.Opacity = 100;
                }
            }
            else if (val == 11)
            {
                mainGiven.Text = "Stinger";
                blank2.Opacity = 0;
                free2.Opacity = 0;
                aresResets();
                buckyResets();
                bulldogResets();
                guardianResets();
                judgeResets();
                marshalResets();
                odinResets();
                operatorResets();
                phantomResets();
                spectreResets();
                stingerResets();
                vandalResets();
                if (stingerArray.Contains("default"))
                {
                    stinger.Opacity = 100;
                }
                else if (stingerArray.Contains("aristocrat"))
                {
                    aristocratstinger.Opacity = 100;
                }
                else if (stingerArray.Contains("cavalier"))
                {
                    cavalierstinger.Opacity = 100;
                }
                else if (stingerArray.Contains("couture"))
                {
                    couturestinger.Opacity = 100;
                }
                else if (stingerArray.Contains("depths"))
                {
                    depthsstinger.Opacity = 100;
                }
                else if (stingerArray.Contains("ego"))
                {
                    egostinger.Opacity = 100;
                }
                else if (stingerArray.Contains("lycan"))
                {
                    lycanstinger.Opacity = 100;
                }
                else if (stingerArray.Contains("prism"))
                {
                    prismstinger.Opacity = 100;
                }
                else if (stingerArray.Contains("redalert"))
                {
                    redalertstinger.Opacity = 100;
                }
                else if (stingerArray.Contains("rgx11"))
                {
                    rgx11stinger.Opacity = 100;
                }
                else if (stingerArray.Contains("sakura"))
                {
                    sakurastinger.Opacity = 100;
                }
                else if (stingerArray.Contains("schema"))
                {
                    schemastinger.Opacity = 100;
                }
                else if (stingerArray.Contains("sensation"))
                {
                    sensationstinger.Opacity = 100;
                }
                else if (stingerArray.Contains("silvanus"))
                {
                    silvanusstinger.Opacity = 100;
                }
                else if (stingerArray.Contains("sovereign"))
                {
                    sovereignstinger.Opacity = 100;
                }
                else if (stingerArray.Contains("surge"))
                {
                    surgestinger.Opacity = 100;
                }
                else if (stingerArray.Contains("varnish"))
                {
                    varnishstinger.Opacity = 100;
                }
            }
            else if (val == 12)
            {
                mainGiven.Text = "vAndal";
                blank2.Opacity = 0;
                free2.Opacity = 0;
                aresResets();
                buckyResets();
                bulldogResets();
                guardianResets();
                judgeResets();
                marshalResets();
                odinResets();
                operatorResets();
                phantomResets();
                spectreResets();
                stingerResets();
                vandalResets();
                if (vandalArray.Contains("default"))
                {
                    vandal.Opacity = 100;
                }
                else if (vandalArray.Contains("aristocrat"))
                {
                    aristocratvandal.Opacity = 100;
                }
                else if (vandalArray.Contains("avalanche"))
                {
                    avalanchevandal.Opacity = 100;
                }
                else if (vandalArray.Contains("cavalier"))
                {
                    cavaliervandal.Opacity = 100;
                }
                else if (vandalArray.Contains("champions"))
                {
                    championsvandal.Opacity = 100;
                }
                else if (vandalArray.Contains("depths"))
                {
                    depthsvandal.Opacity = 100;
                }
                else if (vandalArray.Contains("dotexe"))
                {
                    dotexevandal.Opacity = 100;
                }
                else if (vandalArray.Contains("ego"))
                {
                    egovandal.Opacity = 100;
                }
                else if (vandalArray.Contains("elderflame"))
                {
                    elderflamevandal.Opacity = 100;
                }
                else if (vandalArray.Contains("forsaken"))
                {
                    forsakenvandal.Opacity = 100;
                }
                else if (vandalArray.Contains("gaias"))
                {
                    gaiasvandal.Opacity = 100;
                }
                else if (vandalArray.Contains("glitchpop"))
                {
                    glitchpopvandal.Opacity = 100;
                }
                else if (vandalArray.Contains("hivemind"))
                {
                    hivemindvandal.Opacity = 100;
                }
                else if (vandalArray.Contains("horizon"))
                {
                    horizonvandal.Opacity = 100;
                }
                else if (vandalArray.Contains("ktac"))
                {
                    ktacvandal.Opacity = 100;
                }
                else if (vandalArray.Contains("luxe"))
                {
                    luxevandal.Opacity = 100;
                }
                else if (vandalArray.Contains("lycan"))
                {
                    lycanvandal.Opacity = 100;
                }
                else if (vandalArray.Contains("nitro"))
                {
                    nitrovandal.Opacity = 100;
                }
                else if (vandalArray.Contains("olvidados"))
                {
                    olvidadosvandal.Opacity = 100;
                }
                else if (vandalArray.Contains("origin"))
                {
                    originvandal.Opacity = 100;
                }
                else if (vandalArray.Contains("prime"))
                {
                    primevandal.Opacity = 100;
                }
                else if (vandalArray.Contains("prism"))
                {
                    prismvandal.Opacity = 100;
                }
                else if (vandalArray.Contains("reaver"))
                {
                    reavervandal.Opacity = 100;
                }
                else if (vandalArray.Contains("rgx11"))
                {
                    rgx11vandal.Opacity = 100;
                }
                else if (vandalArray.Contains("ruin"))
                {
                    ruinvandal.Opacity = 100;
                }
                else if (vandalArray.Contains("sakura"))
                {
                    sakuravandal.Opacity = 100;
                }
                else if (vandalArray.Contains("schema"))
                {
                    schemavandal.Opacity = 100;
                }
                else if (vandalArray.Contains("sensation"))
                {
                    sensationvandal.Opacity = 100;
                }
                else if (vandalArray.Contains("sentinels"))
                {
                    sentinelsvandal.Opacity = 100;
                }
                else if (vandalArray.Contains("silvanus"))
                {
                    silvanusvandal.Opacity = 100;
                }
                else if (vandalArray.Contains("tethered"))
                {
                    tetheredvandal.Opacity = 100;
                }
                else if (vandalArray.Contains("valgo"))
                {
                    valgovandal.Opacity = 100;
                }
                else if (vandalArray.Contains("wasteland"))
                {
                    wastelandvandal.Opacity = 100;
                }
                else if (vandalArray.Contains("wunderland"))
                {
                    wunderlandvandal.Opacity = 100;
                }
            }
            else if (val == 13)
            {
                mainGiven.Text = "Your Pick";
                free2.Opacity = 100;
                blank2.Opacity = 0;
                aresResets();
                buckyResets();
                bulldogResets();
                guardianResets();
                judgeResets();
                marshalResets();
                odinResets();
                operatorResets();
                phantomResets();
                spectreResets();
                stingerResets();
                vandalResets();

            }
            else if (val == 14)
            {
                mainGiven.Text = "No Primary";
                blank2.Opacity = 100;
                free2.Opacity = 00;
                aresResets();
                buckyResets();
                bulldogResets();
                guardianResets();
                judgeResets();
                marshalResets();
                odinResets();
                operatorResets();
                phantomResets();
                spectreResets();
                stingerResets();
                vandalResets();

            }
        }
        public void shield()
        {
            string[] shield = new string[4] { "Light", "Heavy", "Free", "Blank" };
            Random randShield = new Random();
            int val = randShield.Next(0, shield.Length + 1);

            if (val == 1)
            {
                light.Opacity = 100;
                heavy.Opacity = 0;
                free3.Opacity = 0;
                blank3.Opacity = 0;
                shieldGiven.Text = "Light Shields";
            }
            else if (val == 2)
            {
                light.Opacity = 0;
                heavy.Opacity = 100;
                free3.Opacity = 0;
                blank3.Opacity = 0;
                shieldGiven.Text = "Heavy Shields";
            }
            else if (val == 3)
            {
                light.Opacity = 0;
                heavy.Opacity = 0;
                free3.Opacity = 100;
                blank3.Opacity = 0;
                shieldGiven.Text = "Your Pick";
            }
            else if (val == 4)
            {
                light.Opacity = 0;
                heavy.Opacity = 0;
                free3.Opacity = 0;
                blank3.Opacity = 100;
                shieldGiven.Text = "No Shields";
            }
        }

        //pistol resets
        public void classicResets()
        {
            classic.Opacity = 0;
            avalancheclassic.Opacity = 0;
            finalclassic.Opacity = 0;
            finesseclassic.Opacity = 0;
            firearmclassic.Opacity = 0;
            forsakenclassic.Opacity = 0;
            galleriaclassic.Opacity = 0;
            glitchpopclassic.Opacity = 0;
            goldwingclassic.Opacity = 0;
            neuroblasterclassic.Opacity = 0;
            infinityclassic.Opacity = 0;
            kingdomclassic.Opacity = 0;
            pistolinhaclassic.Opacity = 0;
            primeclassic.Opacity = 0;
            prismclassic.Opacity = 0;
            crisisclassic.Opacity = 0;
            redalertclassic.Opacity = 0;
            sakuraclassic.Opacity = 0;
            smiteclassic.Opacity = 0;
            snowfallclassic.Opacity = 0;
            songsteelclassic.Opacity = 0;
            specrtumclassic.Opacity = 0;
            splineclassic.Opacity = 0;
            strikerclassic.Opacity = 0;
            surgeclassic.Opacity = 0;
            undercityclassic.Opacity = 0;
            valgoclassic.Opacity = 0;

        }
        public void frenzyResets()
        {
            frenzy.Opacity = 0;
            aerofrenzy.Opacity = 0;
            blastxfrenzy.Opacity = 0;
            celestialfrenzy.Opacity = 0;
            couturefrenzy.Opacity = 0;
            divinefrenzy.Opacity = 0;
            elderflamefrenzy.Opacity = 0;
            glitchpopfrenzy.Opacity = 0;
            horizonfrenzy.Opacity = 0;
            hydrodipfrenzy.Opacity = 0;
            lightwavefrenzy.Opacity = 0;
            livewirefrenzy.Opacity = 0;
            monarchfrenzy.Opacity = 0;
            olvidadosfrenzy.Opacity = 0;
            originfrenzy.Opacity = 0;
            primefrenzy.Opacity = 0;
            ragnarockerfrenzy.Opacity = 0;
            rgx11frenzy.Opacity = 0;
            rushfrenzy.Opacity = 0;
            sensationfrenzy.Opacity = 0;
            spitfirefrenzy.Opacity = 0;
            swoopingfrenzy.Opacity = 0;
        }
        public void ghostResets()
        {
            ghost.Opacity = 0;
            artisanghost.Opacity = 0;
            cavalierghost.Opacity = 0;
            depthsghost.Opacity = 0;
            dotexeghost.Opacity = 0;
            eclipseghost.Opacity = 0;
            egoghost.Opacity = 0;
            gaiasghost.Opacity = 0;
            goldwingghost.Opacity = 0;
            hushghost.Opacity = 0;
            infantryghost.Opacity = 0;
            jigsawghost.Opacity = 0;
            luxeghost.Opacity = 0;
            lycanghost.Opacity = 0;
            magepunkghost.Opacity = 0;
            outpostghost.Opacity = 0;
            prismghost.Opacity = 0;
            reconghost.Opacity = 0;
            ruinationghost.Opacity = 0;
            serenityghost.Opacity = 0;
            soulsilencerghost.Opacity = 0;
            sovereignghost.Opacity = 0;
            tetheredghost.Opacity = 0;
            valgoghost.Opacity = 0;
            vendettaghost.Opacity = 0;
            winterwunderlandghost.Opacity = 0;

        }
        public void sheriffResets()
        {
            sheriff.Opacity = 0;
            arcanesheriff.Opacity = 0;
            aristocratsheriff.Opacity = 0;
            convexsheriff.Opacity = 0;
            deathwishsheriff.Opacity = 0;
            gameoversheriff.Opacity = 0;
            ionsheriff.Opacity = 0;
            ktacsheriff.Opacity = 0;
            lightwavesheriff.Opacity = 0;
            magepunksheriff.Opacity = 0;
            minimasheriff.Opacity = 0;
            nebulasheriff.Opacity = 0;
            peacekeepersheriff.Opacity = 0;
            polyfoxsheriff.Opacity = 0;
            polyfrogsheriff.Opacity = 0;
            prismsheriff.Opacity = 0;
            protektorsheriff.Opacity = 0;
            protocolsheriff.Opacity = 0;
            reaversheriff.Opacity = 0;
            sakurasheriff.Opacity = 0;
            schemasheriff.Opacity = 0;
            sentinelssheriff.Opacity = 0;
            silvanussheriff.Opacity = 0;
            singularitysheriff.Opacity = 0;
            surgesheriff.Opacity = 0;
            varnishsheriff.Opacity = 0;
            wastelandsheriff.Opacity = 0;

        }
        public void shortyResets()
        {
            shorty.Opacity = 0;
            aerosolshorty.Opacity = 0;
            genesisshorty.Opacity = 0;
            hivemindshorty.Opacity = 0;
            monarchshorty.Opacity = 0;
            onishorty.Opacity = 0;
            prismshorty.Opacity = 0;
            ruinshorty.Opacity = 0;
            snakebiteshorty.Opacity = 0;
            tigrisshorty.Opacity = 0;
            velocityshorty.Opacity = 0;
            wastelandshorty.Opacity = 0;
            wayfindershorty.Opacity = 0;
            wunderkindshorty.Opacity = 0;
        }

        //primary resets
        public void aresResets()
        {
            ares.Opacity = 0;
            aristocratares.Opacity = 0;
            celestialares.Opacity = 0;
            divinares.Opacity = 0;
            goldwingares.Opacity = 0;
            hivemindares.Opacity = 0;
            infantryares.Opacity = 0;
            jigsawares.Opacity = 0;
            magepunkares.Opacity = 0;
            minimaares.Opacity = 0;
            nebulaares.Opacity = 0;
            olvidadosares.Opacity = 0;
            outpostares.Opacity = 0;
            polyfrogares.Opacity = 0;
            prismares.Opacity = 0;
            rushares.Opacity = 0;
            sakuraares.Opacity = 0;
            sentinelsares.Opacity = 0;
            singularityares.Opacity = 0;
            snowfallares.Opacity = 0;
            valgoares.Opacity = 0;

        }
        public void buckyResets()
        {
            bucky.Opacity = 0;
            aerosolbucky.Opacity = 0;
            artisanbucky.Opacity = 0;
            cavalierbucky.Opacity = 0;
            galleriabucky.Opacity = 0;
            genesisbucky.Opacity = 0;
            neuroblasterbucky.Opacity = 0;
            horizonbucky.Opacity = 0;
            hydrodipbucky.Opacity = 0;
            ionbucky.Opacity = 0;
            kingdombucky.Opacity = 0;
            lightwavebucky.Opacity = 0;
            magepunkbucky.Opacity = 0;
            monarchbucky.Opacity = 0;
            onibucky.Opacity = 0;
            originbucky.Opacity = 0;
            primebucky.Opacity = 0;
            prismbucky.Opacity = 0;
            crisisbucky.Opacity = 0;
            redalertbucky.Opacity = 0;
            surgebucky.Opacity = 0;
        }
        public void bulldogResets()
        {
            bulldog.Opacity = 0;
            aristocratbulldog.Opacity = 0;
            convexbulldog.Opacity = 0;
            couturebulldog.Opacity = 0;
            depthsbulldog.Opacity = 0;
            genesisbulldog.Opacity = 0;
            glitchpopbulldog.Opacity = 0;
            horizonbulldog.Opacity = 0;
            infinitybulldog.Opacity = 0;
            ktacbulldog.Opacity = 0;
            olvidadosbulldog.Opacity = 0;
            polyfoxbulldog.Opacity = 0;
            protocolbulldog.Opacity = 0;
            rushbulldog.Opacity = 0;
            spectrumbulldog.Opacity = 0;
            strikerbulldog.Opacity = 0;
            undercitybulldog.Opacity = 0;
            varnishbulldog.Opacity = 0;
            velocitybulldog.Opacity = 0;

        }
        public void guardianResets()
        {
            guardian.Opacity = 0;
            aeroguardian.Opacity = 0;
            egoguardian.Opacity = 0;
            gaiasguardian.Opacity = 0;
            galleriaguardian.Opacity = 0;
            hydrodipguardian.Opacity = 0;
            infantryguardian.Opacity = 0;
            infinityguardian.Opacity = 0;
            jigsawguardian.Opacity = 0;
            magepunkguardian.Opacity = 0;
            nebulaguardian.Opacity = 0;
            nitroguardian.Opacity = 0;
            oniguardian.Opacity = 0;
            polyfoxguardian.Opacity = 0;
            primeguardian.Opacity = 0;
            reaverguardian.Opacity = 0;
            reconguardian.Opacity = 0;
            rgx11guardian.Opacity = 0;
            ruinguardian.Opacity = 0;
            ruinationguardian.Opacity = 0;
            songsteelguardian.Opacity = 0;
            sovereignguardian.Opacity = 0;
            spectrumguardian.Opacity = 0;
            tetheredguardian.Opacity = 0;
            valgoguardian.Opacity = 0;

        }
        public void judgeResets()
        {
            judge.Opacity = 0;
            celestialjudge.Opacity = 0;
            convexjudge.Opacity = 0;
            divinejudge.Opacity = 0;
            dotexejudge.Opacity = 0;
            elderflamejudge.Opacity = 0;
            glitchpopjudge.Opacity = 0;
            goldwingjudge.Opacity = 0;
            hydrodipjudge.Opacity = 0;
            jigsawjudge.Opacity = 0;
            luxejudge.Opacity = 0;
            outpostjudge.Opacity = 0;
            polyfoxjudge.Opacity = 0;
            prismjudge.Opacity = 0;
            rushjudge.Opacity = 0;
            sensationjudge.Opacity = 0;
            serenityjudge.Opacity = 0;
            smitejudge.Opacity = 0;
            snowfalljudge.Opacity = 0;
            undercityjudge.Opacity = 0;
            varnishjudge.Opacity = 0;

        }
        public void marshalResets()
        {
            marshal.Opacity = 0;
            artisanmarshal.Opacity = 0;
            avalanchemarshal.Opacity = 0;
            couturemarshal.Opacity = 0;
            divinemarshal.Opacity = 0;
            gaiasmarshal.Opacity = 0;
            galleriamarshal.Opacity = 0;
            magepunkmarshal.Opacity = 0;
            monarchmarshal.Opacity = 0;
            polyfrogmarshal.Opacity = 0;
            ruinmarshal.Opacity = 0;
            songsteelmarshal.Opacity = 0;
            sovereignmarshal.Opacity = 0;
            wastelandmarshal.Opacity = 0;
            wunderlandmarshal.Opacity = 0;

        }
        public void odinResets()
        {
            odin.Opacity = 0;
            aerosolodin.Opacity = 0;
            blastxodin.Opacity = 0;
            dotexeodin.Opacity = 0;
            glitchpopodin.Opacity = 0;
            lightwaveodin.Opacity = 0;
            lycanodin.Opacity = 0;
            nitroodin.Opacity = 0;
            primeodin.Opacity = 0;
            prismodin.Opacity = 0;
            schemaodin.Opacity = 0;
            sensationodin.Opacity = 0;
            smiteodin.Opacity = 0;

        }
        public void operatorResets()
        {
            bigBoom.Opacity = 0;
            aerosolbigBoom.Opacity = 0;
            cavalierbigBoom.Opacity = 0;
            convexbigBoom.Opacity = 0;
            elderflamebigBoom.Opacity = 0;
            forsakenbigBoom.Opacity = 0;
            genesisbigBoom.Opacity = 0;
            glitchpopbigBoom.Opacity = 0;
            neuroblasterbigBoom.Opacity = 0;
            infantrybigBoom.Opacity = 0;
            ionbigBoom.Opacity = 0;
            ktacbigBoom.Opacity = 0;
            luxebigBoom.Opacity = 0;
            magepunkbigBoom.Opacity = 0;
            minimabigBoom.Opacity = 0;
            nitrobigBoom.Opacity = 0;
            originbigBoom.Opacity = 0;
            prismbigBoom.Opacity = 0;
            reaverbigBoom.Opacity = 0;
            redalertbigBoom.Opacity = 0;
            sentinelsbigBoom.Opacity = 0;
            silcanusbigBoom.Opacity = 0;
            splinebigBoom.Opacity = 0;
            strikerbigBoom.Opacity = 0;
            tetheredbigBoom.Opacity = 0;
            tigrisbigBoom.Opacity = 0;
            valgobigBoom.Opacity = 0;

        }
        public void phantomResets()
        {
            phantom.Opacity = 0;
            aerophantom.Opacity = 0;
            artisanphantom.Opacity = 0;
            avalanchephantom.Opacity = 0;
            blastxphantom.Opacity = 0;
            celestialphantom.Opacity = 0;
            galleriaphantom.Opacity = 0;
            glitchpopphantom.Opacity = 0;
            infinityphantom.Opacity = 0;
            ionphantom.Opacity = 0;
            kingdomphantom.Opacity = 0;
            lightwavephantom.Opacity = 0;
            minimaphantom.Opacity = 0;
            nebulaphantom.Opacity = 0;
            oniphantom.Opacity = 0;
            primephantom.Opacity = 0;
            prismphantom.Opacity = 0;
            protocolphantom.Opacity = 0;
            crisisphantom.Opacity = 0;
            reconphantom.Opacity = 0;
            ruinationphantom.Opacity = 0;
            rushphantom.Opacity = 0;
            serenityphantom.Opacity = 0;
            silvanusphantom.Opacity = 0;
            singularityphantom.Opacity = 0;
            smitephantom.Opacity = 0;
            snowfallphantom.Opacity = 0;
            spectrumphantom.Opacity = 0;
            splinephantom.Opacity = 0;
            tigrisphantom.Opacity = 0;
            undercityphantom.Opacity = 0;
            valgophantom.Opacity = 0;
            velocityphantom.Opacity = 0;
            wunderlandphantom.Opacity = 0;

        }
        public void spectreResets()
        {
            spectre.Opacity = 0;
            aerospectre.Opacity = 0;
            avalanchespectre.Opacity = 0;
            blastxspectre.Opacity = 0;
            convexspectre.Opacity = 0;
            forsakenspectre.Opacity = 0;
            neuroblasterspectre.Opacity = 0;
            hivemindspectre.Opacity = 0;
            horizonspectre.Opacity = 0;
            infantryspectre.Opacity = 0;
            infinityspectre.Opacity = 0;
            kingdomspectre.Opacity = 0;
            luxespectre.Opacity = 0;
            magepunkspectre.Opacity = 0;
            minimaspectre.Opacity = 0;
            polyfrogspectre.Opacity = 0;
            primespectre.Opacity = 0;
            prismspectre.Opacity = 0;
            protocolspectre.Opacity = 0;
            crisisspectre.Opacity = 0;
            reconspectre.Opacity = 0;
            ruinationspectre.Opacity = 0;
            serenityspectre.Opacity = 0;
            singularityspectre.Opacity = 0;
            splinespectre.Opacity = 0;
            strikerspectre.Opacity = 0;
            tigrisspectre.Opacity = 0;
            valgospectre.Opacity = 0;
            velocityspectre.Opacity = 0;
            wastelandspectre.Opacity = 0;

        }
        public void stingerResets()
        {
            stinger.Opacity = 0;
            aristocratstinger.Opacity = 0;
            cavalierstinger.Opacity = 0;
            couturestinger.Opacity = 0;
            depthsstinger.Opacity = 0;
            egostinger.Opacity = 0;
            lycanstinger.Opacity = 0;
            prismstinger.Opacity = 0;
            redalertstinger.Opacity = 0;
            rgx11stinger.Opacity = 0;
            sakurastinger.Opacity = 0;
            schemastinger.Opacity = 0;
            sensationstinger.Opacity = 0;
            silvanusstinger.Opacity = 0;
            sovereignstinger.Opacity = 0;
            surgestinger.Opacity = 0;
            varnishstinger.Opacity = 0;

        }
        public void vandalResets()
        {
            vandal.Opacity = 0;
            aristocratvandal.Opacity = 0;
            avalanchevandal.Opacity = 0;
            cavaliervandal.Opacity = 0;
            championsvandal.Opacity = 0;
            depthsvandal.Opacity = 0;
            dotexevandal.Opacity = 0;
            egovandal.Opacity = 0;
            elderflamevandal.Opacity = 0;
            forsakenvandal.Opacity = 0;
            gaiasvandal.Opacity = 0;
            glitchpopvandal.Opacity = 0;
            hivemindvandal.Opacity = 0;
            horizonvandal.Opacity = 0;
            ktacvandal.Opacity = 0;
            luxevandal.Opacity = 0;
            lycanvandal.Opacity = 0;
            nitrovandal.Opacity = 0;
            olvidadosvandal.Opacity = 0;
            originvandal.Opacity = 0;
            primevandal.Opacity = 0;
            prismvandal.Opacity = 0;
            reavervandal.Opacity = 0;
            rgx11vandal.Opacity = 0;
            ruinvandal.Opacity = 0;
            sakuravandal.Opacity = 0;
            schemavandal.Opacity = 0;
            sensationvandal.Opacity = 0;
            sentinelsvandal.Opacity = 0;
            silvanusvandal.Opacity = 0;
            tetheredvandal.Opacity = 0;
            valgovandal.Opacity = 0;
            wastelandvandal.Opacity = 0;
            wunderlandvandal.Opacity = 0;

        }
    }
}
