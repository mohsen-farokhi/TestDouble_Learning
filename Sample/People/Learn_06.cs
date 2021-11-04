using Sample.Logging;

namespace Sample.People.Learn_06
{
    public interface IPersonRepositoy
    {
        void Insert(Person person);
    }

    public class PersonService
    {
        private readonly IPersonRepositoy _personRepositoy;
        private readonly ILogger _logger;

        public PersonService
            (IPersonRepositoy personRepositoy,
            ILogger logger)
        {
            _personRepositoy = personRepositoy;
            _logger = logger;
        }

        public void ResigterPerson(string firstName, string lastName)
        {
            _personRepositoy.Insert(new Person(firstName, lastName));

            _logger.Info(message: "Registered Successfully");
        }
    }

}
