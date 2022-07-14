using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Domain
{
    public class UserModel
    {
        UserData userData = new UserData();
        public bool LoginUser(string user, string password)
        {
            return userData.Login(user, password);
        }

        public bool SigninUser(string email, string name, string userName, string password)
        {
            return userData.Signin(email,name,userName,password);
        }

        ReclamoData reclamoData = new ReclamoData(); 
        public bool newIncidente(string type, string description, string area, string adress)
        {
            return reclamoData.NewIncidente(type, description, area, adress);
        }

    }
}