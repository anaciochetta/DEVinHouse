using aula0208.Models;
namespace aula0208.Repositories;

public class TipoClienteRepository
{
    private static List<TipoCliente> _tipoClientes = new(){
            new TipoCliente(1, "Padrão"),
            new TipoCliente(1, "Premium")
        };

    public TipoCliente ObterPorId(int id)
    {
        return _tipoClientes.FirstOrDefault(tipoCliente => tipoCliente.Id == id);
    }
}
