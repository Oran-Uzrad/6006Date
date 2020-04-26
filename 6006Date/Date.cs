using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6006Date
{
    

    
    class Date
    {
        int day;
        int month;
        int year;

        public Date(int d , int m , int  y)
        {
            this.day = d;
            this.month = m;
            this.year = y;
        }


        public Date(Date d)
        {
            this.day = d.GetDay();
            this.month = d.GetMonth();
            this.year = d.GetYear();
        }

        public void SetYear(int y)
        {
            this.year = y;
        }

        public int GetYear()
        {
            return this.year;
        }

        public void SetMonth(int m)
        {
            this.month = m;
        }

        public int GetMonth()
        {
            return this.month;
        }

        public void SetDay(int d)
        {
            this.day = d;
        }

        public int GetDay()
        {
            return this.day;
        }

        public override string ToString()
        {
            return (this.day + "-" + this.month + "-" + this.year);
        }

        public bool IsLater(Date d)
        {
            if (this.year > d.GetYear())
            {
                return true;
            }
            if (this.year < d.GetYear())
            {
                return false;
            }
            if (this.month > d.GetMonth())
            {
                return true;
            }
            if (this.month < d.GetMonth())
            {
                return false;
            }
            if (this.day > d.GetDay())
            {
                return true;
            }
            if (this.day < d.GetDay())
            {
                return false;
            }
            return false;
        }

        public bool IsEqual(Date d)
        {
            return ((this.day == d.GetDay()) && (this.month == d.GetMonth()) && (this.year == d.GetYear()));
        }

        public void Tomorrow()
        {
            int[] daysInMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 30, 31, 30, 31, 30, 31 };
            if (this.day == daysInMonth[this.month])
            {
                this.day = 1;
                if ( this.month == 12)
                {
                    this.month = 1;
                    this.year++;
                }
                else
                {
                    this.month++;
                }
            }
            else
            {
                this.day++;
            }
        }

        public int DaysDifference(Date d)
        {
            Date dEarly, dLate;
            int count = 0;
            int sign;
            if (IsLater(d))
            {
                dEarly = new Date(d);
                dLate = new Date(this);
                sign = -1;
            }
            else
            {
                dLate = new Date(d);
                dEarly = new Date(this);
                sign = 1;
            }
            while (dLate.IsLater(dEarly))
            {
                count++;
                dEarly.Tomorrow();
            }
            return (sign * count);
        }
    }
}
