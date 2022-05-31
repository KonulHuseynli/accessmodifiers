using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp66
{
    class Student
    {
        private int[] _grades;
        public int[] Grades
        {
            get
            {
                return _grades;
            }
            set
            {
                int count = 0;
                foreach (var item in value)
                {
                    if (item % 2 == 0)
                        count++;
                }
                int [] newArr = new int[count];
                int newArrIndex = 0;
                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] % 2 == 0)
                    {
                        newArr[newArrIndex] = value[i];
                        newArrIndex++;
                    }
                }
                _grades = newArr;
            }
        }
    }
}
