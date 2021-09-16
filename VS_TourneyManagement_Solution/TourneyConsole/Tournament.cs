using System;
using System.Collections.Generic;
using System.Text;

namespace TourneyConsole
{
    class Tournament
    {
        string tourneyName;
        int maxEntries;
        float entryFee;                        // float is smallest memory floating-point type
        List<Venue> venuesList;
        List<TourneyEntry> entriesList;
        Schedule tourneySchedule;

    }
}