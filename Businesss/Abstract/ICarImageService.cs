using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businesss.Abstract
{
    public interface ICarImageService
    {
        IDataResult<List<CarImage>> GetAll();
        IDataResult<List<CarImage>> GetImagesByCarId(int carId);

        IDataResult<CarImage> GetById(int id);

        IResult Add(CarImage carImage, IFormFile file);
        IResult Delete(CarImage carImage);
        IResult Update(CarImage carImage, IFormFile file);


    }
}
