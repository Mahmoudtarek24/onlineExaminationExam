using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineExaminationExam
{
	internal class Parctice : Exam
	{
		public Parctice()
		{
			StudentAnswer = new List<int>();
		}
		public override void ShowStududentAnswearOrDegree(int NumberOfQuestions, List<Question> questions)
		{
			Console.WriteLine("Your Answers:");


			for (var i = 0; i < NumberOfQuestions; i++)
			{
				Console.Write($"Q{i + 1}     {questions[i].Body} :   ");
				if (questions[i].RightAnswer == StudentAnswer[i])
				{
					Console.WriteLine("true");
				}
				else
				{
					Console.WriteLine("false");
				}

				DateTime endTime = DateTime.Now;
				TimeSpan elapsedTime = endTime - startTime;
				Console.WriteLine($"Time taken: {elapsedTime.TotalSeconds} seconds");

			}
		}
	}
	
}
