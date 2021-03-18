using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businesss.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
    }
}
