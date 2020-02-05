using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork_10
{
    enum Kind
    {
        Mouse,
        Cat,
        Dog
    }
    class Pet
    {
        private string _birthPlace;

        public Kind Kind;

        private char _sex;

        public string Name;

        public void SetBirthPlace



        public char Sex
        {
            get
            {
                return _sex;
            }
            set
            {
                if (value == 'F' || value == 'M' || value == 'f' || value == 'm')
                {
                    _sex = value;
                }
                else Console.WriteLine("Неизвестная буква или пол.");
            }
        }
        public int Age { get; set; }

        public string Description
        {
            get
            {
                return $"{Name} is a {Kind} ({Sex}) of {Age} years old.";
            }
        }
    }
}
