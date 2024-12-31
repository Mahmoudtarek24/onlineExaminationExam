using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineExaminationExam
{
	internal class TrueFalseQuestion :Question
	{
		public override string Header { get => "True | False Qusetion"; }

		public override Question CreateQuestion(Question trueFalseQ)
		{
			Console.WriteLine(Header);
			do {
				Console.WriteLine("Please Enter The Body of Question");
				trueFalseQ.Body = Console.ReadLine();
			} while (string.IsNullOrEmpty(trueFalseQ.Body));

			int mark;
			do
			{
				Console.WriteLine("Please Enter The Marks of Question");
			} while (!int.TryParse(Console.ReadLine(),out mark));
			trueFalseQ.Mark= mark;

			int answer;
			do
			{
				Console.WriteLine("Please Enter The Right Answer of Question (1 for True and 2 for False):");
			} while (!int.TryParse(Console.ReadLine(), out answer));
			trueFalseQ.RightAnswer= answer;	

			return trueFalseQ;	
		}
	}
}
