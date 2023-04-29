using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Class2 : Class1
    {
        private Boolean _English=false;
        public Class2(string firm, int diagonal, int soundPower, int English) : base(firm, diagonal, soundPower) //конструктор
        {
            if(English>0)
            {
                _English = true;
            }
        }
        public Boolean GetEn()
        {
            return _English;
        }
        public override double QualityOfStudent()
        {
            double quality = base.QualityOfStudent();
            double qualityEd;
            if (_English == true)
            {
                qualityEd = 2 * quality;
            }
            else
            {
                qualityEd = 0.9 * quality;
            }
            return qualityEd;
        }
        public override string MakeStr() // возвращает строку для вывода в листбокс класса 2-го уровня
        {
            return base.MakeStr() + ", Английский: " + GetEn();
        }
    }
}
