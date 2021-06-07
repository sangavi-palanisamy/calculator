using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace studentprocess.Controllers
{
    public class CalculatorController : Controller
    {
       public string GetResult(string str)
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
            if (symbleList.Count > 1)
            {
                double results = Convert.ToDouble(st[1]);
                for (int i = 2; i < st.Length; i++)
                {
                    double num = Convert.ToDouble(st[2]);
                    int j = i - 1;
                    if (symbleList[0] != symbleList[1])
                    {
                        if ((symbleList[0] == '-') && (symbleList[1] == '+'))
                        {
                                    double temp;
                                    temp = results;
                                    results = num;
                                    num = temp;
                                    results = results - num;
                                    break;

                            
                        }
                        else if (symbleList[1] == '/')
                        {
                            
                                results = results / num;
                                results = System.Math.Abs(results) * (-1);
                                break;
                        }
                        else
                        {
                           
                           results = results * num;

                            results = System.Math.Abs(results) * (-1);
                            break;
                        }
                        
                        
                      
                                                  
                    }
                    else
                    {
                        if (symbleList[0] == '+')
                        {
                                    results = results + num;

                                    break;
                            
                        }


                        else
                        {
                                    results = results + num;
                            results = System.Math.Abs(results) * (-1);
                            break;
                        }

                    }
                }
                TempData["results"]= results;
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
                            result=result+num;
                            break;
                        case '-':
                            result = result - num;
                            break;
                        case '*':
                            result = result * num;
                            break;
                        case '/':
                            result = result / num;
                            break;
                        default:
                            result = 0.0;
                            break;
                    }
                }
                TempData["results"]= result;
            }
           

            return TempData["results"].ToString();
        }
        
        public ActionResult Index()
        {
            if (Request["txt"] != null)
            {
                if (Request["txt"][Request["txt"].Length - 1] == '+' || Request["txt"][Request["txt"].Length - 1] == '-' || Request["txt"][Request["txt"].Length - 1] == '*' || Request["txt"][Request["txt"].Length - 1] == '/')
                {
                    ViewBag.flag = 0;
                    ViewBag.result = Request["txt"];
                }
                else
                {
                    ViewBag.result = GetResult(Request["txt"]);
                    ViewBag.flag = 1;
                }
            }
            return View();
        }
    }

}