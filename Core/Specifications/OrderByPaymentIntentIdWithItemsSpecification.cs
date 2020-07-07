using System;
using System.Linq.Expressions;
using Core.Entities.OrderAggregate;

namespace Core.Specifications
{
    public class OrderByPaymentIntentIdSpecification : BaseSpcification<Order>
    {
        public OrderByPaymentIntentIdSpecification(string paymentIntentId)
        : base(o => o.PaymentIntentId == paymentIntentId)
        {
        }
    }
}