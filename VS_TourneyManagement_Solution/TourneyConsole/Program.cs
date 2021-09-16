using System;

namespace TourneyConsole
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("\nWelcome to Let's Play Tournament Management System\n");
            GetTournamentInfo();
            
        }

        private static Tournament GetTournamentInfo()
        {
            Tournament newTourney = new Tournament();
            Venue newVenue = new Venue();
            
            Console.WriteLine("Please enter the following information and we will produce a bracket for your tournament\n");
            Console.Write("Tournament Name: ");
            newTourney.TourneyName = Console.ReadLine();

            Console.Write("Tournament Organizer - Primary Contact: ");
            newTourney.tourneyPOC.NamePOC = Console.ReadLine();

            Console.Write("Tournament Organizer - Primary E-Mail Address: ");
            newTourney.tourneyPOC.EmailPOC = Console.ReadLine();

            Console.Write("Tournament Organizer - Primary Mobile Phone#: ");
            newTourney.tourneyPOC.PhonePOC = Console.ReadLine();

            Console.Write("\nSet Max# Tournament Entries: ");
            try
            {
                newTourney.MaxEntries = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Write("Max entry inputted was not a number. Please try again");
                try
                {
                    Console.Write("Set Max# Tournament Entries: ");
                    newTourney.MaxEntries = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.Write("Max entry inputted was not a number. Exiting program.");
                    Environment.Exit(1);
                }
            }

            Console.Write("\nAre tournament entries individual competitors or teams?  Type 1 for individual " +
                "competators, and hit enter or any other key for team entries.  37\n");
            string input = Console.ReadLine();
            if (input.Equals("1")) {
                newTourney.AreTeams = false;
            } else newTourney.AreTeams = true;

            Console.Write("\nTournament Fee per Team or Individual Competitor: $ ");
            try
            {
                newTourney.EntryFee = float.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Write("A numeric entry fee was not entered.  Total entry fee income will not be reported in tournament report.");
                newTourney.EntryFee = 0;
            }
            Console.WriteLine("\nPlease enter venue information for the " + newTourney.TourneyName);
            Console.Write("Venue Name: ");
            newVenue.VenueName = Console.ReadLine();
            Console.Write("Street Address (e.g. 1234 Patriot Dr.): ");
            newVenue.VenueAddress = Console.ReadLine();
            Console.Write("City: ");
            newVenue.VenueCity = Console.ReadLine();
            Console.Write("State (e.g. AZ): ");
            newVenue.VenueState = Console.ReadLine();
            Console.Write("Zip Code (e.g. 85142): ");
            newVenue.VenueZip = Console.ReadLine();
            Console.Write("Venue Manager: ");
            newVenue.VenuePOC = Console.ReadLine();
            Console.Write("Venue Manager E-mail Address: ");
            newVenue.VenueEmail = Console.ReadLine();
            Console.Write("Venue Phone: ");
            newVenue.VenuePhone = Console.ReadLine();

            Console.WriteLine("\nDoes " + newVenue.VenueName + " have multiple competitions sites (e.g. Court 1, Court 2, ...)?");
            Console.Write("Please enter the number of competition sites that are available at the venue: ");
            input = Console.ReadLine();
            
                //TODO:  Start here to get number of sites and names of sites

            return newTourney;
        }
    }
}
