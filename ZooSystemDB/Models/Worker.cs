namespace ZooSystemDB.Data;

public enum WorkDays { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
public class Worker
{
    public int Id_Worker { get; set; }
    public int[] Id_AttendedCages { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public WorkDays[] WorkDays { get; set; }

}
