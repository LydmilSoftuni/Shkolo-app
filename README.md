# Shkolo App

**Shkolo App** is a simple application for **managing student information**, **grades**, and **absences**. 
This application provides functionality to **add new students**, **track their marks** in different subjects, **manage absences**, and **view student details**.

<kbd>
  <img src="https://github.com/duygu-rmdn/Work/assets/63354146/162295fa-473d-45dc-be75-c5aecb38f4b0" width="600">
</kbd>
<kbd>
  <img src="https://github.com/duygu-rmdn/Work/assets/63354146/35aa3cc6-66b4-460c-8a6b-a64ed99ca92f" width="400">
</kbd>
<kbd>
  <img src="https://github.com/duygu-rmdn/Work/assets/63354146/71ce93ed-4839-4164-b084-b0836bacd63d" width="700">
</kbd>


## Features
- Add new students with their **names** and **grades**.
- Track **mathematics**, **informatics**, and **sports marks** for each student.
- Manage **excused** and **unexcused absences** for students.
- View **detailed information** about each student, including their **average mark** and **total absences**.

### IndexForm 
The `IndexForm` class represents the **main form** of the application. It displays a **list of students**, **their marks**, and allows users to **add new students**.

- **Loads student data** when the form is loaded.
- Populates the **list view** with student data.
- Opens a form to **add a new student** when the `"Add New Student"` button is clicked.
- **Adds a new student** to the students list and **reloads the student data**.
- Displays **detailed information** about the selected student when a student is clicked in the list view.
- **Retrieves** the selected student from the list view.

<kbd>
  <img src="https://github.com/duygu-rmdn/Work/assets/63354146/162295fa-473d-45dc-be75-c5aecb38f4b0" width="500">
</kbd>

### AddNewStudentForm 
The `AddNewStudentForm` class represents the form for **adding a new student**. It validates user inputs for the **student's name** and **grade**.

- **Validates user inputs** and sets the `Name` and `Grade` properties when the `"Add"` button is clicked.
- Checks if the user inputs are **valid**.
- **Validates** if the **name** input is not empty.
- **Validates** if the **grade** input is a valid number between 1 and 12.
  
<kbd>
  <img src="https://github.com/duygu-rmdn/Work/assets/63354146/415f5b04-22aa-4298-85ee-e6ef13b99682" width="300">
</kbd>

### StudentDetailsForm  
The `StudentDetailsForm` class represents the form displaying **detailed information** about a selected student, including **marks**, **absences**, and **average mark**.

- **Updates** the list view with marks for different subjects.
- Checks if the student has **excessive unexcused absences** and **changes form colors** accordingly.
- **Adds a new mark** to the selected subject for the student.
- Displays an **error message** for a short duration.
- **Adds new absences**, either excused or unexcused, for the student.

<kbd>
  <img src="https://github.com/duygu-rmdn/Work/assets/63354146/3090e79e-8aeb-41a8-92a3-4ceb3579267b" width="600">
</kbd>

### Student  
The `Student` class represents a student object with properties such as name, grade, marks in different subjects, and attendance information.

- Holds the name, grade, list of marks for mathematics, informatics, sports, the number of excused, unexcused absences of the student.
- Calculates the **average mark** of the student based on their subject marks.

# Live Demo
[Exe file from Releases](https://github.com/duygu-rmdn/Work/releases/tag/v0.1)
