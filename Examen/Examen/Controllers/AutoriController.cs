using Examen.Models.Domain;
using Examen.Models.DTO;
using Examen.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Examen.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class AutoriController : Controller
    {
        private readonly IAutorRepository autorRepository;
        private readonly ICarteRepository carteRepository;
        public AutoriController(IAutorRepository autorRepository, ICarteRepository carteRepository)
        {
            this.autorRepository = autorRepository;
            this.carteRepository = carteRepository;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAutor(CreateAutorRequestDto request)
        {
            var autor = new Autor
            {
                Name = request.Name,
                Editura = request.Editura,
                Carti = new List<Carte>()
            };

            foreach(var carteId in request.Carti)
            {
                var existingCarte = await carteRepository.GetCarteById(carteId);
                if (existingCarte != null)
                {
                    autor.Carti.Add(existingCarte);
                }
            }

            autor = await autorRepository.CreateAsync(autor);

            return Ok(autor);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAutori()
        {
            var autori = await autorRepository.GetAllAsync();
            var response = new List<AutorDto>();
            foreach(var autor in autori)
            {
                response.Add(new AutorDto
                {
                    Id = autor.Id,
                    Name = autor.Name,
                    Editura = autor.Editura,
                    Carti = autor.Carti.Select(x => new CarteDto
                    {
                        Id = x.Id,
                        Name = x.Name
                    }).ToList(),
                });
            }
            return Ok(response);
        }
    }
}
