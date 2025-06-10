using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd3_v8_Zykova_Sofya
{
    public class Car
    {
        public int Mileage { get; set; }    //пробег(км)
        public double FuelConsumption { get; set; } //расход топлива на км(л/км)
        public int Year { get; set; }       //год выпуска(доп поле P)
        public string Model { get; set; }   //модель машины(доп поле 1)
        public string VIN { get; set; }     //идентификационный номер(доп поле 2)

        //конструктор базового класса
        public Car(int mileage, double fuelConsumption, int year, string model, string vin)
        {
            Mileage = mileage;
            FuelConsumption = fuelConsumption;
            Year = year;
            Model = model;
            VIN = vin;
        }

        //метод для расчета качества Q
        public virtual double CalculateQ()
        {
            //Q = пробег / расход на км
            return FuelConsumption != 0 ? Mileage / FuelConsumption : 0;  //проверку деления на ноль
        }

        //метод для вывода информации об объекте
        public virtual string GetInfo()
        {
            return $"Модель: {Model}, Пробег: {Mileage} км, Расход: {FuelConsumption} л/км, Год: {Year}, VIN: {VIN}, Q: {CalculateQ():F2}";
        }

        public static bool ValidateInputs(string mileageStr, string consumptionStr, string yearStr, string model, string vin, out int mileage, out double consumption,
        out int year, out string errorMessage)
        {
            mileage = 0;
            consumption = 0;
            year = 0;
            errorMessage = "";

            //Проверка модели
            if (string.IsNullOrEmpty(model))
            {
                errorMessage = "Модель не может быть пустой!";
                return false;
            }

            //Проверка VIN
            if (string.IsNullOrEmpty(vin))
            {
                errorMessage = "VIN не может быть пустым!";
                return false;
            }

            //Проверка пробега
            if (!int.TryParse(mileageStr, out mileage) || mileage < 0)
            {
                errorMessage = "Некорректный пробег! Введите целое положительное число.";
                return false;
            }

            //Проверка расхода
            if (!double.TryParse(consumptionStr, out consumption) || consumption <= 0)
            {
                errorMessage = "Некорректный расход! Введите положительное число (например, 8.5).";
                return false;
            }

            //Проверка года
            if (!int.TryParse(yearStr, out year) || year < 1886 || year > DateTime.Now.Year + 1)
            {
                errorMessage = $"Некорректный год! Введите число между 1886 и {DateTime.Now.Year + 1}.";
                return false;
            }

            return true;
        }
       
    }
}
