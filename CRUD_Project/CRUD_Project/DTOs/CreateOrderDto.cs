﻿namespace CRUD_Project.DTOs
{
    public class CreateOrderDto
    {
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
