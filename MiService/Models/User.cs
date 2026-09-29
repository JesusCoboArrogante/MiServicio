namespace MiService.Models;

public class User
{
    public int id {get; set; }
    public string name { get; set; }
    public string username { get; set; }
    public string email { get; set; }
    public Dirrecion street { get; set; }
    public string phone { get; set; }
    public string website { get; set; }
    public Empresa company { get; set; }
    
}



