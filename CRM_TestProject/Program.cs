using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using System.Net;
using System.ServiceModel.Description;
using Microsoft.Xrm.Sdk.Query;
using DAL;


namespace CRM_TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nТелефоны:");
            CRMResultsGetter.getPhones();

            Console.WriteLine("\nНазвание:");
            CRMResultsGetter.getName();

            Console.WriteLine("\nКласс:");
            CRMResultsGetter.getClass();

            Console.WriteLine("\nТерритория:");
            CRMResultsGetter.getTerritory();

            Console.WriteLine("\nСНО:");
            CRMResultsGetter.getSNO();

            Console.WriteLine("\nГоловная организация:");
            CRMResultsGetter.getParent();

            Console.WriteLine("\nАналитика СПС:");
            CRMResultsGetter.getAnalyticSPS();

            Console.WriteLine("\nАналитика СМИ:");
            CRMResultsGetter.getAnalyticSMI();

            Console.WriteLine("\nАналитика Сбыт:");
            CRMResultsGetter.getAnalyticSbit();

            Console.WriteLine("\nEnd");
            Console.ReadKey();
        }
    }
}
