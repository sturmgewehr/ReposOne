using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectWPF.Models
{
    public class UserViewModel /*: IDataErrorInfo*/
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Phone { get; set; }

        // Validation:
        //public string this[string columnName]
        //{
        //    get
        //    {
        //        string error = "";

        //        switch (columnName)
        //        {
        //            case "Login":
        //                if (Login.Length < 4)
        //                {
        //                    error = "Login is too short!";
        //                }
        //                break;
        //            case "Password":
        //                if (Password.Length < 8)
        //                {
        //                    error = "Password is too short!";
        //                }
        //                break;
        //            case "ConfirmPassword":
        //                if (ConfirmPassword != Password)
        //                {
        //                    error = "Password is not too much!";
        //                }
        //                break;
        //            case "Phone":
        //                if(Phone.Length < 8)
        //                {
        //                    error = "Phone number is too short!";
        //                }
        //                break;                   
        //        }

        //        return error;
        //    }
        //}
        //public string Error { get; set; }
    }
}
