﻿using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using System.Text;

namespace AspNet_1_Assignment;

public class SubscribeController(HttpClient http) : Controller
{
    private readonly HttpClient _http = http;

    [HttpPost]
    public async Task<IActionResult> Subscribe(SubscribeForm form)
    {
            if (ModelState.IsValid)
            {
                var content = new StringContent(JsonConvert.SerializeObject(form), Encoding.UTF8, "application/json");
                var response = await _http.PostAsync("http://localhost:5117/api/Subscribe", content);
                if (response.IsSuccessStatusCode)
                {
                    TempData["Status"] = "Your are now subscribed!";
                    return RedirectToAction ("Home", "Default", "subscribe");
                } 
                else if (response.StatusCode == System.Net.HttpStatusCode.Conflict)
                {
                    TempData["Status"] = "Your are already subscribed!";
                    return RedirectToAction ("Home", "Default", "subscribe");
                }
            }
            TempData["Status"] = "Something went wrong.";
            return RedirectToAction ("Home", "Default", "subscribe");
    }
}
