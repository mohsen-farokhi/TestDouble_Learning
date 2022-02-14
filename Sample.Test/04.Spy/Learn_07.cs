using FluentAssertions;
using Sample.People;
using Sample.Test.TestDoubles.Spys;
using Xunit;

namespace Sample.Test._04.Spy
{
    public class PersonServiceTest_SelfShunt : IPersonRepositoy
    {
        private Person _savedPerson;
        private int _callNumbers;

        public void Insert(Person person)
        {
            _savedPerson = person;

            _callNumbers++;
        }

        [Fact]
        public void saves_person_on_registration()
        {
            var service = new People.Learn_04.PersonService(this);

            var expected = new ResigterPersonDto
            {
                FirstName = "Mohsen",
                LastName = "Farokhi",
            };

            service.ResigterPerson(request: expected);

            _callNumbers.Should().Be(1);
            _savedPerson.FirstName.Should().Be(expected.FirstName);
            _savedPerson.LastName.Should().Be(expected.LastName);

        }
    }
}
