using DevFreela.API.Models;
using DevFreela.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectService _projectService;
        public ProjectsController(IProjectService projectService) 
        {
            _projectService = projectService;
        }

        [HttpGet]
        public IActionResult Get(string query)
        {
            var projects = _projectService.GetAll(query);

            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id) 
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateProjectModel createProjectModel)
        {
            if (createProjectModel.Title.Length > 50)
            {
                return BadRequest();
            }

            return CreatedAtAction(nameof(GetById), new { id = createProjectModel.Id }, createProjectModel);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateProjectModel updateProjectModel)
        {
            if (updateProjectModel.Description.Length > 200) {
                return BadRequest();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) 
        {
            return NoContent();
        }

        [HttpPost("{id}/comments")]
        public IActionResult PostComment([FromBody] CreateCommentModel createComment)
        {
            return NoContent();
        }

        [HttpPut("id/start")]
        public IActionResult Start(int id)
        {
            return NoContent();
        }

        [HttpPut("id/finish")]
        public IActionResult Finish(int id)
        {
            return NoContent();
        }
    }
}
