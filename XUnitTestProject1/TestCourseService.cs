using final_asp.net.Models;
using final_asp.net.Repositories;
using final_asp.net.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace XUnitTestProject1
{
    public class TestCourseService
    {
        [Fact]
        public async Task GetCoursesTest()
        {
            var courses = new List<Course>
            {
                new Course() { CourseID = 1},
                new Course() { Title = "SDP" },
            };

            var fakeRepositoryMock = new Mock<ICourseRepository>();
            fakeRepositoryMock.Setup(x => x.GetAll()).ReturnsAsync(courses);


            var courseService = new CourseService(fakeRepositoryMock.Object);

            var resultCourses = await courseService.GetCourses();

            Assert.Collection(resultCourses, course =>
            {
                Assert.Equal(1, course.CourseID);
            },
            course =>
            {
                Assert.Equal("SDP", course.Title);
            });
        }

    }
}
