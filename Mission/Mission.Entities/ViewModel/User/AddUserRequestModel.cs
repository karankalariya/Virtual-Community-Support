namespace Mission.Entities.ViewModel.User
{
    public class AddUserRequestModel
    {
        public  required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required  string EmailAddress { get; set; }
        public required  string Password { get; set; }    
        public required  string PhoneNumber { get; set; }
        public required string UserType { get; set; }
    }
}
