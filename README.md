# Library Management System

## Project Overview

This project is a **Library Management System** developed as a thesis requirement by 3rd-year BSIT students at Datamex College of Saint Adeline - Sucat. The system aims to computerize library operations, providing an efficient way to manage the library collection, track book information, and handle user records (students and staff).

The system was designed to eliminate manual processes, save time for users searching for books, reduce workload through self-service features, and ultimately reduce the need for extensive manual manpower.

## Features

The system includes the following key features:

* **User Accounts:** Supports different user roles (Admin, Staff, Students).
* **Login System:** Secure login page for accessing the system based on user roles.
* **User Registration:** Students can register using personal information to gain access to library resources.
* **Book Search:** Allows users to search for books by unique ID, author name, or title. Provides details including location.
* **Book Borrowing:** Manages the process of borrowing books, including recording transaction details, borrower information, book details, purpose, and status. Utilizes a code provided by staff/Admin for scanning.
* **Book Return:** Handles the book return process, recording return dates and calculating fines for overdue books.
* **Book Lost and Replacement:** Functionality to record lost books, their details, price, and manage replacement book information and associated penalties.
* **Book Inventory Management:** Allows for adding, updating, and deleting book information in the database, including details like subject, category, publisher, copyright year, barcode, ISBN, copies, status, edition, price, and supplier.
* **User Account Management:** Admin can create, update, and delete user accounts, including personal details and login credentials.
* **Activity Logs:** Records system actions, including date, time, action, and user ID.
* **Time In/Out Logs:** Records user login and logout times.
* **Main Form Tools:** Provides access to common tools like Word, Excel, Calculator, and Notepad.
* **Database Backup:** Option to backup the system database.
* **About System:** Provides information about the system.
* **Change Password:** Allows users to change their password for security.
* **Event Management (Admin):** Admin can add events and important suggestions regarding the library.

## Database Design (Table Structure)

The system's database includes the following tables:

* **Administrator:** `AdminID`, `Username`, `Password`, `Firstname`, `Lastname`, `Mid_initial`, `Gender`, `Address`, `Email`, `Date of Birth`, `Phone number`, `Department`.
* **Book Borrow:** `TransactionID`, `Borrowed date`, `Due date`, `BorrowID`, `Borrower name`, `Course`, `Phone number`, `Book name`, `Copy`, `Purpose`, `Status`, `BookID`.
* **Book Return:** `TransactionID`, `BookID`, `BorroweID`, `Borrower name`, `Book name`, `Borrowed date`, `Due date`, `Return date`, `Fine`.
* **Books:** `BookID`, `Book subject`, `Book name`, `Author`, `JointAuthor1`, `Book category`, `Book class`, `Publisher name`, `Copyright year`, `Barcode`, `ISNB`, `Copies`, `Status`.
* **Books lost and replace:** `BookID`, `Book name lost`, `Book author`, `Book replacement name`, `Book replacement author`, `Book replacement ID`, `Price`, `Penalty`.
* **Logs activity:** `Date`, `Time`, `Action`, `ID`.
* **Log time in:** `Date`, `Time`, `Name`, `Action`, `ID`.
* **Log time out:** `Date`, `Time`, `Name`, `Action`, `ID`.

## Technologies Used

* **Microsoft Visual Studio 2010:** The software was developed using this IDE. (Likely a language supported by VS 2010, such as C# or VB.NET, was used, along with a database system like SQL Server or Access, though not explicitly mentioned in the provided text).

## Scope and Limitations

* **Scope:** The system covers the time-in and time-out of students through a computer database managed by an admin.
* **Limitations:** The system was specifically designed and intended for use only by students of College of Saint Adeline Sucat Branch and is not intended for application in other schools.

## Authors

* Aragon, Janreign
* Capacia, John Julio
* Flores, Donna Mae
* Hiramis, John Brian
* Paz Pablo, Virgilio

## Advisor

* Mr. Melvin F. Libunao
