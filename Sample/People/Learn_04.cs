namespace Sample.People.Learn_04
{

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
            var person = new Person(request.FirstName, request.LastName);

            _personRepositoy.Insert(person);
        }
    }

}
