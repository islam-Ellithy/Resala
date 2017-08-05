using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResalaSystem
{
    class BaseInfo
    {
        public static resalaEntities1 rtc = new resalaEntities1();

        public static void DeleteCourse(String courseName)
        {
            var course = (from C in BaseInfo.rtc.courses
                          where C.course_name == courseName
                          select C).ToList<course>()[0];

            BaseInfo.rtc.courses.Remove(course);

            var questions = (from q in BaseInfo.rtc.questions
                             where q.course_id == course.id
                             select q).ToList();

            BaseInfo.rtc.questions.RemoveRange(questions);
            BaseInfo.rtc.SaveChanges();
            
        }


    }
}
