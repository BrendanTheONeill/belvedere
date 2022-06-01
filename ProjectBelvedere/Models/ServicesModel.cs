namespace BelvedereServices.Models
{
    public class ServicesModel
    {
        public string ImageTitle { get; set; }
        public string ServiceName { get; set; }
        public float BasePrice { get; set; } = 1000;
        public bool GrassCutting { get; set; }
        public bool RoofCleaning { get; set; }
        public bool TreePlanting { get; set; }
        public bool Powerwashing { get; set; }
        public bool ClutterRemoval { get; set; }
        public bool HousePainting { get; set; }
        public bool PoolInstallation { get; set; }
        public bool ProblemSolving { get; set; }
        public float FinalPrice { get; set; }
        public DateTime Datetime { get; set; }
    }
}
