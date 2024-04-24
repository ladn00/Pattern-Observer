using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Паттерн_Наблюдателя
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            WeatherData wd = new WeatherData();
            wd.SetMeasurements(-55.5f, 101, 1000, "Сильная");

            //  Добавление наблюдателей
            CurrentConditionDisplay ccd = new CurrentConditionDisplay(wd);
            ThirdPartyDisplay thrd = new ThirdPartyDisplay(wd);
            StatisticsDisplay stat = new StatisticsDisplay(wd);

            wd.NotifyObservers();

            wd.RemoveObserver(stat);

            wd.NotifyObservers(); // Вывод после удаления статистики
            
        }
    }
}
