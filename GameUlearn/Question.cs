using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GameUlearn
{
    /// <summary>
    /// ����� �������� ��� ��������� � ������� �� ���
    /// </summary>
    static class Question
    {
        static public string[] questions = File.ReadAllLines("Questions.txt", Encoding.GetEncoding(1251)); //������ �������� ��������� �� ����� Questions.txt
        static public string[] answersFirstBtn = File.ReadAllLines("AnswersFirstBtn.txt", Encoding.GetEncoding(1251)); //������ ������� ��������� �� ����� AnswersFirstBtn.txt
        static public string[] answersSecondBtn = File.ReadAllLines("AnswersSecondBtn.txt", Encoding.GetEncoding(1251)); //������ ������� ��������� �� ����� AnswersSecondBtn.txt
        static public string[] answersThirdBtn = File.ReadAllLines("AnswersThirdBtn.txt", Encoding.GetEncoding(1251)); //������ ������� ��������� �� ����� AnswersThirdBtn.txt
        static public string[] answersFourthBtn = File.ReadAllLines("AnswersFourthBtn.txt", Encoding.GetEncoding(1251)); //������ ������� ��������� �� ����� AnswersFourthBtn.txt
    }
}

