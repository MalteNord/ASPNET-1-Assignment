using AspNet_1_Assignment.Models;
using Infrastructure.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace AspNet_1_Assignment;

public class DefaultController : Controller
{

    [Route("/")]
    public IActionResult Home()
    {
        return View();
    }

    [HttpPost]
    public async Task <IActionResult> Subscribe(SubscribeViewModel model)
    {
        if (ModelState.IsValid)
        {
            var subscriberEntity = new SubscriberEntity
            {
                Email = model.Email,
                DailyNewsletter = model.DailyNewsletter,
                AdvertisingUpdates = model.AdvertisingUpdates,
                WeekinReview = model.WeekinReview,
                EventUpdates = model.EventUpdates,
                StartupsWeekly = model.StartupsWeekly,
                Podcasts = model.Podcasts
            };

            _context.Subscribers.Add(subscriberEntity)
            await _context.SaveChangesAsync();
        }
    }

}


