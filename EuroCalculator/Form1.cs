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
        public static Country Aus = new Country { };
        public static Country Bel = new Country { };
        public static Country Bul = new Country { };
        public static Country Cro = new Country { };
        public static Country Cyp = new Country { };
        public static Country Cze = new Country { };
        public static Country Den = new Country { };
        public static Country Est = new Country { };
        public static Country Fin = new Country { };
        public static Country Fra = new Country { };
        public static Country Ger = new Country { };
        public static Country Gre = new Country { };
        public static Country Hun = new Country { };
        public static Country Ire = new Country { };
        public static Country Ita = new Country { };
        public static Country Lat = new Country { };
        public static Country Lit = new Country { };
        public static Country Lux = new Country { };
        public static Country Mal = new Country { };
        public static Country Net = new Country { };
        public static Country Pol = new Country { };
        public static Country Por = new Country { };
        public static Country Rom = new Country { };
        public static Country Slk = new Country { };
        public static Country Sln = new Country { };
        public static Country Spa = new Country { };
        public static Country Swe = new Country { };
        public static Country[] Countries = { Aus, Bel, Bul, Cro, Cyp, Cze, Den, Est, Fin, Fra, Ger, Gre, Hun, Ire, Ita, Lat, Lit, Lux, Mal, Net, Pol, Por, Rom, Slk, Sln, Spa, Swe };

        private void InitialiseCountries()
        {
            // This function creates the countries instances.
            for (int i = 0; i < 27; i++)
            {
                switch (i)
                {
                    case 0:
                        Countries[i].CName = "Austria";
                        Countries[i].CPop = 1.98;
                        Countries[i].eurozonemember = true;
                        break;

                    case 1:
                        Countries[i].CName = "Belgium";
                        Countries[i].CPop = 2.56;
                        Countries[i].eurozonemember = true;
                        break;

                    case 2:
                        Countries[i].CName = "Bulgaria";
                        Countries[i].CPop = 1.56;
                        Countries[i].eurozonemember = false;
                        break;

                    case 3:
                        Countries[i].CName = "Croatia";
                        Countries[i].CPop = 0.91;
                        Countries[i].eurozonemember = false;
                        break;

                    case 4:
                        Countries[i].CName = "Cyprus";
                        Countries[i].CPop = 0.20;
                        Countries[i].eurozonemember = true;
                        break;

                    case 5:
                        Countries[i].CName = "Czech Republic";
                        Countries[i].CPop = 2.35;
                        Countries[i].eurozonemember = false;
                        break;

                    case 6:
                        Countries[i].CName = "Denmark";
                        Countries[i].CPop = 1.30;
                        Countries[i].eurozonemember = false;
                        break;

                    case 7:
                        Countries[i].CName = "Estonia";
                        Countries[i].CPop = 0.30;
                        Countries[i].eurozonemember = true;
                        break;

                    case 8:
                        Countries[i].CName = "Finland";
                        Countries[i].CPop = 1.23;
                        Countries[i].eurozonemember = true;
                        break;

                    case 9:
                        Countries[i].CName = "France";
                        Countries[i].CPop = 14.98;
                        Countries[i].eurozonemember = true;
                        break;

                    case 10:
                        Countries[i].CName = "Germany";
                        Countries[i].CPop = 18.54;
                        Countries[i].eurozonemember = true;
                        break;

                    case 11:
                        Countries[i].CName = "Greece";
                        Countries[i].CPop = 2.40;
                        Countries[i].eurozonemember = true;
                        break;

                    case 12:
                        Countries[i].CName = "Hungary";
                        Countries[i].CPop = 2.18;
                        Countries[i].eurozonemember = false;
                        break;

                    case 13:
                        Countries[i].CName = "Ireland";
                        Countries[i].CPop = 1.10;
                        Countries[i].eurozonemember = true;
                        break;

                    case 14:
                        Countries[i].CName = "Italy";
                        Countries[i].CPop = 13.65;
                        Countries[i].eurozonemember = true;
                        break;

                    case 15:
                        Countries[i].CName = "Latvia";
                        Countries[i].CPop = 0.43;
                        Countries[i].eurozonemember = true;
                        break;

                    case 16:
                        Countries[i].CName = "Lithuania";
                        Countries[i].CPop = 0.62;
                        Countries[i].eurozonemember = true;
                        break;

                    case 17:
                        Countries[i].CName = "Luxembourg";
                        Countries[i].CPop = 0.14;
                        Countries[i].eurozonemember = true;
                        break;

                    case 18:
                        Countries[i].CName = "Malta";
                        Countries[i].CPop = 0.11;
                        Countries[i].eurozonemember = true;
                        break;

                    case 19:
                        Countries[i].CName = "Netherlands";
                        Countries[i].CPop = 3.89;
                        Countries[i].eurozonemember = true;
                        break;

                    case 20:
                        Countries[i].CName = "Poland";
                        Countries[i].CPop = 8.49;
                        Countries[i].eurozonemember = false;
                        break;

                    case 21:
                        Countries[i].CName = "Portugal";
                        Countries[i].CPop = 2.30;
                        Countries[i].eurozonemember = true;
                        break;

                    case 22:
                        Countries[i].CName = "Romania";
                        Countries[i].CPop = 4.34;
                        Countries[i].eurozonemember = false;
                        break;

                    case 23:
                        Countries[i].CName = "Slovakia";
                        Countries[i].CPop = 1.22;
                        Countries[i].eurozonemember = true;
                        break;

                    case 24:
                        Countries[i].CName = "Slovenia";
                        Countries[i].CPop = 0.47;
                        Countries[i].eurozonemember = true;
                        break;

                    case 25:
                        Countries[i].CName = "Spain";
                        Countries[i].CPop = 10.49;
                        Countries[i].eurozonemember = true;
                        break;

                    case 26:
                        Countries[i].CName = "Sweden";
                        Countries[i].CPop = 2.29;
                        Countries[i].eurozonemember = false;
                        break;
                }
            }
        }
        private void HasPassed()
        {
            // This function calculates whether or not the vote has passed based on the values of the MemberStatesVote bar's value and maximum.
            if (MemberStatesVote.Maximum > 0)
            {
                // The number "55" can be replaced with the percentage required based on the voting type. This is a placeholder value.
                if (((double)MemberStatesVote.Value / (double)MemberStatesVote.Maximum) * 100 > 55)
                {
                    PassedFailed.Text = "Passed";
                }
                else
                {
                    PassedFailed.Text = "Failed";
                }
            }
        }
        private void UpdateVoteBars()
        {
            // This function is called whenever a slider or tickbox changes state. It updates the vote bar.
            MemberStatesVote.Maximum = 0;
            MemberStatesVote.Value = 0;
            for (int i = 0; i < 27; i++)
            {
                if (Countries[i].present == true)
                {
                    MemberStatesVote.Maximum++;
                    // For each country that has present set as true, the maximum value for the bar is increased.
                    if (Countries[i].vote == 2)
                    {
                        MemberStatesVote.Value++;
                        // For each country that has present set as true, and has voted "yes", the value for the bar is increased.
                    }
                }
                ParticipatingStates.Text = $"{MemberStatesVote.Maximum}";
                // The text informing the user of how many states have participated is updated based on the maximum value of the bar. This is useful for debugging as well.
            }
            HasPassed();
            // The function calls HasPassed to check if the vote has passed or failed.
        }
        private void AllCountries_CheckedChanged(object sender, EventArgs e)
        {
            // This function handles the "all countries participating" checkbox.
            for (int i = 0; i < 27;i++)
            {
                if(CountriesList.GetItemChecked(i) == true)
                {
                    Countries[i].present = true;
                    UpdateVoteBars();
                    count++;
                }
            }
            // The above for loop runs through all the countries, and checks if any countries are currently participating in the vote.
            if (count != 0)
            {
                AllCountries.Checked = false;
                for (int i = 0; i < 27; i++)
                {
                    Countries[i].present = false;
                    UpdateVoteBars();
                    CountriesList.SetItemChecked(i, false);
                }
                // If any countries are participating in the vote, it runs through all the countries and unchecks them, and makes sure the "all countries participating" box is unchecked as well.
            }
            else
            {
                for (int i = 0; i < 27; i++)
                {
                    Countries[i].present = true;
                    UpdateVoteBars();
                    CountriesList.SetItemChecked(i, true);
                }
                // If no countries are participating in the vote, it runs through all the countries and checks them.
            }
            howToggle = false;
            count = 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateVoteBars();
            InitialiseCountries();
            // When the form loads, it creates the countries instances, and makes sure the vote bar is correct.
        }
        private void CountriesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Countries[CountriesList.SelectedIndex].present = CountriesList.GetItemChecked(CountriesList.SelectedIndex);
            UpdateVoteBars();
            // When a checkbox is changed, this function changes the state of that countrys participation in it's instance, and then updates the vote bar.
        }
        private void AusVote_Scroll(object sender, EventArgs e)
        {
            Aus.vote = AusVote.Value;
            UpdateVoteBars();
        }
        private void BelVote_Scroll(object sender, EventArgs e)
        {
            Bel.vote = BelVote.Value;
            UpdateVoteBars();
        }
        private void BulVote_Scroll(object sender, EventArgs e)
        {
            Bul.vote = BulVote.Value;
            UpdateVoteBars();
        }
        private void CroVote_Scroll(object sender, EventArgs e)
        {
            Cro.vote = CroVote.Value;
            UpdateVoteBars();
        }
        private void CypVote_Scroll(object sender, EventArgs e)
        {
            Cyp.vote = CypVote.Value;
            UpdateVoteBars();
        }
        private void CzeVote_Scroll(object sender, EventArgs e)
        {
            Cze.vote = CzeVote.Value;
            UpdateVoteBars();
        }
        private void DenVote_Scroll(object sender, EventArgs e)
        {
            Den.vote = DenVote.Value;
            UpdateVoteBars();
        }
        private void EstVote_Scroll(object sender, EventArgs e)
        {
            Est.vote = EstVote.Value;
            UpdateVoteBars();
        }
        private void FinVote_Scroll(object sender, EventArgs e)
        {
            Fin.vote = FinVote.Value;
            UpdateVoteBars();
        }
        private void FraVote_Scroll(object sender, EventArgs e)
        {
            Fra.vote = FraVote.Value;
            UpdateVoteBars();
        }
        private void GerVote_Scroll(object sender, EventArgs e)
        {
            Ger.vote = GerVote.Value;
            UpdateVoteBars();
        }
        private void GreVote_Scroll(object sender, EventArgs e)
        {
            Gre.vote = GreVote.Value;
            UpdateVoteBars();
        }
        private void HunVote_Scroll(object sender, EventArgs e)
        {
            Hun.vote = HunVote.Value;
            UpdateVoteBars();
        }
        private void IreVote_Scroll(object sender, EventArgs e)
        {
            Ire.vote = IreVote.Value;
            UpdateVoteBars();
        }
        private void ItaVote_Scroll(object sender, EventArgs e)
        {
            Ita.vote = ItaVote.Value;
            UpdateVoteBars();
        }
        private void LatVote_Scroll(object sender, EventArgs e)
        {
            Lat.vote = LatVote.Value;
            UpdateVoteBars();
        }
        private void LitVote_Scroll(object sender, EventArgs e)
        {
            Lit.vote = LitVote.Value;
            UpdateVoteBars();
        }
        private void LuxVote_Scroll(object sender, EventArgs e)
        {
            Lux.vote = LuxVote.Value;
            UpdateVoteBars();
        }
        private void MalVote_Scroll(object sender, EventArgs e)
        {
            Mal.vote = MalVote.Value;
            UpdateVoteBars();
        }
        private void NetVote_Scroll(object sender, EventArgs e)
        {
            Net.vote = NetVote.Value;
            UpdateVoteBars();
        }
        private void PolVote_Scroll(object sender, EventArgs e)
        {
            Pol.vote = PolVote.Value;
            UpdateVoteBars();
        }
        private void PorVote_Scroll(object sender, EventArgs e)
        {
            Por.vote = PorVote.Value;
            UpdateVoteBars();
        }
        private void RomVote_Scroll(object sender, EventArgs e)
        {
            Rom.vote = RomVote.Value;
            UpdateVoteBars();
        }
        private void SlkVote_Scroll(object sender, EventArgs e)
        {
            Slk.vote = SlkVote.Value;
            UpdateVoteBars();
        }
        private void SlnVote_Scroll(object sender, EventArgs e)
        {
            Sln.vote = SlnVote.Value;
            UpdateVoteBars();
        }
        private void SpaVote_Scroll(object sender, EventArgs e)
        {
            Spa.vote = SpaVote.Value;
            UpdateVoteBars();
        }
        private void SweVote_Scroll(object sender, EventArgs e)
        {
            Swe.vote = SweVote.Value;
            UpdateVoteBars();
        }
        // All of these countries functions update their instances vote state, and call the function to update the vote bar.

        private void EurozoneOnly_CheckedChanged(object sender, EventArgs e)
        {
            // Unfinished.
        }
    }

    public class Country
    {
        // Class containing all necessary values for the country instances.
        public string CName = "Country";
        public double CPop = 0.00;
        public bool eurozonemember = false;
        public bool present = false;
        public int vote = 2;
    }
}
