namespace Exam_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();
            subject.CreateExam(Exam.TypeOfExam());
        }
    }
}
