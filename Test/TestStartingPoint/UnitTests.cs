using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using StartingPoint;


namespace TestStartingPoint
{
    [TestFixture]
    public class UnitTests
    {
        /* Fields */

        // Movies
        Movie m_Cinderella;
        Movie m_StarWars;
        Movie m_Gladiator;

        // Rentals
        Rental m_Rental1;
        Rental m_Rental2;
        Rental m_Rental3;

        // Customers
        Customer m_MickeyMouse;
        Customer m_DonaldDuck;
        Customer m_MinnieMouse;

        /* Methods */

        [SetUp]
        public void Init()
        {
            // Create movies
            m_Cinderella = new Movie("Cinderella", PriceCodes.Childrens);
            m_StarWars = new Movie("Star Wars", PriceCodes.Regular);
            m_Gladiator = new Movie("Gladiator", PriceCodes.NewRelease);

            // Create rentals
            m_Rental1 = new Rental(m_Cinderella, 5);
            m_Rental2 = new Rental(m_StarWars, 5);
            m_Rental3 = new Rental(m_Gladiator, 5);

            // Create customers
            m_MickeyMouse = new Customer("Mickey Mouse");
            m_DonaldDuck = new Customer("Donald Duck");
            m_MinnieMouse = new Customer("Minnie Mouse");
        }

        [Test]
        public void TestMovie()
        {
            // Test title property
            Assert.AreEqual("Cinderella", m_Cinderella.Title);
            Assert.AreEqual("Star Wars", m_StarWars.Title);
            Assert.AreEqual("Gladiator", m_Gladiator.Title);

            // Test price code
            Assert.AreEqual(PriceCodes.Childrens, m_Cinderella.PriceCode);
            Assert.AreEqual(PriceCodes.Regular, m_StarWars.PriceCode);
            Assert.AreEqual(PriceCodes.NewRelease, m_Gladiator.PriceCode);
        }
    }
}
