using System;
using MVVMDemo.MVVM.Models;

namespace MVVMDemo.MVVM.ViewModels
{
	public class PersonViewModel
	{
        public Person Person { get; set; }
		public PersonViewModel()
		{
            Person = new Person
            {
                Name = "HogeHogeさん",
                Age = 82,
                Married = true,
                BirthDate = new DateTime(2000, 01, 01),
                Weight = 100,
                LunchTime = new TimeSpan(10,5,0) 
            };

        }
	}
}

