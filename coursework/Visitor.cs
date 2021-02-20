using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework
{
    class Visitor
    {
        public Visitor(int cardNo, string name, string address, long contactNo, string gender, string occupation, string day, string date, DateTime entryTime)
        {
            CardNo = cardNo;
            Name = name;
            Address = address;
            ContactNo = contactNo;
            Gender = gender;
            Occupation = occupation;
            Day = day;
            Date = date;    
            EntryTime = entryTime;
       
      
        }

        public int CardNo{get; set;}
        public string Name { get; set; }
        public string Address { get; set; }
        public long ContactNo { get; set; }
        public string Gender { get; set; }
        public string Occupation { get; set; }
        public string Day { get; set; }
        public string Date { get; set; }
        public DateTime EntryTime { get; set; }

       
    }
}
