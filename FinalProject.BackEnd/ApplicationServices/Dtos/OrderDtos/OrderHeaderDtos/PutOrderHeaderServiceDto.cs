﻿using FinalProject.BackEnd.ApplicationServices.Dtos.OrderDtos.OrderDetailDtos;
using FinalProject.BackEnd.Models.DomainModels.PersonAggregates;

namespace FinalProject.BackEnd.ApplicationServices.Dtos.OrderDtos.OrderHeaderDtos
{
    public class PutOrderHeaderServiceDto
    {
    //{
    //    public Guid Id { get; set; }
    //    public Person Seller { get; set; }
    //    public Person Buyer { get; set; }
       
            public Guid? Id { get; set; }
            public Guid? SellerId { get; set; }
            public Guid? BuyerId { get; set; }
            public List<PutOrderDetailServiceDto>? OrderDetails { get; set; }
        





    }
}
