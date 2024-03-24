using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_1
{
    class Angle
    {
        int grade;
        int minute;
        int second;
        public int Grade { get; set; }
        
        public int Minute
        { get 
            { 
                return minute; 
            } 
          set 
            {
                Grade += value / 60;
                minute = value % 60;
            } 
        }
        public int Second
        {
            get
            {
                return second;
            }
            set
            {
                Minute += value / 60;
                second = value % 60;
            }
        }
        public Angle(int grade, int minute, int second)
        {
            this.grade = grade;
            this.minute = minute;
            this.second = second;
        }

        public double ToRadian()
        {
            return ((grade + (double) minute / 60 + (double)second / 3600) * (Math.PI)) / 180;
        }

    }
}
