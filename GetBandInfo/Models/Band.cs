using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetBandInfo.Models
{
    public class Band
    {
        public int BandID { get; set; }
        public String BandName { get; set; }
        public List<String> BandGenres { get; set; }
        public List<String> BandMembers { get; set; }
    }
}