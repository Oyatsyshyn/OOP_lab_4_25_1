using System;

namespace OOP_lab_4_25_1
{
    public class Student
    {
        private string _name;
        private string _lastName;
        private string _group;
        private int _year;
        private string _adress;
        private string _passport;
        private int _age;
        private string _telephon;
        private int _rating;
      
        public string Passport
        {
            get { return _passport; }
            set { _passport = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public string Telephon
        {
            get { return _telephon; }
            set { _telephon = value; }
        }
        public int Rating
        {
            get { return _rating; }
            set { _rating = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string Group
        {
            get { return _group; }
            set { _group = value; }
        }
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }
        public string Adress
        {
            get { return _adress; }
            set { _adress = value; }
        }

        public Student()
        {
            _name = "Владислав";
            _lastName = "Проданик";
            _group = "IТ-12";
            _year = 2019;
            _adress = "Товсте";
            _passport = "00000000000";
            _age = 17;
            _telephon = "+380680595513";
            _rating = 57;
        }

        public static string StudentRating(int R)
        {
            if (R >= 90)
            {
                return "Вiтаємо вiдмiнника!";
            }

            if ((R >= 75) && (R < 90))
            {
                return "Можна вчитися краще!";
            }
            
            if (R < 75)
            {
                return "Варто бiльше уваги придiляти навчанню!";
            }

            return "";
        }
    }
    
}
