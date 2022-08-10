﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;


using FormSubmission.Models;

using Microsoft.AspNetCore.Mvc;

namespace FormSubmission.Controllers

{

    public class HomeController : Controller

    {

        [HttpGet("")]

        public ViewResult Index()

        {

            return View();

        }

        [HttpPost("submit")]

        public IActionResult Submit(Submitter user)

        {

            if(ModelState.IsValid)

            {

                return RedirectToAction("Success");

            }

            return View("Index");

        }

        [HttpGet("success")]

        public ViewResult Success()

        {

            return View();

        }

    }

}