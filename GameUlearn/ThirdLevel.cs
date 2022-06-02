using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameUlearn
{
    /// <summary>
    /// Класс третьего уровня
    /// </summary>
    public partial class ThirdLevel : Form
    {
        private int index ; //переменная для определения номера текущего вопроса
        private int count; //переменная счётчика для подсчёта баллов игрока
        public int best = Int32.Parse(File.ReadAllText("BestResult.txt")); //переменная с лучшим результатом, считанная из файла
        /// <summary>
        /// Конструктор третьего уровня
        /// </summary>
        /// <param name="count">счёт</param>
        /// <param name="index">индекс для определения вопроса</param>
        public ThirdLevel(int count, int index)
        {
            InitializeComponent();
            //выводим на экран счётчик баллов за ответы, предварительно перенеся данные с первого уровня
            CountText.Text = "Счётчик: " + count.ToString();
            this.count = count;
            this.index = index;
        }
        /// <summary>
        /// метод обрабатывает нажатие на левую верхнюю кнопку (с первым вариантом ответа)
        /// </summary>
        /// <param name="sender">отправитель</param>
        /// <param name="e">событие</param>
        private void FirstAnswer_Click(object sender, EventArgs e)
        {
            //смотрим на номер вопроса и определяем правильный ответ для этого вопроса,
            //после чего прибавляем или вычитаем 20 баллов (для третьего уровня)
            switch (index)
            {
                case 9:
                    count -= 20;
                    break;
                case 10:
                    count -= 20;
                    break;
                case 11:
                    count += 20;
                    break;
                case 12:
                    count -= 20;
                    break;
                case 13:
                    count -= 20;
                    break;
            }
            //если мы дошли до последнего вопроса, то выводим результат и сравниваем его с лучшим
            if (index == 13)
            {
                CountText.Text = "Ваш результат: " + count;
                if (count > best)
                {
                    best = count;
                    File.WriteAllText("BestResult.txt", best.ToString());
                }
                QuestionLabel.Text = "Лучший результат: " + best;
            }
            //после определения правильного ответа меняем вопрос и варианты ответа из заготовленных массивов
            else
            {
                CountText.Text = "Счётчик: " + count; //также меняем показания счётчика, так как были начислены или отняты баллы
                QuestionLabel.Text = Question.questions[index - 1];
                FirstAnswer.Text = Question.answersFirstBtn[index - 1];
                SecondAnswer.Text = Question.answersSecondBtn[index - 1];
                ThirdAnswer.Text = Question.answersThirdBtn[index - 1];
                FourthAnswer.Text = Question.answersFourthBtn[index - 1];
                index += 1;
            }
        }
        /// <summary>
        /// метод обрабатывает нажатие на правую верхнюю кнопку (со вторым вариантом ответа)
        /// </summary>
        /// <param name="sender">отправитель</param>
        /// <param name="e">событие</param>
        private void SecondAnswer_Click(object sender, EventArgs e)
        {
            //смотрим на номер вопроса и определяем правильный ответ для этого вопроса,
            //после чего прибавляем или вычитаем 20 баллов (для третьего уровня)
            switch (index)
            {
                case 9:
                    count -= 20;
                    break;
                case 10:
                    count += 20;
                    break;
                case 11:
                    count -= 20;
                    break;
                case 12:
                    count -= 20;
                    break;
                case 13:
                    count -= 20;
                    break;
            }
            //если мы дошли до последнего вопроса, то выводим результат и сравниваем его с лучшим
            if (index == 13)
            {
                CountText.Text = "Ваш результат: " + count;
                if (count > best)
                {
                    best = count;
                    File.WriteAllText("BestResult.txt", best.ToString());
                }
                QuestionLabel.Text = "Лучший результат: " + best;
            }
            //после определения правильного ответа меняем вопрос и варианты ответа из заготовленных массивов
            else
            {
                CountText.Text = "Счётчик: " + count; //также меняем показания счётчика, так как были начислены или отняты баллы
                QuestionLabel.Text = Question.questions[index - 1];
                FirstAnswer.Text = Question.answersFirstBtn[index - 1];
                SecondAnswer.Text = Question.answersSecondBtn[index - 1];
                ThirdAnswer.Text = Question.answersThirdBtn[index - 1];
                FourthAnswer.Text = Question.answersFourthBtn[index - 1];
                index += 1;
            }
        }
        /// <summary>
        /// метод обрабатывает нажатие на левую нижнюю кнопку (с третьим вариантом ответа)
        /// </summary>
        /// <param name="sender">отправитель</param>
        /// <param name="e">событие</param>
        private void ThirdAnswer_Click(object sender, EventArgs e)
        {
            //смотрим на номер вопроса и определяем правильный ответ для этого вопроса,
            //после чего прибавляем или вычитаем 20 баллов (для третьего уровня)
            switch (index)
            {
                case 9:
                    count += 20;
                    break;
                case 10:
                    count -= 20;
                    break;
                case 11:
                    count -= 20;
                    break;
                case 12:
                    count += 20;
                    break;
                case 13:
                    count -= 20;
                    break;
            }
            //если мы дошли до последнего вопроса, то выводим результат и сравниваем его с лучшим
            if (index == 13)
            {
                CountText.Text = "Ваш результат: " + count;
                if (count > best)
                {
                    best = count;
                    File.WriteAllText("BestResult.txt", best.ToString());
                }
                QuestionLabel.Text = "Лучший результат: " + best;
            }
            //после определения правильного ответа меняем вопрос и варианты ответа из заготовленных массивов
            else
            {
                CountText.Text = "Счётчик: " + count; //также меняем показания счётчика, так как были начислены или отняты баллы
                QuestionLabel.Text = Question.questions[index - 1];
                FirstAnswer.Text = Question.answersFirstBtn[index - 1];
                SecondAnswer.Text = Question.answersSecondBtn[index - 1];
                ThirdAnswer.Text = Question.answersThirdBtn[index - 1];
                FourthAnswer.Text = Question.answersFourthBtn[index - 1];
                index += 1;
            }
        }
        /// <summary>
        /// метод обрабатывает нажатие на правую нижнюю кнопку (с четвёртым вариантом ответа)
        /// </summary>
        /// <param name="sender">отправитель</param>
        /// <param name="e">событие</param>
        private void FourthAnswer_Click(object sender, EventArgs e)
        {
            //смотрим на номер вопроса и определяем правильный ответ для этого вопроса,
            //после чего прибавляем или вычитаем 20 баллов (для третьего уровня)
            switch (index)
            {
                case 9:
                    count -= 20;
                    break;
                case 10:
                    count -= 20;
                    break;
                case 11:
                    count -= 20;
                    break;
                case 12:
                    count -= 20;
                    break;
                case 13:
                    count += 20;
                    break;
            }
            //если мы дошли до последнего вопроса, то выводим результат и сравниваем его с лучшим
            if (index == 13)
            {
                CountText.Text = "Ваш результат: " + count;
                if (count > best)
                {
                    best = count;
                    File.WriteAllText("BestResult.txt", best.ToString());
                }
                QuestionLabel.Text = "Лучший результат: " + best;
            }
            //после определения правильного ответа меняем вопрос и варианты ответа из заготовленных массивов
            else
            {
                CountText.Text = "Счётчик: " + count; //также меняем показания счётчика, так как были начислены или отняты баллы
                QuestionLabel.Text = Question.questions[index - 1];
                FirstAnswer.Text = Question.answersFirstBtn[index - 1];
                SecondAnswer.Text = Question.answersSecondBtn[index - 1];
                ThirdAnswer.Text = Question.answersThirdBtn[index - 1];
                FourthAnswer.Text = Question.answersFourthBtn[index - 1];
                index += 1;
            }
        }
        /// <summary>
        /// метод обрабатывает нажатие на кнопку выхода
        /// </summary>
        /// <param name="sender">отправитель</param>
        /// <param name="e">событие</param>
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close(); //закрываем это окно и возвращаемся на окно главного меню
        }
        /// <summary>
        /// метод обрабатывает нажатие на табличку с надписью "Второй уровень"
        /// </summary>
        /// <param name="sender">отправитель</param>
        /// <param name="e">событие</param>
        private void LevelLabel_Click(object sender, EventArgs e)
        {
            LevelLabel.Dispose(); //табличку(в формате картинки) убираем
        }
    }
}
