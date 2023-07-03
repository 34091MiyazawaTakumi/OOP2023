using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {

            var day = DateTime.Now;

            foreach (var dayofweek in Enum.GetValues(typeof(DayOfWeek))) {
                var nextDay = NextWeek(day, (DayOfWeek)dayofweek);
                Console.WriteLine("{0}の次週の{1}:{2}",day.ToString("yy/MM/dd"), dayofweek, nextDay.ToString("yy/MM/dd(dddd)"));
            }
        }

        public static DateTime NextWeek(DateTime date, DayOfWeek dayOfWeek) {
            var days = (int)dayOfWeek - (int)(date.DayOfWeek);
            if(days <= 7) {
                days += 7;
            }
            return date.AddDays(days);
        }
    }
}
