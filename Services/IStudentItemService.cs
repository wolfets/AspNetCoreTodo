﻿using AspNetCoreTodo.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTodo.Services
{
    public interface IStudentItemService
    {
        /// <summary>
        /// Get all 
        /// </summary>
        /// <returns></returns>
        Task<Student[]> getAllAsync();

        /// <summary>
        /// Get one by his Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task<Student> getByIdAsync(Guid Id);


        /// <summary>
        /// ajout a student
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task<bool> addAsync(Student student);

        /// <summary>
        /// update a student
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task<bool> updateByIdAsync(Student student);




        /// <summary>
        /// Delete a student
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task<bool> delByIdAsync(Guid Id);


    }
}
