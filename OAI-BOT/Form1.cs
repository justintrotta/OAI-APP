using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using OpenAI_API;

namespace OAI_APP
 
{
    using OAI_APP;
    public partial class Form1 : Form
    {
 
        static string pathToCfg = "./.openai.config";
        //static string keyInfo = File.ReadAllText(pathToCfg);
        OpenAIAPI api = new OpenAIAPI(engine: Engine.Davinci);
        

        public Form1()
        {
            InitializeComponent();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            rtb_output.Text = api.ToString();
            var result = api.Completions.StreamCompletionAsync(
                new CompletionRequest(rtb_output.Text, max_tokens: 100, temperature: 0.75, presencePenalty: 0.8, frequencyPenalty: 0.8),
                res => rtb_output.Text += res.ToString()); 
    

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string promptValue = "";
            
            if (!File.Exists(pathToCfg))
            {
                promptValue = Prompt.ShowDialog("Enter API key", "OpenAI App Initial Config");
                string keyValue = "OPENAI_KEY=" + promptValue;
                File.WriteAllText(pathToCfg, keyValue);
            }

           

        }



        public static class Prompt
        {
            public static string ShowDialog(string text, string caption)
            {
                Form prompt = new Form()
                {
                    Width = 500,
                    Height = 250,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    Text = caption,
                    StartPosition = FormStartPosition.CenterScreen
                };
                Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
                TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
                Button confirmation = new Button() { Text = "Ok", Left = 200, Width = 100, Top = 75, DialogResult = DialogResult.OK };
                confirmation.Click += (sender, e) => { prompt.Close(); };
                prompt.Controls.Add(textBox);
                prompt.Controls.Add(confirmation);
                prompt.Controls.Add(textLabel);
                prompt.AcceptButton = confirmation;

                return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
            }
        }
    }

    
}