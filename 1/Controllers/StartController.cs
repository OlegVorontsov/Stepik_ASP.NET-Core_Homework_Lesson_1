using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1.Controllers
{
    public class StartController : Controller
    {
        public string Hello()
        {
            DateTime dateNow = DateTime.Now;
            DateTime dateStart = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day);
            DateTime dateNight = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, 5, 59, 0);
            DateTime dateMorning = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, 11, 59, 0);
            DateTime dateDay = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, 17, 59, 0);
            DateTime dateEvening = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, 23, 59, 0);

            if (dateStart < dateNow && dateNow < dateNight)
            {
                return "Доброй ночи!";
            }

            if (dateNight < dateNow && dateNow < dateMorning)
            {
                return "Доброе утро!";
            }

            if (dateMorning < dateNow && dateNow < dateDay)
            {
                return "Добрый день!";
            }

            if (dateDay < dateNow && dateNow < dateEvening)
            {
                return "Добрый вечер!";
            }
            return null;
        }
    }
}
