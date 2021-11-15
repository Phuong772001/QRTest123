using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using BUS_Dienthoai.IServices;

namespace BUS_Dienthoai.Services
{
    public class ForgotService:IForgotService
    {
        private IserviceQuanLiNhanVien _iQLyNhanVienService;
        public string RandomString(int size, bool lowerCase)
        {
            
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            if (lowerCase)
            {
                return builder.ToString().ToLower();
            }

            return builder.ToString();
        }
        public int randomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        public string maHoa(string pass)
        {
            MD5 mh = MD5.Create();
            //Chuyển kiểu chuổi thành kiểu byte
            byte[] input = System.Text.Encoding.ASCII.GetBytes(pass);
            //mã hóa chuỗi đã chuyển
            byte[] hash = mh.ComputeHash(input);
            //tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }

            return sb.ToString();
        }
        public bool SendMail(string email, string pass)
        {
            MailMessage mail = new MailMessage();
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("binhktph16675@fpt.edu.vn");
            mail.To.Add(email);
            mail.Subject = "Bạn đã sử dụng tính năng quên mật khẩu";
            mail.Body = "Mã xác nhận của bạn là : " + pass;
            mail.Priority = MailPriority.High;
            smtpClient.Port = 587;
            smtpClient.Credentials = new NetworkCredential("binhktph16675@fpt.edu.vn", "08032002binh");
            smtpClient.EnableSsl = true;
            smtpClient.Send(mail);
            return true;
        }

        public void updatePass(string email,string newpass)
        {
            _iQLyNhanVienService = new ServiceQuanLiNhanVien();
            _iQLyNhanVienService.getlistDB();
            var acc = _iQLyNhanVienService.getlistNV().Where(c => c.Email == email).FirstOrDefault();
            acc.Password = newpass;
            _iQLyNhanVienService.Sua(acc);
        }

    }
}
