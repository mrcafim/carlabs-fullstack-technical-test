using Restaurant.Domain.Entities;
using Restaurant.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Infra.Data.DefaultData
{
    public static class DefaultData
    {
        public static void AddInformation(DataContext context)
        {
            BreakfastData.AddBreakfastData(context);
            LunchData.AddLunchData(context);
            DinnerData.AddDinnerData(context);
        }
    }

}