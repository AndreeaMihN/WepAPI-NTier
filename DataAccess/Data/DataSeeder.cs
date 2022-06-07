using A2Mac1.Costino.Core.Entities;

using Microsoft.EntityFrameworkCore;

using System.Text.Json;

namespace A2Mac1.Costino.DataAccess.Data;

public class DataSeeder
{
    public static async Task Seed(DataContext context)
    {
        if (await context.Equipments.AnyAsync())
        {
            return;
        }

        string? equipmentData = await File.ReadAllTextAsync("../DataAccess/Data/EquipmentSeedData.json");
        List<Equipment>? equipment = JsonSerializer.Deserialize<List<Equipment>>(equipmentData);

        if (equipment == null)
        {
            return;
        }

        await context.Equipments.AddRangeAsync(equipment);
        await context.SaveChangesAsync();
    }
}