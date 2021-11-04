using Sample.People;
using Xunit;

namespace Sample.Test.PersonService.Learn_05
{
    public class PersonServiceTest
    {
        [Fact]
        public void save_person_into_database()
        {
            var mockRepository =
                new Moq.Mock<People.Learn_05.IPersonRepositoy>();

            var personService =
                new People.Learn_05.PersonService(mockRepository.Object);

            var expected = new ResigterPersonDto
            {
                FirstName = "Nicolas",
                LastName = "Cage",
            };

            personService.ResigterPerson(request: expected);

            mockRepository.Verify
                (c => c.Insert(Moq.It.Is<Person>
                (c => c.FirstName == expected.FirstName &&
                      c.LastName == expected.LastName)),
                Moq.Times.Once);

        }
    }
}
