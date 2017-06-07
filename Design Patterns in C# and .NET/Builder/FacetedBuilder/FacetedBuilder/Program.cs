using System;

namespace FacetedBuilder
{
    class Person
    {
        //address
        public string StreetAdress, Postcode, City;

        //employment
        public string CompanyName, Position;
        public int AnnualIncome;

        public override string ToString()
        {
            return $"{nameof(StreetAdress)}: {StreetAdress}, {nameof(Postcode)}: {Postcode}, {nameof(City)}: {City}, " +
                $"{nameof(CompanyName)}: {CompanyName}, {nameof(Position)}: {Position}, {nameof(AnnualIncome)}: {AnnualIncome},";
        }
    }

    class PersonBuilder
    {
        protected Person person = new Person();

        public PersonJobBuilder Works => new PersonJobBuilder(person);
        public PersonAdressBuilder Lives => new PersonAdressBuilder(person);

        public static implicit operator Person(PersonBuilder pb)
        {
            return pb.person;
        }
    }

    class PersonJobBuilder : PersonBuilder
    {
        public PersonJobBuilder(Person person)
        {
            this.person = person;
        }

        public PersonJobBuilder At(string companyName)
        {
            person.CompanyName = companyName;
            return this;
        }

        public PersonJobBuilder AsA(string position)
        {
            person.Position = position;
            return this;
        }

        public PersonJobBuilder Earning(int amount)
        {
            person.AnnualIncome = amount;
            return this;
        }
    }

    class PersonAdressBuilder : PersonBuilder
    {
        public PersonAdressBuilder(Person person)
        {
            this.person = person;
        }

        public PersonAdressBuilder At(string companyName)
        {
            person.CompanyName = companyName;
            return this;
        }

        public PersonAdressBuilder WithPostcode(string Postcode)
        {
            person.Postcode = Postcode;
            return this;
        }

        public PersonAdressBuilder In(string city)
        {
            person.City = city;
            return this;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var pb = new PersonBuilder();
            Person person = pb
                .Lives.At("Avenida de Cillos")
                    .WithPostcode("13450041")
                    .In("Santa Barbara")
                .Works.At("Indra")
                    .AsA("Developer")
                    .Earning(27300);

            Console.WriteLine(person);
            Console.ReadKey();
        }
    }
}