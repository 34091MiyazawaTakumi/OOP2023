using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    public class YearMonth {
        public int Year { get; private set; }

        public int Month { get; private set; }

        public YearMonth(int year, int month) {
            Year = year;
            Month = month;
        }

        public bool Is21Century {
            get { 
                return 2001 <= Year && Year <= 2100;
            }
        }

        public YearMonth AddOneMonth(int year, int month) {
            if (Month == 12) {
                Year++;
                Month = 1;
            }
            else {
                Month++;
            }
            return AddOneMonth(Year,Month);
        }
    }
}
