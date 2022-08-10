
using System.ComponentModel.DataAnnotations;
namespace aula0208.DTOs;

public class ClienteDTO
{
    //validadores do nome
    [Required(ErrorMessage = "O nome do cliente é obrigatório.")] //obrigátorio ter
    [StringLength(40)] //tamanho da string
    public string Nome { get; set; }
    [Range(minimum: 1, maximum: 100)] //para garantir que não vai ser negativo
    public int Idade { get; set; }
    public int TipoClienteId { get; set; }

}