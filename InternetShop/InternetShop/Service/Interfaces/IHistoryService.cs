﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternetShop.Service;

namespace InternetShop.Service.Interfaces
{
    internal interface IHistoryService
    {
        void AddPurchaseData(PurchaseHistory record);
        List<PurchaseHistory> ReadAll();

    }
}
