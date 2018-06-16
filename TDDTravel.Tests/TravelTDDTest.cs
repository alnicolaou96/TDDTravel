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

        [Test]
        public void Test_Total_Travel_Time_Convert_Years_To_Days()
        {
            var trav = new TravelTDD();
            var result = trav.TotalTravelTime(9, 8, 2019);
            Assert.That(result, Is.EqualTo(365));
        }

        [Test]
        public void Test_Total_Travel_Time_Convert_Months_To_Days()
        {
            var trav = new TravelTDD();
            var result = trav.TotalTravelTime(11, 8, 2018);
            Assert.That(result, Is.EqualTo(60));
        }

        [Test]
        public void Test_Total_Travel_Time_Convert_Months_To_Days_And_Adds_To_Days()
        {
            var trav = new TravelTDD();
            var result = trav.TotalTravelTime(11, 9, 2018);
            Assert.That(result, Is.EqualTo(61));
        }

        [Test]
        public void Test_Selection_Method_Returns_California()
        {
            var trav = new TravelTDD();
            var result = trav.Selection(5);
            Assert.That(result, Is.EqualTo("California"));
        }

        [Test]
        public void Test_Selection_Method_Returns_Georgia()
        {
            var trav = new TravelTDD();
            var result = trav.Selection(4);
            Assert.That(result, Is.EqualTo("Georgia"));
        }

        [Test]
        public void Test_Selection_Method_Returns_Florida()
        {
            var trav = new TravelTDD();
            var result = trav.Selection(3);
            Assert.That(result, Is.EqualTo("Florida"));
        }

        [Test]
        public void Test_Selection_Method_Returns_Nashville()
        {
            var trav = new TravelTDD();
            var result = trav.Selection(2);
            Assert.That(result, Is.EqualTo("Nashville"));
        }

        [Test]
        public void Test_Selection_Method_Returns_PutInBay()
        {
            var trav = new TravelTDD();
            var result = trav.Selection(1);
            Assert.That(result, Is.EqualTo("Put In Bay"));
        }

        [Test]
        public void Test_Selection_Method_Returns_StayHome()
        {
            var trav = new TravelTDD();
            var result = trav.Selection(0);
            Assert.That(result, Is.EqualTo("Stay Home"));
        }

        [Test]
        public void Test_Selection_Method_Input_Greater_Than_5()
        {
            var trav = new TravelTDD();
            var result = trav.Selection(6);
            Assert.That(result, Is.EqualTo("The World Is Yours"));
        }

        [Test]
        public void Destination_Class_Instansiation()
        {
            var trav = new Destination();
            var result = trav.Selection(6);
            Assert.That(result, Is.EqualTo("The World Is Yours"));
        }

        [Test]
        public void Selection_Method_5_Destination_TTT_Method_Input()
        {
            var trav = new Destination();
            var TTT = trav.TotalTravelTime(9, 14, 2018);
            var result = trav.Selection(TTT);
            Assert.That(result, Is.EqualTo("The World Is Yours"));
        }

        [Test]
        public void Selection_Method_3_Destination_TTT_Method_Input()
        {
            var trav = new Destination();
            var TTT = trav.TotalTravelTime(9, 13, 2018);
            var result = trav.Selection(TTT);
            Assert.That(result, Is.EqualTo("California"));
        }


        //Vehicle Class Tests
        [Test]
        public void Vehicle_Default_CTR()
        {
            var trav = new Vehicle("FName");
            var result = trav.FirstName;
            Assert.That(result, Is.EqualTo("FName"));
        }

        [Test]
        public void Vehicle_Test_Lastname_Prop()
        {
            var trav = new Vehicle(" ", "LName");
            var result = trav.LastName;
            Assert.That(result, Is.EqualTo("LName"));
        }

        [Test]
        public void Vehicle_Test_Address_Prop()
        {
            var trav = new Vehicle("", "", "123 street name");
            var result = trav.Address;
            Assert.That(result, Is.EqualTo("123 street name"));
        }

        [Test]
        public void Vehicle_Test_Email_Prop()
        {
            var trav = new Vehicle("", "", "", "Email");
            var result = trav.Email;
            Assert.That(result, Is.EqualTo("Email"));
        }

        [Test]
        public void Vehicle_Test_StartDate_Prop()
        {
            var trav = new Vehicle("", "", "", "","9/12/2018");
            var result = trav.StartDate;
            Assert.That(result, Is.EqualTo("9/12/2018"));
        }

        [Test]
        public void Start_Date_Method()
        {
            var trav = new Vehicle();
            var result = trav.GetDate(9,12,2018);
            Assert.That(result, Is.EqualTo("9/12/2018"));
        }

        [Test]
        public void Vehicle_Test_Total_Travel_Time()
        {
            var trav = new Vehicle();
            var result = trav.TotalTravelTime(9, 13, 2018);
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Vehicle_Test_Total_Travel_Time_Convert_Years_To_Days()
        {
            var trav = new Vehicle();
            var result = trav.TotalTravelTime(9, 8, 2019);
            Assert.That(result, Is.EqualTo(365));
        }

        [Test]
        public void Vehicle_Test_Total_Travel_Time_Convert_Months_To_Days()
        {
            var trav = new Vehicle();
            var result = trav.TotalTravelTime(11, 8, 2018);
            Assert.That(result, Is.EqualTo(60));
        }

        [Test]
        public void Vehicle_Test_Total_Travel_Time_Convert_Months_To_Days_And_Adds_To_Days()
        {
            var trav = new Vehicle();
            var result = trav.TotalTravelTime(11, 9, 2018);
            Assert.That(result, Is.EqualTo(61));
        }

        [Test]
        public void Vehicle_Virtual_Selection_Method()
        {
            var trav = new Vehicle();
            var result = trav.Selection(1);
            Assert.That(result, Is.EqualTo("California"));
        }
    }
}
