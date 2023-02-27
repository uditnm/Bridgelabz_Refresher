using System;
using System.Data;
using System.Data.SqlClient;
using System.Numerics;
using System.Xml.Linq;
using System.Configuration;
using NLog;

namespace Employee
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            logger.Info("App Started");
            bool t = true;
            string constring = ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString;
            while (t)
            {
                Console.WriteLine("1.create \n2.Insert \n3.Read \n4.Delete \n5.Exit");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        CreateTable ct = new CreateTable();
                        ct.createTable(constring);
                        logger.Info("Table created");
                        break;
                    case 2:
                        AddRecord ar = new AddRecord();
                        ar.add(constring);
                        logger.Info("New record added");
                        break;
                    case 3:
                        ReadRecords rr = new ReadRecords();
                        rr.read(constring);
                        logger.Info("Records displayed");
                        break;
                    case 4:
                        DeleteRecord dr = new DeleteRecord();
                        dr.delete(constring);
                        logger.Info("A record was deleted");
                        break;
                    case 5:
                        t = false;
                        logger.Info("App Stopped");
                        break;

                }
            }
        }
    }
}

