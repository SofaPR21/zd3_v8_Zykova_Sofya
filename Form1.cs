using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zd3_v8_Zykova_Sofya
{
    public partial class Form1 : Form
    {
        //используем две разные коллекции: List и Dictionary
        private List<Car> carsList = new List<Car>();

        private Dictionary<string, Car> carsDict = new Dictionary<string, Car>();

        public Form1()
        {
            InitializeComponent();
        }

        //метод для очистки полей ввода
        private void ClearInputs()
        {
            txtMileage.Text = "";
            txtConsumption.Text = "";
            txtYear.Text = "";
            txtModel.Text = "";
            txtVIN.Text = "";
            chkEcoFriendly.Checked = false;
        }

        //метод для обновления списка машин
        private void UpdateCarList()
        {
            listBoxCars.Items.Clear();

            //используем LINQ для сортировки коллекции в убывающем порядке
            var sortedCars = from car in carsList //перебираем каждый элемент в коллекции
                             orderby car.CalculateQ() descending //сортируем элементы по результату
                             select car; //возвращаем объект

            foreach (var car in sortedCars)
            {
                listBoxCars.Items.Add(car.GetInfo());
            }

            //обновляем статистику
            UpdateStatistics();
        }

        //метод для обновления статистики
        private void UpdateStatistics()
        {
            if (carsList.Count == 0) return;

            //используем LINQ для вычисления статистики
            double avgQ = carsList.Average(c => c.CalculateQ()); //среднее значение
            double maxQ = carsList.Max(c => c.CalculateQ()); //макисмальное значение
            double minQ = carsList.Min(c => c.CalculateQ()); //макимальное значение

            lblStats.Text = $"Всего машин: {carsList.Count} | Среднее Q: {avgQ:F2} | Макс Q: {maxQ:F2} | Мин Q: {minQ:F2}";
        }

        //метод для добавления машины (перегрузка 1 - базовый класс)
        private void AddCar(Car car)
        {
            if (carsDict.ContainsKey(car.VIN))
            {
                MessageBox.Show($"Машина с VIN '{car.VIN}' уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            carsList.Add(car);
            carsDict.Add(car.VIN, car);
            UpdateCarList();
        }

        //метод для добавления машины (перегрузка 2)
        private void AddCar(int mileage, double fuelConsumption, int year, string model, string vin, bool isImproved = false, bool isEcoFriendly = false)
        {
            if (carsDict.ContainsKey(vin))
            {
                MessageBox.Show($"Машина с VIN '{vin}' уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Car car;
            if (isImproved)
            {
                car = new NasledCar(mileage, fuelConsumption, year, model, vin, isEcoFriendly);
            }
            else
            {
                car = new Car(mileage, fuelConsumption, year, model, vin);
            }

            AddCar(car);
        }

        //метод для удаления машины (перегрузка 1 - по индексу)
        private void RemoveCar(int index)
        {
            if (index >= 0 && index < carsList.Count)
            {
                var car = carsList[index];
                carsList.RemoveAt(index);
                carsDict.Remove(car.VIN);
                UpdateCarList();
            }
        }

        //метод для удаления машины (перегрузка 2 - по VIN)
        private void RemoveCar(string vin)
        {
            if (carsDict.ContainsKey(vin))
            {
                var car = carsDict[vin];
                carsList.Remove(car);
                carsDict.Remove(vin);
                UpdateCarList();
            }
        }

        //кнопка добавления обычной машины
        private void btnAddRegular_Click(object sender, EventArgs e)
        {
            //проверка на пустые поля
            if (string.IsNullOrEmpty(txtMileage.Text) || string.IsNullOrEmpty(txtConsumption.Text) ||
                string.IsNullOrEmpty(txtYear.Text) || string.IsNullOrEmpty(txtModel.Text) ||
                string.IsNullOrEmpty(txtVIN.Text))
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (!Car.ValidateInputs(txtMileage.Text, txtConsumption.Text, txtYear.Text, txtModel.Text, txtVIN.Text,
            out int mileage, out double consumption, out int year, out string errorMessage))
            {
                MessageBox.Show(errorMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (carsDict.ContainsKey(txtVIN.Text))
            {
                MessageBox.Show($"Машина с VIN '{txtVIN.Text}' уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AddCar(mileage, consumption, year, txtModel.Text, txtVIN.Text);
            ClearInputs();
        }

        //кнопка добавления улучшенной машины
        private void btnAddImproved_Click(object sender, EventArgs e)
        {
            //проверка на пустые поля
            if (string.IsNullOrEmpty(txtMileage.Text) || string.IsNullOrEmpty(txtConsumption.Text) ||
                string.IsNullOrEmpty(txtYear.Text) || string.IsNullOrEmpty(txtModel.Text) ||
                string.IsNullOrEmpty(txtVIN.Text))
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Car.ValidateInputs(txtMileage.Text, txtConsumption.Text, txtYear.Text, txtModel.Text, txtVIN.Text,
            out int mileage, out double consumption, out int year, out string errorMessage))
            {
                MessageBox.Show(errorMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (carsDict.ContainsKey(txtVIN.Text))
            {
                MessageBox.Show($"Машина с VIN '{txtVIN.Text}' уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isEco = chkEcoFriendly.Checked;
            AddCar(mileage, consumption, year, txtModel.Text, txtVIN.Text, true, isEco);
            ClearInputs();
        }

        //поиск машины по модели
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (listBoxCars.Items.Count != 0)
            {
                string searchTerm = txtSearch.Text.ToLower();
                if (!string.IsNullOrEmpty(searchTerm))
                {
                    //используем LINQ для поиска модели без учета регистра и сортируем элементы по убыванию
                    var results = carsList.Where(c => c.Model.ToLower().Contains(searchTerm))
                                           .OrderByDescending(c => c.CalculateQ());

                    listBoxCars.Items.Clear();
                    foreach (var car in results)
                    {
                        listBoxCars.Items.Add(car.GetInfo());
                    }
                }
                else
                {
                    UpdateCarList();
                }
            }
            else
            {
                MessageBox.Show($"Список пуст! Добавьте машины.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //удаление машины по выбору
        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            if (listBoxCars.SelectedIndex != -1)
            {
                RemoveCar(listBoxCars.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Выберите машину для удаления", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //удаление машины по VIN
        private void btnRemoveByVIN_Click(object sender, EventArgs e)
        {
            string vin = txtVINToRemove.Text;
            if (!string.IsNullOrEmpty(vin))
            {
                RemoveCar(vin);
                txtVINToRemove.Text = "";
            }
            else
            {
                MessageBox.Show("Введите VIN машины", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
