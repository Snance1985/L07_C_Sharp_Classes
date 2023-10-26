//CREATING A CLASS
// public class Student
// {
//     //DECLARING CLASS MEMBERS
//     private int studentID;
//     private string? name;

//     //GETTERS
//     // Getter for studentID
//     public int getStudentID()
//     {
//         return studentID;
//     }
//     // Getter for name
//     public string? getName()
//     {
//         return name;
//     }

//     //SETTERS
//     // Setter for studentID
//     public void setStudentID(int id)
//     {
//         studentID = id;
//     }

//     // Setter for name
//     public void setName(string studentName)
//     {
//         name = studentName;
//     }

// }


//_________________________________________________
//GET AND SET ACCESSORS FOR PRIVATE FIELDS
// class Student{
//     private int studentID;
//     private string? name;

//     // Accessor for studentID
//     public int StudentID {
//         get { return studentID; }
//         set { studentID = value; }
//     }

//     // Accessor for name
//     public string? Name {
//         get { return name; }
//         set { name = value; }
//     }
// }


//_________________________________________________
// //CONSTRUCTOR
// class Student{
//     private int studentID;
//     private string? name;

//     // Constructor
//     public Student(int id, string sName) {
//         studentID = id;
//         name  = sName;
//     }

//     public int StudentID{
//         get { return studentID; }
//         set { studentID = value; }
//     }

//     public string? Name {
//         get { return name; }
//         set { name = value; }
//     }
// }


//_________________________________________________
//CONSTRUCTOR OVERLOADING
class Student{
    private int studentID;
    private string? name;

    // Default Constructor
    public Student(){
        studentID = 0;
        name = "";
    }

    // Overloaded Parameterized Constructor
    public Student(int id, string sName){
        studentID = id;
        name  = sName;
    }

    public int StudentID{
        get { return studentID; }
        set { studentID = value; }
    }

    public string? Name {
        get { return name; }
        set { name = value; }
    }
}
