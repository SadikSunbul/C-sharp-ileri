using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared;

public static class RabbitMqSettings
{
    public const string Stock_OrderCreatedEventQueue = "stock-order-created-event-queue";
    public const string Payment_StockReservedEventQueue = "payment-stock-reversed-event-queue";
    public const string Order_PymentCompletedEventQueue = "order-payment-completed-event-queue";
    public const string Order_StocNotReservedEventQueue = "order-stock-notreversed-event-queue";
    public const string Order_PaymendFailedEventQueue = "order-paymend-failed-event-queue";
}
