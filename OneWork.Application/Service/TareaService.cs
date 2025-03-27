using OneWork.Domain.Entities;
using OneWork.infraestructura.Repositorio;
namespace OneWork.Application.Service
{
    public class TareaService
    {
     
   
        
            private readonly TareaRepositorio _repository;

            public TareaService(TareaRepositorio repository)
            {
                _repository = repository;
            }

        public async Task<List<Tarea>> ObtenerTodasAsync()
        {
            return await _repository.ObtenerTodoAsync();
        }

        public async Task<Tarea?> ObtenerPorIdAsync(int id)
            {
                return await _repository.ObtenerPorIdAsync(id);
            }

            public async Task AgregarAsync(Tarea tarea)
            {
                await _repository.AgregarAsync(tarea);
            }

            public async Task ActualizarAsync(Tarea tarea)
            {
                await _repository.ActualizarAsync(tarea);
            }

            public async Task EliminarAsync(int id)
            {
                await _repository.EliminarAsync(id);
            }
        }
    }



