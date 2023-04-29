using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Class1
    {
        private string _surname;
        private int _curs;
        private int _bal;
        public Class1() //конструктор по умолчанию
        {

        }

        public Class1(string surname, int curs, int bal) //конструктор с параметрами
        {
            _surname = surname;
            _curs = curs;
            _bal = bal;
        }
        public string GetSurname()
        {
            return _surname;
        }

        public void SetSurname(string surname)
        {
            _surname = surname;
        }
        public int GetCurs()
        {
            return _curs;
        }

        public void SetCurs(int curs)
        {
            _curs = curs;
        }

        public int GetBal()
        {
            return _bal;
        }

        public void SetBal(int bal)
        {
            _bal = bal;
        }
        public virtual double QualityOfStudent() //функция, которая определяет качество объекта по заданной формуле для класса 1-го уровня
        {
            double quality = 0.2 * GetCurs() * GetBal();
            return quality;
        }
        public virtual string MakeStr() // возвращает строку для вывода в листбокс класса 1-го уровня
        {
            return "Фамилия: " + GetSurname() + ", Курс: " + GetCurs() + ", Средний бал: " + GetBal();
        }
    }
}
