using Microsoft.EntityFrameworkCore;

namespace quotable.core.data
{
    /// <summary>
	/// The database context that provides access to document and other data.
	/// </summary>
    public class QuoteContext : DbContext
    {
        /// <summary>
		/// Constructor
		/// </summary>
		public QuoteContext(DbContextOptions options) : base(options)
        {

        }

        /// <summary>
        /// Used to access Quotes in the database.
        /// </summary>
        public DbSet<Quotes> Quotes { get; set; }

        /// <summary>
        /// Used to access authors in the database.
        /// </summary>
        public DbSet<Author> Authors { get; set; }

        /// <inheritdoc/>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QuoteAuthor>().HasKey(x => new { x.QuoteId, x.AuthorId });
        }
    }
}
