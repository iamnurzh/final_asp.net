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
    public class TestDeparmentService
    {
        [Fact]
        public async Task GetDepartmentsTest()
        {
            var departments = new List<Department>
            {
                new Department() { DepartmentID = 1},
                new Department() { Name = "FIT" },
            };

            var fakeRepositoryMock = new Mock<IDepartmentRepository>();
            fakeRepositoryMock.Setup(x => x.GetAll()).ReturnsAsync(departments);


            var departmentService = new DepartmentService(fakeRepositoryMock.Object);

            var resultDepartments = await departmentService.GetDepartments();

            Assert.Collection(resultDepartments, department =>
            {
                Assert.Equal(1, department.DepartmentID);
            },
            department =>
            {
                Assert.Equal("FIT", department.Name);
            });
        }
    }
}
