using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace PopProg
{
    class ClassBase
    {
        List<string> strWorker = new List<string>();

        public void LoadSTR(string volume)
        {
            strWorker.Add(volume);
        }

        public void OutMess(string item)
        {

        }


    }
    class Worker
    {
        //private string _date;
        //private string _name;
        //private string _stanok;
        //private string _workType;
        //private string _partType;
        //private string _ofMachine;
        //private string _amount;
        //private string _unit;

        //public string Date { get => _date; }
        //public string Name { get => _name; }
        //public string Stanok { get => _stanok; }
        //public string WorkType { get => _workType; }
        //public string PartType { get => _partType; }
        //public string OfMachine { get => _ofMachine; }
        //public string Amount { get => _amount; }
        //public string Unit { get => _unit; }

        //public Worker(string date, string name, string stanok, string workType, string partType, string ofMachine, string amount, string unit)
        //{
        //    _date = date;
        //    _name = name;
        //    _stanok = stanok;
        //    _workType = workType;
        //    _partType = partType;
        //    _ofMachine = ofMachine;
        //    _amount = amount;
        //    _unit = unit;
        //}
    }

}
