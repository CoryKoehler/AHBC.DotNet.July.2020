using System;
using System.Collections.Generic;

namespace September9thAssessment3Review
{
    public class Corporation

    {
        public double Cash { get; set; }
        public List<TeamMember>TeamMembers {get; set;}

        public Corporation()
        {
            Cash = 0;
            TeamMembers = new List<TeamMember>()
            {
                new TeamMember("P", "CEO"),
                new TeamMember("A", "CTO"),
                new TeamMember("M", "Manager"),
                new TeamMember("S", "Worker")
            };
        }

        public bool BeginWork()
        {
            if (Cash > 100000.00 && TeamMembers.Count == 4)
                return true;
            else
                return false;
        }
    
    }
    
}
