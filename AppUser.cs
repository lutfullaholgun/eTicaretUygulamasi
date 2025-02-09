using eTicaretUygulamasi.EntityLayer.Interface;

public class AppUser : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string SurName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string? Phone { get; set; }
    public string? UserName { get; set; }

    public string? Image { get; set; }
    public bool IsActive { get; set; }

    public bool IsAdmin { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public Guid? UserGuid { get; set; } = Guid.NewGuid(); 