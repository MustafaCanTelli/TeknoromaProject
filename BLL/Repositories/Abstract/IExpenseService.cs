﻿using BLL.ViewModels.ReportsVM;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repositories.Abstract
{
    public interface IExpenseService:IGenericService<Expense>
    {

        List<MountlySalesVM> MountlySales(DateTime time);

    }

    
}
