using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ArtistsCore;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TestingArtist
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetArtists()
        {
            Assert.IsNotNull(DataAccess.GetArtist());
        }
    }

        [TestMethod]
        public void TestGetUser()
        {
            var artist1 = new User()
            {
                ID_user = 2,
                Login = "alex01",
                Password = "1",
            };
            var artist2 = DataAccess.GetArtist(2);
            Assert.AreEqual(artist1.Id_user, artist2.Id_user);
            Assert.AreEqual(artist1.Login, artist2.Login);
            Assert.AreEqual(artist1.Password, artist2.Password);
        }
    
}
