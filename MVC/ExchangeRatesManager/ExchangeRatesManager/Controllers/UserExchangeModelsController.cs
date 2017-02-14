using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using ExchangeRatesManager.Models;

using Microsoft.AspNet.Identity;

namespace ExchangeRatesManager.Controllers
{
    public class UserExchangeModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: UserExchangeModels/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            var userExchangeModel = new UserExchangeModel();
            var curentUser = User.Identity.GetUserId();

            if (userExchangeModel.OwnerId != User.Identity.GetUserId())
            {
                userExchangeModel = db.UserExchangeModels.FirstOrDefault(t => t.OwnerId == curentUser);
            }

            return View(userExchangeModel);
        }

        // POST: UserExchangeModels/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Edit(UserExchangeModel userExchangeModel)
        {
            var curentUser = User.Identity.GetUserId();
           
            if (ModelState.IsValid)
            {
                var exengeModel = db.UserExchangeModels.FirstOrDefault(t => t.OwnerId == curentUser);

                if (exengeModel == null)
                {
                    userExchangeModel.OwnerId = curentUser;

                    db.Entry(userExchangeModel).State = EntityState.Added;
                    db.SaveChanges();
                }
                else
                {
                    db.UserExchangeModels.Attach(userExchangeModel);

                    exengeModel.EurBuyingRate = userExchangeModel.EurBuyingRate;
                    exengeModel.EurSaleRate = userExchangeModel.EurSaleRate;
                    exengeModel.UsdBuyingRate = userExchangeModel.UsdBuyingRate;
                    exengeModel.UsdSaleRate = userExchangeModel.UsdSaleRate;
                    exengeModel.RubBuyingRate = userExchangeModel.RubBuyingRate;
                    exengeModel.RubSaleRate = userExchangeModel.RubSaleRate;

                    db.Entry(exengeModel).State = EntityState.Modified;
                    db.SaveChanges();
                }

                return View(userExchangeModel);
            }

            return View(userExchangeModel);
        }
    }
}
