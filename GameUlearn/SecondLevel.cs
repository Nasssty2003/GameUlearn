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
    /// Класс второго уровня
    /// </summary>
    public partial class SecondLevel : Form
    {
        private int index; //переменная для определения номера текущего вопроса
        private int count; //переменная счётчика для подсчёта баллов игрока

        public SecondLevel(int count, int index)
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
        /// <param name="e">событие</param
        private void FirstAnswer_Click(object sender, EventArgs e)
        {
            //смотрим на номер вопроса и определяем правильный ответ для этого вопроса,
            //после чего прибавляем или вычитаем 10 баллов (для второго уровня)
            switch (index)
            {
                case 5:
                    count -= 10;
                    break;
                case 6:
                    count -= 10;
                    break;
                case 7:
                    count += 10;
                    break;
                case 8:
                    count -= 10;
                    break;
                case 9:
                    count += 10;
                    break;
            }
            //если мы дошли до последнего вопроса на этом уровне, то открываем окно для третьего уровня и закрываем данное окно
            if (index == 9)
            {
                Close();
                Dispose();
                ThirdLevel tLevel = new ThirdLevel(count, index); //счёт баллов продолжатся, поэтому мы передаём счётчик во второй уровень
                tLevel.ShowDialog();
            }
            // после определения правильного ответа меняем вопрос и варианты ответа из заготовленных массивов
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

        private void SecondAnswer_Click(object sender, EventArgs e)
        {
            //смотрим на номер вопроса и определяем правильный ответ для этого вопроса,
            //после чего прибавляем или вычитаем 10 баллов (для второго уровня)
            switch (index)
            {
                case 5:
                    count -= 10;
                    break;
                case 6:
                    count += 10;
                    break;
                case 7:
                    count -= 10;
                    break;
                case 8:
                    count -= 10;
                    break;
                case 9:
                    count -= 10;
                    break;
            }
            //если мы дошли до последнего вопроса на этом уровне, то открываем окно для третьего уровня и закрываем данное окно
            if (index == 9)
            {
                Close();
                Dispose();
                ThirdLevel tLevel = new ThirdLevel(count, index); //счёт баллов продолжатся, поэтому мы передаём счётчик во второй уровень
                tLevel.ShowDialog();
            }
            // после определения правильного ответа меняем вопрос и варианты ответа из заготовленных массивов
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

        private void ThirdAnswer_Click(object sender, EventArgs e)
        {
            //смотрим на номер вопроса и определяем правильный ответ для этого вопроса,
            //после чего прибавляем или вычитаем 10 баллов (для второго уровня)
            switch (index)
            {
                case 5:
                    count -= 10;
                    break;
                case 6:
                    count -= 10;
                    break;
                case 7:
                    count -= 10;
                    break;
                case 8:
                    count -= 10;
                    break;
                case 9:
                    count -= 10;
                    break;
            }
            //если мы дошли до последнего вопроса на этом уровне, то открываем окно для третьего уровня и закрываем данное окно
            if (index == 9)
            {
                Close();
                Dispose();
                ThirdLevel tLevel = new ThirdLevel(count, index); //счёт баллов продолжатся, поэтому мы передаём счётчик во второй уровень
                tLevel.ShowDialog();
            }
            // после определения правильного ответа меняем вопрос и варианты ответа из заготовленных массивов
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

        private void FourthAnswer_Click(object sender, EventArgs e)
        {
            //смотрим на номер вопроса и определяем правильный ответ для этого вопроса,
            //после чего прибавляем или вычитаем 10 баллов (для второго уровня)
            switch (index)
            {
                case 5:
                    count += 10;
                    break;
                case 6:
                    count -= 10;
                    break;
                case 7:
                    count -= 10;
                    break;
                case 8:
                    count += 10;
                    break;
                case 9:
                    count -= 10;
                    break;
            }
            //если мы дошли до последнего вопроса на этом уровне, то открываем окно для третьего уровня и закрываем данное окно
            if (index == 9)
            {
                Close();
                Dispose();
                ThirdLevel tLevel = new ThirdLevel(count, index); //счёт баллов продолжатся, поэтому мы передаём счётчик во второй уровень
                tLevel.ShowDialog();
            }
            // после определения правильного ответа меняем вопрос и варианты ответа из заготовленных массивов
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
        /// <param name="e">событие</param>м
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
