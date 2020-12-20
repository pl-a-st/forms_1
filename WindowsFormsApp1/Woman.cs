using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Женщина
    /// </summary>
    class Woman:Human
    {
        /// <summary>
        ////Вес
        /// </summary>
        public int Weight
        { get; private set; }
        /// <summary>
        /// Длина волос
        /// </summary>
        public int HairLength
        { get; private set; }
        /// <summary>
        /// Добавляем женщину
        /// </summary>
        /// <param name="weight">Вес</param>
        /// <param name="hairLength">Длина волос</param>
        /// <param name="name">Имя</param>
        /// <param name="lastName">Фамилия</param>
        /// <param name="middleName">Отчество</param>
        /// <param name="age">Возраст</param>
        Woman(int weight, int hairLength, string name, string lastName, string middleName, int age)
        {
            Weight = weight;
            HairLength = hairLength;
            Name = name;
            LastName = lastName;
            MiddleName = middleName;
            Age = age;
            Gender = Gender.Female;
        }

    }
}
