using GetBandInfo.Models;
using GetBandInfo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GetBandInfo.Controllers
{
    public class BandsController : ApiController
    {
        public BandRepository RepositoryData = new BandRepository();


        public IEnumerable<Band> GetBands()
        {
            RepositoryData.setAllBands();
            
            return RepositoryData.getAllBands();
        }
    }
}
