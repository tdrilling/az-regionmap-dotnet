namespace AzureRegionMapApp.Models
{
    public class AzureRegion
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public bool AvailabilityZones { get; set; }
    }
}