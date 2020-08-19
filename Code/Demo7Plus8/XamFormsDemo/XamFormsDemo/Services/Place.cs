using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamFormsDemo.Models;

namespace XamFormsDemo.Services
{
    public class Place : IPlace
    {
        public List<PlaceModel> myPlaces;

        public Place()
        {
            myPlaces = new List<PlaceModel>();

            myPlaces.Add(new PlaceModel{NickName = "Skolen", Description = "Studying here for the exams", Houseletter = "", ID = 01, Streetname = "Finlandsgade", Streetnumber = 22,Latitude = 56.172021, Longitude = 10.191656, ImageURL = "https://studerende.au.dk/fileadmin/_migrated/RTE/RTEmagicC_600x270_Edison.jpg" });
            myPlaces.Add(new PlaceModel{ NickName = "Carls", Description = "Lazy food", Houseletter = "", ID  = 02, Streetname = "Finlandsgade", Streetnumber = 17, Latitude = 56.169550, Longitude = 10.189083, ImageURL = "https://aarhusupdate.dk/wp-content/uploads/2017/10/Carls-Jr.-i-Storcenter-Nord-295x220.jpg" });
            myPlaces.Add(new PlaceModel { NickName = "Hjem", Description = "Home = Bed", Houseletter = "3.TH", ID = 03, Streetname = "Stendalsvej", Streetnumber = 09, Latitude = 56.172861, Longitude = 10.180003, ImageURL = "https://lh3.googleusercontent.com/VS01XqTu-LBSNvt85tukkgGh4msW4JP18wN6geHQRDzs59nX_6Pb_trS2NvBExs33Es1" });

        }

        public async Task<List<PlaceModel>> getPlaces()
        {
            return await Task.FromResult(myPlaces);
        }
    }
}
