using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{

    class Person
    {

        private string name;
        private string surname;
        private int age;
        private string gender;
        private string phoneNumber;

        public class Builder
        {
            private string name;
            private string surname;
            private int age;
            private string gender;
            private string phoneNumber;

            public Builder Name(string name)
            {
                this.name = name;
                return this;
            }

            public Builder Surname(string surname)
            {
                this.surname = surname;
                return this;
            }

            public Builder Age(int age)
            {
                this.age = age;
                return this;
            }

            public Builder Gender(string gender)
            {
                this.gender = gender;
                return this;
            }

            public Builder PhoneNumber(string phoneNumber)
            {
                this.phoneNumber = phoneNumber;
                return this;
            }

            public Person Build()
            {
                return new Person(name, surname, age, gender, phoneNumber);
            }
        }

        public Person(string name, string surname, int age, string gender, string phoneNumber)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.gender = gender;
            this.phoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            string output = "Person:\n\tname: {0}\n\tsurname: {1}\n\tage: {2}\n\tgender: {3}\n\tphone number: {4}\n";
            return String.Format(output, name, surname, age, gender, phoneNumber);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person.Builder()
                .Name("Jan")
                .Surname("Kowalski")
                .Age(40)
                .Gender("male")
                .PhoneNumber("123123123")
                .Build();

            Console.WriteLine(p1);
            Console.ReadLine();

        }
    }
}
