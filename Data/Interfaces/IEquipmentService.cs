
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; 
using System.ComponentModel;
using SkyLightWeb.Data;
using SkyLightWeb.Models;
namespace SkyLightWeb.Models
{
public interface IEquipmentService
{
    IEnumerable<Equipment> GetEquipments(ApplicationDbContext _context);
    IEnumerable<Asset> GetAssets(ApplicationDbContext _context,string equipmentID);
}
public class EquipmentService : IEquipmentService
{

    public IEnumerable<Equipment> GetEquipments(ApplicationDbContext _context)
    {
        var equipments=_context.Equipments;
        return equipments;
    }


    public IEnumerable<Asset> GetAssets(ApplicationDbContext _context,string equipmentID)
    {
        var equipments=_context.Assets.Where(a=>a.EquipmentID==equipmentID);
        return equipments;
    }
}
}