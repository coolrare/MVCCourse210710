using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVCCourse210710.Models
{   
	public  class PersonRepository : EFRepository<Person>, IPersonRepository
	{

	}

	public  interface IPersonRepository : IRepository<Person>
	{

	}
}