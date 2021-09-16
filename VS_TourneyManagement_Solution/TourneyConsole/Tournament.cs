using System;
using System.Collections.Generic;
using System.Text;

namespace TourneyConsole
{
    class Tournament
    {
        
        public struct TourneyPOC
        {
            private string namePOC;
            private string phonePOC;
            private string emailPOC;

            //public TourneyPOC(string namePOC, string phonePOC, string emailPOC)
            //{
            //    this.namePOC = namePOC;
            //    this.phonePOC = phonePOC;
            //    this.emailPOC = emailPOC;
            //}

            public string NamePOC { get => namePOC; set => namePOC = value; }
            public string PhonePOC { get => phonePOC; set => phonePOC = value; }
            public string EmailPOC { get => emailPOC; set => emailPOC = value; }
        }

        
        private string tourneyName;
        public TourneyPOC tourneyPOC;
        private int maxEntries;
        private bool areTeams; 
        private float entryFee;                        // float is smallest memory floating-point type
        private Venue tourneyVenue;
        private List<TourneyEntry> entriesList;
        private Schedule tourneySchedule;


        //TODO:  Consider the proper access for each of these variables

        public string TourneyName { get => tourneyName; set => tourneyName = value; }
        public int MaxEntries {
            get => maxEntries;
            set {
                if (value < 100) { maxEntries = value; }
                else { throw new ArgumentOutOfRangeException("Max tournament entries exceeds limit of 100"); };
            }
        }
        
        public bool AreTeams { get => areTeams; set => areTeams = value; }
        public float EntryFee { get => entryFee; set => entryFee = value; }
        public Venue TourneyVenue { get => tourneyVenue; set => tourneyVenue = value; }
        public List<TourneyEntry> EntriesList { get => entriesList; set => entriesList = value; }
        public Schedule TourneySchedule { get => tourneySchedule; set => tourneySchedule = value; }
       
    }
}