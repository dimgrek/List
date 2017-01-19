using System.Collections.Generic;
using List.Models;
using List.Services;
using List.ViewModels;
using Moq;
using NUnit.Framework;

namespace List.Tests
{
    [TestFixture]
    public class TicketsListViewModelTests
    {
        [SetUp]
        public void SetUp()
        {
            _dataServiceMock = new Mock<IDataService>();
            _filterServiceMock = new Mock<IFilterService>();
            _vm = new TicketsListViewModel(_dataServiceMock.Object, _filterServiceMock.Object);
        }

        private Mock<IDataService> _dataServiceMock;
        private Mock<IFilterService> _filterServiceMock;
        private TicketsListViewModel _vm;

        [Test]
        public void SearchTextChanged_FilterListInvoked()
        {
            //Arrange

            //Act
            _vm.Search = "some search";

            //Assert
            _filterServiceMock.Verify(x => x.Filter(It.IsAny<List<Ticket>>(), It.IsAny<string>()));
        }

        [Test]
        public void ViewModel_Created_TicketsLoaded()
        {
            //Arrange

            //Act

            //Assert
            _dataServiceMock.Verify(x => x.Load());
        }
    }
}