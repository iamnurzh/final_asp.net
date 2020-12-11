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
    public class TestStudentService
    {
        [Fact]
        public async Task GetStudentsTest()
        {
            var students = new List<Student>
            {
                new Student() { ID = 1},
                new Student() { LastName = "Nauryzbayev" },
                new Student() { FirstMidName = "Nurzh" },
            };

            var fakeRepositoryMock = new Mock<IStudentRepository>();
            fakeRepositoryMock.Setup(x => x.GetAll()).ReturnsAsync(students);


            var studentService = new StudentService(fakeRepositoryMock.Object);

            var resultStudents = await studentService.GetStudents();

            Assert.Collection(resultStudents, student =>
            {
                Assert.Equal(1, student.ID);
            },
            student =>
            {
                Assert.Equal("Nauryzbayev", student.LastName);
            },
            student =>
            {
                Assert.Equal("Nurzh", student.FirstMidName);
            });
        }

    }
}
