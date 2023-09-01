﻿using Microsoft.EntityFrameworkCore;

namespace WebApplicationExemplo1.Data
{
    public class ApplicationDbContext : DbContext {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ) :base(options) { }
    }
}
