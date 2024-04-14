using webapp.Models;
using webapp.ViewModels;

namespace webapp.Services
{
    public class PacientiService
    {
        private ClinicDbContext _context;
        public PacientiService(ClinicDbContext context)
        {
            _context = context;
        }

        public void AddPacienti(PacientiVM pacienti) 
        {
            var _pacienti = new Pacienti()
            {
                EmriMbiemri = pacienti.EmriMbiemri,
                Email = pacienti.Email,
                Pass = pacienti.Pass,
                DataLindjes = pacienti.DataLindjes,
                Gjinia = pacienti.Gjinia
            };
            _context.Pacientis.Add(_pacienti);
            _context.SaveChanges();
        }

        public List<Pacienti> GetAllPacienti() 
        {
            var allpacients = _context.Pacientis.ToList();
            return allpacients;
        }

        public Pacienti GetPacientiById(int pacientId) => _context.Pacientis.FirstOrDefault(n => n.PacientiId == pacientId);

        public Pacienti UpdatePacientiById(int pacientiId, PacientiVM pacienti) 
        {
            var _pacienti = _context.Pacientis.FirstOrDefault(n => n.PacientiId == pacientiId);
            if (_pacienti != null) 
            {
                _pacienti.EmriMbiemri = pacienti.EmriMbiemri;
                _pacienti.Email = pacienti.Email;
                _pacienti.Pass = pacienti.Pass;
                _pacienti.DataLindjes = pacienti.DataLindjes;
                _pacienti.Gjinia = pacienti.Gjinia;

                _context.SaveChanges();
            }
            return _pacienti;
        }

        public void DeletePacientiById(int pacientiId) 
        {
            var _pacienti = _context.Pacientis.FirstOrDefault(n => n.PacientiId == pacientiId);
            if (_pacienti != null) 
            {
                _context.Pacientis.Remove(_pacienti);
                _context.SaveChanges();
            }
        }
    }
}
