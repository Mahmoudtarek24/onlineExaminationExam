using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineExaminationExam
{
	internal abstract class Exam
	{
		public int TimeOfExam { get; set; }
		public int NumberOfQuestion { get; set; }
		public DateTime startTime { get; set; }	
		public List<int> StudentAnswer { get; set; }

		public virtual void ShowStududentAnswearOrDegree(int NumberOfQuestions, List<Question> questions) { }

		public void ShowExam(List<Question> questions)
		{
			startTime = DateTime.Now;

			foreach (var question in questions)
			{

				Console.WriteLine(question.Header);
				Console.WriteLine($"           {question.Mark} Mark");
				Console.WriteLine(question.Body);
				if (question.Header == "True | False Qusetion")
				{
					Console.WriteLine("1.True                            2. False");
				}
				else
				{
					for (var i = 0; i < question.answerList.Length; i++)
					{
						Console.WriteLine($"{i + 1}.{question.answerList[i].answerText}            ");
					}
				}
				Console.WriteLine("--------------------------------------------");
				int answer = Convert.ToInt32(Console.ReadLine());
				StudentAnswer.Add(answer);
			}
		}
	}
}
