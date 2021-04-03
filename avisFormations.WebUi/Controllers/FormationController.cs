using avisFormations.WebUi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace avisFormations.WebUi.Controllers
{
    public class FormationController : Controller
    {
        public IActionResult Index()
        {
            var vm = new ToutesLesFormationsViewModel();
            vm.Message = "Ceci est un message du controlleur";
            vm.Nombre = 93;
            return View(vm);
        }
    }
}
