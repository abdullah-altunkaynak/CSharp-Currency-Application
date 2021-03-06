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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            if (userIDTextBox.Text == "")
                errorProvider1.SetError(userIDTextBox, "User ID değerini girmelisiniz!");
            else if (passwordTextBox.Text == "")
                errorProvider1.SetError(passwordTextBox, "Password değerini girmelisiniz!");
            else
            {               
                if (User.UserControl(userIDTextBox.Text, passwordTextBox.Text))
                {
                    MessageBox.Show("Tebrikler, başarılı bir şekilde giriş yaptınız.");
                    MainForm mainForm = new MainForm();
                    mainForm.loginForm = this;
                    User.mainForm = mainForm;
                    User.ProfileScreenUpdate();
                    mainForm.Show();
                    this.Hide();
                    MessageBox.Show("Yukarı orta alanda bulunan converterdan seçilen dövizlere göre işlem yapıldığı için seçim yapılmadan" +
    " satın alma ekranına gidilirse herhangi bir döviz görülmez, dövizleri seç hesaplaya bas ve işlem yapmak istediğin dövizleri seçmiş ol. Satın alma ekranında döviz seçmeyi unutma bu hataya yol açabilir!");
                }
                else
                    MessageBox.Show("Lütfen bilgilerinizi kontrol ediniz.");
            }
        }
        private void registerlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.loginForm = this;
            registerForm.Show();
            this.Hide();
        }

        private void needHelplinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Merhabalar Döviz Uygulamasına hoşgeldiniz. Login ekranından giriş yapabilirsiniz eğer üye değilseniz " +
                "Register ekranından üye olarak başlangıç bonusuda kazanabilirsiniz. MainForm ekranında orta üst kısımda döviz değerini " +
                "değiştirebilirsiniz, değiştirdiğiniz döviz değerlerine göre aşağı kısımda büroların alış-satış-fark değerlerini görebilirsiniz " +
                "Seçlien bu dövizlere göre bir bürodan döviz satınalabilir veya döviz satabilirsiniz. Sağ kısımda profil bilgilerinizi ve sol kısımda " +
                "yapılan tüm işlemleri görebilirsiniz. Teşekkürler.");
        }
    }
}
