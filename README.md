# Education Management System

## Project Purpose
This desktop application is designed to manage student, teacher, and administrative operations for an educational institution. The system serves three distinct user types:

### Features for Students:
- Course registration
- Grade viewing
- Transcript viewing
- Listing registered courses
- Viewing courses from past semesters

### Features for Teachers:
- Entering grades
- Updating profile information
- Approving courses

### Features for Administrative Staff:
- Creating student records
- Creating teacher records
- System management

## Technologies Used

### Programming Language and Framework:
- **C#**
- **.NET Framework**
- **Windows Forms (WinForms)** - For desktop application development

### Database:
- **Microsoft SQL Server (MSSQL)**
- **ADO.NET** - For database operations

### Architecture and Design:
- Form-based architecture
- Object-Oriented Programming (OOP)
- CRUD (Create, Read, Update, Delete) operations

## Project Structure

### Login System:
- Separate login screens for each user type
- User authentication system

### Modules:

#### Student Module:
- Course registration system
- Grade viewing
- Transcript system

#### Teacher Module:
- Grade entry system
- Profile management

#### Administrative Staff Module:
- User management
- System management

### Database Tables:
- `ogrGiris` (Student information)
- `ogrtGiris` (Teacher information)
- `mGiris` (Administrative staff information)
- `notlar` (Grade information)
- `ogrDers` (Course information)
- `danismanOnay` (Advisor approval system)
- `kesinKayit` (Final registration information)
- `gecmisDersler` (Past semester course records)

## Security Features
- User authentication
- Role-based access control
- Password-protected login system

## About the Project
This project is designed to meet the fundamental needs of educational institutions, featuring a user-friendly interface, robust security, and comprehensive management capabilities.
