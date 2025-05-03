

# Library Management System



A Thesis made by 3rd year BSIT
Datamex College of Saint Adeline - Sucat
College Department

Under the Guidance of
Mr. Melvin F. Libunao























Submitted by:

















Aragon, Janreign
Capacia, John Julio
Flores, Donna Mae
Hiramis, John Brian
Paz Pablo, Virgilio



To be submitted to:

















Mr. Melvin F. Libunao




Acknowledgement

I would like to express my special appreciation and gratitude to my advisor Professor Mr. Melvin Libunao you have been a tremendous mentor for me.
       
        I would like to thank you for encouraging my research and for allowing me to grow as a researcher. Your advice on both research as well as on my career have been priceless. I would also like to thank Mr. Cervin Colasito for serving as one of my committee members even at the most difficult times. I also want to thank you for letting my defense be an enjoyable moment, and for your brilliant comments and suggestions. I would especially like to thank College of Saint Adeline Sucat Branch. All of you have been there to support me when I applied hard work and patience in collecting important data for my Library Management System thesis. Special thanks to my dear loved ones and friends, words cannot express how grateful I am on my behalf your prayer for me was what sustain me this far. I would also like to thank all of my groupmates who supported me in writing, and incented me to strive towards my goal.

      Besides to my advisor, i would like to thank the rest of my thesis committee for their insightful comments and encouragement, but also for the hard question which incented me to widen my research from various perspectives.





Preface

	This page contains Library Management System Documents. A development process consists of various phases, the main reason for having a phased process is that it breaks the problem of developing a software into successfully performing a set of phases.

       The objective of this system is to build and manage library collection and keeps software track all information about the books and their complete details where all information stored safely in the database. This system would provide basic set of features to add and update members, books and manage check in specification for the system based on the client’s statement of need. The uniqueness of this to other system are to save time of user in finding kind of books, less workload which means self-server and cost saving that reduce man power. 

      We are grateful to our project guide Mr. Melvin F. Libunao for the guidance inspiration and constructive suggestion that help us in the preparation of this project and cooperation made it possible, who’s constant guidance and encouragement and would be incomplete without the mention of people whose careless. We also thank our colleagues who have helped in successful completion of the project.


TABLE OF CONTENT


LIBRARY MANAGEMENT SYSTEM

	Title of the System?.................................................................1

	Acknowledgement?.................................................................2

	Preface?..................................................................................3

	Process Description?..............................................................5

	Introduction?...........................................................................6

	Table Design?.........................................................................7

	Project Details?.......................................................................8

	Conclusion?............................................................................9

	Advantages of (LMS)?...........................................................10

	Scope and Limitation?...........................................................11


PROCESS DESCRIPTION

       The Library Management System is process of keeping student records, account details and managing employee to handle the current issue and to eliminate the manual system. 

       We have a login page from where its user can access. Provided for working staff members, student and also Admin. Accounts will be manage by Admin and to access the library resources, student have to register by using their own personal information regarding to registration form. After successful registration they will be provided the login facility. Student can search books by using unique identity or by author name, title of the books and also provided by books details such as where it is located. 
       
       If any student lost their books, it should be informed to library working staff member or in the Admin where they can made changes to their account and take appropriate actions. For receiving books from the Library Management System student have to use their code which provide by working staff member under by Admin to scan and add particular books into their account.  

INTRODUCTION

        Library Management System is a program that manage collection of data or information which includes the task of adding new user, issuing, returning and reissuing books and also updating and deleting information. Collecting books back and searching for books user.

        In our project we will be able to classify user as staff or students. Classifying users allow the books issue controls, fine rates base on the classification. Example for students we will able to issue two books at the fine or penalty for late returning. What more we can change this setting based on our needs but we have to set this value just one and not every time the program begun. We have used setting class to implement this.

       The project aims and objective that will be achieved after the completion of this project discussed in this introduction are, student login page where admin can add any event being organized in the Library Management System and important suggestion regarding books.



TABLE DESIGN








Administrator
- AdminID, Username, Password, Firstname, Lastname, Mid_initial, Gender,
  Address, Email, Date of Birth, Phone number, Department.









Book Borrow
- TransactionID, Borrowed date, Due date, BorrowID, Borrower name, Course,
  Phone number, Book name, Copy, Purpose, Status, BookID.

















Book return
- TransactionID, BookID, BorroweID, Borrower name, Book name,
  Borrowed date, Due date, Return date, Fine.

















Books
- BookID, Book subject, Book name, Author, JointAuthor1, Book category,
  Book class, Publisher name, Copyright year, Barcode, ISNB, Copies, Status.

















Books lost and replace
- BookID, Book name lost, Book author, Book replacement name,
  Book replacement author, Book replacement ID, Price, Penalty.














Logs activity
- Date, Time, Action, ID














Log time in
- Date, Time, Name, Action, ID.














Log time out
- Date, Time, Name, Action, ID






PROJECT DETAILS

LOGIN FORM
    • Username – identification use by the user with access to our system.
    • Password – a secret word or phrase that must be used.
    • Login – logging in to a computer system.
    • Clear – to be out of the way or to remove text into our form
    • Time – a measure in which event can be ordered from our database.
    • Date – stated in term of the day, month and year of our logged.
    • Create New User – Creating another account in the system.
    • Change Password – can help keep our system more secure from intruders.
    • About The System – concerning with reference to our system.







MAIN FORM
    • Tools – a device or implement used to carry out particular function like word, excel, calculator and notepad.
    • Logs – computer dictionary definition including related link.
    • Backup Database – another storage of our files in case of technical issue.
    • Help – to understand what is all about the program.
    • Book’s Inventory – the amount of inventory records of books in our system.
    • Book’s Borrow – receiving books in exchange for an obligation.
    • Book Return – send back the book to the working staff member.
    • Books Lost and Replacement – unable to find books, exchange penalty.
    • ID – identification of the user.
    • Username – use by the user to have access.
    • First Name – personal name given to someone at birth.
    • Gender – state of being male or female.
    • Date of Birth – enter your date of birth.
    • Address -  a place where you live.
    • Email - account name for message distributed.
    • Phone or Mobile Number – your contact number.
    • Department – division of large organization.
    • Update – change file in more modern or up to date.
    • Save – store file in our database.
    • Delete – deleting or removing files.

BOOKS BORROW
    • Transaction ID – this number is your proof of purchase.
    • Barrow Date – the date when you borrow the books.
    • Due Date – a period or time of returning the books that you borrow.
    • Name – the unique ID to access the account.
    • Borrower ID – the unique ID number to access the account.
    • Course – your profession or the degree of the person.
    • Phone Number – your contact detail number.
    • Book Name – the title of the books.
    • Book ID – identification of the books to search easier and fast.
    • Copy – duplicating of books base on the needs of borrower.
    • Purpose – the reason for borrowing the books.
    • Status – old or new kinds of books in our database.
    • Borrow – claiming or receiving book from the admin or working staff member.







BOOK RETURN
    • Transaction ID – this number is your proof to return the book.
    • Borrower ID – identification of the books to return in proper storage.
    • Borrower Name – User Identification.
    • Book Name – The title or the name of the books.
    • Borrowed Date – the date when you borrow the book before you return.
    • Due Date – time of returning the books in proper storage.
    • Return Date – the date that you must return the books in the admin or working staff member.
    • Fine – the penalty of being irresponsible for returning the books in due date.
    • Clear All – remove text in the form.
    • Return Book – returning of books.









	
BOOK LOST AND REPLACEMENT

  Information of the lost book.
    • Name of the Book Lost – the book that you lost somewhere.
    • Book ID – unique ID of the books.
    • Book Author – the one who create the books.
    • Price – how much the books is going to cost.
    • Penalty – the amount of the books that you need to pay.

  Information of the replaced book.
    • Book ID – unique random number of the books.
    • Name of the Replaced Book – the book that you must exchange for the fine.
    • Book Author – the author of the new replaced books.
    • Generate – random number for the unique ID of new replaced books.

    • Replaced Book – Button for replacing the book permanent.
    • Clear All – remove the text in the form.



ADD ACCOUNT
    • ID – new unique identity of user.
    • Username – new Username identification.
    • Password – security for the account
    • Retype Password – retyping same password.
    • First Name – personal name given.
    • Last Name – the family name.
    • Gender – state of being male or female.
    • Date of Birth – enter your birthday.
    • Address – the place where you live.
    • Email – account name.
    • Phone Number – your contact number.
    • Department – your organization.
    • Camera – this is for capturing your identity.
    • Add – button for adding new account.
    • New – button for new file form.
    • Clear – remove the text in the form.





ADD BOOKS
    • Book ID – new ID for new books.
    • Books Subject – kinds of subject like English, Filipino etc.
    • Book Name – new book name.
    • Author – creator of new book.
    • Book Category – division of new books.
    • Book Class – set or category of books.
    • Publisher Name – the one who publish the new books.
    • Copyright Year – a year of exclusive legal right.
    • Barcode – a readable code in the form.
    • ISBN –  edition of the books.
    • Copies – duplicate books borrow.
    • Status – state of being old or new books.
    • Edition – form or version of books.
    • Price – amount of new books.
    • Supplier – who provides the new books.
    • Add Book – button for adding new books in our database.





UPDATE BOOK
    • Book ID – change new ID of books.
    • Book Subject – creating new subject of books.
    • Book Name – change book name.
    • Author – change the name of author
    • Joint Author – the one who help the author to create new goods and sevices.
    • Book Category – retype new division of books.
    • Book Class – retype new category of books.
    • Publisher Name – change the new publisher of books.
    • Copyright Year – retyping new legal right.
    • Barcode – new readable code form.
    • ISBN – new edition of books.
    • Copies – retype new duplicate of books.
    • Status – renew the books if it is new or old.
    • Edition – change the form or version of books.
    • Price – change the amount of the books.
    • Supplier – retyping new provider of the books.
    • Clear – remove text in the form.
    • Update – button for changing form in our database.


CONCLUSION

     The project Library Management System is for computerizing the work in the library by the use of working staff member and this system takes care of all the requirements of the library and is capable to provide easy and effective storage of information related to books and users.

     This the Library Management System has been computed successfully and was also tested successfully. It is user friendly and has required option which can be utilized by the user to perform the desire operation. The software is developed using Microsoft Visual Studio 2010. The goals that are achieved by this Library Management System are efficient management of records, simplification of the operations, less processing time and getting required information, user friendly and also flexible for further enhancement or improvements.
     
     A person can also barrow the books for particular days depends on what they need. All the information will be entered or stored in the Library Management System. If the person doesn’t return the books before the due date, a fine will be added and the information will be sent to that particular person about the fine or penalty 


ADVANTAGE OF L.M.S

    • Helps the librarian and other staff members to manage library easily
along with saving time.






    • Allow the librarian to catalogue books and maintain records of issue,
reissued and overdue books easily.






    • Helping to maintain the complete library right from the transaction
between student, staff and institute to issuing, returning and reissuing
of books to maintaining membership information.






    • Eased and made the process of borrowing books error free for everyone







    • Reducing cost and cost and complexity involved in managing huge
libraries.






    • Self-service software for self-service machine and powerful search
Option to find item quickly.






    • Smoothen the working of library and improving trust between the
student and the management.






    • It consists of the comprehensive options for entering the information
Related to books.



Scope
    •        It covers the time-in and time-out of the students through computer database, specifically through an admin’s database records.




Limitations
    •        The system will be only used for students of college of saint Adeline Sucat Branch. It will not be applied in any other perspective school.


