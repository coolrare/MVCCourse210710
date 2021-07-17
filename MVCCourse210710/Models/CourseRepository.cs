using System;
using System.Linq;
using System.Collections.Generic;
using MVCCourse210710.ViewModels;
using EntityFramework.DynamicLinq;
using System.Data.Entity;
using System.Linq.Dynamic.Core;

namespace MVCCourse210710.Models
{   
	public  class CourseRepository : EFRepository<Course>, ICourseRepository
	{
        public override IQueryable<Course> All()
        {
            return base.All().Where(p => !p.IsDeleted);
        }

		public Course FindOne(int id)
        {
            return this.All().FirstOrDefault(p => p.CourseID == id);
        }

        public IQueryable<Course> Search(CourseFilter filter)
        {
            var data = this.All();

            if (!String.IsNullOrEmpty(filter.keyword))
            {
                data = data.Where(p => p.Title.Contains(filter.keyword));
            }
            
            data = data.OrderBy(filter.sortBy + " " + filter.sortDirection);

            return data;
        }

        public override void Delete(Course entity)
        {
            entity.IsDeleted = true;
        }

    }

    public  interface ICourseRepository : IRepository<Course>
	{

	}
}