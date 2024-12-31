using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineExaminationExam
{
	internal class Question
	{
		public virtual string Header { get; set; }	
		public string Body { get; set; }	
		public int RightAnswer { get; set; }	

		public int Mark { get; set; }	
		public Answer[] answerList { get; set; }        //for multiChooseExam

		public Question() {
		//answerList= new Answer[0];		
		}	
		public virtual Question CreateQuestion(Question questionType)
		{
			return questionType;
		}
	}
	internal class Answer
	{
		public string answerText { get; set; }	
		//public int RightAnswear { get; set; }	
		public Answer() { 
		answerText= string.Empty;
		}	
	}
}
