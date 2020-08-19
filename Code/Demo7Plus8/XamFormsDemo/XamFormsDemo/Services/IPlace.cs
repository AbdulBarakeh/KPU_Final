using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamFormsDemo.Models;

namespace XamFormsDemo.Services
{
    public interface IPlace
    {
        Task<List<PlaceModel>> getPlaces();

    }
}
