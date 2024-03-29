﻿using Sample.Logging;

namespace Sample.People.Learn_05
{
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

        public void ResigterPerson(ResigterPersonDto request)
        {
            var person = new Person(request.FirstName, request.LastName);

            _personRepositoy.Insert(person);

            _logger.Info(message: "Registered Successfully");
        }
    }

}
