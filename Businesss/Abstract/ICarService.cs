﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businesss.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByBrandId(int brandId);
        IDataResult<List<Car>> GetCarsByColorId(int colorId);
        IDataResult<List<CarDetailDto>> GetCarDetailsByBrandName(string brandName);
        IDataResult<List<CarDetailDto>> GetCarDetailsByColorName(string colorName);
        IDataResult<List<CarDetailDto>> GetCarDetails();

        IDataResult<Car> GetById(int id);

        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
    }
}
