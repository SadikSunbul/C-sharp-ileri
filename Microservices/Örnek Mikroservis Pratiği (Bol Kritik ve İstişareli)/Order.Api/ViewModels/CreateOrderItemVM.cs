namespace Order.Api.ViewModels;

public class CreateOrderItemVM
{
    public Guid ProductId { get; set; } //mış gibi yapıcaz değilse silsile şeklinde tüm projeyi yapmamız gerekir 
    public int Count { get; set; }
    public decimal Price { get; set; } //mış gibi yaptığımız için bunu böyle yaptık 
}

//ben su kısıyım su urunden su kadarlık su fıyata alıcam der