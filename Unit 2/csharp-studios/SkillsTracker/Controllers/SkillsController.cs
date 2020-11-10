using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SkillsTracker.Controllers
{

        public class SkillsController : Controller
    {
        //GET: <constructor>
        public IActionResult Index()
        {
            return Content("<h1>Skills Tracker</h1>" +
                "<h2>Three languages</h2>" +
                "<ol>" +
                "<li>JavaScript</li>" +
                "<li>C#</li>" +
                "<li>SQL</li>" +
                "</ol>",
                "text/html");
        }

        //GET: <constructor/form>

        [HttpGet]
        [Route("/skills/form")]

        public IActionResult Form()
        {
            string html = "<form method='post' action='/skills/formsubmission'>" +

                //Date

                "<label for='date'>Date:</label>" + "<br/>" +
                "<input type = 'date' name='dateSelect' id='date'>" + "<br/>" +

                //JavaScript Skill Level

                "<label for='skill-level1'>JavaScript:</label><br/>" +
                "<select name='proficiency1' id='skill-level1'>" +
                "<option value='Noob'>Noob</option>" +
                "<option value='Beginner'>Beginner</option>" +
                "<option value='Intermediate'>Intermediate</option><br/>" +
                "<option value='Advanced'>Advanced</option><br/>" +
                "</select><br/>" +

                //C# Skill Level

                "<label for='skill-level2'>C#:</label><br/>" +
                "<select name='proficiency2' id= 'skill-level2'>" +
                "<option value='Noob'>Noob</option>" +
                "<option value='Beginner'>Beginner</option>" +
                "<option value='Intermediate'>Intermediate</option>" +
                "<option value='Advanced'>Advanced</option>" +
                "</select><br/>" +

                // SQL Skill Level

                "<label for='skill-level3'>SQL:</label><br/>" +
                "<select name='proficiency3' id='skill-level3'>" +
                "<option value='Noob'>Noob</option>" + 
                "<option value='Beginner'>Beginner</option>" +
                "<option value='Intermediate'>Intermediate</option>" +
                "<option value='Advanced'>Advanced</option>" +
                "</select><br/>" +

                // Submit Button

                "<input type='submit' value='Submit'/>" +
                "</form>";

            return Content(html, "text/html");
        }

        [HttpPost]
        [Route("/skills/formsubmission")]

        public IActionResult FormSubmission(string dateSelect, string proficiency1, string proficiency2, string proficiency3)
        {
            return Content("<h1>Date: " + dateSelect + "</h1><br/>" +
                "<table>" +
                "<tr>" +
                "<th><u>Language</u>" +
                "<th><u>Skill Level</u>" +
                "</tr>" +

                "<tr>" +
                "<th>Javascript" +
                "<th>" + proficiency1 +
                "</tr>" +


                "<tr>" +
                "<th>C#" +
                "<th>" + proficiency2 +
                "</tr>" +

                "<tr>" +
                "<th>SQL" +
                "<th>" + proficiency3 +
                "</tr>" +
                "</table>",
                "text/html");
        }
    }
}
