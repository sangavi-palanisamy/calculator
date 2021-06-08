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
                                    results =Subtract(results,num);
                                    break;

                            
                        }
                        else if (symbleList[1] == '/')
                        {
                            
                                results = Divide(results,num);
                                results = System.Math.Abs(results) * (-1);
                                break;
                        }
                        else if(symbleList[1] == '*')
                        {
                           
                           results = Multiplication(results,num);

                            results = System.Math.Abs(results) * (-1);
                            break;
                        }
                        else
                        {
                            if ((symbleList[0] == '+') && (symbleList[1] == '-'))
                            {
                                double temp;
                                if(results<num)
                                {

                                
                                temp = results;
                                results = num;
                                num = temp;
                                    results = Subtract(results, num);
                                    results = System.Math.Abs(results) * (-1);
                                    break;
                                }
                                results = Subtract(results, num);
                                break;


                            }
                            else if (symbleList[1] == '/')
                            {

                                results = Divide(results, num);
                               
                                break;
                            }
                            else if (symbleList[1] == '*')
                            {

                                results = Multiplication(results, num);

                                
                                break;
                            }
                        }
                        
                        
                      
                                                  
                    }
                    else
                    {
                        if (symbleList[0] == '+')
                        {
                                    results = Add(results,num);

                                    break;
                            
                        }


                        else
                        {
                                    results = Add(results, num);
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
           

            return TempData["results"].ToString();
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