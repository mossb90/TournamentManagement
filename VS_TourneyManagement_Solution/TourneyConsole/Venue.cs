using System;
using System.Collections.Generic;
using System.Text;

namespace TourneyConsole
{
    class Venue
    {
        private string venueName;
        private string venueAddress;
        private string venueCity;
        private string venueState;
        private string venueZip;
        private string venuePhone;
        private string venuePOC;
        private string venueEmail;
        private int numSites;
        private List<string> venueSites;              // multiple courts, fields
        // open hours for tourney?

        public string VenueName { get => venueName; set => venueName = value; }
        public string VenueAddress { get => venueAddress; set => venueAddress = value; }
        public string VenueCity { get => venueCity; set => venueCity = value; }
        public string VenueState { get => venueState; set => venueState = value; }
        public string VenueZip { get => venueZip; set => venueZip = value; }
        public string VenuePhone { get => venuePhone; set => venuePhone = value; }
        public string VenuePOC { get => venuePOC; set => venuePOC = value; }
        public string VenueEmail { get => venueEmail; set => venueEmail = value; }
        public List<string> VenueSites { get => venueSites; set => venueSites = value; }
        public int NumSites { get => numSites; set => numSites = value; }
    }
}
