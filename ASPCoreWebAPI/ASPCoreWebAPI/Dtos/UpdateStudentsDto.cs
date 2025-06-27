namespace ASPCoreWebAPI.Dtos
{
    public class UpdateStudentsDto
    {
        public required string Name { get; set; }
        public required int age { get; set; }
        public int percentage { get; set; }
        public int stander { get; set; }
    }
}
