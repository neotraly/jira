﻿using System.Windows;
using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;

namespace kapsParty
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] holidays = new string[4]{"День рождения","Пасха","Рождество","Новый год"};
        string congratulation = string.Empty;
        string name = string.Empty;
        string holiday = string.Empty;

        public MainWindow()
        {
            InitializeComponent();
            Holidays.ItemsSource = holidays;
        }

        private void Holidays_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            holiday = Holidays.SelectedItem.ToString();
            TextChange();
        }
        private void TextChange()
        {
            Output.Text = $"{name} с праздником {holiday}!";
        }

        private void Name_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            name = Name.Text;
            TextChange();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Mailto.Text))
            {
                MessageBox.Show("Нужно ввести адрес электронной почты");
            }
            else
            {
                MailAddress from = new MailAddress("shcongrats@gmail.com", "Поздравитель");
                MailAddress to = new MailAddress(Mailto.Text, name);
                string message = Output.Text;

                await Task.Run(() =>
                {
                    using (MailMessage mailMessage = new MailMessage(from, to))
                    {
                        using (SmtpClient smtp = new SmtpClient())
                        {
                            try
                            {
                                mailMessage.Subject = holiday;
                                mailMessage.Body = message;
                                smtp.Host = "smtp.gmail.com";
                                smtp.Credentials = new NetworkCredential(from.Address, "congratulations");
                                smtp.Port = 587;
                                smtp.EnableSsl = false;

                                smtp.Send(mailMessage);
                                MessageBox.Show("Письмо отправлено!");
                            }
                            catch
                            {
                                MessageBox.Show("Произошла ошибка с отправкой почты");
                            }
                        }
                    }
                });
            }
        }
    }
}
