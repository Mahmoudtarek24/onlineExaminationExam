using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineExaminationExam
{
	internal class FinalExam :Exam
	{
		 public FinalExam()
		 {
			StudentAnswer = new List<int>();
		 }

		public override void ShowStududentAnswearOrDegree(int NumberOfQuestions, List<Question> questions)
		{
			int grade = 0;
			int totalgrade = 0;

			for (var i = 0; i < NumberOfQuestions; i++)
			{
				if (questions[i].RightAnswer == StudentAnswer[i])
				{
					//Console.WriteLine("true");
					grade += questions[i].Mark;
				}

				totalgrade += questions[i].Mark;
				Console.WriteLine($"Your Grade is : {grade} from {totalgrade} ");
			
			}
			DateTime endTime = DateTime.Now;
			TimeSpan elapsedTime = endTime - startTime;
			Console.WriteLine($"Time taken: {elapsedTime.Minutes} seconds");
		}
	}
}
