namespace MoqDemo.DatabaseMock
{
    public class EmployeeService
    {
        private readonly IEmployeeRepository repository;

        public EmployeeService(IEmployeeRepository repository)
        {
            this.repository = repository;
        }

        public string GetEmployee(int id)
        {
            return repository.GetEmployeeName(id);
        }
    }
}
