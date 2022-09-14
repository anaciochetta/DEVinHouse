[HttpPost("{userId}/sales")]
public ActionResult<Sale> PostSaleUserId(
            [FromRoute] int userId,
            [FromBody] SaleDTO body)
{
    //- Atributo do BuyerId é obrigatório, caso não seja enviado deve-se retornar o Status de Erro 400 (Bad Request)
    if (_context.Sales.Any(s => s.BuyerId == null || body.BuyerId == 0))
    {
        return BadRequest();
    }

    //- Caso o UserId ou o BuyerId sejam referentes a ids de usuários que não existam, deve-se retornar o Status de Erro 404 (Not Found)
    var user = _context.Users.Find(userId);
    if (user == null) { return NotFound(); }

    var buyer = _context.Users.Find(s => s.BuyerId == body.Buyer);
    if (buyer == null) { return NotFound(); }

    //eliane
    if (_context.Sales.Any(s => s.BuyerId == null || s.SellerId == null))
    {
        return NotFound();
    }


    var sale = new Sale
    {
        BuyerId = body.BuyerId,
        //- Deve ser criado um registro na entidade de Venda, com SellerId sendo o userId.
        SellerId = userId,

            //- Caso não seja enviado o atributo SaleDate, deve-se preencher com a data e hora atual.
            if (body.SaleDate == null)
    {
        body.SaleDate = DateTime.Now
            }
    SaleDate = body.SaleDate
        };
_context.Sales.Add(sale);
_context.SaveChanges();

//Caso de sucesso no endpoint, deve-se retornar o Status 201 (Created), retornando somente o id da venda criada.
return Created("api/sale", sale.Id);
        //caso sucesso retornar status 201 ,somente o id da venda

    }


public class SaleDTO
{

    // ??? public int UserId { get; set; }
    [Required(ErrorMessage = "The Buyer is required.")]
    [MaxLength(255)]
    public int BuyerId { get; set; }
    public DateTime SaleDate { get; set; }
}


//camila
[HttpGet("{id}/com-view-model")]
public ActionResult<ClienteViewModel> GetByIdViewModel([FromRoute] int id)
{
    return Ok(
        _context.Sale
        .Include(c => c.CarteiraTrabalho)
        .Select(c => new ClienteViewModel
        {
            Id = c.Id,
            Nome = c.Nome,
            DataNascimento = c.DataNascimento,
            CarteiraTrabalho = c.CarteiraTrabalho == null ? null : new CarteiraTrabalhoViewModel
            {
                Id = c.CarteiraTrabalho.Id,
                PisPasep = c.CarteiraTrabalho.PisPasep
            }
        })
        .FirstOrDefault(c => c.Id == id)
    );
}

if (_context.Users.Find(body.UserId))
{
    return NotFound();
}

var buyer = _context.Users.Find(s => s.Id == body.BuyerId);
if (buyer == null) { return NotFound(); }



