namespace MyLibrary
{
    public class PersonAdapter : IAdapter<Person, PersonDTO>
    {
        public PersonDTO ConvertToDTO(Person model) => new PersonDTO()
        {
            Name = model.Name,
            Surname = model.Surname,
            Birthday = model.Birthday
        };

        public Person ConvertToModel(PersonDTO dto) => new Person(dto.Name, dto.Surname, dto.Birthday);
    }
}
