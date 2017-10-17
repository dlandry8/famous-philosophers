using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* ---------------------------------------------------------------------------
Comments by the professor:

------------------------------------------------------------------------------
Project Name:       Project 3:  Famous Philosophers Database
Created by:     	David Landry
Dates:              11/15-29/2016
Short Name:         Project 3
Class:		        CS 218 A
Time:               Approx. 12 hours.
Platform:           PC running Windows 10; 
                    Compiled with Visual Studio Community 2015 C#
------------------------------------------------------------------------------
Description:
    This file maintains a list of philosophers.  The user can search by
    name, country, year of birth, works, or philosophy; edit a philosopher;
    add a new philosopher; delete a philosopher; clear a file of all
    philosophers; print the info for a philosopher; or sort a list of
    philosophers by name, year of birth, or country.
------------------------------------------------------------------------------
Required Input:
    Though technically NOT required, the program assumes the user has a
    properly formatted text file containing a list of philosophers.  The
    default one is a text file called philosophers.txt located in the same
    folder as the program.  Without a proper text file, the program loses
    much of its functionability.
Output:
    The program displays a philosopher's name, country of birth, year of
    birth, famous works, philosophical/biographical summary, and source
    link.  The output is displayed in text boxes in the main form and may
    also be printed to a document.
Calculation(s):
    No formal calculations were performed for this program, except perhaps for
    simple arithemetic to check for index bounds.
------------------------------------------------------------------------------
Comments by the student:
I have enclosed several text files to demonstrate how the program handles file
management.  Feel free to delete the philosophers.txt file to see how the
program handles a lack of default database file.
--------------------------------------------------------------------------- */

namespace Project3FamousPhilosophers
{
    public partial class frmPhilosophersMainGUI : Form
    {
        // Class variables
        string currentFile = "philosophers.txt";
        List<Philosopher> philosophers = new List<Philosopher>();
        Bitmap memoryImage;

        //--------------------------------------------------------------------
        //	Method:                 frmPhilosophersMainGUI constructor
        //	Description:            The default constructor for this form.
        //	Date Complete:          11/15/2016
        //	Programmers:			Microsoft
        //	Parameters:             None
        //	Returns:                None
        //	Input:                  None
        //	Output:                 None
        //	Calls:                  InitializeComponent() in Designer.cs
        //	Called by:              Form instantiation in Program.cs
        //	Pre/Post Condition:     No pre-condition.  After the method
        //                              call has completed, all controls'
        //                              properties are set, the form load
        //                              method is called, and the form is
        //                              displayed.
        //	Exceptions:             None
        //	Notes:
        //--------------------------------------------------------------------
        public frmPhilosophersMainGUI()
        {
            InitializeComponent();
        }

        //--------------------------------------------------------------------
        //	Method:                 frmPhilosophersMainGUI_Load
        //	Description:            Form load event handler for the main GUI.
        //                              Sets some control properties and loads
        //                              a starting philosopher text file with
        //                              which to build a list of philosophers.
        //	Date Complete:          11/18/2016 - 11/28/2016
        //	Programmers:			David Landry
        //	Parameters:             None
        //	Returns:                None
        //	Input:                  None
        //	Output:                 None
        //	Calls:                  validateFile, buildPhilosophers, openFile
        //	Called by:              InitializeComponent
        //	Pre/Post Condition:     No pre-condition.  After execution, there
        //                              should be a valid list of philosophers
        //                              and a full list box or more
        //                              uncommonly, an empty list and an
        //                              empty list box.
        //	Exceptions:             Any issues with the input file are handled
        //                              by the validateFile method.
        //	Notes:
        //--------------------------------------------------------------------
        private void frmPhilosophersMainGUI_Load(object sender, EventArgs e)
        {
            // Read philosopher info from philosophers.txt if it's valid and
            //  exists.
            if (validateFile(currentFile))
            {
                buildPhilosophers();
            }

            // If the default file is either missing or in an improper format,
            //  prompt the user to select a different file.
            else
            {
                currentFile = "";
                DialogResult prompt = MessageBox.Show
                    ("The default file " + currentFile + " could not be " +
                    "found.  Would you like to select a different text " +
                    "file to load?", "Default file not found.", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (prompt == DialogResult.Yes)
                {
                    openFile();
                }// End if (prompt == DialogResult.Yes)
                else
                    MessageBox.Show("You are now working with an empty " +
                        "database.  Any changes made will not be saved." +
                        "  It is highly reccommended that you open a file " +
                        "to associate with this program before continuing.",
                        "No active file.", MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
            }
            pdScreen.DefaultPageSettings.Landscape = true;
            if (lstPhilosophers.Items.Count > 0)
                lstPhilosophers.Focus();
            else
                btnAdd.Focus();
            this.Focus();
            this.Activate();
        }

        //--------------------------------------------------------------------
        //	Method:                 lstPhilosophers_SelectedIndexChanged
        //	Description:            Event handler for changing the selected
        //                              index of the lstPhilosophers list
        //                              box.  Dynamically displays info for
        //                              the selected philosopher.
        //	Date Complete:         	11/17/16
        //	Programmers:			David Landry
        //	Parameters:             object sender, EventArgs e
        //	Returns:                None
        //	Input:                  lstPhilosophers index, matching
        //                              philosophers list.
        //	Output:                 Philosopher information in corresponding
        //                              text boxes.
        //	Calls:                  Philosophers.getName, 
        //                              Philosophers.getCountry,
        //                              Philosophers.getYear, 
        //                              Philosophers.getWork,
        //                              Philosophers.getPhilosophy,
        //                              Philosophers.getLink
        //	Called by:              Selected Index change event for
        //                              lstPhilosophers list box.
        //	Pre/Post Condition:     This method requires having at least one
        //                              item in the lstPhilosophers list box.
        //                              After execution, the text boxes on
        //                              the right side of the form should be
        //                              filled with the information from the
        //                              philosopher whose index in the
        //                              philosophers list matches the
        //                              selected index of the list box.
        //	Exceptions:             Since an index of -1 can never be reached
        //                              via this method, no exceptions can
        //                              be thrown.
        //	Notes:                  
        //--------------------------------------------------------------------
        private void lstPhilosophers_SelectedIndexChanged
            (object sender, EventArgs e)
        {
            txtName.Text =
                philosophers[lstPhilosophers.SelectedIndex].getName();
            txtCountry.Text =
                philosophers[lstPhilosophers.SelectedIndex].getCountry();
            txtYear.Text =
                philosophers[lstPhilosophers.SelectedIndex].getYear().
                ToString();
            txtWork.Text =
                philosophers[lstPhilosophers.SelectedIndex].getWork();
            txtPhilosophy.Text =
                philosophers[lstPhilosophers.SelectedIndex].getPhilosophy();
            txtLink.Text = philosophers[lstPhilosophers.SelectedIndex].
                getLink();
        }

        //--------------------------------------------------------------------
        //	Method:                 mnuNameSort_Click
        //	Description:            Event handler for a click event for the
        //                              Sort->Name menu item.
        //	Date Complete:         	11/22/2016
        //	Programmers:			David Landry
        //	Parameters:             object sender, EventArgs e
        //	Returns:                None
        //	Input:                  A list of philosophers
        //	Output:                 A sorted-by-name list of philosophers, 
        //                              displayed by name in the list box.
        //	Calls:                  sortByName, refreshListBox
        //	Called by:              Click event for Sort->Name
        //	Pre/Post Condition:     The method assumes a valid list of
        //                              philosophers.  After execution, the
        //                              list of philosophers are arranged
        //                              by philosophers' names and their
        //                              names are displayed in order in the
        //                              list box.
        //	Exceptions:             None known.
        //	Notes:
        //--------------------------------------------------------------------
        private void mnuNameSort_Click(object sender, EventArgs e)
        {
            sortByName();
            mnuYearSort.Checked = false;
            mnuCountrySort.Checked = false;
            mnuNameSort.Checked = true;
            refreshListBox();
        }

        //--------------------------------------------------------------------
        //	Method:                 mnuYearSort_Click
        //	Description:            Event handler for a click event for the
        //                              Sort->Year menu item.
        //	Date Complete:         	11/22/2016
        //	Programmers:			David Landry
        //	Parameters:             object sender, EventArgs e
        //	Returns:                None
        //	Input:                  A list of philosophers
        //	Output:                 A sorted-by-year list of philosophers, 
        //                              displayed by year of birth in the 
        //                              list box.
        //	Calls:                  sortByYear, refreshListBox
        //	Called by:              Click event for Sort->Year
        //	Pre/Post Condition:     The method assumes a valid list of
        //                              philosophers.  After execution, the
        //                              list of philosophers are arranged
        //                              by philosophers' year of birth and 
        //                              their names and birth years are 
        //                              displayed in order in the list box.
        //	Exceptions:             None known.
        //	Notes:
        //--------------------------------------------------------------------
        private void mnuYearSort_Click(object sender, EventArgs e)
        {
            sortByYear();
            mnuYearSort.Checked = true;
            mnuCountrySort.Checked = false;
            mnuNameSort.Checked = false;
            refreshListBox();
        }

        //--------------------------------------------------------------------
        //	Method:                 mnuCountrySort_Click
        //	Description:            Event handler for a click event for the
        //                              Sort->Country menu item.
        //	Date Complete:         	11/22/2016
        //	Programmers:			David Landry
        //	Parameters:             object sender, EventArgs e
        //	Returns:                None
        //	Input:                  A list of philosophers
        //	Output:                 A sorted-by-country list of philosophers, 
        //                              displayed by country of birth in the 
        //                              list box.
        //	Calls:                  sortByCountry, refreshListBox
        //	Called by:              Click event for Sort->Country
        //	Pre/Post Condition:     The method assumes a valid list of
        //                              philosophers.  After execution, the
        //                              list of philosophers are arranged
        //                              by philosophers' country of birth and
        //                              their names and home countries are 
        //                              displayed in order in the list box.
        //	Exceptions:             None known.
        //	Notes:
        //--------------------------------------------------------------------
        private void mnuCountrySort_Click(object sender, EventArgs e)
        {
            sortByCountry();
            mnuYearSort.Checked = false;
            mnuCountrySort.Checked = true;
            mnuNameSort.Checked = false;
            refreshListBox();
        }

        //--------------------------------------------------------------------
        //	Method:                 btnExit_Click
        //	Description:            Event handler for a click event on
        //                              the btnExit button.
        //	Date Complete:         	11/22/2016
        //	Programmers:		    David Landry
        //	Parameters:             object sender, EventArgs e
        //	Returns:                None
        //	Input:                  None
        //	Output:                 None
        //	Calls:                  Application.Exit
        //	Called by:              btnExit click event.
        //	Pre/Post Condition:     No pre-condition.  After execution, the
        //                              program exits.
        //	Exceptions:             None
        //	Notes:
        //--------------------------------------------------------------------
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //--------------------------------------------------------------------
        //	Method:                 mnuExitFile_Click
        //	Description:            Event handler for a click event on
        //                              the File->Exit menu item.
        //	Date Complete:         	11/22/2016
        //	Programmers:		    David Landry
        //	Parameters:             object sender, EventArgs e
        //	Returns:                None
        //	Input:                  None
        //	Output:                 None
        //	Calls:                  Application.Exit
        //	Called by:              File->Exit click event.
        //	Pre/Post Condition:     No pre-condition.  After execution, the
        //                              program exits.
        //	Exceptions:             None
        //	Notes:
        //--------------------------------------------------------------------
        private void mnuExitFile_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //--------------------------------------------------------------------
        //	Method:                 btnAdd_Click
        //	Description:            Event handler for a click event on
        //                              the btnAdd button for adding a new
        //                              philosopher.
        //	Date Complete:         	11/24/2016-11/29/2016
        //	Programmers:		    David Landry
        //	Parameters:             object sender, EventArgs e
        //	Returns:                None
        //	Input:                  Data entered from the frmAddPhilosopher
        //                              form.
        //	Output:                 Both the new philosopher's name in the
        //                              list box and that philosopher's info
        //                              in the text boxes.
        //	Calls:                  Philosopher constructor, frmAddPhilosopher
        //                              constructor, 
        //                              frmAddPhilosopher.fetchPhilosopher,
        //                              Philosopher.getName, 
        //                              Philosopher.getCountry
        //	Called by:              btnAdd click event, mnuAddAction_Click
        //	Pre/Post Condition:     No pre-condition.  After execution, a new
        //                              philosopher is added to the list of
        //                              philosophers, the philosopher is added
        //                              to the list box and the current file,
        //                              and the new philosopher is highlighted
        //                              in the list box, his/her info
        //                              displayed in the text boxes.
        //	Exceptions:             System.ArgumentException if there is no
        //                              current file.
        //                          System.IO.IOException if the file is
        //                              in use by another process.
        //	Notes:
        //--------------------------------------------------------------------
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Instantiate a new philosopher.
            Philosopher philosopherToAdd = new Philosopher();

            // Instantiate a new Add Philosopher form.
            frmAddPhilosopher addPhilosopher = new frmAddPhilosopher();

            bool isValidEntry = true;
            do
            {
                // Show the new Add Philosopher form.
                addPhilosopher.ShowDialog();

                // Check if the Add button was pressed from the Add 
                //  Philosopher form.  If so, update the list of philosophers
                //  with the newly created philosopher.
                if (addPhilosopher.pressedAdd)
                {
                    philosopherToAdd = addPhilosopher.fetchPhilosopher();
                    // If the philosopher is already on the list, prompt the
                    //  user to try again.
                    bool duplicateEntry = false;
                    for (int i = 0; i < philosophers.Count && !duplicateEntry;
                        i++)
                    {
                        if (philosopherToAdd.getName().ToLower().Trim() == 
                            philosophers[i].getName().ToLower().Trim() && 
                            philosopherToAdd.getCountry().ToLower().Trim() == 
                            philosophers[i].getCountry().ToLower().Trim())
                        {
                            isValidEntry = false;
                            duplicateEntry = true;
                            MessageBox.Show("You already have a philosopher" +
                                " named " + philosopherToAdd.getName() +
                                "from " + philosopherToAdd.getCountry() + 
                                ".  Please try again.",
                                "Duplicate entry found.",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            // Reset isValidEntry to true in case the user is
                            //  re-entering an invalid philosopher.
                            isValidEntry = true;
                        }
                    }
                }
                else
                {
                    // If the user pressed cancel in the add form after
                    //  entering an invalid philosopher, isValidEntry should
                    //  be reset to true to prevent the add form from
                    //  reloading endlessly.
                    isValidEntry = true;
                }
            } while (!isValidEntry);
            if (addPhilosopher.pressedAdd)
            {
                addPhilosopher.Dispose();
                philosophers.Add(philosopherToAdd);

                // The new philosopher has been added, but it was added to the
                //  "bottom" of the list, meaning the list is now unsorted!
                //  To handle this, uncheck all the "sort" options.
                mnuNameSort.Checked = false;
                mnuCountrySort.Checked = false;
                mnuYearSort.Checked = false;

                // Finish up by refreshing the list box and selecting the new
                //  philosopher.
                refreshListBox();
                lstPhilosophers.SelectedIndex = lstPhilosophers.Items.Count 
                    - 1;
                isValidEntry = true;

                // Write each philosopher in the philosopher list to the
                //  output file.
                try
                {
                    System.IO.StreamWriter writePhilosophers =
                        new System.IO.StreamWriter(currentFile);
                    int counter = 0;
                    while (counter < philosophers.Count)
                    {
                        writePhilosophers.WriteLine
                            (philosophers[counter].getName() + "|" +
                            philosophers[counter].getCountry() + "|" +
                            philosophers[counter].getYear() + "|" +
                            philosophers[counter].getWork() + "|" +
                            philosophers[counter].getPhilosophy() + "|" +
                            philosophers[counter++].getLink()
                            );
                    }
                    writePhilosophers.Close();
                }
                catch (System.ArgumentException)
                {
                    // If the program failed to load a philosopher text file,
                    //  this catch block will be called.  This will simply
                    //  bypass the file writing process.  User assumes all
                    //  problems associated with a lack of file association.
                }
                catch (System.IO.IOException ex)
                {
                    // This is thrown if the file is in use by another 
                    //process.
                    MessageBox.Show(ex.Message, "Could not write to file.",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }// End if add pressed
        }// End method btnAdd_Click

        //--------------------------------------------------------------------
        //	Method:                 btnEdit_Click
        //	Description:            Event handler for a click event on
        //                              the btnEdit button to edit a selected
        //                              philosopher.
        //	Date Complete:         	11/25/2016
        //	Programmers:		    David Landry
        //	Parameters:             object sender, EventArgs e
        //	Returns:                None
        //	Input:                  Data entered from the frmEditPhilosopher
        //                              form.
        //	Output:                 Both the philosopher's name in the
        //                              list box and that philosopher's info
        //                              in the text boxes.
        //	Calls:                  Philosopher constructor, 
        //                              frmEditPhilosopher constructor, 
        //                              frmEditPhilosopher.retrieveNewInfo,
        //                              Philosopher.getName, 
        //                              Philosopher.getCountry
        //	Called by:              btnEdit click event, mnuEditAction_Click
        //	Pre/Post Condition:     No pre-condition.  After execution, the
        //                              selected philosopher is edited in
        //                              the Philosophers list, the current
        //                              file, and possibly the list box.
        //                              His/her info is displayed in the text 
        //                              boxes.
        //	Exceptions:             System.IO.IOException if the file is
        //                              already open.
        //	Notes:
        //--------------------------------------------------------------------
        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Can't edit a non-existent philosopher (unless you don't adhere
            //  to existentialism, but that's another discussion for another
            //  day.).
            if (philosophers.Count >= 1)
            {
                // Instantiate a philosopher.
                Philosopher toEdit = new Philosopher();
                int indexToEdit = lstPhilosophers.SelectedIndex;
                string originalName =
                    philosophers[indexToEdit].getName();
                string originalCountry =
                    philosophers[indexToEdit].getCountry();
                // Instantiate an edit form.
                frmEditPhilosopher editPhilosopher = new frmEditPhilosopher
                    (philosophers[indexToEdit]);

                // Enclose the edit philosopher process within a do loop to 
                // avoid the unlikely instance of a duplicate entry.
                bool isDuplicate = false;
                do
                {
                    isDuplicate = false;
                    // Open the edit form.
                    editPhilosopher.ShowDialog();
                    // Get the new philosopher's info.
                    if (editPhilosopher.pressedSave)
                    {
                        toEdit = editPhilosopher.retrieveNewInfo();
                        // Check for duplicate entry.
                        for (int i = 0; 
                            i < philosophers.Count && !isDuplicate; i++)
                        {
                            if (toEdit.getName() == philosophers[i].getName()
                                && toEdit.getCountry() == 
                                philosophers[i].getCountry())
                            {
                                if (toEdit.getName() != originalName && 
                                    toEdit.getCountry() != originalCountry)
                                {
                                    isDuplicate = true;
                                    MessageBox.Show
                                        ("You already have a philosopher" +
                                        " named " + toEdit.getName() +
                                        "from " + toEdit.getCountry() +
                                        ".  Please try again.",
                                        "Duplicate entry found.",
                                        MessageBoxButtons.OK, 
                                        MessageBoxIcon.Warning);
                                }
                                else
                                    isDuplicate = false;
                            }
                            else
                                isDuplicate = false;
                        }
                    }
                    else
                        isDuplicate = false;
                } while (isDuplicate);
                if (editPhilosopher.pressedSave)
                {
                    bool isSorted = true;
                    if (philosophers[indexToEdit].getName() != 
                        toEdit.getName() || 
                        philosophers[indexToEdit].getCountry() != 
                        toEdit.getCountry() || 
                        philosophers[indexToEdit].getYear() != 
                        toEdit.getYear())
                        isSorted = false;
                    // Replace the philosopher in the list w/ the edited 
                    //  philosopher.
                    if (editPhilosopher.pressedSave)
                        philosophers[indexToEdit] = toEdit;

                    // Refresh the list box.
                    refreshListBox();
                    lstPhilosophers.SelectedIndex = indexToEdit;
                    // The list may not be sorted, so check this.
                    if (!isSorted)
                    {
                        mnuCountrySort.Checked = false;
                        mnuYearSort.Checked = false;
                        mnuNameSort.Checked = false;
                    }

                    // Find the line number of the selected philosopher in the
                    //  file.
                    try
                    {
                        string[] lines = System.IO.File.ReadAllLines(currentFile);
                        bool foundAMatch = false;
                        int linesCount = 0;
                        for (int i = 0; i < lines.Length && !foundAMatch; i++)
                        {
                            string[] entries = lines[i].Split('|');
                            if (entries[0] == originalName)
                                foundAMatch = true;
                            else
                                linesCount++;
                        }
                        lines[linesCount] = toEdit.getName() + "|" +
                            toEdit.getCountry() + "|" + toEdit.getYear() + "|" +
                            toEdit.getWork() + "|" + toEdit.getPhilosophy() + "|"
                            + toEdit.getLink();
                        System.IO.File.WriteAllLines(currentFile, lines);
                    }
                    catch (System.IO.IOException ex)
                    {
                        MessageBox.Show(ex.Message, "Could not write to file."
                            , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (System.ArgumentException)
                    {
                        // This catches an exception thrown if there is no
                        //  currently active file.
                    }
                }
            }
            else
                MessageBox.Show("You have no philosophers to edit!", "No " +
                    "philosophers to edit!", MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
        }// End method btnEdit_Click

        //--------------------------------------------------------------------
        //	Method:                 btnDelete_Click
        //	Description:            Event handler for a click event on
        //                              the btnDelete button for deleting a
        //                              selected philosopher.
        //	Date Complete:         	11/26/2016-11/29/2016
        //	Programmers:		    David Landry
        //	Parameters:             object sender, EventArgs e
        //	Returns:                None
        //	Input:                  A philosopher to delete
        //	Output:                 A list of philosophers' names, minus the
        //                              one deleted (if deletion was 
        //                              confirmed).
        //	Calls:                  refreshListBox
        //	Called by:              btnDelete click event, 
        //                              mnuDeleteAction_Click
        //	Pre/Post Condition:     This method will not complete execution
        //                              if the philosophers list is empty.
        //                              After execution, if confirmed, the
        //                              selected philosopher will be removed
        //                              from the philosophers list, the
        //                              current file, and the list box.
        //	Exceptions:             System.IO.IOException if the current
        //                              file is already open somewhere.
        //	Notes:
        //--------------------------------------------------------------------
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (philosophers.Count >= 1)
            {
                int index = lstPhilosophers.SelectedIndex;
                // Confirm deletion.
                DialogResult userSelection =
                MessageBox.Show("Are you sure you want to remove " +
                    philosophers[index].getName() +
                    " from your list of philosophers?", "Remove philosopher?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (userSelection == DialogResult.Yes)
                {
                    // Remove the selected index from the list.
                    philosophers.RemoveAt(index);
                    // Refresh the list box.
                    refreshListBox();
                    // Refresh the file.
                    string[] line = new string[philosophers.Count];
                    for (int i = 0; i < philosophers.Count; i++)
                    {
                        line[i] = philosophers[i].getName() + "|" +
                            philosophers[i].getCountry() + "|" +
                            philosophers[i].getYear() + "|" +
                            philosophers[i].getWork() + "|" +
                            philosophers[i].getPhilosophy() + "|" +
                            philosophers[i].getLink();
                    }
                    try
                    {
                        System.IO.File.WriteAllLines(currentFile, line);
                    }
                    catch (System.IO.IOException ex)
                    {
                        // If the file is already in use, the program cannot
                        //  write to the file.
                        MessageBox.Show(ex.Message, 
                            "Could not write to the file.", 
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (System.ArgumentException)
                    {
                        // If there is no current file, don't write to a
                        //  current file!  The user assumes all risks with not
                        //  having a current file.
                    }
                }
            }
            else
                // Can't delete philosophers if no philosophers exist!
                MessageBox.Show("Your list of philosophers is already " +
                    "empty.  Further deletion is not possible.", "No "+
                    "philosophers to delete!", MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
        }

        //--------------------------------------------------------------------
        //	Method:                 mnuSearchAction_Click
        //	Description:            Click event for the Action->Search menu
        //                              item for searching through a list of
        //                              philosophers.
        //	Date Complete:         	11/26/2016
        //	Programmers:		    David Landry
        //	Parameters:             object sender, EventArgs e
        //	Returns:                None
        //	Input:                  Search parameters from the frmSearch
        //                              search form.
        //	Output:                 If a philosopher is found and selected,
        //                              that philosopher's info is displayed
        //                              in the main GUI form's text boxes.
        //	Calls:                  Philosopher constructor, 
        //                              frmSearch constructor, 
        //                              frmSearch.fetchPhilosopher
        //                              Philosopher.getName, 
        //                              Philosopher.getYear,
        //                              Philosopher.getCountry
        //	Called by:              btnSearch_Click
        //	Pre/Post Condition:     The method requires a non-empty list of
        //                              philosopher (wise man once said, 
        //                              "you cannot find that which does not
        //                              exist").  After execution, if the
        //                              search was successful (i.e., not
        //                              cancelled), the sought-for philosopher
        //                              should be selected in the 
        //                              lstPhilosophers list box and all
        //                              info displayed in the appropriate
        //                              text boxes.
        //	Exceptions:             None
        //	Notes:
        //--------------------------------------------------------------------
        private void mnuSearchAction_Click(object sender, EventArgs e)
        {
            Philosopher soughtPhilosopher = new Philosopher();
            frmSearch searchWindow = new frmSearch(philosophers);
            searchWindow.ShowDialog();
            soughtPhilosopher = searchWindow.fetchPhilosopher();
            if (mnuNameSort.Checked)
                lstPhilosophers.SelectedItem = soughtPhilosopher.getName();
            else if (mnuCountrySort.Checked)
                lstPhilosophers.SelectedItem = soughtPhilosopher.getName() +
                    ", " + soughtPhilosopher.getCountry();
            else if (mnuYearSort.Checked)
                lstPhilosophers.SelectedItem = soughtPhilosopher.getName() +
                    ", " + soughtPhilosopher.getYear();
            else
                lstPhilosophers.SelectedItem = soughtPhilosopher.getName();
        }

        //--------------------------------------------------------------------
        //	Method:                 mnuOpenFile_Click
        //	Description:            Event handler for the File->Open menu
        //                              item click event, used to open a new
        //                              text file containing a list of
        //                              philosophers.
        //	Date Complete:         	11/28/2016
        //	Programmers:		    David Landry
        //	Parameters:             object sender, EventArgs e
        //	Returns:                None
        //	Input:                  A selected file from the open file dialog.
        //	Output:                 The list of philosophers in the list box
        //                              and the text boxes filled in with the
        //                              info from the first philosopher.
        //	Calls:                  openFile, mnuNameSort_Click, 
        //                              refreshListBox
        //	Called by:              mnuOpenFile (File->Open) click event
        //	Pre/Post Condition:     No pre-condition.  After execution, if
        //                              a valid file was selected, the file
        //                              is loaded by the program, the
        //                              philosophers and lstPhilosophers list
        //                              box are populated, and info for the
        //                              first philosopher is displayed.
        //	Exceptions:             File exceptions are handled by 
        //                              validateFile, called by the openFile
        //                              method.
        //	Notes:                  This method was originally created to test
        //                              file exception handling.  However, I
        //                              thought it handy to be able to open
        //                              a different philosopher text file, so
        //                              I implemented this method into the
        //                              final build.
        //--------------------------------------------------------------------
        private void mnuOpenFile_Click(object sender, EventArgs e)
        {
            // Call the open file method to select and validate a file.
            openFile();

            // Sort the philosophers by name by default.
            mnuNameSort.PerformClick();

            // Add the philosophers to the list box.
            refreshListBox();
        }// End mnuFileOpne_Click method

        //--------------------------------------------------------------------
        //	Method:                 mnuListClearFile_Click
        //	Description:            Event handler for File->Clear->List
        //                              click event, used to clear the
        //                              philosophers list and the 
        //                              lstPhilosophers list box, but not the
        //                              file.
        //	Date Complete:         	11/28/2016-11/29/2016
        //	Programmers:		    David Landry
        //	Parameters:             object sender, EventArgs e
        //	Returns:                None
        //	Input:                  None
        //	Output:                 An empty list box and empty text boxes.
        //	Calls:                  refreshListBox
        //	Called by:              mnuListClearFile_Click
        //	Pre/Post Condition:     No pre-condition.  After execution, the
        //                              philosophers list and the 
        //                              lstPhilosophers should be empty and
        //                              all text fields should also be
        //                              empty.
        //	Exceptions:             None, although this method clears out the
        //                              currentFile string, meaning that
        //                              any changes to the philosophers list
        //                              won't be saved to a text file (which
        //                              the user will be warned about).
        //	Notes:
        //--------------------------------------------------------------------
        private void mnuListClearFile_Click(object sender, EventArgs e)
        {
            currentFile = "";
            lstPhilosophers.Items.Clear();
            philosophers.Clear();
            refreshListBox();
            MessageBox.Show("You have cleared all information.  Henceforth," +
                " any changes made will not be saved.  It is highly " +
                "reccommended that you open a file to associate with this " +
                "program before continuing.", "No active file.", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //--------------------------------------------------------------------
        //	Method:                 mnuFileClearFile_Click
        //	Description:            Click event handler for File->Clear->File,
        //                              clearing out the philosophers list,
        //                              lstPhilosophers list box, contents
        //                              of the current file, and all fields
        //                              in the philosophers form.
        //	Date Complete:         	11/28/2016
        //	Programmers:		    David Landry
        //	Parameters:             object sender, EventArgs e
        //	Returns:                None
        //	Input:                  The current philosopher file
        //	Output:                 An empty file and an empty form.
        //	Calls:                  mnuListClearFile_Click
        //	Called by:              None
        //	Pre/Post Condition:     No pre-condition (if there is no current
        //                              file, the method simply acts as the
        //                              list clear click event method.
        //	Exceptions:             None- System.ArgumentException is avoided
        //                              using a simple if statement.
        //	Notes:
        //--------------------------------------------------------------------
        private void mnuFileClearFile_Click(object sender, EventArgs e)
        {
            DialogResult prompt = MessageBox.Show("This will clear your " + 
                "currently active list, " + currentFile + ".  Proceed?", 
                "Clear all data?", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);
            if (prompt == DialogResult.Yes)
            {
                mnuListClearFile.PerformClick();
                if (currentFile != "")
                    System.IO.File.WriteAllText(currentFile, "");
            }
        }

        //--------------------------------------------------------------------
        //	Method:                 btnSearch_Click
        //	Description:            Click event handler for the button 
        //                              btnSearch for searching for a 
        //                              philosopher.
        //	Date Complete:         	11/28/2016
        //	Programmers:		    David Landry
        //	Parameters:             object sender, EventArgs e
        //	Returns:                None
        //	Input:                  None
        //	Output:                 None
        //	Calls:                  mnuSearchAction_Click
        //	Called by:              None
        //	Pre/Post Condition:     There ought to be a list with at least 1
        //                              philosopher.  After execution
        //                              following a successful search, the
        //                              sought-for philosopher should be
        //                              selected in lstPhilosophers and
        //                              appropriate information displayed in
        //                              the text boxes.
        //	Exceptions:             None
        //	Notes:
        //--------------------------------------------------------------------
        private void btnSearch_Click(object sender, EventArgs e)
        {
            mnuSearchAction.PerformClick();
        }

        //--------------------------------------------------------------------
        //	Method:                 mnuAddAction_Click
        //	Description:            Event handler for a click event on
        //                              the File->Action->Add menu item for
        //                              adding a new philosopher.
        //	Date Complete:         	11/28/2016
        //	Programmers:		    David Landry
        //	Parameters:             object sender, EventArgs e
        //	Returns:                None
        //	Input:                  Data entered from the frmAddPhilosopher
        //                              form.
        //	Output:                 Both the new philosopher's name in the
        //                              list box and that philosopher's info
        //                              in the text boxes.
        //	Calls:                  btnAdd_Click
        //	Called by:              Menu Action->Add click event
        //	Pre/Post Condition:     No pre-condition.  After execution, a new
        //                              philosopher is added to the list of
        //                              philosophers, the philosopher is added
        //                              to the list box and the current file,
        //                              and the new philosopher is highlighted
        //                              in the list box, his/her info
        //                              displayed in the text boxes.
        //	Exceptions:             System.ArgumentException if there is no
        //                              current file.
        //                          System.IO.IOException if the file is
        //                              in use by another process.
        //	Notes:
        //--------------------------------------------------------------------
        private void mnuAddAction_Click(object sender, EventArgs e)
        {
            btnAdd.PerformClick();
        }

        //--------------------------------------------------------------------
        //	Method:                 mnuEditAction_Click
        //	Description:            Event handler for a click event on
        //                              the Action->Edit menu item to edit a 
        //                              selected philosopher.
        //	Date Complete:         	11/28/2016
        //	Programmers:		    David Landry
        //	Parameters:             object sender, EventArgs e
        //	Returns:                None
        //	Input:                  Data entered from the frmEditPhilosopher
        //                              form.
        //	Output:                 Both the philosopher's name in the
        //                              list box and that philosopher's info
        //                              in the text boxes.
        //	Calls:                  btnEdit_Click
        //	Called by:              Click event on the Action->Edit menu item.
        //	Pre/Post Condition:     No pre-condition.  After execution, the
        //                              selected philosopher is edited in
        //                              the Philosophers list, the current
        //                              file, and possibly the list box.
        //                              His/her info is displayed in the text 
        //                              boxes.
        //	Exceptions:             System.IO.IOException if the file is
        //                              already open.
        //	Notes:
        //--------------------------------------------------------------------
        private void mnuEditAction_Click(object sender, EventArgs e)
        {
            btnEdit.PerformClick();
        }

        //--------------------------------------------------------------------
        //	Method:                 mnuDeleteAction_Click
        //	Description:            Event handler for a click event on
        //                              the Action->Edit menu item for 
        //                              deleting a selected philosopher.
        //	Date Complete:         	11/28/2016
        //	Programmers:		    David Landry
        //	Parameters:             object sender, EventArgs e
        //	Returns:                None
        //	Input:                  A philosopher to delete
        //	Output:                 A list of philosophers' names, minus the
        //                              one deleted (if deletion was 
        //                              confirmed).
        //	Calls:                  btnDelete_Click
        //	Called by:              Click event on the Action->Delete menu
        //                              item.
        //	Pre/Post Condition:     This method will not complete execution
        //                              if the philosophers list is empty.
        //                              After execution, if confirmed, the
        //                              selected philosopher will be removed
        //                              from the philosophers list, the
        //                              current file, and the list box.
        //	Exceptions:             System.IO.IOException if the current
        //                              file is already open somewhere.
        //	Notes:
        //--------------------------------------------------------------------
        private void mnuDeleteAction_Click(object sender, EventArgs e)
        {
            btnDelete.PerformClick();
        }

        //--------------------------------------------------------------------
        //	Method:                 mnuInfoPrintFile_Click
        //	Description:            Event handler for the File->Print->Info
        //                              menu item for printing the selected
        //                              philosopher's information.
        //	Date Complete:         	11/28/2016
        //	Programmers:		    David Landry
        //	Parameters:             object sender, EventArgs e
        //	Returns:                None
        //	Input:                  Properties of the selected philosopher.
        //	Output:                 A print preview document containing
        //                              information for the selected
        //                              philosopher.
        //	Calls:                  ppdPhilosopher.ShowDialog
        //	Called by:              Click event on the File->Print->Info
        //                              menu item.
        //	Pre/Post Condition:     This method assumes a selected philosopher
        //                              (but will still print an empty
        //                              info document).  After execution, a
        //                              print preview dialog window will pop
        //                              up, allowing printing of the
        //                              selected philosopher's info.
        //	Exceptions:             None
        //	Notes:
        //--------------------------------------------------------------------
        private void mnuInfoPrintFile_Click(object sender, EventArgs e)
        {
            ppdPhilosopher.Document = pdPhilosopher;
            ppdPhilosopher.ShowDialog();
        }

        //--------------------------------------------------------------------
        //	Method:                 mnuFormPrintFile_Click
        //	Description:            Event handler for the File->Print->Form
        //                              menu item for printing a screen 
        //                              capture of the form.
        //	Date Complete:         	11/28/2016
        //	Programmers:		    David Landry
        //	Parameters:             object sender, EventArgs e
        //	Returns:                None
        //	Input:                  The physical form itself.
        //	Output:                 A print preview document containing
        //                              a screen shot of the form.
        //	Calls:                  ppdPhilosopher.ShowDialog,
        //                              captureScreen
        //	Called by:              Click event on the File->Print->Form
        //                              menu item.
        //	Pre/Post Condition:     No pre-condition.  After execution, a
        //                              print preview dialog window will pop
        //                              up, allowing printing of a screen
        //                              capture of the form.
        //	Exceptions:             None
        //	Notes:
        //--------------------------------------------------------------------
        private void mnuFormPrintFile_Click(object sender, EventArgs e)
        {
            ppdPhilosopher.Document = pdScreen;
            captureScreen();
            ppdPhilosopher.ShowDialog();
        }

        //--------------------------------------------------------------------
        //	Method:                 pdScreen_PrintPage
        //	Description:            Print page event handler for the pdScreen
        //                              print document.  Builds a document
        //                              from the screen capture of the form
        //                              for printing.
        //	Date Complete:         	11/29/2016
        //	Programmers:		    David Landry
        //	Parameters:             object sender, PrintPageEventArgs e
        //	Returns:                None
        //	Input:                  The form.
        //	Output:                 A document consisting of the screen 
        //                              capture of the form.
        //	Calls:                  None
        //	Called by:              PrintPage event.
        //	Pre/Post Condition:     No pre-condition.  After execution, the
        //                              screen capture will appear in the
        //                              print preview dialog window.
        //	Exceptions:             None
        //	Notes:
        //--------------------------------------------------------------------
        private void pdScreen_PrintPage
            (object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        //--------------------------------------------------------------------
        //	Method:                 pdPhilosopher_PrintPage
        //	Description:            Print page event handler for the 
        //                              pdPhilosopher print document.  Builds 
        //                              a document from the selected 
        //                              philosopher's information
        //	Date Complete:         	11/28/2016
        //	Programmers:		    David Landry
        //	Parameters:             object sender, PrintPageEventArgs e
        //	Returns:                None
        //	Input:                  Properties of a selected philosopher.
        //	Output:                 A document consisting of info for the
        //                              selected philosopher.
        //	Calls:                  None
        //	Called by:              PrintPage event.
        //	Pre/Post Condition:     No pre-condition.  After execution, the
        //                              screen capture will appear in the
        //                              print preview dialog window.
        //	Exceptions:             None
        //	Notes:
        //--------------------------------------------------------------------
        private void pdPhilosopher_PrintPage
            (object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // The philosophy text is too long for one line, so let's break it
            //  down into several lines.
            string[] philosophy = txtPhilosophy.Text.Split(' ');
            string newPhilosophy = "";
            int lineCounter = 0;
            int wordsPerLine = 10;
            while (lineCounter < philosophy.Length)
            {
                for (int i = 0; i < wordsPerLine && lineCounter < 
                    philosophy.Length; i++)
                {
                    newPhilosophy += philosophy[lineCounter] += ' ';
                    lineCounter++;
                }
                newPhilosophy += '\n';
            }
            e.Graphics.DrawString(txtName.Text,
                new Font("Old English Text MS", 46),
                Brushes.Maroon, 100, 120);
            e.Graphics.DrawString("Country of birth:\n\t" + txtCountry.Text,
                new Font("Verdana", 12),
                Brushes.Black, 100, 250);
            e.Graphics.DrawString("Year of birth:\n\t" + txtYear.Text,
                new Font("Verdana", 12),
                Brushes.Black, 100, 350);
            e.Graphics.DrawString("Famous works:\n\t" + txtWork.Text,
                new Font("Verdana", 12),
                Brushes.Black, 100, 450);
            e.Graphics.DrawString("Philosophy:",
                new Font("Verdana", 12),
                Brushes.Black, 100, 550);
            e.Graphics.DrawString(newPhilosophy,
                new Font("Verdana", 11),
                Brushes.Black, 140, 580);
            e.Graphics.DrawString("Link:\n" + txtLink.Text,
                new Font("Verdana", 10),
                Brushes.Black, 100, 1000);
        }

        //--------------------------------------------------------------------
        //	Method:                 mnuAboutHelp_Click
        //	Description:            Event handler for a click event on the
        //                              Help->About menu item.
        //	Date Complete:         	11/29/2016
        //	Programmers:		    David Landry
        //	Parameters:             object sender, EventArgs e
        //	Returns:                None
        //	Input:                  None
        //	Output:                 The about form
        //	Calls:                  frmAboutPhilosopher constructor
        //	Called by:              Click event on Help->About
        //	Pre/Post Condition:     No pre-condition.  After execution, the
        //                              about window is shown.
        //	Exceptions:             None
        //	Notes:
        //--------------------------------------------------------------------
        private void mnuAboutHelp_Click(object sender, EventArgs e)
        {
            frmAboutPhilosopher aboutForm = new frmAboutPhilosopher();
            aboutForm.ShowDialog();
        }

        //--------------------------------------------------------------------
        //  Begin auxillary methods.
        //--------------------------------------------------------------------

        //--------------------------------------------------------------------
        //	Method:                 sortByName
        //	Description:            Sorts the philosopher list by name.
        //	Date Complete:         	11/18/2016
        //	Programmers:		    David Landry
        //	Parameters:             None
        //	Returns:                None
        //	Input:                  The list of philosophers.
        //	Output:                 The list of philosophers, sorted by name.
        //	Calls:                  Philosopher constructor,
        //                              Philosopher.getName
        //	Called by:              mnuNameSort_Click
        //	Pre/Post Condition:     The method needs a philosopher list with
        //                              at least one philosopher.  After
        //                              execution, the list will be sorted
        //                              by name in alphabetical order.
        //	Exceptions:             None
        //	Notes:                  This method uses the selection sort
        //                              algorithm.
        //--------------------------------------------------------------------
        private void sortByName()
        {
            // Make sure that the list has more than 1 item.
            if (philosophers.Count > 1)
            {
                Philosopher temp = new Philosopher();
                int selectedIndex = 0;
                string selectedValue =
                    philosophers[selectedIndex].getName();
                for (int i = 0; i < philosophers.Count; i++)
                {
                    string startingValue = philosophers[i].getName();
                    selectedIndex = i;
                    selectedValue =
                        philosophers[selectedIndex].getName();
                    int stringCompare = 0;
                    // Inner loop.  Keep track in starting index the position
                    // of the smallest.
                    for (int j = i + 1; j < philosophers.Count; j++)
                    {
                        stringCompare = string.Compare
                            (philosophers[j].getName().ToLower().Trim(),
                            philosophers[selectedIndex].getName().
                            ToLower().Trim());
                        // If the name in the inner loop is before the name of
                        // the previously selected index, stringCompare should
                        // be negative.  Change selectedIndex.
                        if (stringCompare < 1)
                        {
                            selectedIndex = j;
                            selectedValue =
                                philosophers[selectedIndex].getName();
                        }
                    }
                    // if selectedIndex no longer = i, we found the smaller 
                    //  one, so swap.
                    if (selectedIndex != i)
                    {
                        temp = philosophers[i];
                        philosophers[i] = 
                            philosophers[selectedIndex];
                        philosophers[selectedIndex] = temp;
                    }
                }// End for loop
            }// End if (listOfPhilosophers.Count > 1)
        }// End method sortByName

        //--------------------------------------------------------------------
        //	Method:                 sortByCountry
        //	Description:            Sorts the philosopher list by country of
        //                              birth.
        //	Date Complete:         	11/22/2016
        //	Programmers:		    David Landry
        //	Parameters:             None
        //	Returns:                None
        //	Input:                  The list of philosophers.
        //	Output:                 The list of philosophers, sorted by 
        //                              country.
        //	Calls:                  Philosopher constructor,
        //                              Philosopher.getCountry
        //	Called by:              mnuCountrySort_Click
        //	Pre/Post Condition:     The method needs a philosopher list with
        //                              at least one philosopher.  After
        //                              execution, the list will be sorted
        //                              by country in alphabetical order.
        //	Exceptions:             None
        //	Notes:                  This method uses the selection sort
        //                              algorithm.
        //--------------------------------------------------------------------
        private void sortByCountry()
        {
            // Make sure that the list has more than 1 item.
            if (philosophers.Count > 1)
            {
                Philosopher temp = new Philosopher();
                int selectedIndex = 0;
                string selectedValue =
                    philosophers[selectedIndex].getCountry();
                for (int i = 0; i < philosophers.Count; i++)
                {
                    string startingValue = philosophers[i].getCountry();
                    selectedIndex = i;
                    selectedValue =
                        philosophers[selectedIndex].getCountry();
                    int stringCompare = 0;
                    // Inner loop.  Keep track in starting index the position
                    // of the smallest.
                    for (int j = i + 1; j < philosophers.Count; j++)
                    {
                        stringCompare = string.Compare
                            (philosophers[j].getCountry().ToLower().Trim(),
                            philosophers[selectedIndex].getCountry().
                            ToLower().Trim());
                        // If the name in the inner loop is before the name of
                        // the previously selected index, stringCompare should
                        // be negative.  Change selectedIndex.
                        if (stringCompare < 1)
                        {
                            selectedIndex = j;
                            selectedValue =
                                philosophers[selectedIndex].getCountry();
                        }
                    }
                    // if selectedIndex no longer = i, we found the smaller 
                    //  one.  Swap.
                    if (selectedIndex != i)
                    {
                        temp = philosophers[i];
                        philosophers[i] = 
                            philosophers[selectedIndex];
                        philosophers[selectedIndex] = temp;
                    }
                }// End for loop
            }// End if (listOfPhilosophers.Count > 1)
        }// End method sortByCountry

        //--------------------------------------------------------------------
        //	Method:                 sortByYear
        //	Description:            Sorts the philosopher list by year of
        //                              birth.
        //	Date Complete:         	11/22/2016
        //	Programmers:		    David Landry
        //	Parameters:             None
        //	Returns:                None
        //	Input:                  The list of philosophers.
        //	Output:                 The list of philosophers, sorted by 
        //                              year of birth.
        //	Calls:                  Philosopher constructor,
        //                              Philosopher.getCountry
        //	Called by:              mnuYearSort_Click
        //	Pre/Post Condition:     The method needs a philosopher list with
        //                              at least one philosopher.  After
        //                              execution, the list will be sorted
        //                              by year in chronological order.
        //	Exceptions:             None
        //	Notes:                  This method uses the selection sort
        //                              algorithm.
        //--------------------------------------------------------------------
        private void sortByYear()
        {
            // Make sure that the list has more than 1 item.
            if (philosophers.Count > 1)
            {
                Philosopher temp = new Philosopher();
                int selectedIndex = 0;
                Year selectedValue =
                    philosophers[selectedIndex].getYear();
                for (int i = 0; i < philosophers.Count; i++)
                {
                    Year startingValue = philosophers[i].getYear();
                    selectedIndex = i;
                    selectedValue =
                        philosophers[selectedIndex].getYear();
                    // Inner loop.  Keep track in starting index the position
                    // of the smallest.
                    for (int j = i + 1; j < philosophers.Count; j++)
                    {
                        // If the year in the inner loop is before the year of
                        //  the previously selected index, change 
                        //  selectedIndex.
                        if (philosophers[j].getYear() < 
                            philosophers[selectedIndex].getYear())
                        {
                            selectedIndex = j;
                            selectedValue = 
                                philosophers[selectedIndex].getYear();
                        }
                    }
                    // if selectedIndex no longer = i, we found the smaller 
                    //  one.  Swap.
                    if (selectedIndex != i)
                    {
                        temp = philosophers[i];
                        philosophers[i] = 
                            philosophers[selectedIndex];
                        philosophers[selectedIndex] = temp;
                    }
                }// End for loop
            }// End if (listOfPhilosophers.Count > 1)
        }// End method sortByYear

        //--------------------------------------------------------------------
        //	Method:                 refreshListBox
        //	Description:            Refreshes the list box to reflect changes
        //                              to the list of philosophers.
        //	Date Complete:         	11/22/2016
        //	Programmers:		    David Landry
        //	Parameters:             None
        //	Returns:                None
        //	Input:                  lstPhilosophers list box, philosophers 
        //                              list
        //	Output:                 lstPhilosophers items in sync with the
        //                              list of philosophers.
        //	Calls:                  Philosophers.getName, 
        //                              Philosophers.getCountry,
        //                              Philosophers.getYear
        //	Called by:              mnuNameSort_Click, mnuYearSort_Click,
        //                              mnuCountrySort_Click, btnAdd_Click,
        //                              btnEdit_Click, btnDelete_Click,
        //                              mnuOpenFile_Click, 
        //                              mnuListClearFile_Click,
        //                              buildPhilosophers
        //	Pre/Post Condition:     No pre-condition.  After execution, the
        //                              lstPhilosophers list box will be
        //                              filled up in sync with the 
        //                              philosophers list.  If the
        //                              philosophers list is empty, so will
        //                              the list box be, and if the list box
        //                              is empty, the text boxes will be also.
        //	Exceptions:             None
        //	Notes:
        //--------------------------------------------------------------------
        private void refreshListBox()
        {
            // First, clear the list box.
            lstPhilosophers.Items.Clear();

            // Now, add philosophers to the list box.  If the user selected
            //  a sort-by-year or sort-by-country option, also display the
            //  sort parameter.
            for (int i = 0; i < philosophers.Count; i++)
            {
                string nameBuilder = philosophers[i].getName();
                nameBuilder += 
                    (mnuCountrySort.Checked) ? 
                    (", " + philosophers[i].getCountry())
                    : (mnuYearSort.Checked) ? 
                    (", " + philosophers[i].getYear()) : "";
                lstPhilosophers.Items.Add(nameBuilder);

            }
            if (lstPhilosophers.Items.Count != 0)
                lstPhilosophers.SelectedIndex = 0;
            else
            {
                txtName.Text = "";
                txtCountry.Text = "";
                txtLink.Text = "";
                txtPhilosophy.Text = "";
                txtWork.Text = "";
                txtYear.Text = "";
            }
        }// End method refreshListBox

        //--------------------------------------------------------------------
        //	Method:                 buildPhilosophers
        //	Description:            Builds the list of philosophers from the
        //                              currently active file.
        //	Date Complete:         	11/28/2016
        //	Programmers:		    David Landry
        //	Parameters:             None
        //	Returns:                None
        //	Input:                  A properly-formatted file containing
        //                              philosopher information.
        //	Output:                 A properly filled list box, 
        //                              lstPhilosophers and appropriate text
        //                              boxes.
        //	Calls:                  Philosophers.setName,
        //                              Philosophers.setCountry,
        //                              Philosophers.setYear,
        //                              Philosophers.setPhilosophy,
        //                              Philosophers.setWork,
        //                              Philosophers.setLink,
        //                              mnuNameSort_Click, refreshListBox
        //	Called by:              frmPhilosophersMainGUI_Load, openFile
        //	Pre/Post Condition:     This method requires a current valid
        //                              philosopher text file.  After 
        //                              execution, the list box will be
        //                              populated by philosophers, sorted
        //                              by name, unless the philosophers
        //                              list was empty, in which case the
        //                              list box and all text boxes will be
        //                              empty.
        //	Exceptions:             System.ArgumentException if there is no
        //                              current file.
        //	Notes:
        //--------------------------------------------------------------------
        private void buildPhilosophers()
        {
            try
            {
                System.IO.StreamReader fileReader =
                    System.IO.File.OpenText(currentFile);
                // Clear the list of philosophers
                philosophers.Clear();
                while (!fileReader.EndOfStream)
                {
                    // Build a philosopher object.
                    int index = 0;
                    string line = fileReader.ReadLine();
                    string[] elements = line.Split('|');
                    Philosopher readPhilosopher = new Philosopher();
                    readPhilosopher.setName(elements[index++]);
                    readPhilosopher.setCountry(elements[index++]);
                    readPhilosopher.setYear(new Year(elements[index++]));
                    readPhilosopher.setWork(elements[index++]);
                    readPhilosopher.setPhilosophy(elements[index++]);
                    readPhilosopher.setLink(elements[index]);
                    // Add the philosopher to the philosopher list.
                    philosophers.Add(readPhilosopher);
                }

                // Close the file
                fileReader.Close();
            }
            catch (System.ArgumentException)
            {
                // This exception occurs if there is no current file.  If
                //  there is no current file, then don't do anything.  This
                //  could lead to some wonky list setups, but that's the
                //  danger of not working with a valid philosopher text
                //  file!
            }

            // Sort the philosophers by name by default.
            mnuNameSort.PerformClick();

            // Add the philosophers to the list box.
            refreshListBox();
        }// End buildPhilosopher method

        //--------------------------------------------------------------------
        //	Method:                 validateFile
        //	Description:            Checks if a file exists and if it is in
        //                              the correct format.
        //	Date Complete:         	11/28/2016
        //	Programmers:		    David Landry
        //	Parameters:             None
        //	Returns:                A boolean: true if the file is valid, or
        //                              false if it's not.
        //	Input:                  A text file.
        //	Output:                 None
        //	Calls:                  System.IO.StreamReader methods.
        //	Called by:              frmPhilosophersMainGUI_Load,
        //                              openFile
        //	Pre/Post Condition:     No pre-condition.  After execution, a
        //                              boolean is returned depending on
        //                              the validity of the file.
        //	Exceptions:             A System.IO.IOException exception is
        //                              thrown if the file can't be accessed.
        //                              A System.ArgumentException exception 
        //                              is thrown if there is no current file.
        //	Notes:
        //--------------------------------------------------------------------
        private bool validateFile(string fileName)
        {
            //bool pressedCancel = true;
            // Start with a fileReader
            System.IO.StreamReader fileReader;

            // Outermost try block is for correct file format.
            try
            {
                //  try to open it.
                fileReader = System.IO.File.OpenText(fileName);
                // Test the contents for correct format.
                bool isGoodFormat = true;
                while (!fileReader.EndOfStream && isGoodFormat)
                {
                    string testLine = fileReader.ReadLine();
                    string[] testFields = testLine.Split('|');
                    if (testFields.Length != 6)
                        isGoodFormat = false;
                }
                fileReader.Close();
                if (isGoodFormat)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }// End validateFile method

        //--------------------------------------------------------------------
        //	Method:                 openFile
        //	Description:            Opens a selected file
        //	Date Complete:         	11/29/2016
        //	Programmers:		    David Landry
        //	Parameters:             None
        //	Returns:                None
        //	Input:                  A file gathered from the open file dialog
        //                              window.
        //	Output:                 None
        //	Calls:                  System.IO methods, validateFile,
        //                              buildPhilosophers
        //	Called by:              frmPhilosophersMainGUI_Load,
        //                              mnuOpenFile_Click
        //	Pre/Post Condition:     The method begins with no pre-condition.
        //                              After successful execution, a
        //                              list of philosophers will be built
        //                              from the file opened.  Otherwise,
        //                              the ofd will have been cancelled,
        //                              resulting in no change to the
        //                              current file.
        //	Exceptions:             Exceptions are avoided using if 
        //                              statements.  If an invalid file is
        //                              selected, the user will be prompted
        //                              to try opening another file.
        //	Notes:
        //--------------------------------------------------------------------
        private void openFile()
        {
            bool isGoodFile = true;
            string fileToAttempt = "";
            bool cancelledFileBrowse = false;
            // Get the open file dialog ready to open a file.
            // Change some of the OFD's properties:
            // Set the initial/default directory for the open file 
            // dialog to that of the application.
            ofdPhilosophers.InitialDirectory =
                System.IO.Path.GetDirectoryName
                (Application.ExecutablePath);
            ofdPhilosophers.Filter =
                "txt files (*.txt)|*.txt|All files(*.*)|*.*";
            ofdPhilosophers.FilterIndex = 1;
            ofdPhilosophers.RestoreDirectory = true;
            do
            {
                if (ofdPhilosophers.ShowDialog() == DialogResult.OK)
                {
                    fileToAttempt = ofdPhilosophers.FileName;
                    isGoodFile = validateFile(fileToAttempt);
                    if (!isGoodFile)
                        MessageBox.Show("That file is not in a "
                            + "correct format.  Each line in a text" +
                            " file must contain 6 elements " +
                            "separated by the \"|\" symbol.  Try " +
                            "again.", "Invalid format.",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    else
                        currentFile = fileToAttempt;
                }
                else
                    cancelledFileBrowse = true;
            } while (!isGoodFile && !cancelledFileBrowse);
            // If the user didn't cancel, build philosophers from
            //  the file.
            if (!cancelledFileBrowse)
                buildPhilosophers();
            else
            {
                if (currentFile == "")
                    // If there is no current file, remind the user that
                    //  changes will not be saved.
                    MessageBox.Show("You have no current file associated"
                        + " with your list of philosophers.  Changes will"
                        + " not be saved.", "No active file.",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }// End openFile method

        //--------------------------------------------------------------------
        //	Method:                 captureScreen
        //	Description:            Captures the screen for form printing
        //	Date Complete:         	11/28/2016
        //	Programmers:		    David Landry
        //	Parameters:             None
        //	Returns:                None
        //	Input:                  The form itself
        //	Output:                 None
        //	Calls:                  Graphics methods, Bitmap constructor
        //	Called by:              mnuFormPrintFile_Click
        //	Pre/Post Condition:     No pre-condition.  After execution,
        //                              the bitmap is set up for display
        //                              of the form in the print preview
        //                              dialog window.
        //	Exceptions:             None
        //	Notes:
        //--------------------------------------------------------------------
        private void captureScreen()
        {
            Graphics myGraphics = CreateGraphics();
            Size sizeImage = Size;
            memoryImage = new Bitmap
                (sizeImage.Width, sizeImage.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen
                (Location.X, Location.Y, 0, 0, sizeImage);
        }

    }// End class frmPhilosophersMainGUI
}// End namespace Project3FamousPhilosophers