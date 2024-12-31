namespace onlineExaminationExam
{
	internal class Program
	{
		static void Main(string[] args)
		{
		    Subject subject=new Subject("c#");
			subject.CreateQuetions();
			subject.ShowExam();	
		}
	}
}