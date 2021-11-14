using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_1_demo
{
    sealed class Manager : Employee
    {
        public int RoomNumber { get; }

        private readonly int _backupRoomNumber;

        public int RoomNumberNewWay { get; init; }

        public Manager(string firstName, string lastName, int yearOfBirth, decimal salary, int roomNumber = 0):
            base(firstName, lastName, yearOfBirth, salary)
        {
            RoomNumber = roomNumber;
            _backupRoomNumber = roomNumber;
            Console.WriteLine("Wywołano konstruktor z parametrami z Manager");
        }

        //public void ChangeRoomNumber(int roomNumber)
        //{
        //    _backupRoomNumber = roomNumber;
        //    RoomNumber = roomNumber;
        //}

        protected override decimal GetSalary()
        {
            return Salary * 1.1m;
        }
    }

    //class Director : Manager
    //{

    //}
}
