using System;
namespace MVVMDemo.MVVM.ViewModels
{
	public class PeopleViewModel
	{
		public List<string> People { set; get; }

		public PeopleViewModel()
		{
			People = new List<string>
			{
				"Messi",
				"Mikey Musmeci",
				"Tye Luotro",
			};
		}
	}
}

