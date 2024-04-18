using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2.Controllers
{
    public class CalculatorController : Controller
    {
        public string Index(double a, double b, string sign)
        {
            int x = Convert.ToInt32(a);
            int y = Convert.ToInt32(b);

            switch (sign)
            {
                case null:
                case "+": return $"{x} + {y} = {x + y}";
                case "-": return $"{x} - {y} = {x - y}";
                case "*": return $"{x} * {y} = {x * y}";
                case "/":
                    if (x == 0 || y==0) 
                    {
                        return "попытка деления на 0";
                    }
                    return $"{x} / {y} = {(double)x / y}";
                default: return "неверный ввод";
            }
        }
    }
}
