using Microsoft.AspNetCore.Mvc;
using OneWork.Application.Service;
using OneWork.Domain.Entities;

namespace OneWork.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TareaController : ControllerBase
    {
        private readonly TareaService _tareaService;

        public TareaController(TareaService tareaService)
        {
            _tareaService = tareaService;
        }

        [HttpGet]
        public async Task<IActionResult> ObtenerTodas()
        {
            var tareas = await _tareaService.ObtenerTodasAsync();
            return Ok(tareas);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerPorId(int id)
        {
            var tarea = await _tareaService.ObtenerPorIdAsync(id);

            if (tarea == null)
                return NotFound(new { mensaje = "Tarea no encontrada." });

            return Ok(tarea);
        }

        [HttpPost]
        public async Task<IActionResult> Crear([FromBody] Tarea tarea)
        {
            if (tarea == null)
                return BadRequest(new { mensaje = "La tarea enviada no es válida." });

            await _tareaService.AgregarAsync(tarea);
            return CreatedAtAction(nameof(ObtenerPorId), new { id = tarea.Id }, new { mensaje = "Tarea creada con éxito." });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Actualizar(int id, [FromBody] Tarea tarea)
        {
            if (id != tarea.Id)
                return BadRequest(new { mensaje = "El ID de la tarea no coincide." });

            await _tareaService.ActualizarAsync(tarea);
            return Ok(new { mensaje = "Tarea actualizada correctamente." });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Eliminar(int id)
        {
            await _tareaService.EliminarAsync(id);
            return Ok(new { mensaje = "Tarea eliminada." });
        }
    }
}
