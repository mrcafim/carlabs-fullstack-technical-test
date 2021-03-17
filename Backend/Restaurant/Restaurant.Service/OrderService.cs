using System;
using System.Collections.Generic;
using System.Text;
using Restaurant.Domain.Entities;
using Restaurant.Domain.Interfaces.Repositories;
using Restaurant.Domain.Interfaces.Services;
using Restaurant.Domain.Models.Order;
using Restaurant.Domain.Models.Product;

namespace Restaurant.Service
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _repository;

        public OrderService(IOrderRepository repository)
        {
            _repository = repository;
        }

        public Order New(CreateOrderModel orderModel)
        {
            var order = new Order
            {
                TableNumber = orderModel.Table,
                ProductId = orderModel.ProductId
            };

            return _repository.Add(order);
        }
        public List<Order> Get()
        {
            return _repository.Get();
        }

        public Order GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public List<Order> GetByTable(int table)
        {
            return _repository.GetByTable(table);
        }

        public string CalculateBill(int table)
        {
            decimal total = 0; 

            var orders = _repository.GetByTable(table);
            orders.ForEach(x => total += x.Product.Price);

            
            return "$" + total;
        }

    }
}
