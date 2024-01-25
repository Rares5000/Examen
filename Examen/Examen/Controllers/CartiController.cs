using Examen.Models.Domain;
using Examen.Models.DTO;
using Examen.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Examen.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class CartiController : Controller
    {
        private readonly IAutorRepository autorRepository;
        private readonly ICarteRepository carteRepository;
        public CartiController(IAutorRepository autorRepository, ICarteRepository carteRepository)
        {
            this.autorRepository = autorRepository;
            this.carteRepository = carteRepository;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCarte(CreateCarteRequestDto request)
        {
            var carte = new Carte
            {
                Name = request.Name
            };

            carte = await carteRepository.CreateAsync(carte);

            var response = new CarteDto
            {
                Name = carte.Name
            };

            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCarti()
        {
            var carti = await carteRepository.GetAllAsync();
            var response = new List<CarteDto>();
            foreach (var carte in carti)
            {
                response.Add(new CarteDto
                {
                    Id = carte.Id,
                    Name = carte.Name
                });
            }
            return Ok(response);
        }
    }
}
