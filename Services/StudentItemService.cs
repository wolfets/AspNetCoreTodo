using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreTodo.Models.DB;

namespace AspNetCoreTodo.Services
{
    public class StudentItemService : IStudentItemService
    {
        private List<Student> _liste = null;
        public List<Student> Liste
        {
            get
            {
                if (_liste == null)
                {
                    Liste = new List<Student>
                    {
                        new Student{Id = Guid.NewGuid(), LastName = "nom1"},
                        new Student{Id = Guid.NewGuid(), LastName = "nom2"},
                        new Student{Id = Guid.NewGuid(), LastName = "nom3"}
                    };
                }
                return _liste;
            }
            set
            {
                _liste = value;
            }
        }

        Task<bool> IStudentItemService.addAsync(Student student)
        {
            try
            {
                if (student != null)
                {
                    student.Id = Guid.NewGuid();
                    Liste.Add(student);
                }
                return Task.FromResult(true);
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.Message);
            }
        }

        Task<bool> IStudentItemService.delByIdAsync(Guid Id)
        {
            try
            {
                Student item = Liste.Where(s => s.Id == Id).SingleOrDefault();
                if(item!= null)
                    Liste.Remove(item);
                return Task.FromResult(true);
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.Message);
            }
        }

        Task<Student[]> IStudentItemService.getAllAsync()
        {
            try
            {
                return Task.FromResult(Liste.ToArray());
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.Message);
            }
        }

        Task<Student> IStudentItemService.getByIdAsync(Guid id)
        {
            try
            {
                return Task.FromResult(Liste.Where(s=>s.Id == id).SingleOrDefault());
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.Message);
            }
        }

        Task<bool> IStudentItemService.updateByIdAsync(Student student)
        {
            try
            {
                if (student != null)
                {
                    Student item = Liste.Where(s => s.Id == student.Id).SingleOrDefault();
                    if (item != null)
                        Liste[Liste.IndexOf(item)] = student;

                    return Task.FromResult(true);
                }
                return Task.FromResult(true);
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.Message);
            }
        }
    }
}
