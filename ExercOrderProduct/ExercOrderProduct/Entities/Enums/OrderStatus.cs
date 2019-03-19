﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExercOrderProduct.Entities.Enums
{
    enum OrderStatus : int
    {
        PedingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
