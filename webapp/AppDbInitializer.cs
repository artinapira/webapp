using webapp.Models;

namespace webapp
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ClinicDbContext>();

                if (!context.Departments.Any())
                {
                    context.Departments.AddRange(new Department()
                    {
                        Emri = "Departamenti1",
                        Pershkrimi = "asdfghjkl"
                    },
                    new Department()
                    {
                        Emri = "Departamenti2",
                        Pershkrimi = "asdfghjkl2"
                    });

                    context.SaveChanges();
                }
                if (!context.Pacientis.Any())
                {
                    context.Pacientis.AddRange(new Pacienti()
                    {
                        EmriMbiemri = "Pacienti1",
                        Email = "pacienti1@gmail.com",
                        Pass = "pacienti1pass",
                        DataLindjes = DateOnly.FromDateTime(DateTime.Now),
                        Gjinia = "F"

                    },
                    new Pacienti()
                    {
                        EmriMbiemri = "Pacienti2",
                        Email = "pacienti2@gmail.com",
                        Pass = "pacienti2pass",
                        DataLindjes = DateOnly.FromDateTime(DateTime.Now),
                        Gjinia = "M"
                    });

                    context.SaveChanges();
                }
            }
        }
    }
}
