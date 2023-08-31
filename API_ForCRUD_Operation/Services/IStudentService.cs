using API_ForCRUD_Operation.Models;

namespace API_ForCRUD_Operation.Services
{
    public interface IStudentService
    {
        Task<MainResponse> AddStudent(StudentDTO studentDTO);
        Task<MainResponse> UpdateStudent(UpdateStudentDTO studentDTO);
        Task<MainResponse> DeleteStudent(DeleteStudentDTO studentDTO);
        Task<MainResponse> GetAllStudent();
        Task<MainResponse> GetStudentByStudentID(int studentID);
    }
}
