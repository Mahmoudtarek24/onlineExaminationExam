using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace onlineExaminationExam
{
	internal class Subject
	{
		public string subjectName { get; set; }
		public List<Question> questionsList;
		public Exam exam { get; set; }
		int TypeOfExam, TimeOfExam, NumberOfQuestions, typeOfQuestion;
		public Subject(string subject)
		{
			this.subjectName = subject;
			questionsList = new List<Question>();

		}
		public void CreateQuetions()
		{
			Console.WriteLine($"Creating Exam for : {subjectName}");
			do
			{
				Console.Write("Please Enter The Number Of Questions You Wanted To Create: ");

			} while (!int.TryParse(Console.ReadLine(), out NumberOfQuestions));

			do
			{
				Console.Write("Please Enter The Time Of Exam in Miuntes: ");
			} while (!int.TryParse(Console.ReadLine(), out TimeOfExam));

			
			Console.Clear();

			for (int i = 0; i < NumberOfQuestions; i++)
			{
				do
				{
					Console.WriteLine($"Please Choose The Type Of Question Number({i + 1}) (1 for True Or False || 2 For Mcq) ");
				} while (!int.TryParse(Console.ReadLine(), out typeOfQuestion));

				Console.Clear();

				if (typeOfQuestion == 1)
				{
					TrueFalseQuestion tFQuestion = new TrueFalseQuestion();
					var QuestionOfTF = tFQuestion.CreateQuestion(tFQuestion);
					questionsList.Add(QuestionOfTF);
					Console.Clear();
				}
				else
				{
					ChooseOne mCQ = new ChooseOne();
					Console.WriteLine("Choose One Answer Question");
					var QuestionOfChooseOne = mCQ.CreateQuestion(mCQ);
					questionsList.Add(QuestionOfChooseOne);
					Console.Clear();
				}
			}

		}
		public void ShowExam()
		{
			Console.WriteLine($"Creating Exam for : {subjectName}");
			do
			{
				Console.Write("Please Enter The Type Of Exam You Want To Create (1 for Practical and 2 for Final): ");
			} while (!int.TryParse(Console.ReadLine(), out TypeOfExam));

			//DateTime startTime = DateTime.Now; // Record the start time
			//TimeSpan duration = TimeSpan.FromMinutes(1); // Set the duration to 2 minutes

			//while (DateTime.Now - startTime < duration)
			//{
				if (TypeOfExam == 1)
				{
					exam = new FinalExam();
					exam.ShowExam(questionsList);
					exam.ShowStududentAnswearOrDegree(NumberOfQuestions, questionsList);
				}
				else
				{
					exam = new Parctice();
					exam.ShowExam(questionsList);
					exam.ShowStududentAnswearOrDegree(NumberOfQuestions, questionsList);
				}

			//}
			
		}
		
	}
}