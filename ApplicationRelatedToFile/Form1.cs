using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationRelatedToFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string path =
                @"C:\Users\Web App Develop .Net\Desktop\Lab Practice\ApplicationRelatedToFile\ApplicationRelatedToFile\text.txt";

       
        private void saveNameButton_Click(object sender, EventArgs e)
        {
            
            FileStream aStream=new FileStream(path,FileMode.Append);

           StreamWriter aWriter=new StreamWriter(aStream);

            aWriter.WriteLine(nameTextBox.Text);

            aWriter.Close();

            aStream.Close();

            MessageBox.Show("Saved");
            nameTextBox.Text = "";
        }

        private void showNameButton_Click(object sender, EventArgs e)
        {
            nameListBox.Items.Clear();

            FileStream aStream =new FileStream(path,FileMode.Open);

            StreamReader reader=new StreamReader(aStream);


            while (!reader.EndOfStream)
            {
                nameListBox.Items.Add(reader.ReadLine());

            }
           reader.Close();
            aStream.Close();
            
        }
    }
}
