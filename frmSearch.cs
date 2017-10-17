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
    This is the edit philosopher form for the Famous Philosophers database
    program.
------------------------------------------------------------------------------
Required Input:
    A non-empty list of philosophers is required.
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
    public partial class frmSearch : Form
    {
        // Class variables
        List<Philosopher> searchList;
        Philosopher foundPhilosopher = new Philosopher();
        bool selectedPhilosopher = false;
        List<int> foundIndexes = new List<int>();

        //--------------------------------------------------------------------
        //	Method:                 frmSearch
        //	Description:            Default constructor for the search form.
        //	Date Complete:         	11/26/2016
        //	Programmers:		    David Landry
        //	Parameters:             None
        //	Returns:                None
        //	Input:                  None
        //	Output:                 The form and its controls.
        //	Calls:                  Designer.InitializeComponent
        //	Called by:              None
        //	Pre/Post Condition:     The constructor will only be called if
        //                              the philosophers list is not empty.
        //                              After execution, an empty search
        //                              form will be created.
        //	Exceptions:             None
        //	Notes:
        //--------------------------------------------------------------------

        //--------------------------------------------------------------------
        // Default constructor
        //  11/26/16
        //--------------------------------------------------------------------
        public frmSearch()
        {
            InitializeComponent();
        }

        //--------------------------------------------------------------------
        //	Method:                 frmSearch
        //	Description:            Overloaded constructor for the search 
        //                              form.
        //	Date Complete:         	11/26/2016
        //	Programmers:		    David Landry
        //	Parameters:             None
        //	Returns:                None
        //	Input:                  None
        //	Output:                 The form and its controls.
        //	Calls:                  Designer.InitializeComponent
        //	Called by:              frmPhilosopherMainGUI.btnSearch_Click
        //	Pre/Post Condition:     The constructor will only be called if
        //                              the philosophers list is not empty.
        //                              After execution, an empty search
        //                              form will be created.
        //	Exceptions:             None
        //	Notes:
        //--------------------------------------------------------------------
        public frmSearch(List<Philosopher> philosophers)
        {
            InitializeComponent();
            searchList = philosophers;
            txtSearchString.Focus();
        }
        //--------------------------------------------------------------------
        //	Method:                 radName_CheckedChanged
        //	Description:            Event handler for when the radName's
        //                              checked status is changed
        //	Date Complete:         	11/27/2016
        //	Programmers:		    David Landry
        //	Parameters:             object sender, EventArgs e
        //	Returns:                None
        //	Input:                  None
        //	Output:                 None
        //	Calls:                  switchControls()
        //	Called by:              Checked changed event on radName
        //	Pre/Post Condition:     No pre-condition.  After execution,
        //                              different text boxes may become
        //                              visible/invisible and either the
        //                              search text box or the year from
        //                              text box will be focused.
        //	Exceptions:             None
        //	Notes:
        //--------------------------------------------------------------------
        private void radName_CheckedChanged(object sender, EventArgs e)
        {
            switchControls();
        }

        //--------------------------------------------------------------------
        //	Method:                 radCountry_CheckedChanged
        //	Description:            Event handler for when the radCountry's
        //                              checked status is changed
        //	Date Complete:         	11/27/2016
        //	Programmers:		    David Landry
        //	Parameters:             object sender, EventArgs e
        //	Returns:                None
        //	Input:                  None
        //	Output:                 None
        //	Calls:                  switchControls()
        //	Called by:              Checked changed event on radCountry
        //	Pre/Post Condition:     No pre-condition.  After execution,
        //                              different text boxes may become
        //                              visible/invisible and either the
        //                              search text box or the year from
        //                              text box will be focused.
        //	Exceptions:             None
        //	Notes:
        //--------------------------------------------------------------------
        private void radCountry_CheckedChanged(object sender, EventArgs e)
        {
            switchControls();
        }

        //--------------------------------------------------------------------
        //	Method:                 radPhilosophy_CheckedChanged
        //	Description:            Event handler for when the radPhilosophy's
        //                              checked status is changed
        //	Date Complete:         	11/27/2016
        //	Programmers:		    David Landry
        //	Parameters:             object sender, EventArgs e
        //	Returns:                None
        //	Input:                  None
        //	Output:                 None
        //	Calls:                  switchControls()
        //	Called by:              Checked changed event on radPhilosophy
        //	Pre/Post Condition:     No pre-condition.  After execution,
        //                              different text boxes may become
        //                              visible/invisible and either the
        //                              search text box or the year from
        //                              text box will be focused.
        //	Exceptions:             None
        //	Notes:
        //--------------------------------------------------------------------
        private void radPhilosophy_CheckedChanged(object sender, EventArgs e)
        {
            switchControls();
        }

        //--------------------------------------------------------------------
        //	Method:                 radWork_CheckedChanged
        //	Description:            Event handler for when the radWork's
        //                              checked status is changed
        //	Date Complete:         	11/27/2016
        //	Programmers:		    David Landry
        //	Parameters:             object sender, EventArgs e
        //	Returns:                None
        //	Input:                  None
        //	Output:                 None
        //	Calls:                  switchControls()
        //	Called by:              Checked changed event on radWork
        //	Pre/Post Condition:     No pre-condition.  After execution,
        //                              different text boxes may become
        //                              visible/invisible and either the
        //                              search text box or the year from
        //                              text box will be focused.
        //	Exceptions:             None
        //	Notes:
        //--------------------------------------------------------------------
        private void radWork_CheckedChanged(object sender, EventArgs e)
        {
            switchControls();
        }

        //--------------------------------------------------------------------
        //	Method:                 radYear_CheckedChanged
        //	Description:            Event handler for when the radYear's
        //                              checked status is changed
        //	Date Complete:         	11/27/2016
        //	Programmers:		    David Landry
        //	Parameters:             object sender, EventArgs e
        //	Returns:                None
        //	Input:                  None
        //	Output:                 None
        //	Calls:                  switchControls()
        //	Called by:              Checked changed event on radYear
        //	Pre/Post Condition:     No pre-condition.  After execution,
        //                              different text boxes may become
        //                              visible/invisible and either the
        //                              search text box or the year from
        //                              text box will be focused.
        //	Exceptions:             None
        //	Notes:
        //--------------------------------------------------------------------
        private void radYear_CheckedChanged(object sender, EventArgs e)
        {
            switchControls();
        }

        //--------------------------------------------------------------------
        //	Method:                 btnSearch_Click
        //	Description:            Event handler for a click event on the
        //                              button btnSearch.  This event handler
        //                              is nothing more than a traffic
        //                              director.
        //	Date Complete:         	11/27/2016
        //	Programmers:	    	David Landry
        //	Parameters:             object sender, EventArgs e
        //	Returns:                None
        //	Input:                  One of the search text boxes (or 2 if
        //                              by year).
        //	Output:                 None
        //	Calls:                  searchName, searchCountry, searchYear,
        //                              searchPhilosophy, searchWork
        //	Called by:              Click event on btnSearch
        //	Pre/Post Condition:     The visible text field(s) should be
        //                              filled before this is executed.
        //                              After execution, a method is called
        //                              depending on what the user is
        //                              searching for.
        //	Exceptions:             None
        //	Notes:
        //--------------------------------------------------------------------
        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstPhilosophers.Items.Clear();
            foundIndexes.Clear();
            if (radName.Checked)
                searchName();
            else if (radCountry.Checked)
                searchCountry();
            else if (radYear.Checked)
                searchYear();
            else if (radPhilosophy.Checked)
                searchPhilosophy();
            else if (radWork.Checked)
                searchWork();
            if (lstPhilosophers.Items.Count > 0)
                lstPhilosophers.SelectedIndex = 0;
        }

        //--------------------------------------------------------------------
        //	Method:                 btnSelect_Click 
        //	Description:            Event handler for a click event on
        //                              btnSelect.  This selects a philosopher
        //                              from the list, whose name appears in 
        //                              this form's lstPhilosopher list box.
        //	Date Complete:         	11/28/2016
        //	Programmers:		    David Landry
        //	Parameters:             object sender, EventArgs e
        //	Returns:                None
        //	Input:                  An item in this form's lstPhilosophers
        //                              list box.
        //	Output:                 The sought-for philosopher.
        //	Calls:                  None
        //	Called by:              None
        //	Pre/Post Condition:     The button won't be visible until the
        //                              user has successfully sought for
        //                              a philosopher.  After execution,
        //                              a philosopher will have been filled
        //                              in with info based on index after
        //                              searching that may be fetched from
        //                              the main GUI via the fetchPhilosopher
        //                              method.
        //	Exceptions:             None
        //	Notes:                  
        //--------------------------------------------------------------------
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lstPhilosophers.SelectedIndex >= 0)
            {
                int index = foundIndexes[lstPhilosophers.SelectedIndex];
                foundPhilosopher = searchList[index];
                selectedPhilosopher = true;
                Close();
            }
        }

        //--------------------------------------------------------------------
        //	Method:                 btnCancel_Click
        //	Description:            Event handler for the click event for
        //                              the btnCancel button.
        //	Date Complete:         	11/28/2016
        //	Programmers:		    David Landry
        //	Parameters:             object sender, EventArgs e
        //	Returns:                None
        //	Input:                  None
        //	Output:                 None
        //	Calls:                  Dispose
        //	Called by:              Click event on btnCancel
        //	Pre/Post Condition:     No pre-condition.  After execution, the
        //                              search form will close without
        //                              returning a sought-for philosopher.
        //	Exceptions:             None
        //	Notes:
        //--------------------------------------------------------------------
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        //--------------------------------------------------------------------
        //	Method:                 fetchPhilosopher
        //	Description:            Public method for fetching the philosopher
        //                              the user was looking for (this IS the
        //                              philosopher you're looking for).
        //	Date Complete:         	11/26/2016
        //	Programmers:		    David Landry
        //	Parameters:             None
        //	Returns:                A philosopher object- the philosopher the
        //                              user was looking for.
        //	Input:                  None
        //	Output:                 The philosopher.
        //	Calls:                  None
        //	Called by:              frmPhilosophersMainGUI.btnSearch_Click
        //	Pre/Post Condition:     This method assumes a philosopher has
        //                              been successfuly sought for.  After
        //                              execution, the main GUI will have
        //                              the sought-for philosopher for
        //                              display purposes.
        //	Exceptions:             None
        //	Notes:
        //--------------------------------------------------------------------
        public Philosopher fetchPhilosopher()
        {
            return foundPhilosopher;
        }

        //--------------------------------------------------------------------
        //	Method:                 switchControls
        //	Description:            This method switches which controls are
        //                              visible based on how the user wants
        //                              to search.
        //	Date Complete:         	11/27/2016
        //	Programmers:		    David Landry
        //	Parameters:             None
        //	Returns:                None
        //	Input:                  None
        //	Output:                 Different controls visible & invisible.
        //	Calls:                  None
        //	Called by:              radName_CheckChanged,
        //                          radYear_CheckChanged,
        //                          radCountry_CheckChanged,
        //                          radPhilosophy_CheckChanged,
        //                          radWork_CheckChanged,
        //	Pre/Post Condition:     No pre-condition.  After execution, some
        //                              of the controls will have their
        //                              visibility changed.
        //	Exceptions:             None
        //	Notes:
        //--------------------------------------------------------------------
        private void switchControls()
        {
            if (radYear.Checked)
            {
                txtSearchString.Visible = false;
                lblFrom.Visible = true;
                lblTo.Visible = true;
                txtFrom.Visible = true;
                txtTo.Visible = true;
                txtFrom.Focus();
                txtFrom.SelectAll();
            }
            else
            {
                txtSearchString.Visible = true;
                lblFrom.Visible = false;
                lblTo.Visible = false;
                txtFrom.Visible = false;
                txtTo.Visible = false;
                txtSearchString.Focus();
                txtSearchString.SelectAll();
            }
        }

        //--------------------------------------------------------------------
        //	Method:                 searchName
        //	Description:            Method that searches the list of 
        //                              philosophers for the desired name.
        //	Date Complete:         	11/27/2016
        //	Programmers:		    David Landry
        //	Parameters:             None
        //	Returns:                None
        //	Input:                  txtSearchString.Text
        //	Output:                 A philosopher's name added to this
        //                              form's lstPhilosophers list box.
        //	Calls:                  Philosophers.getName, String.Contains
        //	Called by:              btnSearch_Click
        //	Pre/Post Condition:     The method works properly only if the
        //                              requisite search text box has been
        //                              filled.  After execution, an index
        //                              is added to the foundIndexes list
        //                              and a philosopher's name is added
        //                              to the list box.
        //	Exceptions:             None
        //	Notes:
        //--------------------------------------------------------------------
        private void searchName()
        {
            string searchTerm = txtSearchString.Text;
            for (int i = 0; i < searchList.Count; i++)
            {
                string searchFor = searchList[i].getName();
                if (searchFor.Trim().ToLower().Contains(searchTerm.Trim().ToLower()))
                {
                    lstPhilosophers.Items.Add(searchFor);
                    foundIndexes.Add(i);
                }
            }
            if (lstPhilosophers.Items.Count > 0)
                btnSelect.Visible = true;
            else
                btnSelect.Visible = false;
        }

        //--------------------------------------------------------------------
        //	Method:                 searchCountry
        //	Description:            Method that searches the list of 
        //                              philosophers for the desired country.
        //	Date Complete:         	11/27/2016
        //	Programmers:		    David Landry
        //	Parameters:             None
        //	Returns:                None
        //	Input:                  txtSearchString.Text
        //	Output:                 A philosopher's name and country added to 
        //                              this form's lstPhilosophers list box.
        //	Calls:                  Philosophers.getName, 
        //                              Philosophers.getCountry, 
        //                              String.Contains
        //	Called by:              btnSearch_Click
        //	Pre/Post Condition:     The method works properly only if the
        //                              requisite search text box has been
        //                              filled.  After execution, an index
        //                              is added to the foundIndexes list
        //                              and a philosopher's name and country
        //                              is added to the list box.
        //	Exceptions:             None
        //	Notes:
        //--------------------------------------------------------------------
        private void searchCountry()
        {
            string searchTerm = txtSearchString.Text;
            for (int i = 0; i < searchList.Count; i++)
            {
                string searchFor = searchList[i].getCountry();
                if (searchFor.Trim().ToLower().Contains(searchTerm.Trim().
                    ToLower()))
                {
                    lstPhilosophers.Items.Add(searchList[i].getName() + ", " + 
                        searchFor);
                    foundIndexes.Add(i);
                }
            }
            if (lstPhilosophers.Items.Count > 0)
                btnSelect.Visible = true;
            else
                btnSelect.Visible = false;
        }

        //--------------------------------------------------------------------
        //	Method:                 searchPhilosophy
        //	Description:            Method that searches the list of 
        //                              philosophers for the desired 
        //                              philosophy.
        //	Date Complete:         	11/27/2016
        //	Programmers:		    David Landry
        //	Parameters:             None
        //	Returns:                None
        //	Input:                  txtSearchString.Text
        //	Output:                 A philosopher's name and philosophy 
        //                              added to this form's lstPhilosophers 
        //                              list box.
        //	Calls:                  Philosophers.getName, 
        //                          Philosophers.getPhilosophy,
        //                          String.Contains
        //	Called by:              btnSearch_Click
        //	Pre/Post Condition:     The method works properly only if the
        //                              requisite search text box has been
        //                              filled.  After execution, an index
        //                              is added to the foundIndexes list
        //                              and a philosopher's name and 
        //                              philosophy is added to the list box.
        //	Exceptions:             None
        //	Notes:
        //--------------------------------------------------------------------
        private void searchPhilosophy()
        {
            string searchTerm = txtSearchString.Text;
            for (int i = 0; i < searchList.Count; i++)
            {
                string searchFor = searchList[i].getPhilosophy();
                if (searchFor.Trim().ToLower().Contains(searchTerm.Trim().ToLower()))
                {
                    lstPhilosophers.Items.Add(searchList[i].getName() + ", " + searchFor);
                    foundIndexes.Add(i);
                }
            }
            if (lstPhilosophers.Items.Count > 0)
                btnSelect.Visible = true;
            else
                btnSelect.Visible = false;
        }

        //--------------------------------------------------------------------
        //	Method:                 searchWork
        //	Description:            Method that searches the list of 
        //                              philosophers for the desired 
        //                              work.
        //	Date Complete:         	11/27/2016
        //	Programmers:		    David Landry
        //	Parameters:             None
        //	Returns:                None
        //	Input:                  txtSearchString.Text
        //	Output:                 A philosopher's name and work 
        //                              added to this form's lstPhilosophers 
        //                              list box.
        //	Calls:                  Philosophers.getName, 
        //                          Philosophers.getWork,
        //                          String.Contains
        //	Called by:              btnSearch_Click
        //	Pre/Post Condition:     The method works properly only if the
        //                              requisite search text box has been
        //                              filled.  After execution, an index
        //                              is added to the foundIndexes list
        //                              and a philosopher's name and 
        //                              works are added to the list box.
        //	Exceptions:             None
        //	Notes:
        //--------------------------------------------------------------------
        private void searchWork()
        {
            string searchTerm = txtSearchString.Text;
            for (int i = 0; i < searchList.Count; i++)
            {
                string searchFor = searchList[i].getWork();
                if (searchFor.Trim().ToLower().Contains(searchTerm.Trim().ToLower()))
                {
                    lstPhilosophers.Items.Add(searchList[i].getName() + ", " + searchFor);
                    foundIndexes.Add(i);
                }   
            }
            if (lstPhilosophers.Items.Count > 0)
                btnSelect.Visible = true;
            else
                btnSelect.Visible = false;
        }

        //--------------------------------------------------------------------
        //	Method:                 searchYear
        //	Description:            Method that searches the list of 
        //                              philosophers for the year of birth
        //                              in the indicated range.
        //	Date Complete:         	11/27/2016
        //	Programmers:		    David Landry
        //	Parameters:             None
        //	Returns:                None
        //	Input:                  txtSearchString.Text
        //	Output:                 A philosopher's name and year of birth 
        //                              added to this form's lstPhilosophers 
        //                              list box.
        //	Calls:                  Philosophers.getName, 
        //                          Philosophers.getYear,
        //                          String.Contains
        //	Called by:              btnSearch_Click
        //	Pre/Post Condition:     The method works properly only if the
        //                              requisite search text box has been
        //                              filled.  After execution, an index
        //                              is added to the foundIndexes list
        //                              and a philosopher's name and 
        //                              year of birth is added to the list 
        //                              box.
        //	Exceptions:             None
        //	Notes:
        //--------------------------------------------------------------------
        private void searchYear()
        {
            Year fromTerm = Year.Parse(txtFrom.Text);
            Year toTerm = Year.Parse(txtTo.Text);
            for (int i = 0; i < searchList.Count; i++)
            {
                Year searchFor = searchList[i].getYear();
                if (searchFor <= toTerm && searchFor >= fromTerm)
                {
                    lstPhilosophers.Items.Add(searchList[i].getName() + ", " + searchFor);
                    foundIndexes.Add(i);
                }
            }
            if (lstPhilosophers.Items.Count > 0)
                btnSelect.Visible = true;
            else
                btnSelect.Visible = false;
        }

    }// End class frmSearch
}// End namespace Project3FamousPhilosophers