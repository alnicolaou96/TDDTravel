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
            var trav = new TravelTDD(" ","LName");
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

    }
}
