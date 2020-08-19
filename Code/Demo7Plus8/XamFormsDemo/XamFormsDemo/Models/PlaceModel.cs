using System;
using System.Collections.Generic;
using System.Text;

namespace XamFormsDemo.Models
{
    public class PlaceModel
    {
        public int ID { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public string NickName { get; set; }

        public string Streetname { get; set; }

        public int Streetnumber { get; set; }

        public string Houseletter { get; set; }

        public string Description { get; set; }

        public string ImageURL { get; set; }
    }
}
