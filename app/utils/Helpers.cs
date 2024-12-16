using app.db.records;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.utils;
internal class Helpers {
    public static bool IsValidUsername(string username) {
        using (MySqlDataReader reader = UserRecord.SelectUserByName(username)) {
            if (reader.Read()) {
                MessageBox.Show("Tên người dùng đã tồn tại");
                return false;
            }
        }

        if (!Regex.IsMatch(username, @"^[a-zA-Z0-9._]{5,20}$")) {
            MessageBox.Show("Tên người dùng phải chứa từ 5-20 ký tự");
            return false;
        }

        if (!Regex.IsMatch(username, @"^(?!.*[_.]{2}).*$")) {
            MessageBox.Show("Tên không được bao gồm hai dấu (_) hoặc (.) liền nhau");
            return false;
        }

        if (!Regex.IsMatch(username, @"^[^_.].*[^_.]$")) {
            MessageBox.Show("Tên không được bắt đầu hoặc kết thúc bằng ký tự gạch dưới (_) hoặc dấu chấm (.)");
            return false;
        }

        return true;
    }

    public static bool IsValidPassword(string password) {
        if (password.Length < 8)
        {
            MessageBox.Show("Mật khẩu phải chứa ít nhất 8 ký tự");
            return false;
        }

        if (!Regex.IsMatch(password, @".*[!@#$%^&*]"))
        {
            MessageBox.Show("Mật khẩu phải chứa ít nhất 1 trong các ký tự đặc biệt: !,@,#,$,%,^,&,*");
            return false;
        }

        return true;
    }
}
