IBS APPLICATION EXERCISE

DEVELOPMENT ONBOARDING

Here is a little exercise that will give you something to aim for while learning the technology and toolsets. 

TECHNICAL REQUIREMENTS
  
  •	SQL database to store the data 
  
  •	Angular application front end using Dev Extreme controls
  
  o	Written in typescript and html

  Can also be written in C# using WinForms. 

THE APPLICATION WILL NEED THE FOLLOWING:

PEOPLE MODULE
  
  o	Section to add, update and delete people
  
  o	Information to be collected:
  
    	First Name
  
    	Last Name
  
    	Phone Number
    
    	Email
    
    	Active
    
    	Start Date
    
    	End Date

  o	Rules:

    	First name, last name, and email are required fields

    	Default person to active when adding a new person

    	Email addresses must be unique

DEPARTMENT MODULE

  o	Section to add, update and delete departments

  o	Information to be collected:

    	Department Name

    	Department Abbreviation

  o	Rules: 

    	Department Name is required 

    	Cannot have duplicate department names or abbreviations

    	Cannot delete departments which have people assigned to them

DEPARTMENT ASSIGNMENT MODULE

  o	Section to allow a person to be assigned to a department

    	A person can belong to multiple departments

  o	Inactive people should not be available for selection

REPORTING MODULE

  o	A report which will show all departments and the people that belong to the departments

** For all tables we will need audit fields which will trap the following information: **

  •	Created By, Created Date, Modified By, Modified Date
