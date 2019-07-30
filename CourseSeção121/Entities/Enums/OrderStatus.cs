﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSeção121.Entities.Enums
{
    enum OrderStatus : int
    {
        Pending_payment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
