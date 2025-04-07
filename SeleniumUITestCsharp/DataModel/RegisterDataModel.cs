using System.Collections.Generic;

namespace SeleniumUITestCsharp.DataModel
{
    public class RegisterDataModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
    public class RegisterList
    {
        private List<RegisterDataModel> register;
        public List<RegisterDataModel> Register { get => register; set => register = value; }
    }
}