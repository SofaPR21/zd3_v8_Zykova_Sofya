using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd3_v8_Zykova_Sofya
{
    public class NasledCar : Car
    {
        //доп поле для класса-потомка
        public bool IsEcoFriendly { get; set; }

        //конструктор класса-потомка
        public NasledCar(int mileage, double fuelConsumption, int year, string model, string vin, bool isEcoFriendly) : base(mileage, fuelConsumption, year, model, vin)
        {
            IsEcoFriendly = isEcoFriendly;
        }

        //переопределенный метод расчета качества Qp
        public override double CalculateQ()
        {
            //Qp = Q * 1.15 * год выпуска
            double baseQ = base.CalculateQ();
            return baseQ * 1.15 * Year;
        }

        //переопределенный метод вывода информации
        public override string GetInfo()
        {
            return base.GetInfo() + $", Qp: {CalculateQ():F2}, Экологичный: {(IsEcoFriendly ? "Да" : "Нет")}";
        }
    }
}
