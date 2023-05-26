using HotelRoomReservationSystem.Models;
using HotelRoomReservationSystem.Repositories.EmployeeServices;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelRoomReservationSystem.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployee emp;
        public EmployeesController(IEmployee emp)
        {
            this.emp = emp;
        }
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return emp.GetEmployees();
        }

        [HttpGet("{id}")]
        public Employee GetById(int id)
        {
            return emp.GetEmployeesById(id);
        }

        [HttpPost]
        public Employee PostEmployee(Employee employee)
        {
            return emp.PostEmployee(employee);
        }
        [HttpPut("{id}")]
        public Employee PutEmployee(int id, Employee employee)
        {
            return emp.PutEmployee(id, employee);
        }
        [HttpDelete("{id}")]
        public Employee DeleteEmployee(int id)
        {
            return emp.DeleteEmployee(id);
        }



    }
}
