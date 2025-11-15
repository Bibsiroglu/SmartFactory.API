using Microsoft.EntityFrameworkCore;
using SmartFactory.API.Models;
using SmartFactory.API.Data;

public class MachineRepository : IMachineRepository
{
    private readonly SmartFactoryDbContext _context;

    public MachineRepository(SmartFactoryDbContext context)
    {
        // Çakışmayı çözen doğru atama
        this._context = context;
    }

    public async Task<List<Machine>> GetAllAsync() => await _context.Machines.ToListAsync();

    public async Task AddAsync(Machine machine)
    {
        await _context.Machines.AddAsync(machine);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateStatusAsync(int id, string status)
    {
        // Önce makineyi ID ile bulur
        var machine = await _context.Machines.FindAsync(id);

        if (machine != null)
        {
            // Durum bilgisini günceller
            machine.Status = status;

            // Veritabanına kaydeder
            await _context.SaveChangesAsync();
        }
    }
}