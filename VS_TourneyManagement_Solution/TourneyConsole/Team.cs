using System;
using System.Collections.Generic;
using System.Text;

namespace TourneyConsole
{

    class Team: TourneyEntry
    {
        struct Players
        {
            private string name;
            private string phone;
            private string email;
            private int jerseyNumber;
            private float height;
            private float weight;
        }


        string teamName;
        string coachName;
        string coachemail;
        string coachphone;
        string coach2Name;
        string coach2email;
        string coach2phone;
        List<Players> playerList;
        // schedule??

        
    }
}
