namespace MyLibrary
{
    public class ExamAdapter : IAdapter<Exam, ExamDTO>
    {
        public ExamDTO ConvertToDTO(Exam model) => new ExamDTO()
        {
            Title = model.Title,
            Date = model.Date,
            Grade = model.Grade
        };

        public Exam ConvertToModel(ExamDTO dto) => new Exam(dto.Title, dto.Date, dto.Grade);
    }
}
