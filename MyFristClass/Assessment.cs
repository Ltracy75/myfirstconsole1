using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstClass
    {
    internal class Assessment
        {
        public int Points { get; set; } = 0;
        public string Topic { get; set; } = string.Empty; 
        public DateTime DateTaken { get; set; } = DateTime.MinValue;

        public string Display()
            {
            return $"When taking Assessment on {Topic} on {DateTaken} employee recieved {Points} points";
            }
        }
    }
