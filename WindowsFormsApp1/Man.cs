using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Мужчина
    /// </summary>
     class Man:Human
    {
        /// <summary>
        /// Зарплата
        /// </summary>
        public int Salary
        { get; private set; }
        /// <summary>
        /// Рост
        /// </summary>
        public int Height
        { get; private set; }
        /// <summary>
        /// Добавляем мужчину
        /// </summary>
        /// <param name="salary">Зарплата</param>
        /// <param name="height">Рост</param>
        /// <param name="name">Имя</param>
        /// <param name="lastName">Фамилия</param>
        /// <param name="middleName">Отчество</param>
        /// <param name="age">Возраст</param>
        public Man(int salary, int height, string name, string lastName, string middleName, int age)
        {
            Salary = salary;
            Height = height;
            Name = name;
            LastName = lastName;
            MiddleName = middleName;
            Age = age;
            Gender = Gender.Male;
        }
    }
}
