using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GameUlearn
{
    /// <summary>
    /// Класс вопросов для викторины и ответов на них
    /// </summary>
    static class Question
    {
        static public string[] questions = File.ReadAllLines("Questions.txt", Encoding.GetEncoding(1251)); //массив вопросов считываем из файла Questions.txt
        static public string[] answersFirstBtn = File.ReadAllLines("AnswersFirstBtn.txt", Encoding.GetEncoding(1251)); //массив ответов считываем из файла AnswersFirstBtn.txt
        static public string[] answersSecondBtn = File.ReadAllLines("AnswersSecondBtn.txt", Encoding.GetEncoding(1251)); //массив ответов считываем из файла AnswersSecondBtn.txt
        static public string[] answersThirdBtn = File.ReadAllLines("AnswersThirdBtn.txt", Encoding.GetEncoding(1251)); //массив ответов считываем из файла AnswersThirdBtn.txt
        static public string[] answersFourthBtn = File.ReadAllLines("AnswersFourthBtn.txt", Encoding.GetEncoding(1251)); //массив ответов считываем из файла AnswersFourthBtn.txt
    }
}

