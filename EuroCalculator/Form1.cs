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

        private void CypVote_Scroll(object sender, EventArgs e)
        {

        }

        private void BelVote_Scroll(object sender, EventArgs e)
        {

        }
    }
}
