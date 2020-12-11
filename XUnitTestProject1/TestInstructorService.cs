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
    public class TestInstructorService
    {
        [Fact]
        public async Task GetInstructorsTest()
        {
            var instructors = new List<Instructor>
            {
                new Instructor() { ID = 1},
                new Instructor() { LastName = "Dauletbek" },
            };

            var fakeRepositoryMock = new Mock<IInstructorRepository>();
            fakeRepositoryMock.Setup(x => x.GetAll()).ReturnsAsync(instructors);


            var instructorService = new InstructorService(fakeRepositoryMock.Object);

            var resultInstructors = await instructorService.GetInstructors();

            Assert.Collection(resultInstructors, instructor =>
            {
                Assert.Equal(1, instructor.ID);
            },
            instructor =>
            {
                Assert.Equal("Dauletbek", instructor.LastName);
            });
        }
    }
}
