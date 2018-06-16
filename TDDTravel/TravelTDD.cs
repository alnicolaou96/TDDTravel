using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDTravel
{
    public class TravelTDD
    {
        //properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int StartMonth { get; set; }
        public int StartDay { get; set; }
        public int StartYear { get; set; }

        //constructors
        public TravelTDD()
        {
            //default
        }
        public TravelTDD(string firstName)
        {
            this.FirstName = firstName;
        }
        public TravelTDD(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public TravelTDD(string firstName, string lastName, string address)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
        }
        public TravelTDD(string firstName, string lastName, string address,string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.Email = email;
        }
        public TravelTDD(string firstName, string lastName, string address, string email, int startMonth)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.Email = email;
            this.StartMonth = startMonth;
        }
        public TravelTDD(string firstName, string lastName, string address, string email, int startMonth,int startDay)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.Email = email;
            this.StartMonth = startMonth;
            this.StartDay = startDay;
        }
        public TravelTDD(string firstName, string lastName, string address, string email, int startMonth, int startDay,int startYear)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.Email = email;
            this.StartMonth = startMonth;
            this.StartDay = startDay;
            this.StartYear = startYear;
        }

        //methods
        public string GetDate(int startMonth, int startDay, int startYear)
        {
            string date = (startMonth + "/" + startDay + "/" + startYear);

            return date;
        }


        public int TotalTravelTime(int month, int day, int year)
        {
            int[] startDate = new int[3];
            string date = "9/8/2018";
            string[] split = date.Split('/');
            for(int i=0;i<3;i++)
            {
                startDate[i] = int.Parse(split[i]);
            }
            int leavingDay = day - startDate[1];
            int leavingMonth = month - startDate[0];
            int leavingYear = year - startDate[2];

            if ( year > startDate[2])
            {
                leavingDay = leavingDay + (365 * leavingYear);
            }
            if ( month>startDate[0])
            {
                leavingDay = leavingDay + (30 * leavingMonth);
            }
            return leavingDay;
        }
    }
}
