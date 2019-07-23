using System.Collections.Generic;

namespace Students.BusinessLogic
{
    public interface IStudentRepository
    {
        Student Create(Student student);

        void Update(int id, Student student);

        void Delete(int id);

        List<Student> GetAll();
    }
}