namespace _230104.Models.DTOs
{
    public record UserDTO(Guid Id, string UserName, string UserEmail, string Password, DateTime CreatedTime);
    public record CreatedUserDTO(string UserName, string UserEmail, string Password);
    public record UpdateUserDTO(string UserName, string UserEmail, string Password);


    public record AutoDTO(Guid Id, string Márka, string Típus, DateTime CreatedTime, Guid UserId);

    public record CreatedAutoDTO(string Márka, string Típus, Guid UserId);

    public record UpdateAutoDTO(string Márka, string Típus);
}