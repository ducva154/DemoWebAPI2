﻿using DAL.Repositories;
using DTO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public interface ICategoryService
    {
        Category GetById(int id);
    }
}
