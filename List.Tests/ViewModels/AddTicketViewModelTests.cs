using List.Models;
using List.Services;
using List.ViewModels;
using Moq;
using NUnit.Framework;

namespace List.Tests.ViewModels
{
    [TestFixture]
    public class AddTicketViewModelTests
    {
        [SetUp]
        public void Setup()
        {
            _dataServiceMock = new Mock<IDataService>();
            _vm = new AddTicketViewModel(_dataServiceMock.Object);
        }

        private Mock<IDataService> _dataServiceMock;
        private AddTicketViewModel _vm;

        [Test]
        public void SaveCommand_Executed_TicketSaved()
        {
            //Arrange
Te
            //Act
            _vm.SaveCommand.Execute(null);

            //Assert
            _dataServiceMock.Verify(x => x.Save(It.IsAny<Ticket>()));
        }
    }
}