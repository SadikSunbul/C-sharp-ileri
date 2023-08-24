using Order.Api.Models.Entities;
using Order.Api.Models.Enums;

namespace Order.Api.ViewModels;
public class CreateOrderViewModel
{
    public Guid BuyerId { get; set; }
    public List<CreateOrderItemVM> OrderItems { get; set; }
}

//ben su kısıyım su urunden su kadarlık su fıyata alıcam der