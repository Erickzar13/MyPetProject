using System.ComponentModel.DataAnnotations;

namespace VM.LocationModels
{
    class LocationsViewModels
    {
        public int Id { get; set; }
        [Microsoft.Build.Framework.Required]
        public string Name { get; set; }

        public string City { get; set; }
        
        [Display(Name = "Country")]
        public int Country_Id { get; set; }

        public string CountryName { get; set; }
    }
}
