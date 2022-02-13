﻿
namespace POOConcepts
{
    public class Date
    {
        //Attributes
        private int _year, _month, _day;

        //Builder
        public Date(int year, int month, int day)
        {
            _year = year;
            _month = CheckMonth(month);
            _day = CheckDay(year, month, day);
        }

        public override string ToString()
        {
            return $"{_year}/{_month:00}/{_day:00}";
        }


        // private metods
        private int CheckDay(int year, int month, int day)
        {

            if(month == 2 && day == 29 && IsLeapYear(year))
            {
                return day;
            }

            int[] DaysPerMonth = {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
            if(day >= 1 && day <= DaysPerMonth[month])
            {
                return day;
            }
            
            throw new DayException("Invalid day");
        }

        private bool IsLeapYear(int year)
        {
            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
            //if(year % 4 == 0)
            //{
            //    if(year % 100 == 0)
            //    {
            //        if(year % 400 ==0)
            //        {
            //            return true;
            //        }
            //        else
            //        {
            //            return false;
            //        }
            //    }
            //    else
            //    {
            //        return true;

            //    }
            //}
            //else
            //{
            //    return false;
            //}

            //throw new NotImplementedException();
        }

        private int CheckMonth(int month)
        {
            if (month >= 1 && month <= 12)
            {
                return month;
            }

            throw new MonthException("Invalid month");
        }

    }
}
