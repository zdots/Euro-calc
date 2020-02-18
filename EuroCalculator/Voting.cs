using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroCalculator
{
    public class Voting
    {
        // Class containing all necessary values for the voting instances.
        public string VoteName = "VoteType";
        private double CountryVoteNeeded = 0.0;
        private double PercentVoteNeeded = 0.0;
        public Voting(string VotingTypeName, double CVoteNeeded, double PVoteNeeded)
        {
            VoteName = VotingTypeName;
            CountryVoteNeeded = CVoteNeeded;
            PercentVoteNeeded = PVoteNeeded;
        }
        public double getCVote() { return CountryVoteNeeded; }
        public double getPVote() { return PercentVoteNeeded; }
        public void setCVote(double countryVote) { CountryVoteNeeded = countryVote; }
        public void setPVote(double populationVote) { PercentVoteNeeded = populationVote; }
    }
}
