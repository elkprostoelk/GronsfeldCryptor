using System.Text;
using System.Text.RegularExpressions;

namespace GronsfeldCryptor
{
    public partial class Form1 : Form
    {
        private readonly string _alphabet = "0123456789 ?!,.;:()[]{}*&^%$|#@\\\"'~/ABCDEFGHIJKLMNOPQRSTUVWXYZАБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯabcdefghijklmnopqrstuvwxyzабвгґдеєжзиіїйклмнопрстуфхцчшщьюя";

        public Form1()
        {
            InitializeComponent();
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            var result = new StringBuilder();
            var key = keyTextBox.Text;
            if (!Regex.IsMatch(key, @"^\d+$"))
            {
                MessageBox.Show("Ключ має містити лише цифри!");
                return;
            }
            if (key.Length != originalRichTextBox.Text.Length)
            {
                MessageBox.Show($"Ключ має бути тієї ж довжини, що й текст! Ключ: {key.Length} Текст: {originalRichTextBox.Text.Length}");
                return;
            }

            var input = originalRichTextBox.Text;

            int alphabetLength = _alphabet.Length;
            var alphabetIndexes = new int[alphabetLength];
            for (var i = 0; i < alphabetLength; i++)
            {
                alphabetIndexes[i] = i;
            }

            int inputLength = input.Length;

            while (key.Length < inputLength)
            {
                key += key;
            }
            key = key[..inputLength];

            for (var i = 0; i < inputLength; i++)
            {
                int charIndex = _alphabet.IndexOf(input[i]);

                var keyIndex = int.Parse(key[i].ToString());
                int newIndex = (charIndex + keyIndex) % alphabetLength;

                result.Append(_alphabet[newIndex]);
            }

            resultRichTextBox.Text = result.ToString();
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            var result = new StringBuilder();
            var key = keyTextBox.Text;
            if (!Regex.IsMatch(key, @"^\d+$"))
            {
                MessageBox.Show("Ключ має містити лише цифри!");
                return;
            }
            if (key.Length != originalRichTextBox.Text.Length)
            {
                MessageBox.Show($"Ключ має бути тієї ж довжини, що й текст! Ключ: {key.Length} Текст: {originalRichTextBox.Text.Length}");
                return;
            }

            var input = originalRichTextBox.Text;

            for (var i = 0; i < input.Length; i++)
            {
                char c = input[i];
                char k = key[i % key.Length];

                int index = _alphabet.IndexOf(c) - int.Parse(k.ToString());
                if (index < 0)
                {
                    index += _alphabet.Length;
                }

                result.Append(_alphabet[index]);
            }
            resultRichTextBox.Text = result.ToString();
        }
    }
}