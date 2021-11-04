namespace Sample.People.Learn_05
{
    public interface IPersonRepositoy
    {
        void Insert(Person person);
    }

    public class PersonService
    {
        private readonly IPersonRepositoy _personRepositoy;

        public PersonService
            (IPersonRepositoy personRepositoy)
        {
            _personRepositoy = personRepositoy;
        }

        public void ResigterPerson(ResigterPersonDto request)
        {
            _personRepositoy.Insert
                (new Person(request.FirstName, request.LastName));
        }
    }

}
