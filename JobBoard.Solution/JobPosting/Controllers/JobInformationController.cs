using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;
using System.Collections.Generic;

namespace JobBoard.Controllers
{
  public class JobInformationController : Controller
  {
    [HttpGet("/jobs")]
    public ActionResult Index()
    {
      List<JobInformation> allJobs = JobInformation.GetAll();
      return View(allJobs);
    }

    [HttpGet("/jobs/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/jobs")]
    public ActionResult Create(string title, string description, string name, string email, string phoneNumber)
    {
      JobInformation myJob = new JobInformation (title, description, name, email, phoneNumber);
      return RedirectToAction("Index");
    }
  }

}