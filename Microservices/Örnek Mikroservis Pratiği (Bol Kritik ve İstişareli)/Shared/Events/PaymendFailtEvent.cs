﻿using Shared.Events.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Events;

public class PaymendFailtEvent : IEvent
{
    public Guid OrderId { get; set; }
    public string Message { get; set; }

}
