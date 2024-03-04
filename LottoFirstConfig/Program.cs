
using LottoAdat.Data;
using LottoAdat.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;  


LottoContext _context = new LottoContext();
if (!_context.Employee.Any()) {
    string[] tomb = File.ReadAllLines(@"C:\adat\nevek.csv");
	for (int i = 1; i < tomb.Length; i++)	
        _context.Employee.Add(new Employee(tomb[i]));
    _context.SaveChanges();
}


if (!_context.Tipp.Any()) {
    string[] tomb = File.ReadAllLines(@"C:\adat\l5.csv");
	for (int i = 1; i < tomb.Length; i++)	
        _context.Tipp.Add(new Tipp(tomb[i]));
    _context.SaveChanges();
}