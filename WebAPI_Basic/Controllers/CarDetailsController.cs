﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI_Basic.Models;

namespace WebAPI_Basic.Controllers
{
    public class CarDetailsController : ApiController
    {
        [HttpGet]
        public IEnumerable<CarsStock> GetAllcarDetails()
        {
            CarsStock ST = new CarsStock();
            CarsStock ST1 = new CarsStock();
            List<CarsStock> li = new List<CarsStock>();

            ST.CarName = "Maruti Waganor";
            ST.CarPrice = "4 Lakh";
            ST.CarModel = "VXI";
            ST.CarColor = "Brown";

            ST1.CarName = "Maruti Swift";
            ST1.CarPrice = "5 Lakh";
            ST1.CarModel = "VXI";
            ST1.CarColor = "RED";

            li.Add(ST);
            li.Add(ST1);
            return li;
        }

        public IEnumerable<CarsStock> Get(int id)
        {
            CarsStock ST = new CarsStock();
            CarsStock ST1 = new CarsStock();
            List<CarsStock> li = new List<CarsStock>();
            if (id == 1)
            {
                ST.CarName = "Maruti Waganor";
                ST.CarPrice = "4 Lakh";
                ST.CarModel = "VXI";
                ST.CarColor = "Brown";
                li.Add(ST);
            }
            else
            {
                ST1.CarName = "Maruti Swift";
                ST1.CarPrice = "5 Lakh";
                ST1.CarModel = "VXI";
                ST1.CarColor = "RED";
                li.Add(ST1);
            }
            return li;
        }

        [HttpPost]
        public void PostCar([FromBody] CarsStock cs)
        {

        }

        [HttpPut]
        public void Putcar(int id, [FromBody]CarsStock cs)
        {

        }

        [HttpDelete]
        public void Deletecar(int id)
        {

        } 
    }
}