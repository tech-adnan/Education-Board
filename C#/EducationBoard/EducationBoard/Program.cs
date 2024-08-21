using System;

//Author Name:-Adnan M.Shaikh
//Roll No:-03
//Displaying The Details Of Various Boards
//Start Date:-17/07/2024
//Modified Date:-24/07/2024
//Description:- To Find Classes and objects in the institutions Website and this is a code written to display the Various Boards By Taking input from the user.

public class EducationBoard
{
    public string Name { get; set; }
    public string EstablishedDate { get; set; }
    public string ResolutionNumber { get; set; }
    public string GazetteNotificationDate { get; set; }

    public EducationBoard(string name, string establishedDate, string resolutionNumber, string gazetteNotificationDate)
    {
        Name = name;
        EstablishedDate = establishedDate;
        ResolutionNumber = resolutionNumber;
        GazetteNotificationDate = gazetteNotificationDate;
    }

    public void GetBoardInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Established Date: {EstablishedDate}");
        Console.WriteLine($"Resolution Number: {ResolutionNumber}");
        Console.WriteLine($"Gazette Notification Date: {GazetteNotificationDate}");
    }
}

public class NationalBoard : EducationBoard
{
    public string RecognitionDate { get; set; }
    public string ApprovedBy { get; set; }

    public NationalBoard(string name, string establishedDate, string resolutionNumber, string gazetteNotificationDate, string recognitionDate, string approvedBy)
        : base(name, establishedDate, resolutionNumber, gazetteNotificationDate)
    {
        RecognitionDate = recognitionDate;
        ApprovedBy = approvedBy;
    }

    public void GetNationalBoardInfo()
    {
        GetBoardInfo();
        Console.WriteLine($"Recognition Date: {RecognitionDate}");
        Console.WriteLine($"Approved By: {ApprovedBy}");
    }
}

public class SchoolBoard : EducationBoard
{
    public string AssociatedMinistry { get; set; }
    public string Rules { get; set; }

    public SchoolBoard(string name, string establishedDate, string resolutionNumber, string gazetteNotificationDate, string associatedMinistry, string rules)
        : base(name, establishedDate, resolutionNumber, gazetteNotificationDate)
    {
        AssociatedMinistry = associatedMinistry;
        Rules = rules;
    }

    public void GetSchoolBoardInfo()
    {
        GetBoardInfo();
        Console.WriteLine($"Associated Ministry: {AssociatedMinistry}");
        Console.WriteLine($"Rules: {Rules}");
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Choose an education board:");
        Console.WriteLine("1. National Board");
        Console.WriteLine("2. School Board");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            NationalBoard cbse = new NationalBoard(
                "Central Board of Secondary Education (CBSE)",
                "01.07.1929",
                "F-115-R/28",
                "11.11.1929",
                "20.10.1990",
                "Ministry of Education"
            );
            cbse.GetNationalBoardInfo();
        }
        else if (choice == "2")
        {
            SchoolBoard msrvvp = new SchoolBoard(
                "Maharshi Sandipani Rashtriya Veda Sanskrit Shiksha Board, Ujjain",
                "08.08.2022",
                "Rule 14(iv) (f)",
                "25.01.2023",
                "Department of Higher Education",
                "MoA of MSRVVP"
            );
            msrvvp.GetSchoolBoardInfo();
        }
        else
        {
            Console.WriteLine("Invalid choice. Please enter either 1 or 2.");
        }
    }
}

