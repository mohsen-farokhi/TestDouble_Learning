using Sample.People;
using Xunit;

namespace Sample.Test.PersonService.Learn_04
{
    public class PersonServiceTest
    {
        [Fact]
        public void saves_person_into_database()
        {
            var mockRepository = new Moq.Mock<IPersonRepositoy>();

            var personService =
                new People.Learn_04.PersonService(mockRepository.Object);

            var expected = new ResigterPersonDto
            {
                FirstName = "Nicolas",
                LastName = "Cage",
            };

            personService.ResigterPerson(request: expected);

            // Interaction Verification
            mockRepository.Verify
                (c => c.Insert(Moq.It.Is<Person>
                (c => c.FirstName == expected.FirstName &&
                      c.LastName == expected.LastName)),
                Moq.Times.Once);

        }
    }
}
