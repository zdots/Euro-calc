using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EuroCalculator
{
    
    //class CWorks
    //{
    //    public static Country Aus = new Country { };
    //    public static Country Bel = new Country { };
    //    public static Country Bul = new Country { };
    //    public static Country Cro = new Country { };
    //    public static Country Cyp = new Country { };
    //    public static Country Cze = new Country { };
    //    public static Country Den = new Country { };
    //    public static Country Est = new Country { };
    //    public static Country Fin = new Country { };
    //    public static Country Fra = new Country { };
    //    public static Country Ger = new Country { };
    //    public static Country Gre = new Country { };
    //    public static Country Hun = new Country { };
    //    public static Country Ire = new Country { };
    //    public static Country Ita = new Country { };
    //    public static Country Lat = new Country { };
    //    public static Country Lit = new Country { };
    //    public static Country Lux = new Country { };
    //    public static Country Mal = new Country { };
    //    public static Country Net = new Country { };
    //    public static Country Pol = new Country { };
    //    public static Country Por = new Country { };
    //    public static Country Rom = new Country { };
    //    public static Country Slk = new Country { };
    //    public static Country Sln = new Country { };
    //    public static Country Spa = new Country { };
    //    public static Country Swe = new Country { };

    //    public static Country[] Countries = { Aus, Bel, Bul, Cro, Cyp, Cze, Den, Est, Fin, Fra, Ger, Gre, Hun, Ire, Ita, Lat, Lit, Lux, Mal, Net, Pol, Por, Rom, Slk, Sln, Spa, Swe };

    //    public static void DisplayCountries()
    //    {
    //        int i = 0;
    //        while (i != 27)
    //        {
    //            if (i != 0)
    //                Console.WriteLine($"Country: Name-{Countries[i].CName}; Pop-{Countries[i].CPop}; EUZone-{Countries[i].eurozonemember}");
    //            i++;
    //        }
    //        Console.WriteLine();
    //    }

    //    public static void Initializer()
    //    {
    //        int i = 0;
    //        while (i != Countries.Length)
    //        {
    //            switch (i)
    //            {
    //                case 0:
    //                    break;
    //                case 1:
    //                    Countries[i].CName = "Austria";
    //                    Countries[i].CPop = 1.98;
    //                    Countries[i].eurozonemember = true;
    //                    break;

    //                case 2:
    //                    Countries[i].CName = "Belgium";
    //                    Countries[i].CPop = 2.56;
    //                    Countries[i].eurozonemember = true;
    //                    break;

    //                case 3:
    //                    Countries[i].CName = "Bulgaria";
    //                    Countries[i].CPop = 1.56;
    //                    Countries[i].eurozonemember = false;
    //                    break;

    //                case 4:
    //                    Countries[i].CName = "Croatia";
    //                    Countries[i].CPop = 0.91;
    //                    Countries[i].eurozonemember = false;
    //                    break;

    //                case 5:
    //                    Countries[i].CName = "Cyprus";
    //                    Countries[i].CPop = 0.20;
    //                    Countries[i].eurozonemember = true;
    //                    break;

    //                case 6:
    //                    Countries[i].CName = "Czech Republic";
    //                    Countries[i].CPop = 2.35;
    //                    Countries[i].eurozonemember = false;
    //                    break;

    //                case 7:
    //                    Countries[i].CName = "Denmark";
    //                    Countries[i].CPop = 1.30;
    //                    Countries[i].eurozonemember = false;
    //                    break;

    //                case 8:
    //                    Countries[i].CName = "Estonia";
    //                    Countries[i].CPop = 0.30;
    //                    Countries[i].eurozonemember = true;
    //                    break;

    //                case 9:
    //                    Countries[i].CName = "Finland";
    //                    Countries[i].CPop = 1.23;
    //                    Countries[i].eurozonemember = true;
    //                    break;

    //                case 10:
    //                    Countries[i].CName = "France";
    //                    Countries[i].CPop = 14.98;
    //                    Countries[i].eurozonemember = true;
    //                    break;

    //                case 11:
    //                    Countries[i].CName = "Germany";
    //                    Countries[i].CPop = 18.54;
    //                    Countries[i].eurozonemember = true;
    //                    break;

    //                case 12:
    //                    Countries[i].CName = "Greece";
    //                    Countries[i].CPop = 2.40;
    //                    Countries[i].eurozonemember = true;
    //                    break;

    //                case 13:
    //                    Countries[i].CName = "Hungary";
    //                    Countries[i].CPop = 2.18;
    //                    Countries[i].eurozonemember = false;
    //                    break;

    //                case 14:
    //                    Countries[i].CName = "Ireland";
    //                    Countries[i].CPop = 1.10;
    //                    Countries[i].eurozonemember = true;
    //                    break;

    //                case 15:
    //                    Countries[i].CName = "Italy";
    //                    Countries[i].CPop = 13.65;
    //                    Countries[i].eurozonemember = true;
    //                    break;

    //                case 16:
    //                    Countries[i].CName = "Latvia";
    //                    Countries[i].CPop = 0.43;
    //                    Countries[i].eurozonemember = true;
    //                    break;

    //                case 17:
    //                    Countries[i].CName = "Lithuania";
    //                    Countries[i].CPop = 0.62;
    //                    Countries[i].eurozonemember = true;
    //                    break;

    //                case 18:
    //                    Countries[i].CName = "Luxembourg";
    //                    Countries[i].CPop = 0.14;
    //                    Countries[i].eurozonemember = true;
    //                    break;

    //                case 19:
    //                    Countries[i].CName = "Malta";
    //                    Countries[i].CPop = 0.11;
    //                    Countries[i].eurozonemember = true;
    //                    break;

    //                case 20:
    //                    Countries[i].CName = "Netherlands";
    //                    Countries[i].CPop = 3.89;
    //                    Countries[i].eurozonemember = true;
    //                    break;

    //                case 21:
    //                    Countries[i].CName = "Poland";
    //                    Countries[i].CPop = 8.49;
    //                    Countries[i].eurozonemember = false;
    //                    break;

    //                case 22:
    //                    Countries[i].CName = "Portugal";
    //                    Countries[i].CPop = 2.30;
    //                    Countries[i].eurozonemember = true;
    //                    break;

    //                case 23:
    //                    Countries[i].CName = "Romania";
    //                    Countries[i].CPop = 4.34;
    //                    Countries[i].eurozonemember = false;
    //                    break;

    //                case 24:
    //                    Countries[i].CName = "Slovakia";
    //                    Countries[i].CPop = 1.22;
    //                    Countries[i].eurozonemember = true;
    //                    break;

    //                case 25:
    //                    Countries[i].CName = "Slovenia";
    //                    Countries[i].CPop = 0.47;
    //                    Countries[i].eurozonemember = true;
    //                    break;

    //                case 26:
    //                    Countries[i].CName = "Spain";
    //                    Countries[i].CPop = 10.49;
    //                    Countries[i].eurozonemember = true;
    //                    break;

    //                case 27:
    //                    Countries[i].CName = "Sweden";
    //                    Countries[i].CPop = 2.29;
    //                    Countries[i].eurozonemember = false;
    //                    break;
    //            }

    //            i++;
    //        }
    //    }

    //}
    //class ProgramOld
    //{
    //    public static void CodeIni()
    //    {
    //        CWorks.Initializer();
    //        CWorks.DisplayCountries();
    //        string ans = "";
    //        while (ans != "quit")
    //        {
    //            switch (ans)
    //            {
    //                case "vote":
    //                    //Voting.VoteMain();
    //                    break;
    //                case "quit":
    //                    break;
    //                default:
    //                    Console.WriteLine("Please enter 'vote' or 'quit'.");
    //                    break;
    //            }
    //        }
    //    }
    //}

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool howToggle = false;
        private int count = 0;
        private int votesYes = 0;
        private int votesNo = 0;
        private int votesAbstain = 0;
        private double success = 0.0;

        private void countparticipants()
        {
            for (int i = 0; i < CountriesList.Items.Count; i++)
            {
                if (CountriesList.GetItemChecked(i) == true)
                {
                    count++;
                }
            }
            ParticipatingStates.Text = ($"{count}");
            MemberStatesVote.Maximum = count;
            count = 0;
        }
        private void AllCountries_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < CountriesList.Items.Count;i++)
            {
                if(CountriesList.GetItemChecked(i) == true)
                {
                    count++;
                }
            }
            if (count != 0)
            {
                for (int i = 0; i < CountriesList.Items.Count; i++)
                {
                    CountriesList.SetItemChecked(i, false);
                }
            }
            else
            {
                for (int i = 0; i < CountriesList.Items.Count; i++)
                {
                    CountriesList.SetItemChecked(i, true);
                }
            }
            howToggle = false;
            count = 0;
            countparticipants();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            countparticipants();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            MemberStatesVote.Value = 0;
            for (int i = 0; i < 27; i++)
            {
                if (CountriesList.GetItemChecked(i) == true)
                {
                    
                    if (i == 0) { if (AusVote.Value == 2) { MemberStatesVote.Value++; votesYes++;} else if (AusVote.Value == 1) { votesNo++; } else if (AusVote.Value == 0) { votesAbstain++; } }
                    if (i == 1) { if (BelVote.Value == 2) { MemberStatesVote.Value++; votesYes++;} else if (BelVote.Value == 1) { votesNo++; } else if (BelVote.Value == 0) { votesAbstain++; } }
                    if (i == 2) { if (BulVote.Value == 2) { MemberStatesVote.Value++; votesYes++;} else if (BulVote.Value == 1) { votesNo++; } else if (BulVote.Value == 0) { votesAbstain++; } }
                    if (i == 3) { if (CroVote.Value == 2) { MemberStatesVote.Value++; votesYes++;} else if (CroVote.Value == 1) { votesNo++; } else if (CroVote.Value == 0) { votesAbstain++; } }
                    if (i == 4) { if (CypVote.Value == 2) { MemberStatesVote.Value++; votesYes++;} else if (CypVote.Value == 1) { votesNo++; } else if (CypVote.Value == 0) { votesAbstain++; } }
                    if (i == 5) { if (CzeVote.Value == 2) { MemberStatesVote.Value++; votesYes++;} else if (CzeVote.Value == 1) { votesNo++; } else if (CzeVote.Value == 0) { votesAbstain++; } }
                    if (i == 6) { if (DenVote.Value == 2) { MemberStatesVote.Value++; votesYes++;} else if (DenVote.Value == 1) { votesNo++; } else if (DenVote.Value == 0) { votesAbstain++; } }
                    if (i == 7) { if (EstVote.Value == 2) { MemberStatesVote.Value++; votesYes++;} else if (EstVote.Value == 1) { votesNo++; } else if (EstVote.Value == 0) { votesAbstain++; } }
                    if (i == 8) { if (FinVote.Value == 2) { MemberStatesVote.Value++; votesYes++;} else if (FinVote.Value == 1) { votesNo++; } else if (FinVote.Value == 0) { votesAbstain++; } }
                    if (i == 9) { if (FraVote.Value == 2) { MemberStatesVote.Value++; votesYes++;} else if (FraVote.Value == 1) { votesNo++; } else if (FraVote.Value == 0) { votesAbstain++; } }
                    if (i == 10) { if (GerVote.Value == 2) { MemberStatesVote.Value++; votesYes++;} else if (GerVote.Value == 1) { votesNo++; } else if (GerVote.Value == 0) { votesAbstain++; } }
                    if (i == 11) { if (GreVote.Value == 2) { MemberStatesVote.Value++; votesYes++;} else if (GreVote.Value == 1) { votesNo++; } else if (GreVote.Value == 0) { votesAbstain++; } }
                    if (i == 12) { if (HunVote.Value == 2) { MemberStatesVote.Value++; votesYes++;} else if (HunVote.Value == 1) { votesNo++; } else if (HunVote.Value == 0) { votesAbstain++; } }
                    if (i == 13) { if (IreVote.Value == 2) { MemberStatesVote.Value++; votesYes++;} else if (IreVote.Value == 1) { votesNo++; } else if (IreVote.Value == 0) { votesAbstain++; } }
                    if (i == 14) { if (ItaVote.Value == 2) { MemberStatesVote.Value++; votesYes++;} else if (ItaVote.Value == 1) { votesNo++; } else if (ItaVote.Value == 0) { votesAbstain++; } }
                    if (i == 15) { if (LatVote.Value == 2) { MemberStatesVote.Value++; votesYes++;} else if (LatVote.Value == 1) { votesNo++; } else if (LatVote.Value == 0) { votesAbstain++; } }
                    if (i == 16) { if (LitVote.Value == 2) { MemberStatesVote.Value++; votesYes++;} else if (LitVote.Value == 1) { votesNo++; } else if (LitVote.Value == 0) { votesAbstain++; } }
                    if (i == 17) { if (LuxVote.Value == 2) { MemberStatesVote.Value++; votesYes++;} else if (LuxVote.Value == 1) { votesNo++; } else if (LuxVote.Value == 0) { votesAbstain++; } }
                    if (i == 18) { if (MalVote.Value == 2) { MemberStatesVote.Value++; votesYes++;} else if (MalVote.Value == 1) { votesNo++; } else if (MalVote.Value == 0) { votesAbstain++; } }
                    if (i == 19) { if (NetVote.Value == 2) { MemberStatesVote.Value++; votesYes++;} else if (NetVote.Value == 1) { votesNo++; } else if (NetVote.Value == 0) { votesAbstain++; } }
                    if (i == 20) { if (PolVote.Value == 2) { MemberStatesVote.Value++; votesYes++;} else if (PolVote.Value == 1) { votesNo++; } else if (PolVote.Value == 0) { votesAbstain++; } }
                    if (i == 21) { if (PorVote.Value == 2) { MemberStatesVote.Value++; votesYes++;} else if (PorVote.Value == 1) { votesNo++; } else if (PorVote.Value == 0) { votesAbstain++; } }
                    if (i == 22) { if (RomVote.Value == 2) { MemberStatesVote.Value++; votesYes++;} else if (RomVote.Value == 1) { votesNo++; } else if (RomVote.Value == 0) { votesAbstain++; } }
                    if (i == 23) { if (SlkVote.Value == 2) { MemberStatesVote.Value++; votesYes++;} else if (SlkVote.Value == 1) { votesNo++; } else if (SlkVote.Value == 0) { votesAbstain++; } }
                    if (i == 24) { if (SlnVote.Value == 2) { MemberStatesVote.Value++; votesYes++;} else if (SlnVote.Value == 1) { votesNo++; } else if (SlnVote.Value == 0) { votesAbstain++; } }
                    if (i == 25) { if (SpaVote.Value == 2) { MemberStatesVote.Value++; votesYes++;} else if (SpaVote.Value == 1) { votesNo++; } else if (SpaVote.Value == 0) { votesAbstain++; } }
                    if (i == 26) { if (SweVote.Value == 2) { MemberStatesVote.Value++; votesYes++;} else if (SweVote.Value == 1) { votesNo++; } else if (SweVote.Value == 0) { votesAbstain++; } }
                    VoteYesNumber.Text = $"{votesYes}";
                    VoteNoNumber.Text = $"{votesNo}";
                    VoteAbstainNumber.Text = $"{votesAbstain}";
                }
            }
            if (votesYes > 0)
            {
                MessageBox.Show($"{MemberStatesVote.Maximum}");
                MessageBox.Show($"{votesYes}");
                success = (double)votesYes / (double)MemberStatesVote.Maximum;
                MessageBox.Show($"{success}");
                if (success * 100 >= 55) { PassedFailed.Text = "Passed"; }
                else { PassedFailed.Text = "Failed"; }
            }
            else { PassedFailed.Text = "Failed"; }
            votesYes = 0;
            votesNo = 0;
            votesAbstain = 0;
        }

        private void CountriesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            countparticipants();
        }
    }

    class Country
    {

        public string CName = "Country";
        public double CPop = 0.00;
        public bool eurozonemember = false;
        public bool present = false;
        public string vote = "abstain";

    }
}
