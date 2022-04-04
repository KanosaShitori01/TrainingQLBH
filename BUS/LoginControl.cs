using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using DTO;
using DAL;
namespace BUS
{
    public class LoginControl
    {
        private DataAccess access = new DataAccess();
        public string HashAccount(LoginProps props)
        {
            Hashtable hashT = access.HashAccounts();
            if (hashT.ContainsKey(props.username) == false)
            {
                return "Tài khoản không tồn tại";
            }
            else
            {
                if (hashT.ContainsValue(props.password) == false)
                {
                    return "Mật khẩu không đúng";
                }
                else
                {
                    return "Đăng nhập thành công";
                }
            }
        }
        public string checkAccount(LoginProps props)
        {
            if(props.username == ""){
                return "required_username";
            }
            if (props.password == "")
            {
                return "required_passowrd";
            }

            return access.CheckLogin(props); 
        }
    }
}
