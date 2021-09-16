using System.Collections.Generic;

namespace JobBoard.Models
{
  public class JobInformation
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public string Name { get; set; }
    public string Email {get;set;}
    public string PhoneNumber{get; set;}

    private static List<JobInformation> _instances = new List<JobInformation> { };

    public JobInformation(string title, string description, string name, string email, string phoneNumber)
    {
      Title = title;
      Description = description;
      Name = name;
      Email = email;
      PhoneNumber = phoneNumber;
      
      _instances.Add(this);
    }

    public static List<JobInformation> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
