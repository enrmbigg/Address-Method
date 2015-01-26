using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Address_method
{
    public partial class Form1 : Form
    {
        int width = 350 / 20;
        int numberOfLines = 0;
        StringBuilder sb = new StringBuilder();
        string textrow;
        string InitialDirectory;
        List<string> addressItems = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            txtAddress.Clear();
            txtAddressResult.Clear();
            try
            {
                numberOfLines = Convert.ToInt32(txtNoLines.Text);
                InitialDirectory = txtDirect.Text;
                lblText.Text = txtDirect.Text;
            }
            catch
            {
                numberOfLines = 4;

                FolderBrowserDialog FB = new FolderBrowserDialog();
                if (FB.ShowDialog() == DialogResult.OK)
                {
                    InitialDirectory = FB.SelectedPath;
                }
                else
                    return;
                lblText.Text = "Default";
            }
           
            
            var files = new DirectoryInfo(InitialDirectory).GetFiles();
            int index = new Random().Next(0, files.Length);
            FileStream fs1 = new FileStream(InitialDirectory +'\\' + files[index].Name, FileMode.Open);
            StreamReader sr1 = new StreamReader(fs1);

            while ((textrow = sr1.ReadLine()) != null)
            {
                string[] s = textrow.Split(',');
                foreach (string add in s)
                {
                    addressItems.Add(add);
                }   
            }
            sr1.Close();
            fs1.Close();
        
                   
            //Before
            foreach (string prime in addressItems) // Loop through List with foreach
            {
                txtAddress.AppendText(prime + "\n");
            }
            //Method doing its work
            AddressLimit(addressItems, width, numberOfLines);
            //After
            foreach (string prime in addressItems) // Loop through List with foreach
            {
                txtAddressResult.AppendText(prime + "\n");
            }
            this.Refresh();
            addressItems.Clear();
            sb.Clear();
        }

        public void AddressLimit(List<string> addressItems, int width, int numberOfLines)
        {
            string Address;
            int CurrentCapacity;
            //Builds List into a String
            StringBuilder sb = new StringBuilder();
            foreach (string address in addressItems)
            {
                sb.Append(address).Append(",");
            }
            addressItems.Clear();
            //Splits the string into a array
            string[] split = sb.ToString().Split(',');
            //string[] split = addressItems.ToArray()            
            //Shortens the line depending on whether it meets the char limit or not
            foreach (string address in split)
            {
                if (width < address.Length)
                {
                    Address = address.Substring(0, width - 3) + "...";
                    addressItems.Add(Address);
                }
                else if (String.IsNullOrWhiteSpace(address))
                {
                }
                else
                {
                    Address = address;
                    addressItems.Add(Address);
                }
            }
            CurrentCapacity = addressItems.Count;
            ///////////
            //Checks to see if lines can be saved an joined together
            for (int i = 0; i < CurrentCapacity; i++)
            {
                //Saving line sapce
                if ((i + 1 < CurrentCapacity) && (addressItems[i].Length + addressItems[i + 1].Length <= width - 1))
                {
                    addressItems[i] = addressItems[i] + "," + addressItems[i + 1];
                    addressItems.Remove(addressItems[i + 1]);
                    CurrentCapacity = addressItems.Count;
                }
            }
            ///////////
            //if any lines are left on that dont meet the required line count
            //it just throws it off(Bar the last line(usally contains the PC), it removes the 2nd to last line)
            for (int i = numberOfLines; i < CurrentCapacity; )
            {
                addressItems.Remove(addressItems[CurrentCapacity - 2]);
                CurrentCapacity = addressItems.Count;
            }
        }
    }
}


