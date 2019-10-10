using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace ShoeCollectionCS
{
    public partial class Form1 : Form
    {
        // Declare a List of shoes within the scope of the entire form
        private List<shoe> shoeList = new List<shoe>();

        public Form1()
        {
            InitializeComponent();
        }

        private void addBrandLabel_Click(object sender, EventArgs e)
        {

        }

        // A function that prints the current list to the ListViews on the editMenuPanel and removeShoePanel
        void printList()
        {
            // Clear the items in the ListViews to have a clean slate to print the current list
            currentListView.Items.Clear();
            removeShoeListView.Items.Clear();
            int numberOfShoe = 1;

            // foreach loop to print out the current list to the ListView in the editMenuPanel
            foreach (shoe currentShoe in shoeList)
            {
                string[] row = new string[] { numberOfShoe.ToString(), currentShoe.Brand, currentShoe.Model, currentShoe.Color };
                ListViewItem shoeToAdd = new ListViewItem(row);
                currentListView.Items.Add(shoeToAdd);
                numberOfShoe++;
            }

            // Resets numberOfShoe = 1 for the ListView in the removeShoePanel
            // foreach loop to print out the current list to the ListView in the editMenuPanel
            numberOfShoe = 1;
            foreach (shoe currentShoe in shoeList)
            {
                string[] row = new string[] { numberOfShoe.ToString(), currentShoe.Brand, currentShoe.Model, currentShoe.Color };
                ListViewItem shoeToAdd = new ListViewItem(row);
                removeShoeListView.Items.Add(shoeToAdd);
                numberOfShoe++;
            }

        }

        // Event for when the createCollectionButton is clicked
        // It clears the shoeList and makes the Main Menu invisible while making the Add shoe panel visible
        private void createCollectionButton_Click(object sender, EventArgs e)
        {
            shoeList.Clear();
            mainMenuBox.Visible = false;
            addShoePanel.Visible = true;
            MessageBox.Show("Add as many shoes as you would like and click 'Finish' when you're done!");
        }

        // Event for when the Add Shoe button is clicked
        private void addShoeButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                // Creates a new object tempShoe that will hold all the properties the user has input
                shoe tempShoe = new shoe();

                // Throws an exception if any of the text boxes in the panel are left blank by the user
                if (addBrandTextbox.Text == "" || addModelTextbox.Text == "" || addColorTextbox.Text == "")
                    throw new ArgumentNullException();

                // Sets the tempShoe object properties to the values the user has input
                tempShoe.Brand = addBrandTextbox.Text;
                tempShoe.Model = addModelTextbox.Text;
                tempShoe.Color = addColorTextbox.Text;

                // Adds the tempShoe to the currrent list
                shoeList.Add(tempShoe);

                // Updates the label on the panel to alert the user which shoe they have added
                addedShoeLabel.Text = ("Added " + tempShoe.Brand + " " + tempShoe.Model + " " + tempShoe.Color);

                // Resets the fields on the panel
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

        // Event for when the Finish button on the Add Shoe Panel is clicked
        private void finishAddShoeButton_Click(object sender, EventArgs e)
        {
            // Sets the Add Shoe Panel to invisible while making the Edit Menu Panel visible and calls the printList function
            addShoePanel.Visible = false;
            editMenuPanel.Visible = true;
            printList();

        }

        // Event for when the Exit button in the Edit Menu Panel is clicked, closes the program
        private void exitEditMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Event for when the Main Menu button in the Edit Menu Panel is clicked,
        //  Makes the Edit Menu Panel invisible and the Main Menu GroupBox visible
        private void toMainMenu_Click(object sender, EventArgs e)
        {
            editMenuPanel.Visible = false;
            mainMenuBox.Visible = true;
        }

        // Event for when the Add Shoe button on the Edit Menu Panel is clicked
        //  Makes the Edit Menu Panel invisible and the Add Shoe Panel visible
        private void addToCurrentButton_Click(object sender, EventArgs e)
        {
            editMenuPanel.Visible = false;
            addShoePanel.Visible = true;
        }

        // Event for when the Finish button on the Remove Shoe panel is clicked
        //  Makes the Remoe Shoe Panel invisible and the Edit Menu Panel visible
        private void finishRemoveShoeButton_Click(object sender, EventArgs e)
        {
            removeShoePanel.Visible = false;
            editMenuPanel.Visible = true;
        }

        // Event for when the Remove Shoe button in the Remove Shoe Panel is clicked
        private void removeShoeButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Sets the shoeIndex variable to the number the user enters - 1 which is the actual index of the shoe 
                //  the user is trying to remove
                int shoeIndex = int.Parse(shoeToRemoveTextBox.Text) - 1;

                // Updates the label to let the user know which shoe they removed, removes the shoe from the list and reprints the current list
                removedShoeLabel.Text = "Removed: " + shoeList[shoeIndex].Brand + " " + shoeList[shoeIndex].Model + " " + shoeList[shoeIndex].Color;
                shoeList.RemoveAt(shoeIndex);
                printList();
            }

            catch
            {
                MessageBox.Show("Please enter a valid number");
            }

        }

        // Event fof when the Remove Shoe button in the Edit Menu Panel is clicked
        //  Makes the Edit Menu Panel invisible and the Remove Shoe Panel visible
        private void removeFromCurrentButton_Click(object sender, EventArgs e)
        {
            editMenuPanel.Visible = false;
            removeShoePanel.Visible = true;
        }

        // Event for when the Save Collection button in the Edit Menu Panel is clicked
        private void saveListButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Creates a new SaveFileDialog object called saveDialog 
                SaveFileDialog saveDialog = new SaveFileDialog();

                saveDialog.FileName = "DefaultOutput.txt";
                saveDialog.Filter = "Text File | *.txt";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    // Creates a StreamWriter object called writer used to write the text to the output file designated by user
                    StreamWriter writer = new StreamWriter(saveDialog.OpenFile());

                    // For loop that prints out all the shoes in the current list to an output file using the '|' character
                    //  as a delimiter for when the list is imported in the future
                    for (int i = 0; i < shoeList.Count; i++)
                    {
                        writer.WriteLine(shoeList[i].Brand + "|" + shoeList[i].Model + "|" + shoeList[i].Color + "|");
                    }

                    // Disposes what is in the writer and closes the writer
                    writer.Dispose();
                    writer.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Event for when the Import Collection button on the Main Menu Group Box is clicked
        private void importCollectionButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Clears the current shoe list to make room for the list being imported
                shoeList.Clear();

                // Creates a new OpenFileDialog object named openCollection
                OpenFileDialog openCollection = new OpenFileDialog();
                openCollection.FileName = "DefaultOutput.txt";
                openCollection.Filter = "Text File | *.txt";

                if (openCollection.ShowDialog() == DialogResult.OK)
                {
                    // Creates a StreamReader object called inputFile 
                    // Also declared inputLine variable (to hold the entire line)
                    //  and shoeComponents array (to hold each individual shoe component from inputLine)
                    StreamReader inputFile = new StreamReader(openCollection.OpenFile());
                    string inputLine;
                    string[] shoeComponents;
                    
                    
                    // Reads the inputFile until the end
                    while(!inputFile.EndOfStream)
                    {
                        // Creates new shoe object called tempShoe to hold the current shoe being input
                        shoe tempShoe = new shoe();

                        // Sets inputLine = to the shoe on the line being read
                        //  shoeComponents = the individual components of the shoes
                        inputLine = inputFile.ReadLine();
                        shoeComponents = inputLine.Split('|');

                        tempShoe.Brand = shoeComponents[0];
                        tempShoe.Model = shoeComponents[1];
                        tempShoe.Color = shoeComponents[2];

                        // Adds tempShoe to the current list
                        shoeList.Add(tempShoe);

                    }

                    // Disposes and closes inputFile
                    inputFile.Dispose();
                    inputFile.Close();
                }

                // Makes the Main Menu GroupBox invisible, calls printList function, makes the Edit Menu Panel visible
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
