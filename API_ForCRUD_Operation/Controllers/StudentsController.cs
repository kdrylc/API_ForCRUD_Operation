using API_ForCRUD_Operation.Models;
using API_ForCRUD_Operation.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_ForCRUD_Operation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {

        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet("GetAllStudent")]
        public async Task<IActionResult> GetAllStudent()
        {
            try
            {
                var response = await _studentService.GetAllStudent();
                return Ok(response);
            }
            catch (Exception ex)
            {
                return ErrorResponse.ReturnErrorResponse(ex.Message);
            }
        }

        [HttpGet("GetStudentByStudentID/{StudentID}")]
        public async Task<IActionResult> GetStudentByStudentID(int StudentID)
        {
            try
            {
                var response = await _studentService.GetStudentByStudentID(StudentID);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return ErrorResponse.ReturnErrorResponse(ex.Message);
            }
        }


        [HttpPost("AddStudent")]
        public async Task<IActionResult> AddStudent([FromBody] StudentDTO studentInfo)
        {
            try
            {
                var response = await _studentService.AddStudent(studentInfo);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return ErrorResponse.ReturnErrorResponse(ex.Message);
            }

        }

        [HttpPost("UpdateStudent")]
        public async Task<IActionResult> UpdateStudent(UpdateStudentDTO studentInfo)
        {
            try
            {
                var response = await _studentService.UpdateStudent(studentInfo);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return ErrorResponse.ReturnErrorResponse(ex.Message);
            }

        }

        [HttpPost("DeleteStudent")]
        public async Task<IActionResult> DeleteStudent([FromBody]DeleteStudentDTO studentInfo)
        {
            try
            {
                var response = await _studentService.DeleteStudent(studentInfo);
                return Ok(response);

            }
            catch (Exception ex)
            {
                return ErrorResponse.ReturnErrorResponse(ex.Message);
            }

        }
    }
}
