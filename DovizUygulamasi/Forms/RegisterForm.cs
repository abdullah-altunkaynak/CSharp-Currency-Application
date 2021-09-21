using DovizUygulamasi.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DovizUygulamasi
{
    public partial class RegisterForm : Form
    {
        public LoginForm loginForm;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {          
        }
        private void loginlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            loginForm.Show();
        }
        private void registerButton_Click(object sender, EventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            if (userIDTextBox.Text == "") 
                errorProvider1.SetError(userIDTextBox, "User ID değerini girmelisiniz!");  
            else if (passwordTextBox.Text == "")
                errorProvider1.SetError(passwordTextBox, "Password değerini girmelisiniz!");
            else if (passwordTextBox2.Text == "")
                errorProvider1.SetError(passwordTextBox2, "Password2 değerini girmelisiniz!");
            else if (passwordTextBox.Text != passwordTextBox2.Text)
                errorProvider1.SetError(passwordTextBox2, "Parolalar uyuşmalıdır!");
            else
            {               
                if(User.UserRegister(userIDTextBox.Text, passwordTextBox.Text))
                    MessageBox.Show("Başarılı bir şekilde kayıt oluşturuldu.");
            }
           
        }

        private void needHelplinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Merhabalar Döviz Uygulamasına hoşgeldiniz. Login ekranından giriş yapabilirsiniz eğer üye değilseniz " +
               "Register ekranından üye olarak başlangıç bonusuda kazanabilirsiniz. MainForm ekranında orta üst kısımda döviz değerini " +
               "değiştirebilirsiniz, değiştirdiğiniz döviz değerlerine göre aşağı kısımda büroların alış-satış-fark değerlerini görebilirsiniz " +
               "Seçilen bu dövizlere göre bir bürodan döviz satınalabilir veya döviz satabilirsiniz. Sağ kısımda profil bilgilerinizi ve sol kısımda " +
               "yapılan tüm işlemleri görebilirsiniz. Teşekkürler.");
        }

        private void RegisterForm_Close_Event(object sender, FormClosedEventArgs e)
        {
            loginForm.Show();
        }
    }
}
