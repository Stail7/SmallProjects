using System;

namespace AccessModifiers
{
    public class Person
    {
        //// Fields (first public fields -> private -> calculated)
        public string Name { get; set; }
        // auto-properties
        public DateTime Birthday { get; private set; }
        // private
        private DateTime _birthdate;

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthday;
                var years = timeSpan.Days / 365;
                return years;
            }
        }

        //// Constructors
        // for auto-properties
        public Person(DateTime birthday)
        {
            Birthday = birthday;
        }

        //// Methods
        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _birthdate;
        }
    }
}