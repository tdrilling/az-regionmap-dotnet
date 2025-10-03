using Microsoft.AspNetCore.Mvc;
using AzureRegionMapApp.Models;
using System.Collections.Generic;

namespace AzureRegionMapApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegionsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<AzureRegion> Get()
        {
            return new List<AzureRegion>
            {
                new AzureRegion { Name = "westeurope", Location = "Niederlande", Latitude = 52.1326, Longitude = 5.2913, AvailabilityZones = true },
                new AzureRegion { Name = "eastus", Location = "USA (Virginia)", Latitude = 37.9269, Longitude = -78.0249, AvailabilityZones = true },
                new AzureRegion { Name = "southeastasia", Location = "Singapur", Latitude = 1.3521, Longitude = 103.8198, AvailabilityZones = true }
            };
        }
    }
}