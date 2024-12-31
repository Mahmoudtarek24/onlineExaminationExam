using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineExaminationExam
{
	internal class ChooseOne : Question
	{
	    public	ChooseOne()
		{

			answerList = new Answer[3];
			for (var i = 0; i < answerList.Length; i++)
			{
				answerList[i] = new Answer();
			}
		}
		public override string Header
		{
			get => "Choose One Answer Question";
		}
		public override Question CreateQuestion(Question MCQ)
		{
			Console.WriteLine(Header);
			do
			{
				Console.WriteLine("Please Enter The Body of Question");
				MCQ.Body = Console.ReadLine();
			} while (string.IsNullOrEmpty(MCQ.Body));


			int mark;
			do
			{
				Console.WriteLine("Please Enter The Marks of Question");
			} while (!int.TryParse(Console.ReadLine(), out mark));
			MCQ.Mark = mark;


			Console.WriteLine("The Choices Of Question:");
			for (int j = 0; j < 3; j++)
			{
				Console.Write($"Please Enter The Choice Number {j + 1}:");
				string answer = Console.ReadLine();
				MCQ.answerList[j].answerText = answer;
			}

			int rightChoice;
			do
			{
				Console.WriteLine("Please Specify The Right Choice of Question");
			} while (!int.TryParse(Console.ReadLine(), out rightChoice) || rightChoice < 1 || rightChoice > 3);
			MCQ.RightAnswer = rightChoice;

			return MCQ;
		}
	}
}

