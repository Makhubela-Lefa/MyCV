using CVApp.Models;
using CVApp.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace CVApp.Controllers
{
    public class CVController : Controller
    {
        public IActionResult Index()
        {
            var model = new CVViewModel
            {
                // PROFILE
                Profile = new Profile
                {
                    FullName = "Lefa Makhubela",
                    Title = "BCAD Student | Aspiring Software Developer",
                    About = "Bachelor of Computer Science in Application Development student at Emeris Ruimsig (formerly IIE MSA), with experience building web-based and database-driven applications. Passionate about solving real-world problems through technology.",
                    Email = "ST10442096@myemeris.edu.za",
                    GitHubUrl = "https://github.com/Makhubela-Lefa",
                    LinkedInUrl = "https://za.linkedin.com/in/lefa-makhubela-383243395"
                },

                // SKILLS
                Skills = new List<Skill>
                {
                    new Skill
                    {
                        Category = "Programming Languages",
                        Items = new List<string> { "C#", "Java", "SQL" } // removed Python
                    },
                    new Skill
                    {
                        Category = "Web & Frontend",
                        Items = new List<string> { "HTML", "CSS", "ASP.NET Core MVC" }
                    },
                    new Skill
                    {
                        Category = "Cloud & Tools",
                        Items = new List<string> { "Azure", "Git", "GitHub", "Visual Studio" }
                    }
                },

                // PROJECTS
                Projects = new List<Project>
                {
                    new Project
                    {
                        Title = "Contract Monthly Claim System (CMCS)",
                        Description = "Web-based claim system for independent contractor lecturers to submit and manage monthly claims.",
                        Technologies = "C#, ASP.NET Core MVC, SQL",
                        GitHubLink = "https://github.com/Makhubela-Lefa/CMCSApplication.git"
                    },
                    new Project
                    {
                        Title = "ABC Retailers Application",
                        Description = "Retail product management system with image storage and Microsoft service integration.",
                        Technologies = "C#, SQL Server, Azure",
                        GitHubLink = "https://github.com/Makhubela-Lefa/CLDV6212POE-Part3.git"
                    }
                },

                // EDUCATION
                Education = new Education
                {
                    Qualification = "Bachelor of Computer Science in Application Development (BCAD)",
                    Institution = "Emeris Ruimsig (formerly IIE MSA)",
                    CompletionDate = "Expected 2026",
                    RelevantModules = new List<string>
                    {
                        "Object-Oriented Programming",
                        "Information Systems/Databases",
                        "Cloud Development",
                        "Network Engineering"
                    }
                },

                // LEADERSHIP ROLES
                LeadershipRoles = new List<Leadership>
                {
                    new Leadership
                    {
                        Role = "Youth Chairperson",
                        Organization = "JLCC Kagiso Krugersdorp",
                        Duration = "Nov 2024 - Present",
                        Responsibilities = new List<string>
                        {
                            "Lead youth department activities",
                            "Organise events and meetings",
                            "Provide mentorship and guidance"
                        }
                    },
                    new Leadership
                    {
                        Role = "HOD - Admin & Engagement",
                        Organization = "Youth Of The Spirit (YOTS) Movement",
                        Duration = "Jan 2026 - Present",
                        Responsibilities = new List<string>
                        {
                            "Lead and manage administration and engagement tasks",
                            "Coordinate events and community programs"
                        }
                    }
                },

                // REFERENCES
                References = new List<Reference>
                {
                    new Reference
                    {
                        Name = "Available on request",
                        ContactInfo = ""
                    }
                }
            };

            return View(model);
        }
    }
}