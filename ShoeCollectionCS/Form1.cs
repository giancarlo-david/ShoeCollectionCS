using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace ShoeCollectionCS
{
    public partial class Form1 : Form
    {
        private List<shoe> shoeList = new List<shoe>();

        public Form1()
        {
            InitializeComponent();
        }

        private void addBrandLabel_Click(object sender, EventArgs e)
        {

        }

        void printList()
        {
            currentListView.Items.Clear();
            removeShoeListView.Items.Clear();
            int numberOfShoe = 1;
            foreach (shoe currentShoe in shoeList)
            {
                string[] row = new string[] { numberOfShoe.ToString(), currentShoe.Brand, currentShoe.Model, currentShoe.Color };
                ListViewItem shoeToAdd = new ListViewItem(row);
                currentListView.Items.Add(shoeToAdd);
                numberOfShoe++;
            }

            numberOfShoe = 1;
            foreach (shoe currentShoe in shoeList)
            {
                string[] row = new string[] { numberOfShoe.ToString(), currentShoe.Brand, currentShoe.Model, currentShoe.Color };
                ListViewItem shoeToAdd = new ListViewItem(row);
                removeShoeListView.Items.Add(shoeToAdd);
                numberOfShoe++;
            }

        }

        private void createCollectionButton_Click(object sender, EventArgs e)
        {
            shoeList.Clear();
            mainMenuBox.Visible = false;
            addShoePanel.Visible = true;
            MessageBox.Show("Add as many shoes as you would like and click 'Finish' when you're done!");
        }

        private void addShoeButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                shoe tempShoe = new shoe();

                if (addBrandTextbox.Text == "" || addModelTextbox.Text == "" || addColorTextbox.Text == "")
                    throw new ArgumentNullException();

                tempShoe.Brand = addBrandTextbox.Text;
                tempShoe.Model = addModelTextbox.Text;
                tempShoe.Color = addColorTextbox.Text;

                shoeList.Add(tempShoe);

                addedShoeLabel.Text = ("Added " + tempShoe.Brand + " " + tempShoe.Model + " " + tempShoe.Color);

                addBrandTextbox.Text = null;
                addModelTextbox.Text = null;
                addColorTextbox.Text = null;
                addBrandTextbox.Focus();
            }
            catch
            {
                MessageBox.Show("Please fill out all the required information");
            }
        }

        private void finishAddShoeButton_Click(object sender, EventArgs e)
        {
            addShoePanel.Visible = false;
            editMenuPanel.Visible = true;
            printList();

        }

        private void exitEditMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toMainMenu_Click(object sender, EventArgs e)
        {
            editMenuPanel.Visible = false;
            mainMenuBox.Visible = true;
        }

        private void addToCurrentButton_Click(object sender, EventArgs e)
        {
            editMenuPanel.Visible = false;
            addShoePanel.Visible = true;
        }

        private void finishRemoveShoeButton_Click(object sender, EventArgs e)
        {
            removeShoePanel.Visible = false;
            editMenuPanel.Visible = true;
        }

        private void removeShoeButton_Click(object sender, EventArgs e)
        {
            int shoeIndex = int.Parse(shoeToRemoveTextBox.Text) - 1;

            removedShoeLabel.Text = "Removed: " + shoeList[shoeIndex].Brand + " " + shoeList[shoeIndex].Model + " " + shoeList[shoeIndex].Color;
            shoeList.RemoveAt(shoeIndex);
            printList();

        }

        private void removeFromCurrentButton_Click(object sender, EventArgs e)
        {
            editMenuPanel.Visible = false;
            removeShoePanel.Visible = true;
            currentListView.BringToFront();
        }

        private void saveListButton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();

                saveDialog.FileName = "DefaultOutput.txt";
                saveDialog.Filter = "Text File | *.txt";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter writer = new StreamWriter(saveDialog.OpenFile());
                    for (int i = 0; i < shoeList.Count; i++)
                    {
                        writer.WriteLine(shoeList[i].Brand + "|" + shoeList[i].Model + "|" + shoeList[i].Color + "|");
                    }

                    writer.Dispose();
                    writer.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void importCollectionButton_Click(object sender, EventArgs e)
        {
            try
            {
                shoeList.Clear();
                OpenFileDialog openCollection = new OpenFileDialog();
                openCollection.FileName = "DefaultOutput.txt";
                openCollection.Filter = "Text File | *.txt";

                if (openCollection.ShowDialog() == DialogResult.OK)
                {
                    StreamReader inputFile = new StreamReader(openCollection.OpenFile());
                    string inputLine;
                    string[] shoeComponents;
                    
                    

                    while(!inputFile.EndOfStream)
                    {
                        shoe tempShoe = new shoe();
                        inputLine = inputFile.ReadLine();
                        shoeComponents = inputLine.Split('|');

                        tempShoe.Brand = shoeComponents[0];
                        tempShoe.Model = shoeComponents[1];
                        tempShoe.Color = shoeComponents[2];

                        shoeList.Add(tempShoe);

                    }

                    inputFile.Dispose();
                    inputFile.Close();
                }

                mainMenuBox.Visible = false;
                printList();
                editMenuPanel.Visible = true;
            }

            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
