﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HXShopCoreApp.Data.Interfaces
{
    public interface IHasSoftDelete
    {
        bool IsDeleted { get; set; }
    }
}
