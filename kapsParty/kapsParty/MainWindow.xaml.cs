using System.Windows;
using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;
using System.Linq;
using System;

namespace kapsParty
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnd = new Random();
        string[] holidays = new string[]{"День рождения","Пасха","Рождество","Новый год", "23 февраля", "8 марта",
            "День варенья", "День пельменей", "День матери", "День учителя", "9 мая"};
        string[] congrats = new string[] { "счастья", "здоровья", "удачи","успехов"};
        string congratulation = string.Empty;
        string name = string.Empty;
        string holiday = string.Empty;
        int count = 3;
        string[] words;

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
            Output.Text = $"{name} с праздником {holiday} и {string.Join(", ", words.ToArray())} вам!";
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
                                smtp.EnableSsl = true;

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
                Mailto.Text = "";
            }
        }

        private void Count_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (int.TryParse(Count.Text, out int result))
            {
                count = result;
                if (count <= 0)
                {
                    MessageBox.Show("Вы ввели неправильное число качеств");
                    count = 3;
                    Count.Text = 3.ToString();
                }
                if (count > congrats.Length)
                {
                    MessageBox.Show("Вы ввели неправильное число качеств");
                    Count.Text = congrats.Length.ToString();
                    count = congrats.Length;
                }
            }
            else
            {
                MessageBox.Show("Вы ввели неправильное число качеств");
                Count.Text = 3.ToString();
            }
            words = congrats.OrderBy(x => rnd.Next()).Take(count).ToArray();
            TextChange();
        }
    }
}
