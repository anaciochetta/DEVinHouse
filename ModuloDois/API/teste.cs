@@ -1,17 + 1,20 @@
using DEVinCar.Api.Models;
using DEVinCar.Api.Data;
using Microsoft.AspNetCore.Mvc;

namespace DEVinCar.Api.Controllers;

[ApiController]
[Route("api/xyz")]
public class XYZController : ControllerBase
[Route("api/sales")]
public class SalesController : ControllerBase
{

    private readonly ILogger<XYZController> _logger;
    private readonly DevInCarDbContext _context;

    public XYZController(ILogger<XYZController> logger)

    public SalesController(DevInCarDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet]
@ -19,4 +22,109 @@ public class XYZController : ControllerBase
    {
        return Ok();
    }


    //Criar Endpoint GET /user/{userId}/sales


    //Deve-se buscar todos os registros de Venda com SellerId igual ao userId;
    //busca a/s venda/s pelo id do usuários
    [HttpGet("/user/{userId}/sales")]
    public ActionResult<Sale> GetSalesBySellerId(
        [FromRoute] int userId)
    {
        var sales = _context.Sales.Where(s => s.SellerId == userId);

        //Caso não haja nenhum resultado, deve-se retornar o código de Status 204
        if (sales == null || sales.Count() == 0)
        {
            return NoContent();
        }
        return Ok(sales.ToList());
    }
}


[ApiController]
[Route("api/deliveries")]
public class DeliveriesController : ControllerBase
{

    private readonly DevInCarDbContext _context;


    public DeliveriesController(DevInCarDbContext context)
    {
        _context = context;
    }

    //Criar Endpoint POST /sales/{saleId}/deliver

    [HttpPost("{saleId}/deliver")]
    public ActionResult<Delivery> PostDeliver(
       [FromRoute] int saleId,
       [FromBody] DeliveryDTO body)
    {

        //Caso não seja enviado um AddressId, deve-se retornar o Status de Erro 400 (Bad Request)
        if (body.AddressId == null || body.AddressId == 0)
        {
            return BadRequest();
        }

        //Caso seja enviado um saleId que não exista na tabela de Venda ou um AddressId que não exista na tabela de endereço, deve-se retornar o Status de Erro 404 (Not Found)

        if (_context.Sales.Find(saleId) == null)
        {
            return NotFound();
        }

        if (_context.Sales.Find(body.AddressId) == null)
        {
            return NotFound();
        }

        //Caso seja enviada uma DeliveryForecast com data e horário anterior à data atual, deve-se retornar o Status de Erro 400 (Bad Request)
        var now = DateTime.Now;
        if (body.DeliveryForecast == now)
        {
            return BadRequest();
        }

        //Caso não seja enviada uma DeliveryForecast, deve-se considerar a data e hora atual somados de 7 dias
        if (body.DeliveryForecast == null)
        {
            body.DeliveryForecast = DateTime.Now.AddDays(7);
        }

        //criação do objeto - linha na tabela
        var deliver = new Delivery
        {
            AddressId = body.AddressId,
            SaleId = saleId,
            DeliveryForecast = body.DeliveryForecast
        };

        _context.Deliveries.Add(deliver);
        _context.SaveChanges();

        return Created("/sales/{saleId}/deliver", deliver);
    }


    //DeliveryDTO

    public class DeliveryDTO
    {
        public int AddressId { get; set; }
        public DateTime DeliveryForecast { get; set; }
    }

    [HttpPost("{saleId}/deliver")]
    public ActionResult<Delivery> PostDeliver(
       [FromRoute] int saleId,
       [FromQuery] int? addressId,
       [FromQuery] DateTime? deliveryForecast)
    {
        if (!addressId.HasValue)
        {
            return BadRequest();
        }

        var querySales = _context.Sales.FirstOrDefault(a => a.Id == saleId);
        if (querySales == null)
        {
            return NotFound();
        }

        var queryDeliveries = _context.Deliveries.FirstOrDefault(a => a.AddressId == addressId);

        if (queryDeliveries == null)
        {
            return NotFound();
        }

        var now = DateTime.Now;
        if (deliveryForecast < now)
        {
            return BadRequest();
        }

        if (deliveryForecast == null)
        {
            deliveryForecast = DateTime.Now.AddDays(7);
        }

        var deliver = new Delivery
        {
            AddressId = (int)addressId,
            SaleId = saleId,
            DeliveryForecast = (DateTime)deliveryForecast
        };

        _context.Deliveries.Add(deliver);
        _context.SaveChanges();

        return Created("{saleId}/deliver", deliver);

    }


    //versão certa
    [HttpPost("{saleId}/deliver")]
    public ActionResult<Delivery> PostDeliver(
           [FromRoute] int saleId,
           [FromBody] DeliveryDTO body)
    {
        if (!body.AddressId.HasValue)
        {
            return BadRequest();
        }

        if (_context.Sales.Find(saleId) == null)
        {
            return NotFound();
        }

        if (_context.Sales.Find(body.AddressId) == null)
        {
            return NotFound();
        }

        var now = DateTime.Now;
        if (body.DeliveryForecast < now)
        {
            return BadRequest();
        }

        if (body.DeliveryForecast == null)
        {
            body.DeliveryForecast = DateTime.Now.AddDays(7);
        }

        var deliver = new Delivery
        {
            AddressId = (int)body.AddressId,
            SaleId = saleId,
            DeliveryForecast = (DateTime)body.DeliveryForecast
        };

        _context.Deliveries.Add(deliver);
        _context.SaveChanges();

        return Created("{saleId}/deliver", deliver);
    }

