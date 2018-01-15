using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using INC.DomainModel.Model;
using INC.BusinessLayer.Interfaces;

namespace INC.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            IBusinessLayer businessLayer = new INC.BusinessLayer.Interfaces.BusinessLayer();
            IList<swift_msg_inc> recs = businessLayer.GetAllSwiftMsgInc();
            foreach (swift_msg_inc item in recs)
            {
                System.Console.WriteLine(string.Format("{0} - {1} - {2} {3}", item.date_in, item.swift_type, item.ccy, item.amount));

            }
            System.Console.ReadKey();

        }
    }
}
