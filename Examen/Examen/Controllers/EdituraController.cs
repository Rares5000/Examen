using Examen.Models.Domain;
using Examen.Models.DTO;
using Examen.Repositories.Implementation;
using Examen.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Examen.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class EdituraController : Controller
    {
        private readonly IAutorRepository autorRepository;
        private readonly IEdituraRepository edituraRepository;

        public EdituraController(IAutorRepository autorRepository, IEdituraRepository edituraRepository) 
        {
            this.autorRepository = autorRepository;
            this.edituraRepository = edituraRepository;
        }
        [HttpPost]
        public async Task<IActionResult> CreateEditura(CreateEdituraRequestDto request)
        {
            var editura = new Editura
            {
                Name = request.Name
            };

            editura = await edituraRepository.CreateAsync(editura);

            return Ok(editura);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEdituri()
        {
            var edituri = await edituraRepository.GetAllAsync();
            var response = new List<EdituraDto>();
            foreach (var editura in edituri)
            {
                response.Add(new EdituraDto
                {
                    Id = editura.Id,
                    Name = editura.Name
                });
            }
            return Ok(response);
        }
    }
}
