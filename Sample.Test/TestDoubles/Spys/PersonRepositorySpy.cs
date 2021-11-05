using Sample.People;

namespace Sample.Test.TestDoubles.Spys
{
    internal class PersonRepositorySpy : IPersonRepositoy
    {
        private Person _person;
        private int _callNumbers;

        public void Insert(Person person)
        {
            _person = person;

            _callNumbers++;
        }

        public Person GetSavedPerson()
        {
            return _person;
        }

        public int GetNumberOfSavedPerson()
        {
            return _callNumbers;
        }

    }
}
