using Microsoft.EntityFrameworkCore;

namespace Rental.Models{

    /*
        // This class handles the connection to DB
           and helps to retrieve/store/update data

        // If something chages on the models/tables, exec:
        - dotnet ef migrations add <someName>
        - dotnet ef database update
    */
    public class DataContext : DbContext {

        public DataContext( DbContextOptions<DataContext> options ) : base(options) {

        }
        // New line of code 
        // Specify which models need to be converted into DB tables
        public DbSet<Car> Cars {get; set;}
        //

    }
}

// You can copy all this code to re-use on other projects
// because its universal. Handles connection to DB