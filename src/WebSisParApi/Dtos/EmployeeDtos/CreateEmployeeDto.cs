namespace WebSisParApi.Dtos.EmployeeDtos
{
    public class CreateEmployeeDto
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Mail { get; set; }
        public string PhoneNumber { get; set; }
        public string ImageUrl { get; set; }
        public string ProfilUrl { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }
    }
}
