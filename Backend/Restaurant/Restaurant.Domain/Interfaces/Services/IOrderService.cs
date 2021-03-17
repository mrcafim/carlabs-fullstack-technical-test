using Restaurant.Domain.Entities;
using Restaurant.Domain.Models.Order;
using Restaurant.Domain.Models.Product;
using System;
using System.Collections.Generic;

namespace Restaurant.Domain.Interfaces.Services
{
    public interface IOrderService
    {
        Order New(CreateOrderModel orderModel);
        List<Order> Get();
        Order GetById(Guid id);
        List<Order> GetByTable(int table);
        string CalculateBill(int table);

    }
}