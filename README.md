# Student Grade Management System

This is a simple console-based Student Grade Management System written in C#. The application allows users to manage student details, record grades, calculate averages, and display detailed reports.

## Features

- Add new students with their name and roll number.
- Add subjects and marks for each student.
- Calculate grades for individual subjects based on marks.
- Calculate the overall average grade for a student.
- Display detailed student information, including grades and average marks.

## How to Use

1. Clone the repository:
   ```bash
   git clone https://github.com/kamalisundar17/StudentGrade-Management-System.git
   ```
2. Open the project in your preferred C# IDE (e.g., Visual Studio).
3. Build and run the project.
4. Follow the on-screen menu options in the console application to perform various operations.

## Code Structure

The project consists of the following key classes:

1. **`GradeCalc`**
   - Contains methods for calculating grades and averages:
     - `calcgrade(int marks)` - Returns a grade based on the marks.
     - `average(List<Subject> subjects)` - Calculates the average marks for a list of subjects.

2. **`Student`**
   - Represents a student with properties:
     - `name` (string)
     - `rollno` (int)
     - `Subjects` (List of `Subject` objects)
   - Methods:
     - `addSubjects(Subject su)` - Adds a subject to the student.
     - `displayInfo()` - Displays detailed student information, including grades and average marks.

3. **`Subject`**
   - Represents a subject with properties:
     - `name` (string)
     - `marks` (int)
   - Methods:
     - `getname()` - Returns the subject name.
     - `getmarks()` - Returns the subject marks.

4. **`Program`**
   - Entry point of the application, containing the main menu and methods for user interaction:
     - `AddStudent()` - Adds a new student.
     - `AddSubject()` - Adds subjects and marks for a student.
     - `Calculate()` - Displays grades for each subject.
     - `DisplayInfo()` - Shows detailed information about a student.

## Sample Console Interaction

```text
1. Add Student
2. Add Subject and Marks
3. Grades Details for Each Subject
4. DisplayInfo
5. Exit
Choose an option: 1
Enter Student Name: John Doe
Enter Roll No: 101
Student added successfully!

Choose an option: 2
Enter Student Roll No: 101
Enter No of Subjects: 2
Enter Subject Name: Math
Enter Marks: 85
Enter Subject Name: Science
Enter Marks: 90
Subjects added successfully!

Choose an option: 4
Enter Student Roll No: 101
Name: John Doe
Roll No: 101
Subject --- Mark --- Grade
Math --- 85 --- B
Science --- 90 --- A
Average Marks: 88
Overall Grade: B
```

## Grading System

| Marks Range | Grade |
|-------------|-------|
| 90 - 100    | A     |
| 75 - 89     | B     |
| 50 - 74     | C     |
| Below 50    | F     |

## Requirements

- .NET SDK 6.0 or higher.

## Contributing

Contributions are welcome! Feel free to fork the repository and submit pull requests for enhancements or bug fixes.

## License

This project is licensed under the [MIT License](LICENSE).

---

Enjoy using the Student Grade Management System!

