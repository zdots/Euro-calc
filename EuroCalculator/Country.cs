using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroCalculator
{
    public class Country
    {
        // Class containing all necessary values for the country instances.
        private string CName = "Country";
        private double CPop = 0.00;
        private bool eurozoneMember = false;
        private bool present = false;
        private int vote = 2;
        private double votingPopulation = 0.00;
        public Country(string name, double population, bool ezMember)
        {
            CName = name;
            CPop = population;
            eurozoneMember = ezMember;
        }
        public int getVote() { return vote; }
        public void setVote(int changedVote) { vote = changedVote; }
        public double getPop() { return CPop; }
        public bool getPresent() { return present; }
        public void setPresent(bool changedPresent) { present = changedPresent; }
    }
}
