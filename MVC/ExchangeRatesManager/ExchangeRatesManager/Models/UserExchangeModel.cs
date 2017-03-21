using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

using Microsoft.AspNet.Identity.EntityFramework;

namespace ExchangeRatesManager.Models
{
    [Bind(Exclude = "ExchangeId")]
    public class UserExchangeModel
    {
        [ScaffoldColumn(false)]
        [Key]
        public int ExchangeId { get; set; }

        [ScaffoldColumn(false)]
        public string OwnerId { get; set; }             
        
        [DisplayName("Usd продажа")]
        [Required(ErrorMessage = "field is required")]
        [Range(0.01, 1000.00, ErrorMessage = "Price must be between 0.01 and 1000.00")]
        public int UsdSaleRate { get; set; }

        [DisplayName("Usd покупка")]
        [Required(ErrorMessage = "An Album Title is required")]
        [Range(0.01, 1000.00, ErrorMessage = "Price must be between 0.01 and 1000.00")]
        public int UsdBuyingRate { get; set; }

        [DisplayName("Eur продажа")]
        [Required(ErrorMessage = "An Album Title is required")]
        [Range(0.01, 1000.00, ErrorMessage = "Price must be between 0.01 and 1000.00")]
        public int EurSaleRate { get; set; }

        [DisplayName("Eur покупка")]
        [Required(ErrorMessage = "An Album Title is required")]
        [Range(0.01, 1000.00, ErrorMessage = "Price must be between 0.01 and 1000.00")]
        public int EurBuyingRate { get; set; }

        [DisplayName("Rub продажа")]
        [Required(ErrorMessage = "An Album Title is required")]
        [Range(0.01, 1000.00, ErrorMessage = "Price must be between 0.01 and 1000.00")]
        public int RubSaleRate { get; set; }

        [DisplayName("Rub покупка")]
        [Required(ErrorMessage = "An Album Title is required")]
        [Range(0.01, 1000.00, ErrorMessage = "Price must be between 0.01 and 1000.00")]
        public int RubBuyingRate { get; set; }
    }
}