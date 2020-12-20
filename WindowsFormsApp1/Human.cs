using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Пол
    /// </summary>
    enum Gender
    {
        Male,
        Female
    }
    /// <summary>
    /// Человек
    /// </summary>
     class Human
    {
        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName
        { get; protected set; }
        /// <summary>
        ////Имя
        /// </summary>
        public string Name
        { get; protected set; }
        /// <summary>
        /// Отчество
        /// </summary>
        public string MiddleName
        { get; protected set; }
        /// <summary>
        /// Возраст
        /// </summary>
        public int Age
        { get; protected set; }
        /// <summary>
        /// Пол
        /// </summary>
        public Gender Gender
        { get; protected set; }
        
    }
}
