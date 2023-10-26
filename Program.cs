//DECLARING OBJECTS
//1ST METHOD
// Student richard;
// richard = new Student();

// //2ND METHOD
// Student richard = new Student();


//_________________________________________________
//DOT NOTATION
// Student richard = new Student();

// richard.setStudentID(11);
// richard.setName("Richard");

// Console.WriteLine(richard.getName() + " has the student ID: "
//     + richard.getStudentID());


//_________________________________________________
//GET AND SET ACCESSORS FOR PRIVATE FIELDS
// Student richard = new Student();

// richard.StudentID = 11;
// richard.Name = "Richard";

// Console.WriteLine(richard.Name + " has the student ID: "
//     + richard.StudentID);


//_________________________________________________
//CONSTRUCTOR
Student richard = new Student(11, "Richard");

Console.WriteLine(richard.Name + " has the student ID: "
    + richard.StudentID);
