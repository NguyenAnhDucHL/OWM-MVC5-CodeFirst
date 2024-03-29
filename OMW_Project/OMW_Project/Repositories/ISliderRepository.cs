﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OMW_Project.Models;

namespace OMW_Project.Repositories
{
    public interface ISliderRepository:IDisposable
    {
        void Add(Slider slider);
        void Update(Slider slider);
        IList<Slider> GetAll();
    }
}
