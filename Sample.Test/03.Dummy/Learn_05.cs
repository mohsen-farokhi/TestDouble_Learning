using Sample.Logging;
using Sample.People;
using Xunit;

namespace Sample.Test.PersonService.Learn_05
{
    public class PersonServiceTest
    {
        [Fact]
        public void saves_person_into_database()
        {
            var mockRepository = new Moq.Mock<IPersonRepositoy>();

            #region Using Dummy Object
            var personService =
                new People.Learn_05.PersonService(mockRepository.Object, new DummyLogger());

            var expected = new ResigterPersonDto
            {
                FirstName = "Mohsen",
                LastName = "Farokhi",
            };
            #endregion

            #region Using Moq
            //var logger = new Moq.Mock<ILogger>();

            //logger.Setup(c => c.Info(Moq.It.IsAny<string>()))
            //    .Verifiable();

            //var personService =
            //    new People.Learn_05.PersonService(mockRepository.Object, logger.Object);

            //var expected = new ResigterPersonDto
            //{
            //    FirstName = "Mohsen",
            //    LastName = "Farokhi",
            //};
            #endregion

            personService.ResigterPerson(request: expected);

            mockRepository.Verify
                (c => c.Insert(Moq.It.Is<Person>
                (c => c.FirstName == expected.FirstName &&
                      c.LastName == expected.LastName)),
                Moq.Times.Once);

        }
    }
}
