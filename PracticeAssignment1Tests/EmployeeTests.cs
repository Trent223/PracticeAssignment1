using PracticeAssignment1;

namespace PracticeAssignment1Tests
{
    public class EmployeeTests
    {
        [Fact]
        public void CreateNewEmployeeTest()
        {
            //arrange & act
            var employee = new Employee();

            //assert
            Assert.NotNull(employee);
        }
    }
}