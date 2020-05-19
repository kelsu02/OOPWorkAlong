using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class OrderItem : EntityBase
    {
        public OrderItem()
        {
        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal? PurchasePrice { get; set; }


        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }

        public override bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }

        public bool Save(OrderItem orderItem)
        {
            var success = true;

            if (orderItem.HasChanges)
            {
                if (orderItem.IsValid)
                {
                    if (orderItem.IsNew)
                    {
                        // Call an insert stored procedure
                    }
                    else
                    {
                        // Call an update stored procedure
                    }
                }
                else
                {
                    success = false;
                }
            }

            return success;
        }
    }
}
