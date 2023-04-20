using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace UserTests
{
    public class User_Data_Test
    {
        [Fact]
        public void IsCreated()
        {
            var User= new UserData (" Mairah ");
            var Email = new UserData (" mairahwebb@gmail.com");
            
            Assert.Equal ("Mairah", "mairahwebb@gmail.com");
        }
    }

    public class Setup_Complete_Test
    {
        [Fact]
        public void IsCreated()
        {
            Name = null;
            Email = null;
            Password = null;
        }
    }

    public class Create_Password_Test
    {
        [Fact]
        public void IsCreated()
        {
          
        }
    }

    public class Login_Test
    {
        [Fact]
        public void IsCreated()
        {

        }
    }

    public class Logout_Test
    {
        [Fact]
        public void IsCreated()
        {

        }
    }
}