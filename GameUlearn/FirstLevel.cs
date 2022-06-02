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
    /// <summary>
    /// Класс первого уровня
    /// </summary>
    public partial class FirstLevel : Form
    {
        private int index  = 1; //переменная для определения номера текущего вопроса
        private int count; //переменная счётчика для подсчёта баллов игрока
        /// <summary>
        /// Конструктор первого уровня
        /// </summary>
        public FirstLevel()
        {
            InitializeComponent();
        }
        /// <summary>
        /// метод обрабатывает нажатие на левую верхнюю кнопку (с первым вариантом ответа)
        /// </summary>
        /// <param name="sender">отправитель</param>
        /// <param name="e">событие</param>
        private void FirstAnswer_Click(object sender, EventArgs e)
        {
            //смотрим на номер вопроса и определяем правильный ответ для этого вопроса,
            //после чего прибавляем или вычитаем 5 баллов (для первого уровня)
            switch (index)
            {
                case 1:
                    count -= 5;
                    break;
                case 2:
                    count += 5;
                    break;
                case 3:
                    count -= 5;
                    break;
                case 4:
                    count -= 5;
                    break;
                case 5:
                    count -= 5;
                    break;
            }
            //если мы дошли до последнего вопроса на этом уровне, то открываем окно для второго уровня и закрываем данное окно
            if (index == 5)
            {
                Close();
                Dispose();
                SecondLevel sLevel = new SecondLevel(count, index); //счёт баллов продолжатся, поэтому мы передаём счётчик во второй уровень, как и номер вопроса
                sLevel.ShowDialog();
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
            //после чего прибавляем или вычитаем 5 баллов (для первого уровня)
            switch (index)
            {
                case 1:
                    count -= 5;
                    break;
                case 2:
                    count -= 5;
                    break;
                case 3:
                    count += 5;
                    break;
                case 4:
                    count -= 5;
                    break;
                case 5:
                    count -= 5;
                    break;

            }
            //если мы дошли до последнего вопроса на этом уровне, то открываем окно для второго уровня и закрываем данное окно
            if (index == 5)
            {
                Close();
                Dispose();
                SecondLevel sLevel = new SecondLevel(count, index); //счёт баллов продолжатся, поэтому мы передаём счётчик во второй уровень, как и номер вопроса
                sLevel.ShowDialog();
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
            //после чего прибавляем или вычитаем 5 баллов (для первого уровня)
            switch (index)
            {
                case 1:
                    count += 5;
                    break;
                case 2:
                    count -= 5;
                    break;
                case 3:
                    count -= 5;
                    break;
                case 4:
                    count += 5;
                    break;
                case 5:
                    count -= 5;
                    break;
            }
            //если мы дошли до последнего вопроса на этом уровне, то открываем окно для второго уровня и закрываем данное окно
            if (index == 5)
            {
                Close();
                Dispose();
                SecondLevel sLevel = new SecondLevel(count, index); //счёт баллов продолжатся, поэтому мы передаём счётчик во второй уровень, как и номер вопроса
                sLevel.ShowDialog();
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
            //после чего прибавляем или вычитаем 5 баллов (для первого уровня)
            switch (index)
            {
                case 1:
                    count -= 5;
                    break;
                case 2:
                    count -= 5;
                    break;
                case 3:
                    count -= 5;
                    break;
                case 4:
                    count -= 5;
                    break;
                case 5:
                    count += 5;
                    break;
            }
            //если мы дошли до последнего вопроса на этом уровне, то открываем окно для второго уровня и закрываем данное окно
            if (index == 5)
            {
                Close();
                Dispose();
                SecondLevel sLevel = new SecondLevel(count, index); //счёт баллов продолжатся, поэтому мы передаём счётчик во второй уровень, как и номер вопроса
                sLevel.ShowDialog();
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
        /// метод обрабатывает нажатие на кнопку "Выход"
        /// </summary>
        /// <param name="sender">отправитель</param>
        /// <param name="e">событие</param>
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close(); //закрываем это окно и возвращаемся на окно главного меню
        }
        /// <summary>
        /// метод обрабатывает нажатие на табличку с надписью "Первый уровень"
        /// </summary>
        /// <param name="sender">отправитель</param>
        /// <param name="e">событие</param>
        private void LevelLabel_Click(object sender, EventArgs e)
        {
            LevelLabel.Dispose(); //табличку(в формате картинки) убираем
        }
    }
}
