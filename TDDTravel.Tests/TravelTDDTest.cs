using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDTravel.Tests
{
    class TravelTDDTest
    {
        [Test]
        public void Default_CTR()
        {
            var trav = new TravelTDD("FName");
            var result = trav.FirstName;
            Assert.That(result, Is.EqualTo("FName"));
        }
        [Test]
        public void Test_Lastname_Prop()
        {
            var trav = new TravelTDD(" ", "LName");
            var result = trav.LastName;
            Assert.That(result, Is.EqualTo("LName"));
        }
        [Test]
        public void Test_Address_Prop()
        {
            var trav = new TravelTDD("", "", "123 street name");
            var result = trav.Address;
            Assert.That(result, Is.EqualTo("123 street name"));
        }
        [Test]
        public void Test_Email_Prop()
        {
            var trav = new TravelTDD("", "", "", "Email");
            var result = trav.Email;
            Assert.That(result, Is.EqualTo("Email"));
        }
        [Test]
        public void Test_Start_Month_Prop()
        {
            var trav = new TravelTDD("", "", "", "", 1);
            var result = trav.StartMonth;
            Assert.That(result, Is.EqualTo(1));

        }
        [Test]
        public void Test_Start_Day_Prop()
        {
            var trav = new TravelTDD("", "", "", "", 1,2);
            var result = trav.StartDay;
            Assert.That(result, Is.EqualTo(2));
        }
        [Test]
        public void Test_Start_Year_Prop()
        {
            var trav = new TravelTDD("", "", "", "", 1, 2, 3);
            var result = trav.StartYear;
            Assert.That(result, Is.EqualTo(3));
        }
        [Test]
        public void Test_GetDate()
        {
            var trav = new TravelTDD();
            var result = trav.GetDate(9,8,2018);
            Assert.That(result, Is.EqualTo("9/8/2018"));
        }
        [Test]
        public void Test_Total_Travel_Time()
        {
            var trav = new TravelTDD();
            var result = trav.TotalTravelTime(9, 13, 2018);
            Assert.That(result, Is.EqualTo(5));
        }
    }
}
