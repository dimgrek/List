using System.Collections.Generic;
using List.Models;
using List.Services;
using NUnit.Framework;

namespace List.Tests.Services
{
    [TestFixture]
    public class FilterServiceTests
    {
        //private Mock<IFilterService> _filterService;

        [SetUp]
        public void Setup()
        {
            //_filterService = new Mock<IFilterService>();
            _filterService = new FilterService();
        }

        private FilterService _filterService;

        [Test]
        public void FilterList()
        {
            //Arrange
            var t1 = new Ticket
            {
                Priority = Priority.Low,
                ProblemName = "first problem"
            };

            var t2 = new Ticket
            {
                Priority = Priority.Low,
                ProblemName = "second problem"
            };

            var t3 = new Ticket
            {
                Priority = Priority.Low,
                ProblemName = "third problem"
            };
            var tickets = new List<Ticket> {t1, t2, t3};
            var filteredTicket = t2;
            //Act
            //_filterService.Setup(x => x.Filter(It.IsAny<List<Ticket>>(), It.IsAny<string>()))
            //    .Returns(() => new ObservableCollection<Ticket>());
            var filteredTickets = _filterService.Filter(tickets, "second");

            //Assert
            Assert.AreEqual(filteredTicket, filteredTickets[0]);
        }
    }
}