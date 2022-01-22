using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Text.RegularExpressions;
using OpenAI_API;


namespace OAI_APP
 
{
    using OAI_APP;
    public partial class Form1 : Form
    {   

        OpenAIAPI api = new OpenAI_API.OpenAIAPI(APIAuthentication.LoadFromPath());

        public bool mute = true;

        public int max_tokens = 100;
        public double temperature = 0.65;
        public double presencePenalty = 0.2;
        public double frequencyPenalty = 0.4;


        public Form1()
        {
            InitializeComponent();
            System.Drawing.Icon icon = new System.Drawing.Icon("../../../Resources/icon.ico");
            this.Icon = icon;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var rand = new Random();
            var files = Directory.GetFiles("../../../Resources/wav");

            if (!mute)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(files[rand.Next(files.Length)]);
                player.Play();
            }

             var result = api.Completions.StreamCompletionAsync(
                  new CompletionRequest(rtb_output.Text, max_tokens: 100, temperature: 0.65, presencePenalty: 0.2, frequencyPenalty: 0.4),
                  res => rtb_output.Text += res.ToString());
            
          /*  var result = api.Completions.CreateCompletionsAsync(
                new CompletionRequest(rtb_output.Text, max_tokens: 100, temperature: 0.65, presencePenalty: 0.8, frequencyPenalty: 0.8), 1).Result;
            rtb_output.Text += result.Completions.First();
             */
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string promptValue = "";


            if (!File.Exists(".openai"))
            { 
                promptValue = Prompt.ShowDialog("Enter API key", "OpenAI App Initial Config");
                string keyValue = "OPENAI_KEY=" + promptValue;

                bool x = string.IsNullOrEmpty(promptValue);

                if (!x)
                {
                    File.WriteAllText(".openai", keyValue);
                }
            }

           

        }



        public static class Prompt
        {
            public static string ShowDialog(string text, string caption)
            {
                Form prompt = new Form()
                {
                    Width = 500,
                    Height = 200,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    Text = caption,
                    StartPosition = FormStartPosition.CenterScreen
                };
                Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
                TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
                Label textLabel2 = new Label() { Left = 125, Top = 120, Width = 400, Text = "Please restart the app after submitting your key" };
                Button confirmation = new Button() { Text = "Ok", Left = 200, Width = 100, Top = 75, DialogResult = DialogResult.OK };
                confirmation.Click += (sender, e) => { prompt.Close(); };
                prompt.Controls.Add(textBox);
                prompt.Controls.Add(confirmation);
                prompt.Controls.Add(textLabel);
                prompt.Controls.Add(textLabel2); 
                prompt.AcceptButton = confirmation;

                return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
            }
        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.M && Control.ModifierKeys == Keys.Control)
            {
                mute = !mute;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox1.Text, @"^[0-9]+$") && (textBox1.Text != null) && (textBox1.Text != "") && textBox1.Text[0] != '.')
            {
                max_tokens = int.Parse(textBox1.Text);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox2.Text, @"^[0-9.]+$") && (textBox2.Text != null) && (textBox2.Text != "") && textBox2.Text[0] != '.')
            {
                temperature = double.Parse(textBox2.Text);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox3.Text, @"^[0-9.]+$") && (textBox3.Text != null) && (textBox3.Text != "") && textBox3.Text[0] != '.')
            {
                presencePenalty = double.Parse(textBox3.Text);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox4.Text, @"^[0-9.]+$") && (textBox4.Text != null) && (textBox4.Text != "") && textBox4.Text[0] != '.')
            {
                frequencyPenalty = double.Parse(textBox4.Text);
            }

        }
    }

    
}