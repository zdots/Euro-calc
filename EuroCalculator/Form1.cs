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
            for (int i = 0; i < 27; i++)
            {
                switch (i)
                {
                    case 0:
                        break;
                    case 1:
                        Countries[i].CName = "Austria";
                        Countries[i].CPop = 1.98;
                        Countries[i].eurozonemember = true;
                        break;

                    case 2:
                        Countries[i].CName = "Belgium";
                        Countries[i].CPop = 2.56;
                        Countries[i].eurozonemember = true;
                        break;

                    case 3:
                        Countries[i].CName = "Bulgaria";
                        Countries[i].CPop = 1.56;
                        Countries[i].eurozonemember = false;
                        break;

                    case 4:
                        Countries[i].CName = "Croatia";
                        Countries[i].CPop = 0.91;
                        Countries[i].eurozonemember = false;
                        break;

                    case 5:
                        Countries[i].CName = "Cyprus";
                        Countries[i].CPop = 0.20;
                        Countries[i].eurozonemember = true;
                        break;

                    case 6:
                        Countries[i].CName = "Czech Republic";
                        Countries[i].CPop = 2.35;
                        Countries[i].eurozonemember = false;
                        break;

                    case 7:
                        Countries[i].CName = "Denmark";
                        Countries[i].CPop = 1.30;
                        Countries[i].eurozonemember = false;
                        break;

                    case 8:
                        Countries[i].CName = "Estonia";
                        Countries[i].CPop = 0.30;
                        Countries[i].eurozonemember = true;
                        break;

                    case 9:
                        Countries[i].CName = "Finland";
                        Countries[i].CPop = 1.23;
                        Countries[i].eurozonemember = true;
                        break;

                    case 10:
                        Countries[i].CName = "France";
                        Countries[i].CPop = 14.98;
                        Countries[i].eurozonemember = true;
                        break;

                    case 11:
                        Countries[i].CName = "Germany";
                        Countries[i].CPop = 18.54;
                        Countries[i].eurozonemember = true;
                        break;

                    case 12:
                        Countries[i].CName = "Greece";
                        Countries[i].CPop = 2.40;
                        Countries[i].eurozonemember = true;
                        break;

                    case 13:
                        Countries[i].CName = "Hungary";
                        Countries[i].CPop = 2.18;
                        Countries[i].eurozonemember = false;
                        break;

                    case 14:
                        Countries[i].CName = "Ireland";
                        Countries[i].CPop = 1.10;
                        Countries[i].eurozonemember = true;
                        break;

                    case 15:
                        Countries[i].CName = "Italy";
                        Countries[i].CPop = 13.65;
                        Countries[i].eurozonemember = true;
                        break;

                    case 16:
                        Countries[i].CName = "Latvia";
                        Countries[i].CPop = 0.43;
                        Countries[i].eurozonemember = true;
                        break;

                    case 17:
                        Countries[i].CName = "Lithuania";
                        Countries[i].CPop = 0.62;
                        Countries[i].eurozonemember = true;
                        break;

                    case 18:
                        Countries[i].CName = "Luxembourg";
                        Countries[i].CPop = 0.14;
                        Countries[i].eurozonemember = true;
                        break;

                    case 19:
                        Countries[i].CName = "Malta";
                        Countries[i].CPop = 0.11;
                        Countries[i].eurozonemember = true;
                        break;

                    case 20:
                        Countries[i].CName = "Netherlands";
                        Countries[i].CPop = 3.89;
                        Countries[i].eurozonemember = true;
                        break;

                    case 21:
                        Countries[i].CName = "Poland";
                        Countries[i].CPop = 8.49;
                        Countries[i].eurozonemember = false;
                        break;

                    case 22:
                        Countries[i].CName = "Portugal";
                        Countries[i].CPop = 2.30;
                        Countries[i].eurozonemember = true;
                        break;

                    case 23:
                        Countries[i].CName = "Romania";
                        Countries[i].CPop = 4.34;
                        Countries[i].eurozonemember = false;
                        break;

                    case 24:
                        Countries[i].CName = "Slovakia";
                        Countries[i].CPop = 1.22;
                        Countries[i].eurozonemember = true;
                        break;

                    case 25:
                        Countries[i].CName = "Slovenia";
                        Countries[i].CPop = 0.47;
                        Countries[i].eurozonemember = true;
                        break;

                    case 26:
                        Countries[i].CName = "Spain";
                        Countries[i].CPop = 10.49;
                        Countries[i].eurozonemember = true;
                        break;

                    case 27:
                        Countries[i].CName = "Sweden";
                        Countries[i].CPop = 2.29;
                        Countries[i].eurozonemember = false;
                        break;
                }
            }
        }
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
            InitialiseCountries();
        }
        private void CountriesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            countparticipants();
        }
        private void AusVote_Scroll(object sender, EventArgs e)
        {

        }
    }

    public class Country
    {
        public string CName = "Country";
        public double CPop = 0.00;
        public bool eurozonemember = false;
        public bool present = false;
        public int vote = 2;
    }
}
