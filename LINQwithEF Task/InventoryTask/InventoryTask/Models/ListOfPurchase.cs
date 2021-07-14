﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryTask.Models
{
    public class ListOfPurchase
    {
        public tbl_Customer CustomerName{ get; set; }
        public tbl_PurchaseOrder POID { get; set; }
        public tbl_Product ProductName { get; set; }
        public tbl_PurchaseOrderDetail Price { get; set; }

    }
}