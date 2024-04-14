using Microsoft.AspNetCore.Mvc;
using Infrastructure.Models;
using Newtonsoft.Json;
using AspNet_1_Assignment.Models;

namespace AspNet_1_Assignment.Controllers;

public class CoursesController(HttpClient http) : Controller
{
    private readonly HttpClient _http = http;
    private string _categoryApiUrl = "http://localhost:5117/api/Categories";
    private string _courseApiUrl = "http://localhost:5117/api/Courses";

    public async Task<IActionResult> Index(string category = "", string searchQuery = "", int pageNumber = 1, int pageSize = 6)
    {
        var viewModel = new CoursesViewModel();

        var categoryResponse = await _http.GetAsync(_categoryApiUrl);
        if (categoryResponse.IsSuccessStatusCode)
        {
            var categories = JsonConvert.DeserializeObject<IEnumerable<Category>>(await categoryResponse.Content.ReadAsStringAsync());
            if (categories != null)
                viewModel.Categories = categories;
        }

        var courseResponse = await _http.GetAsync($"{_courseApiUrl}?category={Uri.EscapeDataString(category)}&searchQuery={Uri.EscapeDataString(searchQuery)}&pageNumber={pageNumber}&pageSize={pageSize}");
        if (courseResponse.IsSuccessStatusCode)
        {
            var result = JsonConvert.DeserializeObject<CourseResult>(await courseResponse.Content.ReadAsStringAsync());
            if (result != null)
            {
                viewModel.Courses = result.Courses;
                viewModel.Pagination = new Pagination
                {
                    PageSize = pageSize,
                    CurrentPage = pageNumber,
                    TotalPages = result.TotalPages,
                    TotalCount = result.TotalCount,              
                };
            }

        }


        return View(viewModel);
    }
}
