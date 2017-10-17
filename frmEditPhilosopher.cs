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
    public partial class frmEditPhilosopher : Form
    {
        // Class variables
        Philosopher toEdit = new Philosopher();
        public bool pressedSave = false;
        string originalName = "";

        //--------------------------------------------------------------------
        //	Method:                 frmEditPhilosopher constructor
        //	Description:            The default constructor for this form.
        //	Date Complete:          11/25/2016
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
        public frmEditPhilosopher()
        {
            InitializeComponent();
        }

        //--------------------------------------------------------------------
        //	Method:                 frmEditPhilosopher overloaded constructor
        //	Description:            An overloaded constructor for this form.
        //	Date Complete:          11/25/2016
        //	Programmers:			Microsoft, David Landry
        //	Parameters:             A Philosopher, toEdit, sent from the
        //                              main GUI.
        //	Returns:                None
        //	Input:                  Properties of the aforementioned
        //                              Philosopher.
        //	Output:                 Philosopher properties filled into
        //                              each text box.
        //	Calls:                  InitializeComponent() in Designer.cs
        //                              Philosopher.getName,
        //                              Philosopher.getCountry,
        //                              Philosopher.getYear
        //                              Philosopher.getPhilosophy,
        //                              Philosopher.getWork
        //                              Philosopher.getLink
        //	Called by:              btnEdit_Click
        //	Pre/Post Condition:     No pre-condition.  After the method
        //                              call has completed, all controls'
        //                              properties are set, the form load
        //                              method is called, and the form is
        //                              displayed.
        //	Exceptions:             None
        //	Notes:
        //--------------------------------------------------------------------
        public frmEditPhilosopher(Philosopher toEdit)
        {
            InitializeComponent();
            txtName.Text = toEdit.getName();
            txtCountry.Text = toEdit.getCountry();
            txtYear.Text = toEdit.getYear().ToString();
            txtWork.Text = toEdit.getWork();
            txtPhilosophy.Text = toEdit.getPhilosophy();
            txtLink.Text = toEdit.getLink();
            originalName = txtName.Text;
        }

        //--------------------------------------------------------------------
        //	Method:                 btnCancel_Click
        //	Description:            Event handler for the btnCancel button.
        //                              Cancels the file editing process and
        //                              closes the edit form.
        //	Date Complete:         	11/26/2016
        //	Programmers:		    David Landry
        //	Parameters:             object sender, EventArgs e
        //	Returns:                None
        //	Input:                  None
        //	Output:                 None
        //	Calls:                  None
        //	Called by:              None
        //	Pre/Post Condition:     No pre-condition.  After execution, this
        //                              edit form is closed without any
        //                              philosopher info stored.
        //	Exceptions:             None
        //	Notes:
        //--------------------------------------------------------------------
        private void btnCancel_Click(object sender, EventArgs e)
        {
            pressedSave = false;
            Dispose();
        }

        //--------------------------------------------------------------------
        //	Method:                 retrieveNewInfo
        //	Description:            Public method that fetches the philosopher
        //                              put together by this form.
        //	Date Complete:         	11/26/2016
        //	Programmers:		    David Landry
        //	Parameters:             None
        //	Returns:                The philosopher created from the Save
        //                              button click event.
        //	Input:                  The created philosopher.
        //	Output:                 The created philosopher.
        //	Calls:                  None
        //	Called by:              frmPhilosopherMainGUI.btnEdit_Click
        //	Pre/Post Condition:     The method will only work when a proper
        //                              philosopher has been created.  After
        //                              execution, the main GUI will take
        //                              hold of the created philosopher.
        //	Exceptions:             None
        //	Notes:
        //--------------------------------------------------------------------
        public Philosopher retrieveNewInfo()
        {
            return toEdit;
        }

        //--------------------------------------------------------------------
        //	Method:                 btnAdd_Click
        //	Description:            Event handler for a click event on the
        //                              btnAdd button.
        //	Date Complete:          11/26/2016 	
        //	Programmers:		    David Landry
        //	Parameters:             object sender, EventArgs e
        //	Returns:                None
        //	Input:                  Text for each philosopher property.
        //	Output:                 None
        //	Calls:                  Validation.hasNumeral,
        //                          Philosopher.setName,
        //                          Philosopher.setCountry,
        //                          Philosopher.setYear,
        //                          Philosopher.setPhilosophy,
        //                          Philosopher.setWork
        //                          Philosopher.setLink, Year.Parse
        //	Called by:              btnAdd click event         
        //	Pre/Post Condition:     Before execution, all text fields should
        //                              be filled out.  After successful
        //                              execution, a philosopher object
        //                              will take on the properties of the
        //                              text boxes to be fetched by the
        //                              main form.
        //	Exceptions:             None
        //	Notes:                  This method doesn't actually "add" the
        //                              philosopher.  Rather, it puts a
        //                              philosopher together so that the
        //                              main form can fetch it via a call to
        //                              the fetchPhilosopher method.
        //                              This method should have been
        //                              btnSave_Click, but I forgot to change
        //                              the name of the button I copied from
        //                              the frmAddPhilosopher form, thus its
        //                              different name.
        //--------------------------------------------------------------------
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Edit a philosopher 
            if (txtName.Text != "" && txtCountry.Text != "" &&
                txtLink.Text != "" && txtPhilosophy.Text != "" &&
                txtWork.Text != "" && txtYear.Text != "")
            {
                if (!Validation.hasNumeral(txtName.Text))
                {
                    toEdit.setName(txtName.Text);
                    if (!Validation.hasNumeral(txtCountry.Text))
                    {
                        toEdit.setCountry(txtCountry.Text);
                        toEdit.setYear(Year.Parse(txtYear.Text));
                        toEdit.setWork(txtWork.Text);
                        toEdit.setPhilosophy(txtPhilosophy.Text);
                        toEdit.setLink(txtLink.Text);
                        pressedSave = true;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Country should not have a number.");
                        txtCountry.Focus();
                        txtCountry.SelectAll();
                    }

                }
                else
                {
                    MessageBox.Show("Name should not have a number.");
                    txtName.Focus();
                    txtName.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("Please fill in each field.", "Attention!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }// End class frmEditPhilosopher
}// End namespace Project3FamousPhilosophers