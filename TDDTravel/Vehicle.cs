using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDTravel
{
    public class Vehicle
    {
        //properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string StartDate { get; set; }

        //constructors
        public Vehicle()
        {
            //default
        }
        public Vehicle(string firstName)
        {
            this.FirstName = firstName;
        }
        public Vehicle(string firstName,string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public Vehicle(string firstName, string lastName,string address)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
        }
        public Vehicle(string firstName, string lastName, string address,string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.Email = email;
        }
        public Vehicle(string firstName, string lastName, string address, string email,string startDate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.Email = email;
            this.StartDate = startDate;
        }

        //methods
        public string GetDate(int month,int day, int year)
        {
            DateTime DateTravel = new DateTime(year,month,day);
            StartDate =DateTravel.ToString("M/dd/yyyy");
            return StartDate;
        }
        public int TotalTravelTime(int month, int day, int year)
        {
            int[] startDate = new int[3];
            string date = "9/8/2018";
            string[] split = date.Split('/');
            for (int i = 0; i < 3; i++)
            {
                startDate[i] = int.Parse(split[i]);
            }
            int leavingDay = day - startDate[1];
            int leavingMonth = month - startDate[0];
            int leavingYear = year - startDate[2];

            if (year > startDate[2])
            {
                leavingDay = leavingDay + (365 * leavingYear);
            }
            if (month > startDate[0])
            {
                leavingDay = leavingDay + (30 * leavingMonth);
            }
            return leavingDay;
        }
        public virtual string Selection(int number)
        {
            string location = "";
            switch (number)
            {
                case 1:
                    location = "California";
                    break;
            }
            return location;
        }
    }
}
