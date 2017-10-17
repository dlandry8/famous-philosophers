using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------------------------------------------------------------------------
Comments by the professor:

------------------------------------------------------------------------------
Class Name:         Philosopher
Created by:     	David Landry
Dates:              11/15-17/2016; Project date: 11/29/2016
Class:		        CS 218 A
Time:               Approx. 1 hour.
Platform:           PC running Windows 10; 
                    Compiled with Visual Studio Community 2015 C#

Properties:                 
        private string m_name:          A philosopher's name.
        private Year m_year:            A year object.  A philosopher's year
                                            of birth.
        private string m_country        A philosopher's country of birth.
        private string m_work           A philosopher's significant works
                                            or writings.
        private string m_philosophy     A description of a philosopher's
                                            philosophies or a brief bio of
                                            the philosopher.
        private string m_link           A link to discover more information
                                            about the philosopher.

Description:
    This is a simple class that defines a Philosopher data type.  This class
    is an object class, allowing instantiation of one (or several)
    Philosopher(s).
------------------------------------------------------------------------------
Comments by the student:
    This is a fairly simple data type.  It does require the use of a
    Year class data object, supplied by this project.
--------------------------------------------------------------------------- */

namespace Project3FamousPhilosophers
{
    public class Philosopher
    {
        //--------------------------------------------------------------------
        //  Constructors
        //--------------------------------------------------------------------

        //--------------------------------------------------------------------
        //	Method:                 Philosopher
        //	Description:            Default constructor
        //	Parameters:             None
        //	Returns:                None
        //	Calls:                  Year constructor
        //--------------------------------------------------------------------
        public Philosopher()
        {
            m_name = "";
            m_year = new Year();
            m_philosophy = "";
            m_work = "";
            m_country = "";
            m_link = "";
        }

        //--------------------------------------------------------------------
        //	Method:                 Philosopher
        //	Description:            An overloaded constructor.  Constructs
        //                              a philosopher object given user-
        //                              supplied arguments.
        //	Parameters:             A string for the name,
        //                              A Year object for the year,
        //                              A string for the country of birth,
        //                              A string for the philosophy,
        //                              A string for famous works,
        //                              A string for the link for more info.
        //	Returns:                None
        //	Calls:                  Year constructor
        //--------------------------------------------------------------------
        public Philosopher(string name, Year yearOfBirth,
            string country, string philosophy, string link)
        {
            m_name = name;
            // Create a new year object.  The Year constructor handles any
            //  needed validation.
            m_year = new Year(yearOfBirth);
            m_country = country;
            m_philosophy = philosophy;
            m_link = link;
        }

        //--------------------------------------------------------------------
        //	Method:                 Philosopher
        //	Description:            The overloaded copy constructor.  
        //                              Constructs one philosopher object
        //                              from the data of another philosopher
        //                              object.
        //	Parameters:             A Philosopher object: the source object
        //                              to copy from.
        //	Returns:                None
        //	Calls:                  Year constructor
        //--------------------------------------------------------------------
        public Philosopher(Philosopher source)
        {
            m_name = source.m_name;
            m_year = new Year(source.m_year);
            m_country = source.m_country;
            m_philosophy = source.m_philosophy;
            m_link = source.m_link;
        }

        //--------------------------------------------------------------------
        // Accessors:
        //--------------------------------------------------------------------

        //--------------------------------------------------------------------
        //	Method:                 getName
        //	Description:            Retrieves the philosopher's name.
        //	Parameters:             None
        //	Returns:                A string: the philosopher's name (m_name)
        //--------------------------------------------------------------------
        public string getName()
        {
            return m_name;
        }

        //--------------------------------------------------------------------
        //	Method:                 getYear
        //	Description:            Retrieves the philosopher's year of birth.
        //	Parameters:             None
        //	Returns:                A Year object: the philosopher's year of
        //                              birth (m_year)
        //	Calls:                  The Year constructor.
        //--------------------------------------------------------------------
        public Year getYear()
        {
            return new Year(m_year);
        }

        //--------------------------------------------------------------------
        //	Method:                 getCountry
        //	Description:            Retrieves the philosopher's country of 
        //                              birth.
        //	Parameters:             None
        //	Returns:                A string: the philosopher's country of
        //                              birth (m_country)
        //--------------------------------------------------------------------
        public string getCountry()
        {
            return m_country;
        }

        //--------------------------------------------------------------------
        //	Method:                 getPhilosophy
        //	Description:            Retrieves the philosopher's philosophical
        //                              info.
        //	Parameters:             None
        //	Returns:                A string: the philosopher's philosophy
        //                              (m_country)
        //--------------------------------------------------------------------
        public string getPhilosophy()
        {
            return m_philosophy;
        }

        //--------------------------------------------------------------------
        //	Method:                 getWork
        //	Description:            Retrieves the philosopher's famous works.
        //	Parameters:             None
        //	Returns:                A string: the philosopher's famous
        //                              works (m_work)
        //--------------------------------------------------------------------
        public string getWork()
        {
            return m_work;
        }

        //--------------------------------------------------------------------
        //	Method:                 getLink
        //	Description:            Retrieves the link to get more info about
        //                              the philosopher.
        //	Parameters:             None
        //	Returns:                A string: the link to the philosopher's
        //                              information (m_link)
        //--------------------------------------------------------------------
        public string getLink()
        {
            return m_link;
        }

        //--------------------------------------------------------------------
        // Mutators:
        //--------------------------------------------------------------------

        //--------------------------------------------------------------------
        //	Method:                 setName
        //	Description:            Sets the philosopher's name (m_name)
        //	Parameters:             A string with which to set the 
        //                              philosopher's name
        //	Returns:                None
        //--------------------------------------------------------------------
        public void setName(string name)
        {
            m_name = name;
        }

        //--------------------------------------------------------------------
        //	Method:                 setYear
        //	Description:            Sets the philosopher's year of birth 
        //                              (m_year)
        //	Parameters:             An integer and a string with which to set 
        //                              the philosopher's year of birth.
        //	Returns:                None
        //	Calls:                  Year object constructor
        //--------------------------------------------------------------------
        public void setYear(int year, string era)
        {
            m_year = new Year(year, era);
        }

        //--------------------------------------------------------------------
        //	Method:                 setYear
        //	Description:            Sets the philosopher's year of birth 
        //                              (m_year)
        //	Parameters:             A Year object with which to set the
        //                              philosopher's year of birth.
        //	Returns:                None
        //--------------------------------------------------------------------
        public void setYear(Year year)
        {
            m_year = year;
        }

        //--------------------------------------------------------------------
        //	Method:                 setCountry
        //	Description:            Sets the philosopher's country of birth 
        //                              (m_country)
        //	Parameters:             A string with which to set the 
        //                              philosopher's country of birth.
        //	Returns:                None
        //--------------------------------------------------------------------
        public void setCountry(string country)
        {
            m_country = country;
        }

        //--------------------------------------------------------------------
        //	Method:                 setWork
        //	Description:            Sets the philosopher's works (m_work)
        //	Parameters:             A string with which to set the 
        //                              philosopher's works
        //	Returns:                None
        //--------------------------------------------------------------------
        public void setWork(string work)
        {
            m_work = work;
        }

        //--------------------------------------------------------------------
        //	Method:                 setPhilosophy
        //	Description:            Sets the philosopher's philosophy 
        //                              (m_philosophy)
        //	Parameters:             A string with which to set the 
        //                              philosopher's philosophy.
        //	Returns:                None
        //--------------------------------------------------------------------
        public void setPhilosophy(string philosophy)
        {
            m_philosophy = philosophy;
        }

        //--------------------------------------------------------------------
        //	Method:                 setLink
        //	Description:            Sets the link with which to obtain more
        //                              info on the philosopher (m_link)
        //	Parameters:             A string with which to set the 
        //                              philosopher's link
        //	Returns:                None
        //--------------------------------------------------------------------
        public void setLink (string link)
        {
            m_link = link;
        }

        //--------------------------------------------------------------------
        // Private properties
        //--------------------------------------------------------------------
        private string m_name;
        private Year m_year;
        private string m_country;
        private string m_work;
        private string m_philosophy;
        private string m_link;

    }// End class Philosopher
}// End namespace Project3FamousPhilosophers
