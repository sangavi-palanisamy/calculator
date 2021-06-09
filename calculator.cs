using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace studentprocess.Controllers
{
    public class CalculatorController : Controller
    {
       public JsonResult GetResult(string str)
        {
            List<char> symbleList = new List<char>();
            char[] charSymble = { '+', '-', '*', '/' };
            string[] st = str.Split(charSymble);
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '+' || str[i] == '-' || str[i] == '*' || str[i] == '/')
                {
                    symbleList.Add(str[i]);
                }
            }
            if ((str[0] == '-')||(str[0]=='+'))
            {
               

                double result = Convert.ToDouble(st[1]);

                if (str[0] == '-')
                {

                    result = System.Math.Abs(result) * (-1);
                }

                for (int i = 2; i <st.Length; i++)
                {
                    double num = Convert.ToDouble(st[i]);
                   

                    int j = i - 1;
                    switch (symbleList[j])
                    {
                        case '+':
                            result = Add(result, num);
                            break;
                        case '-':
                                result = Subtract(result, num);

                            break;
                        case '*':
                            result = Multiplication(result, num);
                            break;
                        case '/':
                            result = Divide(result, num);
                            break;
                        default:
                            result = 0.0;
                            break;
                    }
                    TempData["results"] = result;
                }
            }

            else
            {
                double result = Convert.ToDouble(st[0]);
                for (int i = 1; i < st.Length; i++)
                {
                    double num = Convert.ToDouble(st[i]);
                    int j = i - 1;
                    switch (symbleList[j])
                    {
                        case '+':
                            result=Add(result,num);
                            break;
                        case '-':
                            result = Subtract(result,num);
                            break;
                        case '*':
                            result = Multiplication(result,num);
                            break;
                        case '/':
                            result = Divide(result,num);
                            break;
                        default:
                            result = 0.0;
                            break;
                    }
                }
                TempData["results"]= result;
            }
            var response = TempData["results"];

            return Json(response, JsonRequestBehavior.AllowGet); 
        }
       public double Add(double m,double n)
        {
            double result=m+n;
            return result;
        }
        public double Subtract(double m, double n)
        {
            double result = m - n;
            return result;
        }
        public double Multiplication(double m, double n)
        {
            double result = m * n;
            return result;
        }
        public double Divide(double m, double n)
        {
            double result = m / n;
            return result;
        }
        public ActionResult Index()
        {
           
            return View();
        }
    }

}