using FluentAssertions;
using Sample.People;
using Sample.Test.TestDoubles.Spys;
using Xunit;

namespace Sample.Test._04.Spy
{
    public class PersonServiceTest
    {
        [Fact]
        public void saves_person_on_registration()
        {
            var repository = new PersonRepositorySpy();

            var service = new People.Learn_04.PersonService(repository);

            var expected = new ResigterPersonDto
            {
                FirstName = "Mohsen",
                LastName = "Farokhi",
            };

            service.ResigterPerson(request: expected);

            var actual = repository.GetSavedPerson();

            repository.GetNumberOfSavedPerson().Should().Be(expected: 1);

            actual.FirstName.Should().Be(expected: expected.FirstName);

            actual.LastName.Should().Be(expected: expected.LastName);
        }
    }
}
