namespace BOL;

[Serializable]
public class Project
{
    //POCO - Auto Properties for PMS
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Manager { get; set; }

    //Default Constructor
    public Project()
    {
        this.Id = 1;
        this.Name = "PMS";
        this.Description = "Complete PMS Solution";
        this.Manager = "Mahendra";
    }

    //Parameterized Constructor
    public Project(int id, string name, string description, string manager)
    {
        this.Id = id;
        this.Name = name;
        this.Description = description;
        this.Manager = manager;
    }

    //over to string method to display
    public override string ToString()
    {
        return "Project ID- "
            + this.Id
            + ", "
            + "Project Name- "
            + this.Name
            + ", "
            + "Project Description- "
            + this.Description
            + ", "
            + "Project Manager- "
            + this.Manager;
    }
}
