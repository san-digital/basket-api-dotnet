using Microsoft.AspNetCore.Mvc;

namespace BasketApi.Controllers;

[ApiController]
[Route("[controller]")]
public class BasketController : ControllerBase
{
    private readonly ILogger<BasketController> _logger;

    public BasketController(ILogger<BasketController> logger)
    {
        _logger = logger;
    }

    [HttpGet("{id}")]
    public async Task<BasketState> Get()
    {
        return new BasketState();
    }

    [HttpPost("{id}/add")]
    public async Task<BasketState> AddToBasket(string id, AddToBasketRequest request)
    {
        return new BasketState();
    }
}

public class AddToBasketRequest
{
    public string? SKU { get; set; }
    public int? Quantity { get; set; }
}

public class BasketState
{
    public string? Id { get; set; }
    public List<BasketItem>? Items { get; set; }
    public decimal? SubTotal { get; set; }
    public decimal? Discount { get; set; }
    public string? DiscountedTotal { get; set; }
}

public class BasketItem
{
    public string? SKU { get; set; }
    public int? Quantity { get; set; }
    public decimal? Price { get; set; }
    public decimal? Total { get; set; }
    public decimal? Discount { get; set; }
    public string? DiscountDescription { get; set; }
}

