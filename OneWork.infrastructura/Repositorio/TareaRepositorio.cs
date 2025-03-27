using OneWork.Domain.Data;
using OneWork.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace OneWork.infraestructura.Repositorio
{
    public class TareaRepositorio
    {
        private readonly OneWorkContext _context;

        public TareaRepositorio(OneWorkContext context)
        {
            _context = context;
        }

        public async Task<List<Tarea>> ObtenerTodoAsync()
        {
            return await _context.Tareas.ToListAsync();
        }

        public async Task<Tarea?> ObtenerPorIdAsync(int id)
        {
            return await _context.Tareas.FirstOrDefaultAsync(t => t.Id == id);
        }


        public async Task AgregarAsync(Tarea Tarea)
        {
            _context.Tareas.Add(Tarea);
            await _context.SaveChangesAsync();
        }

        public async Task ActualizarAsync(Tarea Tarea)
        {
            _context.Tareas.Update(Tarea);
            await _context.SaveChangesAsync();
        }

        public async Task EliminarAsync(int id)
        {
            var tarea = await _context.Tareas.FindAsync(id);
            if (tarea != null)
            {
                _context.Tareas.Remove(tarea);
                await _context.SaveChangesAsync();
            }
        }
    }
}
