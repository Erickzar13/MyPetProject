using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

using Microsoft.AspNet.Identity.EntityFramework;

namespace ExchangeRatesManager.Models
{
    [Bind(Exclude = "UserId")]
    public class UserExchangeModel
    {
        [ScaffoldColumn(false)]
        [Key]
        public int ExchangeId { get; set; }

        public string OwnerId { get; set; }

        [ScaffoldColumn(false)]
        [ForeignKey("OwnerId")]
        public ApplicationUser Owner { get; set; }

        [DisplayName("Usd Sale Rate")]
        [Required(ErrorMessage = "An Album Title is required")]
        [Range(0.01, 1000.00, ErrorMessage = "Price must be between 0.01 and 1000.00")]
        public int UsdSaleRate { get; set; }

        [DisplayName("Usd Buying Rate")]
        [Required(ErrorMessage = "An Album Title is required")]
        [Range(0.01, 1000.00, ErrorMessage = "Price must be between 0.01 and 1000.00")]
        public int UsdBuyingRate { get; set; }

        [DisplayName("Eur Sale Rate")]
        [Required(ErrorMessage = "An Album Title is required")]
        [Range(0.01, 1000.00, ErrorMessage = "Price must be between 0.01 and 1000.00")]
        public int EurSaleRate { get; set; }

        [DisplayName("Eur Buying Rate")]
        [Required(ErrorMessage = "An Album Title is required")]
        [Range(0.01, 1000.00, ErrorMessage = "Price must be between 0.01 and 1000.00")]
        public int EurBuyingRate { get; set; }

        [DisplayName("Rub Sale Rate")]
        [Required(ErrorMessage = "An Album Title is required")]
        [Range(0.01, 1000.00, ErrorMessage = "Price must be between 0.01 and 1000.00")]
        public int RubSaleRate { get; set; }

        [DisplayName("Rub Buying Rate")]
        [Required(ErrorMessage = "An Album Title is required")]
        [Range(0.01, 1000.00, ErrorMessage = "Price must be between 0.01 and 1000.00")]
        public int RubBuyingRate { get; set; }
    }
}