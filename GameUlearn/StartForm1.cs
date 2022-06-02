using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameUlearn
{

    public partial class StartForm : Form
    {
        FirstLevel firstLevel = new FirstLevel(); //создаём форму для первого уровня
        /// <summary>
        /// Конструктор начальной формы
        /// </summary>
        public StartForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// метод обрабатывает нажатие на кнопку старта
        /// </summary>
        /// <param name="sender">отправитель</param>
        /// <param name="e">событие</param>
        private void StartBtn_Click(object sender, EventArgs e)
        {
            firstLevel.ShowDialog(); //открываем форму первого уровня
        }
        /// <summary>
        /// метод обрабатывает нажатие на кнопку выхода
        /// </summary>
        /// <param name="sender">отправитель</param>
        /// <param name="e">событие</param>
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close(); //закрываем приложение
        }
    }
}
