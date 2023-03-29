# File-Storage-System
Creating a windows app using C#, Visual Studio, and .NET framework

---

## Purpose:

Shows students a Windows app.
Talker about the Windows Operating System (NTFS)
Learning how to handle events.

---

### Setting up a Windows App:
##### 1. If you know how to create a Windows app using Python or Java, you can.  Let me know first.

##### 2. Using the C# language and Windows Presentation Forms (WPF)

##### 3. Using Visual Studio 2022 for the IDE.

##### 4. Visual Studio 2022 can be downloaded for free, to your personal computer.

##### 5. Create a project

##### 6. Set dropdown boxes to:  C# / Windows / Desktop
    a.If you choose the correct items, Windows Forms (.Net framework) will be one of your choices.
    b.Click this item, then hit the Next button.

##### 7.	Name the project based on the following:
    a. Name your lab: <your last name>_<a 4-digit file system name>.
      i. Ex: Ganther_MyFS.
    b. Get this name correct, because it’s hard to change later.
    c. Choose a location to store the project.
    d. Do not change the Solution Name.
    e. Click the button that says Next.

##### 8.	On the Additional Information screen
    a. Choose .Net 4.7.2, if not already chosen.
    b. Click Create.
    c. The project will be created (may take a minute).
    d. You should see a small window call Solution Explorer, to the right.

##### 9.	Controls and their Properties.
    a. Control are found in the ToolBar window (that pops out of the left side).
    b. Each items you put on the window is a Control.
    c. Each control has Properties and Events.
    d. Must give each control a name.
    e. Properties are how the control will look on the Windows.
    f. The properties can be changed at Startup, and in your code.
    g. Each of the controls, and its properties, can be accessed globally in your main window code.

##### 10.	Some Notes
    a. Events (work like interrupts) whenever a event is triggered, the program will go to the event handler code (function).  The code will be performed.

##### 11.	ContentRedered window event – If you want to right code when the window is first displayed, use this event.

##### 12.	Window  (a.k.a Form) – In visual studio, windows are called forms. 
    a. Create a window title, named “CmpSc472 File Storage System”.

---

## Coding Requirements

##### 1.	Disabling/Enabling the Add Button
    a. The Add button starts off as disabled.  The Add button should only be Enabled when there is data in the two textboxes.
    b. When a FileSize and FileName are entered in the two textboxes, then Enable the ADD button.
    c. Use the textbox event called “TextChanged”.

##### 2.	When user clicks on the ADD button.
    a. Format a string and store the string into the File System Table.
    b. Then determine what sector blocks are going to be used for that file.
    c. Then fill in those particular sectors so the file is stored in the sectors.
    d. If file needs more than 1 sector, used a linked list approach.

##### 3. When user clicks on the REMOVE button
    a. User must selected a file from the File System list.
    b. If one is selected, the Remove button will be Enabled.
    c. When Remove is clicked, remove the item from the File System List, and the sectors entries, from the List of Sectors.

---

## File System Requirements:

##### 1. Listbox – display all sectors.
    a. Display all sectors and what files are using them
    b. Remove a file, by selecting the file and clicking Remove.

##### 2.	Controls for File System Attributes.
    a. File name:
    b. File extension:
    c. File size:
    d. Attributes: hidden, read-only, author
    e. Listbox – showing the File System attributes for each file.
    f. This file is display-only.
    g. add new files to write into the sectors.

#### 3.	Add a file:
    a. Cannot add a file until all file attributes are filled out.
    b. Is so, enable the add File to the file System log and put the data into the designates sectors.


