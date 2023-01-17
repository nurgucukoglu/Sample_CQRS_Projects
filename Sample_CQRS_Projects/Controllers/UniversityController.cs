using MediatR;
using Microsoft.AspNetCore.Mvc;
using Sample_CQRS_Projects.CQRS.Commands.UniversityCommands;
using Sample_CQRS_Projects.CQRS.Queries.UniversityQueries;
using System.Threading.Tasks;

namespace Sample_CQRS_Projects.Controllers
{
    public class UniversityController : Controller
    {
        private readonly IMediator _mediator;//mediator aracılığıyla query'e ulaşacağım ve verileri böylece handler sınıfını burada tanımlamak zorunda kalmadım.

        public UniversityController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> GetAllUniversities()
        {
            var values = await _mediator.Send(new GetAllUniversityQuery()); //Verileri query üzerinden getirir. köprü görevi görür.
            return View(values);

        }

        //güncelleme için id'ye göre o güncelleencek verinin eski bilgilerini getirme
        [HttpGet]
        public async Task<IActionResult> UpdateUniversity(int id)
        {
            var values = await _mediator.Send(new GetUniversityByIDQuery(id));
            return View(values);
        }
        //güncelleme işlemi
        [HttpPost]
        public async Task<IActionResult> UpdateUniversity(UpdateUniversityCommand command)
        {
            var values = await _mediator.Send(command);
            return RedirectToAction("GetAllUniversities");
        }

        //ekleme işlemi
        [HttpGet]
        public IActionResult AddUniversity()
        {
            return View();
        }
        //ekleme işlemi
        [HttpPost]
        public async Task<IActionResult> AddUniversity(CreateUniversityCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("GetAllUniversities");

        }

        //silme
        public async Task<IActionResult> DeleteUniversity(int id)
        {
            await _mediator.Send(new RemoveUniversityCommand(id));
            return RedirectToAction("GetAllUniversities");

        }
    }
}
