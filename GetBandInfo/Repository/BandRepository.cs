using GetBandInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetBandInfo.Repository
{
    public class BandRepository
    {
        List<Band> allbands = new List<Band>();

        public List<Band> setAllBands()
        {
            allbands.Add(
                new Band
                {
                    BandID = 1,
                    BandName = "Pink Floyd",
                    BandGenres = new List<string>() { "Classic Rock" },
                    BandMembers = new List<string>() { "David Gilmour", "Roger Watters" },

                });

            allbands.Add(
                new Band
                {
                    BandID = 2,
                    BandName = "AC/DC",
                    BandGenres = new List<string>() { "Classic Rock" },
                    BandMembers = new List<string>() { "Angus Yang" },
                });

            allbands.Add(
                new Band
                {
                    BandID = 3,
                    BandName = "Dave Matthews Band",
                    BandGenres = new List<string>() { "Rock", "jam", "jazz", "fusion", "folk rock", "bluegrass", "funk rock", "pop rock", "alternative rock", "Post-grunge"},
                    BandMembers = new List<string>() { "Dave Matthews","Carter Beauford","Stefan Lessard","Boyd Tinsley","Tim Reynolds","Rashawn Ross","Jeff Coffin"},
                });

            return allbands;

        }

        public List<Band> getAllBands()
        {
            return allbands;
        }
    }
}