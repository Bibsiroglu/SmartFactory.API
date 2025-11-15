using SmartFactory.API.Models;

public interface IMachineRepository
{
    Task<List<Machine>> GetAllAsync();
    Task AddAsync(Machine machine);
    Task UpdateStatusAsync(int id, string status);
}