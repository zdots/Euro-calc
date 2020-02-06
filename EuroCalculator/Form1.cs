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
    public partial class Form1 : Form
    {
        private bool HowToggle = false;
        private int count = 0;
        public Form1()
        {
            InitializeComponent();
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
            HowToggle = false;
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
            for (int i = 0; i < MemberStatesVote.Maximum; i++)
            {
                if (CountriesList.GetItemChecked(i) == true)
                {
                    if (i == 0) { if (AusVote.Value == 2) { MemberStatesVote.Value++; } }
                    else if (i == 1) { if (BelVote.Value == 2) { MemberStatesVote.Value++; } }
                    else if (i == 2) { if (BulVote.Value == 2) { MemberStatesVote.Value++; } }
                    else if (i == 3) { if (CroVote.Value == 2) { MemberStatesVote.Value++; } }
                    else if (i == 4) { if (CypVote.Value == 2) { MemberStatesVote.Value++; } }
                    else if (i == 5) { if (CzeVote.Value == 2) { MemberStatesVote.Value++; } }
                    else if (i == 6) { if (DenVote.Value == 2) { MemberStatesVote.Value++; } }
                    else if (i == 7) { if (EstVote.Value == 2) { MemberStatesVote.Value++; } }
                    else if (i == 8) { if (FinVote.Value == 2) { MemberStatesVote.Value++; } }
                    else if (i == 9) { if (FraVote.Value == 2) { MemberStatesVote.Value++; } }
                    else if (i == 10) { if (GerVote.Value == 2) { MemberStatesVote.Value++; } }
                    else if (i == 11) { if (GreVote.Value == 2) { MemberStatesVote.Value++; } }
                    else if (i == 12) { if (HunVote.Value == 2) { MemberStatesVote.Value++; } }
                    else if (i == 13) { if (IreVote.Value == 2) { MemberStatesVote.Value++; } }
                    else if (i == 14) { if (ItaVote.Value == 2) { MemberStatesVote.Value++; } }
                    else if (i == 15) { if (LatVote.Value == 2) { MemberStatesVote.Value++; } }
                    else if (i == 16) { if (LitVote.Value == 2) { MemberStatesVote.Value++; } }
                    else if (i == 17) { if (LuxVote.Value == 2) { MemberStatesVote.Value++; } }
                    else if (i == 18) { if (MalVote.Value == 2) { MemberStatesVote.Value++; } }
                    else if (i == 19) { if (NetVote.Value == 2) { MemberStatesVote.Value++; } }
                    else if (i == 20) { if (PolVote.Value == 2) { MemberStatesVote.Value++; } }
                    else if (i == 21) { if (PorVote.Value == 2) { MemberStatesVote.Value++; } }
                    else if (i == 22) { if (RomVote.Value == 2) { MemberStatesVote.Value++; } }
                    else if (i == 23) { if (SlkVote.Value == 2) { MemberStatesVote.Value++; } }
                    else if (i == 24) { if (SlnVote.Value == 2) { MemberStatesVote.Value++; } }
                    else if (i == 25) { if (SpaVote.Value == 2) { MemberStatesVote.Value++; } }
                    else if (i == 26) { if (SweVote.Value == 2) { MemberStatesVote.Value++; } }
                }
            }
        }

        private void CountriesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            countparticipants();
        }
    }
}
