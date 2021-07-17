using System;
using System.Linq;
using System.Collections.Generic;
	
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

        public IQueryable<Course> Search(string keyword)
        {
            var data = this.All();

            if (!String.IsNullOrEmpty(keyword))
            {
                data = data.Where(p => p.Title.Contains(keyword) && p.Credits > 1);
            }

            data = data.OrderByDescending(p => p.Credits);

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