namespace ZooSystemDB.Data;
public enum AnimalType { Penguin, Walrus, Whale, Dolphin, Shark, Otter }
public class Animal
{
    public int Id_Animal { get; set; }
    public int Id_Cage { get; set; }
    public string Name { get; set; }
    public AnimalType Specie { get; set; }
    public DateTime LastAttended { get; set; }

}
