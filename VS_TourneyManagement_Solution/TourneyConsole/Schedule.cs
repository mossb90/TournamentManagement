using System;
using System.Collections.Generic;
using System.Text;

namespace TourneyConsole
{
    class Schedule { 
    
        struct Game{
            Team team1;
            Team team2;
            int scoreTeam1;
            int scoreTeam2;
            Venue location;
            string locationSite;
            DateTime startTime;
        
        }
        List<Game> gamesList;
    }
}
