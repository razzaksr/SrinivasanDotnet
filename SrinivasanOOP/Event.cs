using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrinivasanOOP
{
    internal class Event
    {
        public override string ToString()
        {
            return eveName + " " + eveId + " " + eveDate + " " + eveParts + " " + eveWinner + "\n";
        }
        // default constructor
        public Event() { Console.WriteLine("Hai there!"); }
        //parameterized constructor
        public Event(int eveId, String eveName, DateTime eveDate)
        {
            this.eveId = eveId;
            this.eveName = eveName;
            this.eveDate = eveDate;
        }
        //parameterized constructor
        public Event(int eveId,String eveName, String[] eveParts,DateTime eveDate,String eveWinner) 
        {
            this.eveId = eveId;
            this.eveName = eveName;
            this.eveParts = eveParts;   
            this.eveDate = eveDate;
            this.eveWinner = eveWinner;
        }
        public int eveId { set; get; }
        public String eveName { set; get; }
        public String[] eveParts { set; get; }
        public DateTime eveDate { set; get; }
        public String eveWinner { set; get; }
        /*
        int eveId;
        public void setEveId(int eveId)
        {
            this.eveId = eveId;
        }
        public int getEveId() { return eveId; }
        string eveName;
        DateAndTime eveDate;
        String[] eveParts = new String[10];
        String eveWinner;
        */
    }
}
